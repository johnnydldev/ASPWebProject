using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLLMedicament
    {

        //Create
        public static string CreateMedicament(VO_Medicament medicament)
        {
            return DALMedicament.CreateMedicament(medicament);
        }
        //Read
        public static List<VO_Medicament> ListMedicaments()
        {
            return DALMedicament.ListMedicament();
        }

        /* Method to list the results by patient
        public static List<VO_Medicament> ListMedicamentByPatient(int idPatient)
        {
            List<VO_Medicament> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static string UpdateMedicament(VO_Medicament medicament)
        {
            return DALMedicament.UpdateMedicament(medicament);
        }

        //Delete
        public static string DeleteMedicament(int idMedicament)
        {
            
            VO_Treatment treatment = BLLTreatment.GetTreatmentByMedicamentId(idMedicament);

            if (treatment.Medicament.IdMedicament >= 1)
            {
                return "El resultado de medicamento esta vinculado a un tratamiento, no se puede eliminar ";
            }

            return DALMedicament.DeleteMedicament(idMedicament);

        }//End delete method

        public static VO_Medicament GetMedicamentById(int id)
        {
            return DALMedicament.GetMedicamentById(id);
        }//End get medicament by id



    }//End medicament class
}//End namespace
