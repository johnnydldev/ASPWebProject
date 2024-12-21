using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VO;

namespace AspWebProject.WS
{
    
    public class DiagnosticService : IDiagnosticService
    {

        //Create
        [WebMethod]
        public int CreateDiagnostic(VO_Diagnostic diagnostic)
        {
            return DALDiagnostic.CreateDiagnostic(diagnostic);
        }

        //Read
        [WebMethod]
        public List<VO_Diagnostic> GetAllDiagnostics()
        {
            return DALDiagnostic.GetAllDiagnostics();
        }

        //Update
        [WebMethod]
        public bool UpdateDiagnostic(VO_Diagnostic diagnostic)
        {
            return DALDiagnostic.UpdateDiagnostic(diagnostic);
        }

        //Delete
        [WebMethod]
        public bool DeleteDiagnostic(int id)
        {

            return DALDiagnostic.DeleteDiagnostic(id);

        }//End delete method

        [WebMethod]
        public VO_Diagnostic GetDiagnosticByLabId(int id)
        {

            return DALDiagnostic.GetByIdLab(id);

        }//End get diagnostic by lab method

        [WebMethod]
        public VO_Diagnostic GetDiagnosticByDoctorId(int idDoctor)
        {

            return DALDiagnostic.GetByIdDoctor(idDoctor);

        }//End get diagnostic by lab method

        [WebMethod]
        public VO_Diagnostic GetDiagnosticByPatientId(int idDoctor)
        {

            return DALDiagnostic.GetByIdPatient(idDoctor);

        }//End get diagnostic by lab method

        [WebMethod]
        public VO_Diagnostic GetDiagnosticById(int idDoctor)
        {

            return DALDiagnostic.GetById(idDoctor);

        }//End get diagnostic by lab method

    }//End diagnostic class
}
