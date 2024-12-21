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

    public class PatientService : IPatientService
    {

        //Create
        [WebMethod]
        public int CreatePatient(VO_Patient patient)
        {
            return DALPatient.CreatePatient(patient);
        }

        //Read
        [WebMethod]
        public List<VO_Patient> GetAllPatients()
        {
            return DALPatient.GetAllPatients();
        }

        [WebMethod]
        public List<VO_Patient> GetAllPatientsWithNameComplete()
        {
            return DALPatient.GetAllPatientsWithNameComplete();
        }

        //Update
        [WebMethod]
        public bool UpdatePatient(VO_Patient patient)
        {
            return DALPatient.UpdatePatient(patient);
        }

        //Delete
        [WebMethod]
        public bool DeletePatient(int id)
        {

            return DALPatient.DeletePatient(id);

        }//End delete method

        [WebMethod]
        public VO_Patient searchById(int idPatient)
        {

            return DALPatient.GetById(idPatient);

        }//End delete method

    }//End class
}
