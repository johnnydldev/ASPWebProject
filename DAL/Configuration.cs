using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Configuration
    {
        //Declaring and assign of string connection
        static string _stringConnection = @"Data Source = DESKTOP-O21DSCR\SQLEXPRESS; Initial Catalog = HOSPITAL; Integrated Security = true;";

        public static string GetStringConnection
        {
            get
            {
                return _stringConnection;
            }
        }//End get's string connection method


    }//End configuration class
}//End namespace
