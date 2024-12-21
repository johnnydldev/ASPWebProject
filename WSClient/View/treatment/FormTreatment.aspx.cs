using WSClient.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceTreatment;
using WSClient.WSMedicament;

namespace WSClient.View.Treatment
{
    public partial class FormTreatment : System.Web.UI.Page
    {
        TreatmentServiceSoapClient treatmentWSClient;
        MedicamentServiceSoapClient medicamentWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            treatmentWSClient = new TreatmentServiceSoapClient();
            medicamentWSClient = new MedicamentServiceSoapClient();
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    //Header of form
                    title.Text = "Registrar Tratamiento";
                    subTitle.Text = "Registro de nuevo Tratamiento";
                    chargeDropdownList();
                }
                else
                {
                    chargeDropdownList();

                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Treatment Treatment = treatmentWSClient.GetTreatmentById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (Treatment.IdTreatment > 0)
                    {
                        string dateComplete = Treatment.StartedDate.ToString();
                        string year = dateComplete.Substring(6, 4);
                        string month = dateComplete.Substring(3, 2);
                        string day = dateComplete.Substring(0, 2);
                        string medicament = Treatment.Medicament.NameMedicament.ToString();
                        //Assign the new values to record according to the id Treatment selected
                        title.Text = "Actualizar Treatment";
                        subTitle.Text = $"Modificar los datos del Treatment #{_id}";
                        txtRecommendTreatment.Text = Treatment.RecommendTreatment;
                        ddlyear.Items.FindByText(year).Selected = true;
                        ddlmonth.Items.FindByText(month).Selected = true;
                        ddlday.Items.FindByText(day).Selected = true;
                        ddlMedicament.Items.FindByText(medicament).Selected = true;

                        Console.WriteLine("El objeto es: " + Treatment);
                    }
                    else
                    {
                        //Return to index page of Treatment
                        Response.Redirect("IndexTreatment.aspx");
                    }

                }//End verify of record or new 

            }//End evaluate of postback

        }//End load event

        string date = string.Empty;
 

        protected void Selection_Change(object sender, EventArgs e)
        {
            //almacenos la fecha seleccionada en el calendario de salida de forma global
            //birthDate = clcBirthdate.SelectedDate;

            //clcBirthdate.SelectedDate = birthDate;
            //clcBirthdate.VisibleDate = birthDate;
        }


        protected void btnSaveClick(object sender, EventArgs e)
        {

            string title = "", response = "", type = "";
            int outputCreate = 0; bool outputUpdate = false;

            try
            {
                //Create the instance of new object Treatment
                VO_Treatment Treatment = new VO_Treatment();
                Treatment.RecommendTreatment = txtRecommendTreatment.Text;
                Treatment.Medicament.IdMedicament = Convert.ToInt32(ddlMedicament.SelectedValue.ToString());
                Treatment.StartedDate = GetDateSelected();

                //Verify if the info is to create or update
                if (Request.QueryString["Id"] == null)
                {
                    outputCreate = treatmentWSClient.CreateTreatment(Treatment);

                    if (outputCreate == 0)
                    {
                        title = "Ops...";
                        response = "No se ha podido registrar el nuevo tratamiento.";
                        type = "warning";

                    }

                    HttpContext.Current.Response.Redirect("IndexTreatment.aspx");

                }
                else
                {
                    //Update
                    Treatment.IdTreatment = int.Parse(Request.QueryString["Id"]);
                    outputUpdate = treatmentWSClient.UpdateTreatment(Treatment);
                    HttpContext.Current.Response.Redirect("IndexTreatment.aspx");
                }

                //Preparing the info to show the errors through the Seet Alert
                if (!outputUpdate)
                {
                    title = "Ops...";
                    response = "No se ha podido registrar o actualizar el tratamiento.";
                    type = "warning";
                    SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

                }
                else
                {
                    title = "Correcto!";
                    response = "Actualización del tratamiento o registro exitoso.";
                    type = "success";
                    SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

                }
            }
            catch (Exception ex)
            {
                title = "Error";
                response = ex.Message;
                type = "error";
                SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

            }


        }

        protected void btnBackClick(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("IndexTreatment.aspx");
        }

        protected void btnSearchClick(object sender, EventArgs e)
        {

        }

        protected void GetDate(object sender, EventArgs e)
        {

        }

        protected void btnAddMedicamentClick(object sender, EventArgs e)
        {

        }

        private void chargeDropdownList()
        {
            List<string> years = ChargeDateValues.ChargeYears();
            List<string> months = ChargeDateValues.ChargeMonths();
            List<string> days = ChargeDateValues.ChargeDays();

            List<WSMedicament.VO_Medicament> medicaments = medicamentWSClient.ListMedicaments().ToList();

            foreach (string year in years)
            {
                ddlyear.Items.Add(year);
            }

            foreach (string month in months)
            {
                ddlmonth.Items.Add(month);
            }

            foreach (string day in days)
            {
                ddlday.Items.Add(day);
            }

            foreach (WSMedicament.VO_Medicament medicament in medicaments)
            {
                ddlMedicament.Items.Add(new ListItem(medicament.NameMedicament , medicament.IdMedicament.ToString()));
            }

        }//End charge dropdowns


        private string GetDateSelected()
        {
            string date = ddlyear.Text + "/" + ddlmonth.Text + "/" + ddlday.Text;
            return date;
        }//End get date selected





    }//End treatment class
}//End namespace