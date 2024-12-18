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
        public static string CreateDiagnostic(VO_Diagnostic diagnostic)
        {
            return DALDiagnostic.CreateDiagnostic(diagnostic);
        }
        //Read
        public static List<VO_Diagnostic> ListDiagnostics(params object[] parameters)
        {
            return DALDiagnostic.ListDiagnostics(parameters);
        }

        /* Method to list the results by patient
        public static List<VO_Diagnostic> ListDiagnosticByPatient(int idPatient)
        {
            List<VO_Diagnostic> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static string UpdateDiagnostic(VO_Diagnostic diagnostic)
        {
            return DALDiagnostic.UpdateDiagnostic(diagnostic);
        }

        //Delete
        public static string DeleteDiagnostic(int id)
        {

            return DALDiagnostic.DeleteDiagnostic(id);

        }//End delete method

        public static VO_Diagnostic GetDiagnosticByLabResult(int id)
        {

            return DALDiagnostic.GetDiagnosticByLabResult(id);

        }//End get diagnostic by lab method


    }//End diagnostic class
}//End namespace
