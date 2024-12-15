using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class VO_Patient
    {
        //Declaring of variables according to sql database
        private int idPatient;
        private string namePatient;
        private string middleName;
        private string lastName;
        private string birthDate;
        private string telephone;
        private int idAddress;

        //Declaring of getters and setters
        public int IdPatient { get => idPatient; set => idPatient = value; }
        public string NamePatient { get => namePatient; set => namePatient = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int IdAddress { get => idAddress; set => idAddress = value; }

        public VO_Patient()
        {
            idPatient = 0;
            namePatient = string.Empty;
            middleName = string.Empty;
            lastName = string.Empty;
            birthDate = string.Empty;
            telephone = string.Empty;
            idAddress = 0;

        }//End constructor method

        public VO_Patient(DataRow row)
        {
            idPatient = int.Parse(row["idPatient"].ToString());
            namePatient = row["namePatient"].ToString();
            middleName = row["middleName"].ToString();
            lastName = row["lastName"].ToString();
            birthDate = row["birthDate"].ToString();
            telephone = row["telephone"].ToString();
            idAddress = int.Parse(row["idAddress"].ToString());
        }//End overrride constructor method



    }//End Patient class
}//End namespace
