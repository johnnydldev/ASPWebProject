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
        private VO_Medicament medicament;

        //Declaring og getters and setters
        public int IdTreatment { get => idTreatment; set => idTreatment = value; }
        public string RecommendTreatment { get => recommendTreatment; set => recommendTreatment = value; }
        public string StartedDate { get => startedDate; set => startedDate = value; }
        public VO_Medicament Medicament { get => medicament; set => medicament = value; }

        public VO_Treatment()
        {
            idTreatment = 0;
            recommendTreatment = string.Empty;
            startedDate = string.Empty;
            medicament = new VO_Medicament();
        }//End constructor method

        public VO_Treatment(DataRow row)
        {
            idTreatment = int.Parse(row["idTreatment"].ToString());
            recommendTreatment = row["recommendTreatment"].ToString();
            startedDate = row["startedDate"].ToString();
            medicament = new VO_Medicament()
            {
                IdMedicament = int.Parse(row["idMedicament"].ToString()),
                NameMedicament = row["nameMedicament"].ToString(),
                Dose = row["dose"].ToString(),
                UseInstruction = row["useInstruction"].ToString()
            };
        }//End override constructor method


    }//End treatment class
}//End namespace
