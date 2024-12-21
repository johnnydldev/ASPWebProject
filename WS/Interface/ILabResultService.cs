using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace AspWebProject.WS.Interface
{
    [ServiceContract]
    public interface ILabResultService
    {

        //Create
        [OperationContract]
        string CreateLabResult(VO_Laboratory_Result lr);

        //Read
        [OperationContract]
        List<VO_Laboratory_Result> ListLabResults();

        //Update
        [OperationContract]
        string UpdateLabResult(VO_Laboratory_Result lr);

        //Delete
        [OperationContract]
        string DeleteLabResult(int idLab);

        [OperationContract]
        VO_Laboratory_Result GetLaboratoryResultById(int id);



    }//End class
}
