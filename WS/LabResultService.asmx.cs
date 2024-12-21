using AspWebProject.WS.Interface;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VO;

namespace AspWebProject.WS
{
   
    public class LabResultService : ILabResultService
    {


        //Create
        [WebMethod]
        public string CreateLabResult(VO_Laboratory_Result lr)
        {
            return DALLaboratoryResult.CreateLabResult(lr);
        }

        //Read
        [WebMethod]
        public List<VO_Laboratory_Result> ListLabResults()
        {
            return DALLaboratoryResult.ListlabResult();
        }

        //Update
        [WebMethod]
        public string UpdateLabResult(VO_Laboratory_Result lr)
        {
            return DALLaboratoryResult.UpdatelabResult(lr);
        }

        //Delete
        [WebMethod]
        public string DeleteLabResult(int idLab)
        {
            VO_Diagnostic diagnostic = BLLDiagnostic.GetDiagnosticByLabId(idLab);

            if (diagnostic.LabResult.IdLaboratoryResult >= 1)
            {
                return "El resultado de laboratorio esta vinculado a un diagnostico, no se puede eliminar ";
            }

            return DALLaboratoryResult.DeleteLabResult(idLab);


        }//End delete method

        [WebMethod]
        public VO_Laboratory_Result GetLaboratoryResultById(int id)
        {
            return DALLaboratoryResult.GetLaboratoryResultById(id);
        }//End get laboratory by id


    }//End class
}
