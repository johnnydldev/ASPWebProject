using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebProject.View.Treatment
{
    public partial class IndexTreatment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGrid();
            }
        }//End load event

        public void loadGrid()
        {
            //Load the data grid view with the information record
            GVTreatments.DataSource = BLLTreatment.GetAllTreatments();

            //Rendering the information
            GVTreatments.DataBind();
        }//End load method

        protected void CreateTreatment(object sender, EventArgs e)
        {
            Response.Redirect("FormTreatment.aspx");

        }//End load page event

        protected void OnDeleteTreatment(object sender, GridViewDeleteEventArgs e)
        {
            //Got the id Treatment of row specified
            int idTreatment = int.Parse(GVTreatments.DataKeys[e.RowIndex].Values["IdTreatment"].ToString());

            //Calling the delete Treatment method to get a response
            bool response = BLLTreatment.DeleteTreatment(idTreatment);

            //Configuring the sweet alert created
            string title, msg, type;
            if (!response)
            {
                title = "Error";
                msg = "No se ha podido eliminar el tratamiento";
                type = "error";
            }
            else
            {
                title = "Correcto!";
                msg = "Tratamiento eliminado con exito";
                type = "success";
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

                //Got the id of Treatment accordint to the row selected early
                string id = GVTreatments.Rows[varIndex].Cells[0].Text;

                //Redirecting to the form Treatment with values of Treatment selected
                Response.Redirect($"DetailsTreatment.aspx?Id={id}");
            }
            else if (e.CommandName == "Edit")
            {


                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of Treatment accordint to the row selected early
                string idTreatment = GVTreatments.Rows[varIndex].Cells[0].Text;

                //string idTreatment = row.Cells[0].Text;

                //Redirecting to the form Treatment with values of Treatment selected
                Response.Redirect($"FormTreatment.aspx?Id={idTreatment}");
            }

        }//End load page event


        protected void OnEditTreatment(object sender, GridViewEditEventArgs e)
        {

        }

        protected void OnUpdateTreatment(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void OnCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }


    }//End treatment class
}//End namespace