using WSClient.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceLabResult;

namespace WSClient.View.LabResult
{
    public partial class FormLabResult : System.Web.UI.Page
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
                    //Header of form
                    title.Text = "Agregar resultado";
                    subTitle.Text = "Registro de una nuevo resultado";
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Laboratory_Result labResult = labResultWSClient.GetLaboratoryResultById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (labResult.IdLaboratoryResult != 0)
                    {
                        //Assign the new values to record according to the id labResult selected
                        title.Text = "Actualizar resultado";
                        subTitle.Text = $"Modificar los datos del resultado #{_id}";
                        txtTest.Text = labResult.Test;
                        txtResult.Text = labResult.ResultValue;
                        txtDateDone.Text = labResult.DateDone;

                        Console.WriteLine("El objeto es: " + labResult);
                    }
                    else
                    {
                        //Return to index page of labResult
                        Response.Redirect("IndexLabResult.aspx");
                    }
                }

            }

        }//End load event

        protected void btnSaveClick(object sender, EventArgs e)
        {
            string title = "", response = "", type = "", outputResult = "";
            try
            {
                //Create the instance of new object labResult
                VO_Laboratory_Result labResult = new VO_Laboratory_Result();
                labResult.Test = txtTest.Text;
                labResult.ResultValue = txtResult.Text;
                labResult.DateDone = txtDateDone.Text;

                //Verify if the info is to create or update
                if (Request.QueryString["Id"] == null)
                {
                    outputResult = labResultWSClient.CreateLabResult(labResult);

                    if (!outputResult.ToUpper().Contains("ERROR"))
                    {
                        title = "Ops...";
                        response = outputResult;
                        type = "warning";
                        SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());


                    }

                    HttpContext.Current.Response.Redirect("IndexlabResult.aspx");

                }
                else
                {
                    //Update
                    labResult.IdLaboratoryResult = int.Parse(Request.QueryString["Id"]);
                    outputResult = labResultWSClient.UpdateLabResult(labResult);
                    HttpContext.Current.Response.Redirect("IndexLabResult.aspx");
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
            }
            //sweet alert
            SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType(), "/view/labResult/IndexlabResult.aspx");

        }//End save event

        protected void btnBackClick(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("IndexLabResult.aspx");
        }

    }//End lab result class
}//End namespace