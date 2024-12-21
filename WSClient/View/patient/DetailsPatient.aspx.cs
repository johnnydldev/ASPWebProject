
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServicePatient;

namespace WSCLient.View.Patient
{
    public partial class DetailsPatient : System.Web.UI.Page
    {
        PatientServiceSoapClient patientWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            patientWSClient = new PatientServiceSoapClient();
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("IndexPatient.aspx");
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Patient Patient = patientWSClient.searchById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (Patient.IdPatient >= 1)
                    {
                        //Assign the new values to record according to the id address selected
                        lblNamePatient.Text = Patient.NamePatient;
                        lblMiddleName.Text = Patient.MiddleName;
                        lblLastName.Text = Patient.LastName;
                        lblTelephone.Text = Patient.Telephone;
                        lblAddress.Text = Patient.Address.Street;
                        lblBirthdate.Text = Patient.BirthDate;

                        Console.WriteLine("El objeto es: " + Patient);
                    }

                }

            }
        }//End load event

        protected void btnBackClick(object sender, EventArgs e)
        {
            Response.Redirect("IndexPatient.aspx");
        }//End back event


    }//End patient class
}//End namespace