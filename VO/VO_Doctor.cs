using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class VO_Doctor
    {
        //Declaring of variables
        private int idDoctor ;
        private string nameDoctor;
        private string middleName;
        private string lastName ;
        private string birthDate;
        private string telephone;
        private int idAddress;

        //Declaring of getters and setters
        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string NameDoctor { get => nameDoctor; set => nameDoctor = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int IdAddress { get => idAddress; set => idAddress = value; }


        public VO_Doctor()
        {
            idDoctor = 0;
            nameDoctor = string.Empty;
            middleName = string.Empty;
            lastName = string.Empty;
            birthDate = string.Empty;
            telephone = string.Empty;
            idAddress = 0;
        }//End constructor method


        public VO_Doctor(DataRow row)
        {
            idDoctor = int.Parse(row["idDoctor"].ToString());
            nameDoctor = row["nameDoctor"].ToString();
            middleName = row["middleName"].ToString();
            lastName = row["lastName"].ToString();
            birthDate = row["birthDate"].ToString();
            telephone = row["telephone"].ToString();
            idAddress = int.Parse(row["idAddress"].ToString());
        }//End override constructor method


    }//End Doctor class
}//End namespace
