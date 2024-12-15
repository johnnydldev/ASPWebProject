using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebProject.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }//End load event


        protected void ShowAddress(object sender, EventArgs e)
        {
            Response.Redirect("/View/Address/IndexAddress.aspx");
        }//End load event

        protected void ShowDiagnostic(object sender, EventArgs e)
        {
            Response.Redirect("/View/Diagnostic/IndexDiagnostic.aspx");
        }//End load event

        protected void ShowDoctor(object sender, EventArgs e)
        {
            Response.Redirect("/View/Doctor/IndexDoctor.aspx");
        }//End load event

        protected void ShowLabResult(object sender, EventArgs e)
        {
            Response.Redirect("/View/LabResult/IndexLabResult.aspx");
        }//End load event

        protected void ShowMedicament(object sender, EventArgs e)
        {
            Response.Redirect("/View/Medicament/IndexMedicament.aspx");
        }//End load event

        protected void ShowPatient(object sender, EventArgs e)
        {
            Response.Redirect("/View/Patient/IndexPatient.aspx");
        }//End load event

        protected void ShowRecipe(object sender, EventArgs e)
        {
            Response.Redirect("/View/Recipe/IndexRecipe.aspx");
        }//End load event

        protected void ShowTreatment(object sender, EventArgs e)
        {
            Response.Redirect("/View/Treatment/IndexTreatment.aspx");
        }//End load event

    }//End class
}//End namespace