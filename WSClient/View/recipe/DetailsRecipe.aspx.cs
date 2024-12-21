
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceRecipe;

namespace WSClient.View.Recipe
{
    public partial class DetailsRecipe : System.Web.UI.Page
    {
        RecipeServiceSoapClient recipeWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            recipeWSClient = new RecipeServiceSoapClient();
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("IndexRecipe.aspx");
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Recipe recipe = recipeWSClient.GetByIdRecipe(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (recipe.IdRecipe >= 1)
                    {
                        //Assign the new values to record according to the id address selected
                        lblNamePatient.Text = recipe.NamePatient;
                        lblMedicalCondition.Text = recipe.MedicalCondition;
                        lblTreatment.Text = recipe.Treatment;
                        lblTest.Text = recipe.Test;
                        lblTestResult.Text = recipe.TestResult;
                        lblMedicament.Text = recipe.Medicament;
                        lblDoctor.Text = recipe.Doctor;
                        lblRegisterDate.Text = recipe.RegisterDate;

                        Console.WriteLine("El objeto es: " + recipe);
                    }//

                }//

            }//

        }//End load event

        protected void btnBackClick(object sender, EventArgs e)
        {
            Response.Redirect("IndexRecipe.aspx");
        }//End back event

    }//End recipe class
}//End namespace