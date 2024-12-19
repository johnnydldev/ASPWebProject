using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace AspWebProject.View.Patient
{
    public partial class IndexPatient : System.Web.UI.Page
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
            GVPatients.DataSource = BLLPatient.GetAllPatients();

            //Rendering the information
            GVPatients.DataBind();
        }//End load grid event

        protected void CreatePatient(object sender, EventArgs e)
        {
            Response.Redirect("FormPatient.aspx");

        }//End create Patient event

        protected void OnDeletePatient(object sender, GridViewDeleteEventArgs e)
        {
            bool response;
            //Got the id Medicament of row specified
            int idPatient = int.Parse(GVPatients.DataKeys[e.RowIndex].Values["IdPatient"].ToString());

            VO_Diagnostic diagnostic = BLLDiagnostic.GetDiagnosticByPatientId(idPatient);

            if (diagnostic.IdDiagnostic >= 1)
            {
                response = false;
            }
            else
            {
                //Calling the delete Medicament method to get a response

                response = BLLPatient.DeletePatient(idPatient);
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
                string id = GVPatients.Rows[varIndex].Cells[0].Text;

                //Redirecting to the form Medicament with values of Medicament selected
                Response.Redirect($"DetailsPatient.aspx?Id={id}");
            }
            else if (e.CommandName == "Edit")
            {


                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of Medicament accordint to the row selected early
                string idPatient = GVPatients.Rows[varIndex].Cells[0].Text;

                //string idMedicament = row.Cells[0].Text;

                //Redirecting to the form Medicament with values of Medicament selected
                Response.Redirect($"FormPatient.aspx?Id={idPatient}");
            }

        }//End create and update event


        protected void OnEditPatient(object sender, GridViewEditEventArgs e)
        {

        }//End edit event

        protected void OnUpdatePatient(object sender, GridViewUpdateEventArgs e)
        {

        }//End update event

        protected void OnCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }//End cancel and edit event


    }//End patient class
}//End namespace