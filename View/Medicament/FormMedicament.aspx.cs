using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace AspWebProject.View.Medicament
{
    public partial class FormMedicament : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    //Header of form
                    title.Text = "Agregar Medicamento";
                    subTitle.Text = "Registro de una nueva medicamento";
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Medicament Medicament = BLLMedicament.GetMedicamentById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (Medicament.IdMedicament != 0)
                    {
                        //Assign the new values to record according to the id Medicament selected
                        title.Text = "Actualizar medicamento";
                        subTitle.Text = $"Modificar los datos de la medicamento #{_id}";
                        txtNameMedicament.Text = Medicament.NameMedicament;
                        txtDose.Text = Medicament.Dose;
                        txtUseInstruction.Text = Medicament.UseInstruction;

                        Console.WriteLine("El objeto es: " + Medicament);
                    }
                    else
                    {
                        //Return to index page of Medicament
                        Response.Redirect("IndexMedicament.aspx");
                    }
                }

            }
        }//End load page

        protected void btnSaveClick(object sender, EventArgs e)
        {
            string title = "", response = "", type = "", outputResult = "";
            try
            {
                //Create the instance of new object Medicament
                VO_Medicament Medicament = new VO_Medicament();
                Medicament.NameMedicament = txtNameMedicament.Text;
                Medicament.Dose = txtDose.Text;
                Medicament.UseInstruction = txtUseInstruction.Text;

                //Verify if the info is to create or update
                if (Request.QueryString["Id"] == null)
                {
                    outputResult = BLLMedicament.CreateMedicament(Medicament);

                    if (!outputResult.ToUpper().Contains("ERROR"))
                    {
                        title = "Ops...";
                        response = outputResult;
                        type = "warning";
                        SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

                    }

                    HttpContext.Current.Response.Redirect("IndexMedicament.aspx");

                }
                else
                {
                    //Update
                    Medicament.IdMedicament = int.Parse(Request.QueryString["Id"]);
                    outputResult = BLLMedicament.UpdateMedicament(Medicament);
                    HttpContext.Current.Response.Redirect("IndexMedicament.aspx");
                }

                //Preparing the info to show the errors through the Seet Alert
                if (outputResult.ToUpper().Contains("ERROR"))
                {
                    title = "Ops...";
                    response = outputResult;
                    type = "warning";
                    SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

                }
                else
                {
                    title = "Correcto!";
                    response = outputResult;
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
            //sweet alert
            SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType(), "/view/Medicament/IndexMedicament.aspx");

        }//End save event

        protected void btnBackClick(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("IndexMedicament.aspx");
        }

    }//End medicament class
}//End namespace