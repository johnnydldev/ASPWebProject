using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLLTreatment
    {

        //Create
        public static string CreateTreatment(VO_Treatment treatment)
        {
            return DALTreatment.CreateTreatment(treatment);
        }
        //Read
        public static List<VO_Treatment> ListTreatments(params object[] parameters)
        {
            return DALTreatment.ListTreatment(parameters);
        }

        /* Method to list the results by patient
        public static List<VO_Treatment> ListTreatmentByPatient(int idPatient)
        {
            List<VO_Treatment> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static string UpdateTreatment(VO_Treatment treatment)
        {
            return DALTreatment.UpdateTreatment(treatment);
        }

        //Delete
        public static string DeleteTreatment(int id)
        {
            return DALTreatment.DeleteTreatment(id);

        }//End delete method

        public static VO_Treatment GetTreatmentByMedicament(int id)
        {
            return DALTreatment.GetTreatmentByMedicament(id);

        }//End get treatment method

    }//End treatment class
}//End namespace
