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
    public interface IDiagnosticService
    {

        //Create
        [OperationContract]
        int CreateDiagnostic(VO_Diagnostic diagnostic);

        //Read
        [OperationContract]
        List<VO_Diagnostic> GetAllDiagnostics();

        //Update
        [OperationContract]
        bool UpdateDiagnostic(VO_Diagnostic diagnostic);

        //Delete
        [OperationContract]
        bool DeleteDiagnostic(int id);

        [OperationContract]
        VO_Diagnostic GetDiagnosticByLabId(int id);

        [OperationContract]
        VO_Diagnostic GetDiagnosticByDoctorId(int idDoctor);

        [OperationContract]
        VO_Diagnostic GetDiagnosticByPatientId(int idDoctor);

        [OperationContract]
        VO_Diagnostic GetDiagnosticById(int idDoctor);


    }//End class
}
