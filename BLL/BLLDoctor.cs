using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLLDoctor
    {

        //Create
        public static string CreateDoctor(VO_Doctor Doctor)
        {
            return DALDoctor.CreateDoctor(Doctor);
        }
        //Read
        public static List<VO_Doctor> ListDoctors(params object[] parameters)
        {
            return DALDoctor.ListDoctors(parameters);
        }

        /* Method to list the results by patient
        public static List<VO_Doctor> ListDoctorByPatient(int idPatient)
        {
            List<VO_Doctor> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static string UpdateDoctor(VO_Doctor Doctor)
        {
            return DALDoctor.UpdateDoctor(Doctor);
        }

        //Delete
        public static string DeleteDoctor(int id)
        {

            return DALDoctor.DeleteDoctor(id);

        }//End delete method




    }//End doctor class
}//End namespace
