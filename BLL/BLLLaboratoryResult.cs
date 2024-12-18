using VO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLLaboratoryResult
    {

        //Create
        public static string CreateLabResult(VO_Laboratory_Result lr)
        {
            return DALLaboratoryResult.CreateLabResult(lr);
        }
        //Read
        public static List<VO_Laboratory_Result> ListLabResults(params object[] parameters)
        {
            return DALLaboratoryResult.ListlabResult(parameters);
        }

        /* Method to list the results by patient
        public static List<VO_Laboratory_Result> ListLabResultByPatient(int idPatient)
        {
            List<VO_Laboratory_Result> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static string UpdateLabResult(VO_Laboratory_Result lr)
        {
            return DALLaboratoryResult.UpdatelabResult(lr);
        }

        //Delete
        public static string DeleteLabResult(int idLab)
        {
            VO_Diagnostic diagnostic = BLLDiagnostic.GetDiagnosticByLabId(idLab);
            
            if (diagnostic.LabResult.IdLaboratoryResult >= 1)
            {
                return "El resultado de laboratorio esta vinculado a un diagnostico, no se puede eliminar ";
            }

            return DALLaboratoryResult.DeleteLabResult(idLab);


        }//End delete method

        public static VO_Laboratory_Result GetLaboratoryResultById(int id)
        {
            return DALLaboratoryResult.GetLaboratoryResultById(id);
        }//End get laboratory by id


    }//End lab result class
}//End namespace
