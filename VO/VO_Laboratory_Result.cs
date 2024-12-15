using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class VO_Laboratory_Result
    {
        //Declaring of variables
        private int idLaboratoryResult;
        private string test;
        private string resultValue;
        private string dateDone;

        //Declaring of getters and setters
        public int IdLaboratoryResult { get => idLaboratoryResult; set => idLaboratoryResult = value; }
        public string Test { get => test; set => test = value; }
        public string ResultValue { get => resultValue; set => resultValue = value; }
        public string DateDone { get => dateDone; set => dateDone = value; }

        public VO_Laboratory_Result()
        {
            idLaboratoryResult = 0;
            test = string.Empty;
            resultValue = string.Empty;
            dateDone = string.Empty;
        }//End constructor method

        public VO_Laboratory_Result(DataRow row)
        {
            idLaboratoryResult = int.Parse(row["idLaboratoryResult"].ToString());
            test = row["test"].ToString() ;
            resultValue = row["resultValue"].ToString() ;
            dateDone = row["dateDone"].ToString() ;
        }//End constructor method


    }//End laboratory class
}//End namespace
