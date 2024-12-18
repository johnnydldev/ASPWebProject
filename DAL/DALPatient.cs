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
    public class DALPatient
    {
        public static List<VO_Patient> GetAllPatients()
        {
            List<VO_Patient> patients = new List<VO_Patient>();

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_List_Patients", objConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patients.Add(new VO_Patient()
                            {
                                IdPatient = Convert.ToInt32(reader["idPatient"].ToString()),
                                NamePatient = reader["namePatient"].ToString(),
                                MiddleName = reader["middleName"].ToString(),
                                LastName = reader["lastName"].ToString(),
                                BirthDate = reader["birthDate"].ToString(),
                                Telephone = reader["telephone"].ToString(),
                                Address = new VO_Address()
                                {
                                    IdAddress = Convert.ToInt32(reader["idAddress"].ToString()),
                                    Street = reader["street"].ToString(),
                                    Suburb = reader["suburb"].ToString(),
                                    City = reader["city"].ToString(),
                                    State = reader["state"].ToString()

                                }

                            });//End VO_patients listing

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    patients = new List<VO_Patient>();
                }


            }//End using of stringConnection


            return patients;
        }//End listing VO_patients

        public static VO_Patient GetById(int idPatient)
        {
            VO_Patient patient = new VO_Patient();

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;
                    SqlCommand cmd;

                    cmd = new SqlCommand("SP_Search_Patient_By_Id", objConnection);
                    cmd.Parameters.AddWithValue("idPatient", idPatient);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patient = new VO_Patient
                            {
                                IdPatient = Convert.ToInt32(reader["idPatient"].ToString()),
                                NamePatient = reader["namePatient"].ToString(),
                                MiddleName = reader["middleName"].ToString(),
                                LastName = reader["lastName"].ToString(),
                                BirthDate = reader["birthDate"].ToString(),
                                Telephone = reader["telephone"].ToString(),
                                Address = new VO_Address()
                                {
                                    IdAddress = Convert.ToInt32(reader["idAddress"].ToString()),
                                    Street = reader["street"].ToString(),
                                    Suburb = reader["suburb"].ToString(),
                                    City = reader["city"].ToString(),
                                    State = reader["state"].ToString()

                                }
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                patient = new VO_Patient(); ;
            }

            return patient;
        }//End get VO_Patient id


        public static int CreatePatient(VO_Patient patient)
        {
            int patientGenerated = 0;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlCommand cmd = new SqlCommand("SP_Create_Patient", objConnection);
                    cmd.Parameters.AddWithValue("namePatient", patient.NamePatient);
                    cmd.Parameters.AddWithValue("middleName", patient.MiddleName);
                    cmd.Parameters.AddWithValue("lastName", patient.LastName);
                    cmd.Parameters.AddWithValue("birthDate", patient.BirthDate);
                    cmd.Parameters.AddWithValue("telephone", patient.Telephone);
                    cmd.Parameters.AddWithValue("idAddress", patient.Address.IdAddress);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    patientGenerated = Convert.ToInt32(cmd.Parameters["response"].Value);

                }
            }
            catch (Exception ex)
            {
                patientGenerated = 0;
                message = ex.ToString();
            }

            Console.WriteLine(message);

            return patientGenerated;
        }//End create VO_Patient

        public static bool UpdatePatient(VO_Patient patient)
        {
            bool response = false;
            string message = string.Empty;

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Update_Patient", objConnection);
                    cmd.Parameters.AddWithValue("idPatient", patient.IdPatient);
                    cmd.Parameters.AddWithValue("namePatient", patient.NamePatient);
                    cmd.Parameters.AddWithValue("middleName", patient.MiddleName);
                    cmd.Parameters.AddWithValue("lastName", patient.LastName);
                    cmd.Parameters.AddWithValue("birthDate", patient.BirthDate);
                    cmd.Parameters.AddWithValue("telephone", patient.Telephone);
                    cmd.Parameters.AddWithValue("idAddress", patient.Address.IdAddress);
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

        }//End edit VO_Patient

        public static bool DeletePatient(int idPatient)
        {
            bool response = false;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {

                    SqlCommand cmd = new SqlCommand("SP_Delete_Patient", objConnection);
                    cmd.Parameters.AddWithValue("idPatient", idPatient);
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

        }//End delete patient

    }//End patient class
}//End namespace
