﻿using DAL;
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
        public static int CreateTreatment(VO_Treatment treatment)
        {
            return DALTreatment.CreateTreatment(treatment);
        }
        //Read
        public static List<VO_Treatment> GetAllTreatments()
        {
            return DALTreatment.GetAllTreatments();
        }

        /* Method to list the results by patient
        public static List<VO_Treatment> ListTreatmentByPatient(int idPatient)
        {
            List<VO_Treatment> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/

        //Update
        public static bool UpdateTreatment(VO_Treatment treatment)
        {
            return DALTreatment.UpdateTreatment(treatment);
        }

        //Delete
        public static bool DeleteTreatment(int id)
        {
            return DALTreatment.DeleteTetreatment(id);

        }//End delete method

        public static VO_Treatment GetTreatmentById(int id)
        {
            return DALTreatment.GetTreatmentById(id);

        }//End get treatment method

        

        public static VO_Treatment GetTreatmentByMedicamentId(int idMedicament)
        {
            return DALTreatment.GetTreatmentByMedicamentId(idMedicament);

        }//End get treatment method



    }//End treatment class
}//End namespace
