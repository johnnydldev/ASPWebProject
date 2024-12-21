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
    public interface IPatientService
    {

        //Create
        [OperationContract]
        int CreatePatient(VO_Patient patient);

        //Read
        [OperationContract]
        List<VO_Patient> GetAllPatients();

        [OperationContract]
        List<VO_Patient> GetAllPatientsWithNameComplete();

        //Update
        [OperationContract]
        bool UpdatePatient(VO_Patient patient);

        //Delete
        [OperationContract]
        bool DeletePatient(int id);

        [OperationContract]
        VO_Patient searchById(int idPatient);



    }//End class
}
