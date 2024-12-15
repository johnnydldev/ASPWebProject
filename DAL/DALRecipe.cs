using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class DALRecipe
    {

        public static string CreateRecipe(VO_Recipe recipe)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Create_Recipe",
                    "@namePatient", recipe.NamePatient,
                    "@medicalCondition", recipe.MedicalCondition,
                    "@treatment", recipe.Treatment,
                    "@test", recipe.Test,
                    "@testResult", recipe.TestResult,
                    "@medicament", recipe.Medicament,
                    "@doctor", recipe.Doctor,
                    "@registerDate", recipe.RegisterDate,
                    "@idPatient", recipe.IdPatience
                );

                if (response != 0)
                {
                    outputResult = "Receta registrada con éxito";
                }
                else
                {
                    outputResult = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                outputResult = "Error: " + e.Message;
                outputResult = $"Error: {e.Message}";
            }
            return outputResult;
        }//End create recipe method

        //Read
        public static List<VO_Recipe> ListRecipes(params object[] parameters)
        {
            //creo una lista de objetox VO
            List<VO_Recipe> list = new List<VO_Recipe>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet dsAddress = DataGetObject.executeDataSet("SP_List_Recipes", parameters);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in dsAddress.Tables[0].Rows)
                {
                    list.Add(new VO_Recipe(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido : " + ex.ToString());
                throw;
            }

        }//End list address method

        //Update
        public static string UpdateRecipe(VO_Recipe recipe)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Update_Recipe",
                    "@idRecipe", recipe.IdRecipe,
                    "@namePatient", recipe.NamePatient,
                    "@medicalCondition", recipe.MedicalCondition,
                    "@treatment", recipe.Treatment,
                    "@test", recipe.Test,
                    "@testResult", recipe.TestResult,
                    "@medicament", recipe.Medicament,
                    "@doctor", recipe.Doctor,
                    "@registerDate", recipe.RegisterDate,
                    "@idPatient", recipe.IdPatience
                    );

                if (response != 0)
                {
                    outputResult = "Receta actualizada con éxito";
                }
                else
                {
                    outputResult = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                outputResult = $"Error: {e.Message}";
            }
            return outputResult;
        }//End update recipe method

        //Delete
        public static string DeleteRecipe(int id)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Delete_Recipe",
                    "@idRecipe", id
                    );

                if (response != 0)
                {
                    outputResult = "Receta eliminada con éxito";
                }
                else
                {
                    outputResult = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                outputResult = $"Error: {e.Message}";
            }
            return outputResult;
        }//End delete recipe method




    }//End recipe class
}//End namespace
