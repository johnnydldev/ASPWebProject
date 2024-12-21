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
    public interface IDoctorService
    {

        //Create
        [OperationContract]
        int CreateDoctor(VO_Doctor Doctor);

        //Read
        [OperationContract]
        List<VO_Doctor> GetAllDoctors();

        [OperationContract]
        List<VO_Doctor> GetAllDoctorsWithNameCompete();

        //Update
        [OperationContract]
        bool UpdateDoctor(VO_Doctor Doctor);

        //Delete
        [OperationContract]
        bool DeleteDoctor(int id);

        [OperationContract]
        VO_Doctor searchById(int idDoctor);



    }//End class
}
