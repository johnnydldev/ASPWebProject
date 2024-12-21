using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using VO;

namespace AspWebProject.WS
{
    [ServiceContract]
    public interface ITreatmentService
    {

        //Create
        [OperationContract]
        int CreateTreatment(VO_Treatment treatment);

        //Read
        [OperationContract]
        List<VO_Treatment> GetAllTreatments();


        //Update
        [OperationContract]
        bool UpdateTreatment(VO_Treatment treatment);

        //Delete
        [OperationContract]
        bool DeleteTreatment(int id);

        [OperationContract]
        VO_Treatment GetTreatmentById(int id);


        [OperationContract]
        VO_Treatment GetTreatmentByMedicamentId(int idMedicament);

    }//End class
}
