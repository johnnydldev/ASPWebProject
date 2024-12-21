using WSClient.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServicePatient;
using WSClient.ServiceAddress;

namespace WSClient.View.Patient
{
    public partial class FormPatient : System.Web.UI.Page
    {
        public DateTime birthDate;
        PatientServiceSoapClient patientWSClient;
        AddressServiceSoapClient addressWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            patientWSClient = new PatientServiceSoapClient();
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    //Header of form
                    title.Text = "Registrar Paciente";
                    subTitle.Text = "Registro de nuevo Paciente";
                    chargeDropdownList();

                }
                else
                {
                    chargeDropdownList();

                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Patient Patient = patientWSClient.searchById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (Patient.IdPatient > 0)
                    {
                        string dateComplete = Patient.BirthDate.ToString();
                        string year = dateComplete.Substring(6, 4);
                        string month = dateComplete.Substring(3, 2);
                        string day = dateComplete.Substring(0, 2);
                        string address = Patient.Address.Street.ToString();
                        //Assign the new values to record according to the id Patient selected
                        title.Text = "Actualizar Patient";
                        subTitle.Text = $"Modificar los datos del Patient #{_id}";
                        txtNamePatient.Text = Patient.NamePatient;
                        txtMiddlename.Text = Patient.MiddleName;
                        txtLastname.Text = Patient.LastName;
                        txtTelephone.Text = Patient.Telephone;
                        ddlyear.Items.FindByText(year).Selected = true;
                        ddlmonth.Items.FindByText(month).Selected = true;
                        ddlday.Items.FindByText(day).Selected = true;
                        ddlAddress.Items.FindByText(address).Selected = true;

                        Console.WriteLine("El objeto es: " + Patient);
                    }
                    else
                    {
                        //Return to index page of Patient
                        Response.Redirect("IndexPatient.aspx");
                    }

                }//End verify of record or new 

            }//End evaluate of postback

        }//End load event

        string date = string.Empty;
        protected void GetBirthdate(object sender, EventArgs e)
        {
            //almacenos la fecha seleccionada en el calendario de salida de forma global
            //birthDate = clcBirthdate.SelectedDate;

            //clcBirthdate.SelectedDate = birthDate;
            //clcBirthdate.VisibleDate = birthDate;
        }

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
                //Create the instance of new object Patient
                VO_Patient Patient = new VO_Patient();
                Patient.NamePatient = txtNamePatient.Text;
                Patient.MiddleName = txtMiddlename.Text;
                Patient.LastName = txtLastname.Text;
                Patient.Telephone = txtTelephone.Text;
                Patient.BirthDate = GetDateSelected();
                Patient.Address.IdAddress = Convert.ToInt32(ddlAddress.SelectedValue.ToString());

                //Verify if the info is to create or update
                if (Request.QueryString["Id"] == null)
                {
                    outputCreate = patientWSClient.CreatePatient(Patient);

                    if (outputCreate == 0)
                    {
                        title = "Ops...";
                        response = "No se ha podido registrar el nuevo Paciente.";
                        type = "warning";

                    }

                    HttpContext.Current.Response.Redirect("IndexPatient.aspx");

                }
                else
                {
                    //Update
                    Patient.IdPatient = int.Parse(Request.QueryString["Id"]);
                    outputUpdate = patientWSClient.UpdatePatient(Patient);
                    HttpContext.Current.Response.Redirect("IndexPatient.aspx");
                }

                //Preparing the info to show the errors through the Seet Alert
                if (!outputUpdate)
                {
                    title = "Ops...";
                    response = "No se ha podido registrar o actualizar el paciente.";
                    type = "warning";
                }
                else
                {
                    title = "Correcto!";
                    response = "Actualización del paciente o registro exitoso.";
                    type = "success";
                }
            }
            catch (Exception ex)
            {
                title = "Error";
                response = ex.Message;
                type = "error";
            }
            //sweet alert
            SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType(), "/view/Patient/IndexPatient.aspx");




        }

        protected void btnBackClick(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("IndexPatient.aspx");
        }

        protected void btnSearchClick(object sender, EventArgs e)
        {

        }

        protected void btnAddAddressClick(object sender, EventArgs e)
        {

        }

        private void chargeDropdownList()
        {
            List<string> years = ChargeDateValues.ChargeYears();
            List<string> months = ChargeDateValues.ChargeMonths();
            List<string> days = ChargeDateValues.ChargeDays();

            List<ServiceAddress.VO_Address> addresses = addressWSClient.ListAddressComplete().ToList();

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

            foreach (ServiceAddress.VO_Address Patient in addresses)
            {
                ddlAddress.Items.Add(new ListItem(Patient.Street, Patient.IdAddress.ToString()));
            }

        }//End charge dropdowns


        private string GetDateSelected()
        {
            string birthdate = ddlyear.Text + "/" + ddlmonth.Text + "/" + ddlday.Text;
            return birthdate;
        }//End get date selected

    }//End patient class
}//End namespace