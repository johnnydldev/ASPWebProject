using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public static List<VO_Laboratory_Result> ListlabResult()
        {
            List<VO_Laboratory_Result> labResults = new List<VO_Laboratory_Result>();

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_List_Lab_Results", objConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            labResults.Add(new VO_Laboratory_Result()
                            {
                                IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString()),
                                Test = reader["test"].ToString(),
                                ResultValue = reader["resultValue"].ToString(),
                                DateDone = reader["dateDone"].ToString()

                            });//End VO_LaboratoryResults listing

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    labResults = new List<VO_Laboratory_Result>();
                }


            }//End using of stringConnection


            return labResults;
        }//End listing VO_LaboratoryResults

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
        public static string DeleteLabResult(int id)
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


        public static VO_Laboratory_Result GetLaboratoryResultById(int id)
        {
            VO_Laboratory_Result LaboratoryResult = new VO_Laboratory_Result();

            using (SqlConnection objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_Get_LabResult_By_Id", objConnection);
                    cmd.Parameters.AddWithValue("idLabResult", id);
                    cmd.CommandType = CommandType.StoredProcedure;


                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LaboratoryResult = new VO_Laboratory_Result
                            {
                                IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString()),
                                Test = reader["test"].ToString(),
                                ResultValue = reader["resultValue"].ToString(),
                                DateDone = reader["dateDone"].ToString()

                            };

                            //End adding information LaboratoryResult

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    LaboratoryResult = new VO_Laboratory_Result();
                }


            }//End using of stringConnection


            return LaboratoryResult;

        }//End list LaboratoryResult method


    }//End laboratory result class
}//End namespace
