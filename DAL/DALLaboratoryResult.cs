using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DALLaboratoryResult
    {
        public static string CreateLabResult(VO_Laboratory_Result labResult)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Create_Lab_Result",
                    "@test", labResult.Test,
                    "@resultValue", labResult.ResultValue,
                    "@dateDone", labResult.DateDone
                    );

                if (response != 0)
                {
                    outputResult = "Resultado de laboratorio registrado con éxito";
                }
                else
                {
                    outputResult = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                outputResult = "Error: " + e.Message;
                outputResult = $"Error: {e.Message}";
            }
            return outputResult;
        }//End create labResult method

        //Read
        public static List<VO_Laboratory_Result> ListlabResult(params object[] parameters)
        {
            //creo una lista de objetox VO
            List<VO_Laboratory_Result> list = new List<VO_Laboratory_Result>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet dslabResult = DataGetObject.executeDataSet("SP_List_Lab_Results", parameters);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in dslabResult.Tables[0].Rows)
                {
                    list.Add(new VO_Laboratory_Result(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido : " + ex.ToString());
                throw;
            }

        }//End list labResult method

        //Update
        public static string UpdatelabResult(VO_Laboratory_Result labResult)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Update_Lab_Result",
                    "@idLaboratoryResult", labResult.IdLaboratoryResult,
                    "@test", labResult.Test,
                    "@resultValue", labResult.ResultValue,
                    "@dateDone", labResult.DateDone
                    );

                if (response != 0)
                {
                    outputResult = "Resultado de laboratorio actualizado con éxito";
                }
                else
                {
                    outputResult = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                outputResult = $"Error: {e.Message}";
            }
            return outputResult;
        }//End update labResult method

        //Delete
        public static string SP_Delete_labResult(int id)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Delete_Lab_Result",
                    "@idLabResult", id
                    );

                if (response != 0)
                {
                    outputResult = "Resultado de laboratorio eliminado con éxito";
                }
                else
                {
                    outputResult = "Ha ocurrido un error";
                }
            }
            catch (Exception e)
            {
                outputResult = $"Error: {e.Message}";
            }
            return outputResult;
        }//End delete labResult method



    }//End laboratory result class
}//End namespace
