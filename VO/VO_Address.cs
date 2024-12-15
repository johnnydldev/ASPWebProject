using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class VO_Address
    {

        //Declaring of variables according to sql database
        private int idAddress;
        private string street ;
        private string suburb ;
        private string city;
        private string state;

        //Declaring of getters and setters
        public int IdAddress { get => idAddress; set => idAddress = value; }
        public string Street { get => street; set => street = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }


        public VO_Address()
        {
            idAddress = 0;
            street = string.Empty;
            suburb = string.Empty;
            city = string.Empty;
            state = string.Empty;
        }//End constructor method


        public VO_Address(DataRow row)
        {
            idAddress = int.Parse(row["idAddress"].ToString());
            street = row["street"].ToString();
            suburb = row["suburb"].ToString();
            city = row["city"].ToString();
            state = row["state"].ToString();
        }//End override constructor method with use of DataRow



    }//End Address class

}//End namespace
