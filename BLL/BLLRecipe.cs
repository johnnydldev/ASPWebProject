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
        public static int CreateRecipe(VO_Recipe recipe)
        {
            return DALRecipe.CreateRecipe(recipe);
        }
        //Read
        public static List<VO_Recipe> GetAllRecipes()
        {
            return DALRecipe.GetAllRecipes();
        }

        //Update
        public static VO_Recipe GetByIdRecipe(int idRecipe)
        {
            return DALRecipe.GetById(idRecipe);
        }

    }//End recipe class
}//End namespace
