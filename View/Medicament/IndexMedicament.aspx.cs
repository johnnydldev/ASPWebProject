using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace AspWebProject.View.Medicament
{
    public partial class IndexMedicament : System.Web.UI.Page
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
            GVMedicaments.DataSource = BLLMedicament.ListMedicaments();

            //Rendering the information
            GVMedicaments.DataBind();
        }

        protected void CreateMedicament(object sender, EventArgs e)
        {
            Response.Redirect("FormMedicament.aspx");

        }//End load page event

        protected void OnDeleteMedicament(object sender, GridViewDeleteEventArgs e)
        {
            //Got the id Medicament of row specified
            int idMedicament = int.Parse(GVMedicaments.DataKeys[e.RowIndex].Values["IdMedicament"].ToString());

            //Calling the delete Medicament method to get a response
            string response = BLLMedicament.DeleteMedicament(idMedicament);

            //Configuring the sweet alert created
            string title, msg, type;
            if (response.ToUpper().Contains("ERROR"))
            {
                title = "Error";
                msg = response;
                type = "error";
            }
            else
            {
                title = "Correcto!";
                msg = response;
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

                //Got the id of Medicament accordint to the row selected early
                string id = GVMedicaments.Rows[varIndex].Cells[0].Text;

                //Redirecting to the form Medicament with values of Medicament selected
                Response.Redirect($"DetailsMedicament.aspx?Id={id}");
            }
            else if (e.CommandName == "Edit")
            {


                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of Medicament accordint to the row selected early
                string idMedicament = GVMedicaments.Rows[varIndex].Cells[0].Text;

                //string idMedicament = row.Cells[0].Text;

                //Redirecting to the form Medicament with values of Medicament selected
                Response.Redirect($"FormMedicament.aspx?Id={idMedicament}");
            }

        }//End load page event


        protected void OnEditMedicament(object sender, GridViewEditEventArgs e)
        {

        }

        protected void OnUpdateMedicament(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void OnCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }


    }//End medicament class
}//End namespace