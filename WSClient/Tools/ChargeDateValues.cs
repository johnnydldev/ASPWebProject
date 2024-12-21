using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSClient.Tools
{
    public class ChargeDateValues
    {

        public static List<string> ChargeYears()
        {
            int yearCurrent = Convert.ToInt32(DateTime.Now.Year.ToString());

            List<string> years = new List<string>();
            int counter = yearCurrent - 100;

            while (yearCurrent >= counter)
            {
                years.Add(yearCurrent.ToString());
                yearCurrent--;
            }

            return years;
        }//End charge years method

        public static List<string> ChargeMonths()
        {
            List<string> months = new List<string>();
            int monthMajor = 12;
            while (monthMajor >= 1)
            {
                if(monthMajor < 10)
                {
                    string month = "0"+ monthMajor.ToString();
                    months.Add(month);
                }
                else
                {
                    months.Add(monthMajor.ToString());
                }
                monthMajor--;
            }

            return months;
        }//End charge months method


        public static List<string> ChargeDays()
        {
            List<string> days = new List<string>();
            int dayMajor = 31;
            while (dayMajor >= 1)
            {

                if (dayMajor < 10)
                {
                    string day = "0" + dayMajor.ToString();
                    days.Add(day);
                }
                else
                {
                    days.Add(dayMajor.ToString());
                }

                dayMajor--;
            }

            return days;
        }//End charge days method



    }//End charge date class
}//End namespace
