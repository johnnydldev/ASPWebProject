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
        public static string DeleteLabResult(int id)
        {
            List<VO_Laboratory_Result> listLab = BLLLaboratoryResult.ListLabResults();

            VO_Laboratory_Result item = listLab.Where(x => x.IdLaboratoryResult == id).FirstOrDefault();

            VO_Diagnostic diagnostic = BLLDiagnostic.GetDiagnosticByLabResult(item.IdLaboratoryResult);
            if (diagnostic.IdLaboratoryResult >= 1)
            {
                return "El resultado de laboratorio esta vinculado a un diagnostico, no se puede eliminar ";
            }

            return DALLaboratoryResult.DeleteLabResult(id);


        }//End delete method

        public static VO_Laboratory_Result GetLaboratoryResultById(int id)
        {
            return DALLaboratoryResult.GetLaboratoryResultById(id);
        }//End get laboratory by id


    }//End lab result class
}//End namespace
