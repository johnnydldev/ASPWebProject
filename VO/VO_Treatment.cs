using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class VO_Treatment
    {
        //Declaring of variables
        private int idTreatment;
        private string recommendTreatment;
        private string startedDate;
        private int idMedicament;

        //Declaring og getters and setters
        public int IdTreatment { get => idTreatment; set => idTreatment = value; }
        public string RecommendTreatment { get => recommendTreatment; set => recommendTreatment = value; }
        public string StartedDate { get => startedDate; set => startedDate = value; }
        public int IdMedicament { get => idMedicament; set => idMedicament = value; }

        public VO_Treatment()
        {
            idTreatment = 0;
            recommendTreatment = string.Empty;
            startedDate = string.Empty;
            idMedicament = 0;
        }//End constructor method

        public VO_Treatment(DataRow row)
        {
            idTreatment = int.Parse(row["idTreatment"].ToString());
            recommendTreatment = row["recommendTreatment"].ToString();
            startedDate = row["startedDate"].ToString();
            idMedicament = int.Parse(row["idMedicament"].ToString());
        }//End override constructor method


    }//End treatment class
}//End namespace
