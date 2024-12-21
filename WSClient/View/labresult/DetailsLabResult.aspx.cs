
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceLabResult;

namespace WSClient.View.LabResult
{
    public partial class DetailsLabResult : System.Web.UI.Page
    {

        LabResultServiceSoapClient labResultWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            labResultWSClient = new LabResultServiceSoapClient();
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("IndexLabResult.aspx");
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Laboratory_Result LabResult = labResultWSClient.GetLaboratoryResultById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (LabResult.IdLaboratoryResult != 0)
                    {
                        //Assign the new values to record according to the id LabResult selected
                        lblTest.Text = LabResult.Test;
                        result.Text = LabResult.ResultValue;
                        dateDone.Text = LabResult.DateDone;

                        Console.WriteLine("El objeto es: " + LabResult);
                    }

                }

            }

        }//End load event


        protected void btnBackClick(object sender, EventArgs e)
        {
            Response.Redirect("IndexLabResult.aspx");
        }//End back event


    }//End result details class
}//End namespace