using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace AspWebProject.WS
{
    [ServiceContract]
    public interface IRecipeService
    {

        //Create
        [OperationContract]
        int CreateRecipe(VO_Recipe recipe);

        //Read
        [OperationContract]
        List<VO_Recipe> GetAllRecipes();

        //Update
        [OperationContract]
        VO_Recipe GetByIdRecipe(int idRecipe);

    }
}
