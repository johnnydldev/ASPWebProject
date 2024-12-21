
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceTreatment;

namespace WSClient.View.Treatment
{
    public partial class DetailsTreatment : System.Web.UI.Page
    {
        TreatmentServiceSoapClient treatmentWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            treatmentWSClient = new TreatmentServiceSoapClient();
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("IndexTreatment.aspx");
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Treatment treatment = treatmentWSClient.GetTreatmentById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (treatment.IdTreatment >= 1)
                    {
                        //Assign the new values to record according to the id address selected
                        lblTreatment.Text = treatment.RecommendTreatment;
                        lblMedicament.Text = treatment.Medicament.NameMedicament;
                        lblDose.Text = treatment.Medicament.Dose;
                        lblUseInstruction.Text = treatment.Medicament.UseInstruction;
                        lblStartedDate.Text = treatment.StartedDate;

                        Console.WriteLine("El objeto es: " + treatment);
                    }//

                }//

            }//
        }//End load event

        protected void btnBackClick(object sender, EventArgs e)
        {
            Response.Redirect("IndexTreatment.aspx");
        }//End back event

    }//End details treatment class
}//End namespace