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
        public static int CreateDoctor(VO_Doctor Doctor)
        {
            return DALDoctor.CreateDoctor(Doctor);
        }
        //Read
        public static List<VO_Doctor> GetAllDoctors()
        {
            return DALDoctor.GetAllDoctors();
        }

        public static List<VO_Doctor> GetAllDoctorsWithNameCompete()
        {
            return DALDoctor.GetAllDoctorsWithNameCompete();
        }

        /* Method to list the results by patient
        public static List<VO_Doctor> ListDoctorByPatient(int idPatient)
        {
            List<VO_Doctor> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static bool UpdateDoctor(VO_Doctor Doctor)
        {
            return DALDoctor.UpdateDoctor(Doctor);
        }

        //Delete
        public static bool DeleteDoctor(int id)
        {

            return DALDoctor.DeleteDoctor(id);

        }//End delete method

        public static VO_Doctor searchById(int idDoctor)
        {

            return DALDoctor.GetById(idDoctor);

        }//End delete method


    }//End doctor class
}//End namespace
