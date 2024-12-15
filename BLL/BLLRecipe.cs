using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLLRecipe
    {
        //Create
        public static string CreateRecipe(VO_Recipe recipe)
        {
            return DALRecipe.CreateRecipe(recipe);
        }
        //Read
        public static List<VO_Recipe> ListRecipes(params object[] parameters)
        {
            return DALRecipe.ListRecipes(parameters);
        }

        /* Method to list the results by patient
        public static List<VO_Recipe> ListRecipeByPatient(int idPatient)
        {
            List<VO_Recipe> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static string UpdateRecipe(VO_Recipe recipe)
        {
            return DALRecipe.UpdateRecipe(recipe);
        }

        //Delete
        public static string DeleteRecipe(int id)
        {

            return DALRecipe.DeleteRecipe(id);

        }//End delete method




    }//End recipe class
}//End namespace
