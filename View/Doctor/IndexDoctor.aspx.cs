using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace AspWebProject.View.Doctor
{
    public partial class IndexDoctor : System.Web.UI.Page
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
            GVDoctors.DataSource = BLLDoctor.GetAllDoctors();

            //Rendering the information
            GVDoctors.DataBind();
        }//End load grid event

        protected void CreateDoctor(object sender, EventArgs e)
        {
            Response.Redirect("FormDoctor.aspx");

        }//End create doctor event

        protected void OnDeleteDoctor(object sender, GridViewDeleteEventArgs e)
        {
            bool response;
            //Got the id Medicament of row specified
            int idDoctor = int.Parse(GVDoctors.DataKeys[e.RowIndex].Values["IdDoctor"].ToString());

            VO_Diagnostic diagnostic = BLLDiagnostic.GetDiagnosticByDoctorId(idDoctor);

            if (diagnostic.IdDiagnostic >= 1)
            {
                response = false;
            }
            else
            {
                //Calling the delete Medicament method to get a response

                response = BLLDoctor.DeleteDoctor(idDoctor);
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
                string id = GVDoctors.Rows[varIndex].Cells[0].Text;

                //Redirecting to the form Medicament with values of Medicament selected
                Response.Redirect($"DetailsDoctor.aspx?Id={id}");
            }
            else if (e.CommandName == "Edit")
            {


                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of Medicament accordint to the row selected early
                string idDoctor = GVDoctors.Rows[varIndex].Cells[0].Text;

                //string idMedicament = row.Cells[0].Text;

                //Redirecting to the form Medicament with values of Medicament selected
                Response.Redirect($"FormDoctor.aspx?Id={idDoctor}");
            }

        }//End create and update event


        protected void OnEditDoctor(object sender, GridViewEditEventArgs e)
        {

        }//End edit event

        protected void OnUpdateDoctor(object sender, GridViewUpdateEventArgs e)
        {

        }//End update event

        protected void OnCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }//End cancel and edit event

    }//End doctor class
}//End namespace