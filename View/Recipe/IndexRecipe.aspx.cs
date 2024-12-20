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
            if (!IsPostBack)
            {
                loadGrid();
            }
        }//End load event

        public void loadGrid()
        {
            //Load the data grid view with the information record
            GVRecipes.DataSource = BLLRecipe.GetAllRecipes();

            //Rendering the information
            GVRecipes.DataBind();
        }//End load grid event

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

        }//End create and update event


    }//End recipe class
}//End namespace