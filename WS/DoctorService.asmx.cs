using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Services;
using VO;

namespace AspWebProject.WS
{
    public class DoctorService : IDoctorService
    {

        //Create
        [WebMethod]
        public int CreateDoctor(VO_Doctor Doctor)
        {
            return DALDoctor.CreateDoctor(Doctor);
        }

        //Read
        [WebMethod]
        public List<VO_Doctor> GetAllDoctors()
        {
            return DALDoctor.GetAllDoctors();
        }

        [WebMethod]
        public List<VO_Doctor> GetAllDoctorsWithNameCompete()
        {
            return DALDoctor.GetAllDoctorsWithNameCompete();
        }


        //Update
        [WebMethod]
        public bool UpdateDoctor(VO_Doctor Doctor)
        {
            return DALDoctor.UpdateDoctor(Doctor);
        }

        //Delete
        [WebMethod]
        public bool DeleteDoctor(int id)
        {

            return DALDoctor.DeleteDoctor(id);

        }//End delete method

        [WebMethod]
        public VO_Doctor searchById(int idDoctor)
        {

            return DALDoctor.GetById(idDoctor);

        }//End delete method


    }//End class
}
