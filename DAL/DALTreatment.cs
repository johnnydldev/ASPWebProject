using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DALTreatment
    {
        public static List<VO_Treatment> GetAllTreatments()
        {
            List<VO_Treatment> treatments = new List<VO_Treatment>();

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_List_Treatments", objConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            treatments.Add(new VO_Treatment()
                            {
                                IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                RecommendTreatment = reader["recommendTreatment"].ToString(),
                                StartedDate = reader["startedDate"].ToString(),
                                Medicament = new VO_Medicament()
                                {
                                    IdMedicament = Convert.ToInt32(reader["idMedicament"].ToString()),
                                    NameMedicament = reader["nameMedicament"].ToString(),
                                    Dose = reader["dose"].ToString(),
                                    UseInstruction = reader["useInstruction"].ToString()

                                }

                            });//End VO_Treatments listing

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    treatments = new List<VO_Treatment>();
                }


            }//End using of stringConnection


            return treatments;
        }//End listing treatment

        public static VO_Treatment GetById(int idTreatment)
        {
            VO_Treatment treatment = new VO_Treatment();

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;
                    SqlCommand cmd;

                    cmd = new SqlCommand("SP_Search_Treatment_By_Id", objConnection);
                    cmd.Parameters.AddWithValue("idTreatment", idTreatment);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            treatment = new VO_Treatment
                            {
                                IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                RecommendTreatment = reader["recommendTreatment"].ToString(),
                                StartedDate = reader["startedDate"].ToString(),
                                Medicament = new VO_Medicament()
                                {
                                    IdMedicament = Convert.ToInt32(reader["idMedicament"].ToString()),
                                    NameMedicament = reader["nameMedicament"].ToString(),
                                    Dose = reader["dose"].ToString(),
                                    UseInstruction = reader["useInstruction"].ToString()

                                }
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                treatment = new VO_Treatment(); ;
            }

            return treatment;
        }//End get treatment


        public static int CreateTreatment(VO_Treatment treatment)
        {
            int treatmentGenerated = 0;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlCommand cmd = new SqlCommand("SP_Create_Treatment", objConnection);
                    cmd.Parameters.AddWithValue("@recommendTreatment", treatment.RecommendTreatment);
                    cmd.Parameters.AddWithValue("@startedDate", treatment.StartedDate);
                    cmd.Parameters.AddWithValue("@idMedicament", treatment.Medicament.IdMedicament);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    treatmentGenerated = Convert.ToInt32(cmd.Parameters["response"].Value);

                }
            }
            catch (Exception ex)
            {
                treatmentGenerated = 0;
                message = ex.ToString();
            }

            Console.WriteLine(message);

            return treatmentGenerated;
        }//End create treatment

        public static bool UpdateTreatment(VO_Treatment treatment)
        {
            bool response = false;
            string message = string.Empty;

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Update_Treatment", objConnection);
                    cmd.Parameters.AddWithValue("@recommendTreatment", treatment.RecommendTreatment);
                    cmd.Parameters.AddWithValue("@startedDate", treatment.StartedDate);
                    cmd.Parameters.AddWithValue("@idMedicament", treatment.Medicament.IdMedicament);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;


                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    response = Convert.ToBoolean(cmd.Parameters["response"].Value);

                }
                catch (Exception ex)
                {
                    response = false;
                    message = ex.Message.ToString();
                }
            }

            Console.WriteLine(message);

            return response;

        }//End edit treatment

        public static bool DeleteTetreatment(int idTreatment)
        {
            bool response = false;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {

                    SqlCommand cmd = new SqlCommand("SP_Delete_Treatment", objConnection);
                    cmd.Parameters.AddWithValue("idTreatment", idTreatment);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    response = Convert.ToBoolean(cmd.Parameters["response"].Value);

                }
            }
            catch (Exception ex)
            {
                response = false;
                message = ex.Message;
            }

            Console.WriteLine(message);

            return response;

        }//End delete treatment

        public static VO_Treatment GetTreatmentById(int idTreatment)
        {
            VO_Treatment treatment = new VO_Treatment();
            bool response = false;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;

                    SqlCommand cmd = new SqlCommand("SP_Search_Treatment_By_Id", objConnection);
                    cmd.Parameters.AddWithValue("idTreatment", idTreatment);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            treatment = new VO_Treatment
                            {
                                IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                RecommendTreatment = reader["recommendTreatment"].ToString(),
                                StartedDate = reader["startedDate"].ToString(),
                                Medicament = new VO_Medicament()
                                {
                                    IdMedicament = Convert.ToInt32(reader["idMedicament"].ToString()),
                                    NameMedicament = reader["nameMedicament"].ToString(),
                                    Dose = reader["dose"].ToString(),
                                    UseInstruction = reader["useInstruction"].ToString()

                                }
                            };
                        }
                    }

                    response = Convert.ToBoolean(cmd.Parameters["response"].Value);

                }
            }
            catch (Exception ex)
            {
                response = false;
                message = ex.Message;
            }

            Console.WriteLine(message);

            return treatment;

        }//End get by id treatment

        public static VO_Treatment GetTreatmentByMedicamentId(int idMedicament)
        {
            VO_Treatment treatment = new VO_Treatment();
            bool response = false;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;

                    SqlCommand cmd = new SqlCommand("SP_Verify_Medicament_Linked_With_Treatment", objConnection);
                    cmd.Parameters.AddWithValue("idMedicament", idMedicament);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            treatment = new VO_Treatment
                            {
                                IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                RecommendTreatment = reader["recommendTreatment"].ToString(),
                                StartedDate = reader["startedDate"].ToString(),
                                Medicament = new VO_Medicament()
                                {
                                    IdMedicament = Convert.ToInt32(reader["idMedicament"].ToString()),
                                    NameMedicament = reader["nameMedicament"].ToString(),
                                    Dose = reader["dose"].ToString(),
                                    UseInstruction = reader["useInstruction"].ToString()

                                }
                            };
                        }
                    }

                    response = Convert.ToBoolean(cmd.Parameters["response"].Value);

                }
            }
            catch (Exception ex)
            {
                response = false;
                message = ex.Message;
            }

            Console.WriteLine(message);

            return treatment;

        }//End get treatment by id medicament

    }//End treatment class
}//End namespace
