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
        public static string CreatePatient(VO_Patient atient)
        {
            return DALPatient.CreatePatient(patient);
        }
        //Read
        public static List<VO_Patient> ListPatients(params object[] parameters)
        {
            return DALPatient.ListPatient(parameters);
        }

        /* Method to list the results by patient
        public static List<VO_Patient> ListPatientByPatient(int idPatient)
        {
            List<VO_Patient> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static string UpdatePatient(VO_Patient patient)
        {
            return DALPatient.UpdatePatient(patient);
        }

        //Delete
        public static string DeletePatient(int id)
        {

            return DALPatient.DeletePatient(id);

        }//End delete method




    }//End patient class
}//End namespace
