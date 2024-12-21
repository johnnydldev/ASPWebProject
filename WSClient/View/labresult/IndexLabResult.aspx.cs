using WSClient.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceLabResult;

namespace WSClient.View.LabResult
{
    public partial class IndexLabResult : System.Web.UI.Page
    {
        LabResultServiceSoapClient labResultWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            labResultWSClient = new LabResultServiceSoapClient();
            if (!IsPostBack)
            {
                loadGrid();
            }
        }//End load event

        public void loadGrid()
        {
            //Load the data grid view with the information record
            GVLabResults.DataSource = labResultWSClient.ListLabResults();

            //Rendering the information
            GVLabResults.DataBind();
        }

        protected void CreateLabResult(object sender, EventArgs e)
        {
            Response.Redirect("FormLabResult.aspx");

        }//End load page event

        protected void OnDeleteLabResult(object sender, GridViewDeleteEventArgs e)
        {
            //Got the id LabResult of row specified
            int idLabResult = int.Parse(GVLabResults.DataKeys[e.RowIndex].Values["IdLaboratoryResult"].ToString());

            //Calling the delete LabResult method to get a response
            string response = labResultWSClient.DeleteLabResult(idLabResult);

            //Configuring the sweet alert created
            string title, msg, type;
            if (response.ToUpper().Contains("ERROR"))
            {
                title = "Error";
                msg = response;
                type = "error";
                SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

            }
            else
            {
                title = "Correcto!";
                msg = response;
                type = "success";
                SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

            }

            //sweet alert
            SweetAlert.Sweet_Alert(title, msg, type, this.Page, this.GetType());

            //reload
            loadGrid();

        }//End load page event

        protected void OnExcecuteCommand(object sender, GridViewCommandEventArgs e)
        {
            //Verify that the element clicked had the select event
            if (e.CommandName == "Select")
            {
                //Got the index of the data grid view of row selected
                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of LabResult accordint to the row selected early
                string id = GVLabResults.Rows[varIndex].Cells[0].Text;

                //Redirecting to the form LabResult with values of LabResult selected
                Response.Redirect($"DetailsLabResult.aspx?Id={id}");
            }
            else if (e.CommandName == "Edit")
            {


                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of LabResult accordint to the row selected early
                string idLabResult = GVLabResults.Rows[varIndex].Cells[0].Text;

                //string idLabResult = row.Cells[0].Text;

                //Redirecting to the form LabResult with values of LabResult selected
                Response.Redirect($"FormLabResult.aspx?Id={idLabResult}");
            }

        }//End load page event


        protected void OnEditLabResult(object sender, GridViewEditEventArgs e)
        {

        }

        protected void OnUpdateLabResult(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void OnCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }



    }//End lab result class
}//End namespace