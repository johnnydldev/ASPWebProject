using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class VO_Medicament
    {
        //Declaring of variables
        private int idMedicament;
        private string nameMedicament;
        private string dose;
        private string useInstruction;

        //Declaring of getters and setters
        public int IdMedicament { get => idMedicament; set => idMedicament = value; }
        public string NameMedicament { get => nameMedicament; set => nameMedicament = value; }
        public string Dose { get => dose; set => dose = value; }
        public string UseInstruction { get => useInstruction; set => useInstruction = value; }

        public VO_Medicament()
        {
            idMedicament = 0;
            nameMedicament = string.Empty;
            dose = string.Empty;
            useInstruction = string.Empty;
        }//End constructor method

        public VO_Medicament(DataRow row)
        {
            idMedicament = int.Parse(row["idMedicament"].ToString());
            nameMedicament = row["nameMedicament"].ToString();
            dose = row["dose"].ToString();
            useInstruction = row["useInstruction"].ToString();
        }//End override constructor method


    }//End Medicament class
}//End namespace
