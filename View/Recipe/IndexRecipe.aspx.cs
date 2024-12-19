using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace AspWebProject.View.Recipe
{
    public partial class IndexRecipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }//End load event

        public void loadGrid()
        {
            //Load the data grid view with the information record
            GVRecipes.DataSource = BLLRecipe.GetAllRecipes();

            //Rendering the information
            GVRecipes.DataBind();
        }//End load grid event

        protected void CreateRecipe(object sender, EventArgs e)
        {
            Response.Redirect("FormRecipe.aspx");

        }//End create Recipe event

        protected void OnDeleteRecipe(object sender, GridViewDeleteEventArgs e)
        {
            bool response;
            //Got the id Medicament of row specified
            int idRecipe = int.Parse(GVRecipes.DataKeys[e.RowIndex].Values["IdRecipe"].ToString());

            VO_Diagnostic diagnostic = BLLDiagnostic.GetDiagnosticByRecipeId(idRecipe);

            if (diagnostic.IdDiagnostic >= 1)
            {
                response = false;
            }
            else
            {
                //Calling the delete Medicament method to get a response

                response = BLLRecipe.DeleteRecipe(idRecipe);
            }

            //Configuring the sweet alert created
            string title, msg, type;
            if (!response)
            {
                title = "Error";
                msg = "No se ha realizado la eliminación, esto se puede deber a que esta vinculado a un diagnostico o no existe.";
                type = "error";
            }
            else
            {
                title = "Correcto!";
                msg = "Eliminación exitosa.";
                type = "success";
            }

            //sweet alert
            SweetAlert.Sweet_Alert(title, msg, type, this.Page, this.GetType());

            //reload
            loadGrid();

        }//End delete event

        protected void OnExcecuteCommand(object sender, GridViewCommandEventArgs e)
        {
            //Verify that the element clicked had the select event
            if (e.CommandName == "Select")
            {
                //Got the index of the data grid view of row selected
                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of Medicament accordint to the row selected early
                string id = GVRecipes.Rows[varIndex].Cells[0].Text;

                //Redirecting to the form Medicament with values of Medicament selected
                Response.Redirect($"DetailsRecipe.aspx?Id={id}");
            }
            else if (e.CommandName == "Edit")
            {


                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of Medicament accordint to the row selected early
                string idRecipe = GVRecipes.Rows[varIndex].Cells[0].Text;

                //string idMedicament = row.Cells[0].Text;

                //Redirecting to the form Medicament with values of Medicament selected
                Response.Redirect($"FormRecipe.aspx?Id={idRecipe}");
            }

        }//End create and update event


        protected void OnEditRecipe(object sender, GridViewEditEventArgs e)
        {

        }//End edit event

        protected void OnUpdateRecipe(object sender, GridViewUpdateEventArgs e)
        {

        }//End update event

        protected void OnCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }//End cancel and edit event

    }//End recipe class
}//End namespace