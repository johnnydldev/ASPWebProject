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
        public static List<VO_Medicament> ListMedicaments(params object[] parameters)
        {
            return DALMedicament.ListMedicament(parameters);
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
        public static string DeleteMedicament(int id)
        {
         
            return DALMedicament.DeleteMedicament(id);

        }//End delete method


    }//End medicament class
}//End namespace
