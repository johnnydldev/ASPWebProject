using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLLDiagnostic
    {
        //Create
        public static int CreateDiagnostic(VO_Diagnostic diagnostic)
        {
            return DALDiagnostic.CreateDiagnostic(diagnostic);
        }
        //Read
        public static List<VO_Diagnostic> GetAllDiagnostics()
        {
            return DALDiagnostic.GetAllDiagnostics();
        }

        /* Method to list the results by patient
        public static List<VO_Diagnostic> ListDiagnosticByPatient(int idPatient)
        {
            List<VO_Diagnostic> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static bool UpdateDiagnostic(VO_Diagnostic diagnostic)
        {
            return DALDiagnostic.UpdateDiagnostic(diagnostic);
        }

        //Delete
        public static bool DeleteDiagnostic(int id)
        {

            return DALDiagnostic.DeleteDiagnostic(id);

        }//End delete method

        public static VO_Diagnostic GetDiagnosticByLabId(int id)
        {

            return DALDiagnostic.GetByIdLab(id);

        }//End get diagnostic by lab method


        public static VO_Diagnostic GetDiagnosticByDoctorId(int idDoctor)
        {

            return DALDiagnostic.GetByIdDoctor(idDoctor);

        }//End get diagnostic by lab method


    }//End diagnostic class
}//End namespace
