using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VO;

namespace AspWebProject.WS
{
  
    public class TreatmentService : ITreatmentService
    {

        //Create
        [WebMethod]
        public int CreateTreatment(VO_Treatment treatment)
        {
            return DALTreatment.CreateTreatment(treatment);
        }

        //Read
        [WebMethod]
        public List<VO_Treatment> GetAllTreatments()
        {
            return DALTreatment.GetAllTreatments();
        }


        //Update
        [WebMethod]
        public bool UpdateTreatment(VO_Treatment treatment)
        {
            return DALTreatment.UpdateTreatment(treatment);
        }

        //Delete
        [WebMethod]
        public bool DeleteTreatment(int id)
        {
            return DALTreatment.DeleteTetreatment(id);

        }//End delete method

        [WebMethod]
        public VO_Treatment GetTreatmentById(int id)
        {
            return DALTreatment.GetTreatmentById(id);

        }//End get treatment method


        [WebMethod]
        public VO_Treatment GetTreatmentByMedicamentId(int idMedicament)
        {
            return DALTreatment.GetTreatmentByMedicamentId(idMedicament);

        }//End get treatment method



    }//End class
}
