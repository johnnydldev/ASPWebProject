using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebProject.View.Diagnostic
{
    public partial class IndexDiagnostic : System.Web.UI.Page
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
            GVDiagnostics.DataSource = BLLDiagnostic.GetAllDiagnostics();

            //Rendering the information
            GVDiagnostics.DataBind();
        }//End load method

        protected void CreateDiagnostic(object sender, EventArgs e)
        {
            Response.Redirect("FormDiagnostic.aspx");

        }//End load page event

        protected void OnDeleteDiagnostic(object sender, GridViewDeleteEventArgs e)
        {
            //Got the id Diagnostic of row specified
            int idDiagnostic = int.Parse(GVDiagnostics.DataKeys[e.RowIndex].Values["IdDiagnostic"].ToString());

            //Calling the delete Diagnostic method to get a response
            bool response = BLLDiagnostic.DeleteDiagnostic(idDiagnostic);

            //Configuring the sweet alert created
            string title, msg, type;
            if (!response)
            {
                title = "Error";
                msg = "No se ha podido eliminar el diagnostic";
                type = "error";
                SweetAlert.Sweet_Alert(title, msg, type, this.Page, this.GetType());

            }
            else
            {
                title = "Correcto!";
                msg = "Tratamiento eliminado con exito";
                type = "success";
                SweetAlert.Sweet_Alert(title, msg, type, this.Page, this.GetType());

            }

          
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

                //Got the id of Diagnostic accordint to the row selected early
                string id = GVDiagnostics.Rows[varIndex].Cells[0].Text;

                //Redirecting to the form Diagnostic with values of Diagnostic selected
                Response.Redirect($"DetailsDiagnostic.aspx?Id={id}");
            }
            else if (e.CommandName == "Edit")
            {


                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of Diagnostic accordint to the row selected early
                string idDiagnostic = GVDiagnostics.Rows[varIndex].Cells[0].Text;

                //string idDiagnostic = row.Cells[0].Text;

                //Redirecting to the form Diagnostic with values of Diagnostic selected
                Response.Redirect($"FormDiagnostic.aspx?Id={idDiagnostic}");
            }

        }//End load page event


        protected void OnEditDiagnostic(object sender, GridViewEditEventArgs e)
        {

        }

        protected void OnUpdateDiagnostic(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void OnCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }



    }//End diagnostic class
}//End namespace