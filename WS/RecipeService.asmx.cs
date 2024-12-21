using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VO;

namespace AspWebProject.WS
{
    
    public class RecipeService : IRecipeService
    {

        [WebMethod]
        //Create
        public int CreateRecipe(VO_Recipe recipe)
        {
            return DALRecipe.CreateRecipe(recipe);
        }

        //Read
        [WebMethod]
        public List<VO_Recipe> GetAllRecipes()
        {
            return DALRecipe.GetAllRecipes();
        }

        //Update
        [WebMethod]
        public VO_Recipe GetByIdRecipe(int idRecipe)
        {
            return DALRecipe.GetById(idRecipe);
        }


    }//End class
}
