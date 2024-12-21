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
   
    public class MedicamentService : IMedicamentService
    {

        //Create
        [WebMethod]
        public string CreateMedicament(VO_Medicament medicament)
        {
            return DALMedicament.CreateMedicament(medicament);
        }

        //Read
        [WebMethod]
        public List<VO_Medicament> ListMedicaments()
        {
            return DALMedicament.ListMedicament();
        }

        //Update
        [WebMethod]
        public string UpdateMedicament(VO_Medicament medicament)
        {
            return DALMedicament.UpdateMedicament(medicament);
        }

        //Delete
        [WebMethod]
        public string DeleteMedicament(int idMedicament)
        {

            VO_Treatment treatment = BLLTreatment.GetTreatmentByMedicamentId(idMedicament);

            if (treatment.Medicament.IdMedicament >= 1)
            {
                return "El resultado de medicamento esta vinculado a un tratamiento, no se puede eliminar ";
            }

            return DALMedicament.DeleteMedicament(idMedicament);

        }//End delete method

        [WebMethod]
        public VO_Medicament GetMedicamentById(int id)
        {
            return DALMedicament.GetMedicamentById(id);
        }//End get medicament by id


    }//End medicament service class
}//End namespace
