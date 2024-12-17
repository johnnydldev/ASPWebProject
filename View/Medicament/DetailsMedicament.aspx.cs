using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace AspWebProject.View.Medicament
{
    public partial class DetailsMedicament : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("IndexMedicament.aspx");
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Medicament medicament = BLLMedicament.GetMedicamentById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (medicament.IdMedicament != 0)
                    {
                        //Assign the new values to record according to the id Medicament selected
                        lblNameMedicament.Text = medicament.NameMedicament;
                        dose.Text = medicament.Dose;
                        useInstruction.Text = medicament.UseInstruction;

                        Console.WriteLine("El objeto es: " + medicament);
                    }

                }

            }
        }//End load


        protected void btnBackClick(object sender, EventArgs e)
        {
            Response.Redirect("IndexMedicament.aspx");
        }//End back event



    }//End medicament class
}//End namespace