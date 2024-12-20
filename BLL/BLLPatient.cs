using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLLPatient
    {

        //Create
        public static int CreatePatient(VO_Patient patient)
        {
            return DALPatient.CreatePatient(patient);
        }
        //Read
        public static List<VO_Patient> GetAllPatients()
        {
            return DALPatient.GetAllPatients();
        }

        public static List<VO_Patient> GetAllPatientsWithNameComplete()
        {
            return DALPatient.GetAllPatientsWithNameComplete();
        }

        /* Method to list the results by patient
        public static List<VO_Patient> ListPatientByPatient(int idPatient)
        {
            List<VO_Patient> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static bool UpdatePatient(VO_Patient patient)
        {
            return DALPatient.UpdatePatient(patient);
        }

        //Delete
        public static bool DeletePatient(int id)
        {

            return DALPatient.DeletePatient(id);

        }//End delete method


        public static VO_Patient searchById(int idPatient)
        {

            return DALPatient.GetById(idPatient);

        }//End delete method


    }//End patient class
}//End namespace
