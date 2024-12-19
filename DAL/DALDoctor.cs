using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DALDoctor
    {
        public static List<VO_Doctor> GetAllDoctors()
        {
            List<VO_Doctor> doctors = new List<VO_Doctor>();

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_List_Doctors", objConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctors.Add(new VO_Doctor()
                            {
                               IdDoctor = Convert.ToInt32(reader["idDoctor"].ToString()),
                               NameDoctor = reader["nameDoctor"].ToString(),
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

                            });//End VO_Doctors listing

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    doctors = new List<VO_Doctor>();
                }


            }//End using of stringConnection


            return doctors;
        }//End listing VO_Doctors

        public static VO_Doctor GetById(int idDoctor)
        {
            VO_Doctor doctor = new VO_Doctor();

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;
                    SqlCommand cmd;

                    cmd = new SqlCommand("SP_Search_Doctor_By_Id", objConnection);
                    cmd.Parameters.AddWithValue("idDoctor", idDoctor);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctor = new VO_Doctor
                            {
                                IdDoctor = Convert.ToInt32(reader["idDoctor"].ToString()),
                                NameDoctor = reader["nameDoctor"].ToString(),
                                MiddleName = reader["middleName"].ToString(),
                                LastName = reader["lastName"].ToString(),
                                BirthDate = reader["birthDate"].ToString(),
                                Telephone = reader["telephone"].ToString(),
                                Address = new VO_Address()
                                {
                                    IdAddress = Convert.ToInt32(reader["idAddress"].ToString()),
                                    Street = reader["street"].ToString()
                                }
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                doctor = new VO_Doctor(); ;
            }

            return doctor;
        }//End get VO_Doctor id

       
        public static int CreateDoctor(VO_Doctor doctor)
        {
            int doctorGenerated = 0;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlCommand cmd = new SqlCommand("SP_Create_Doctor", objConnection);
                    cmd.Parameters.AddWithValue("nameDoctor", doctor.NameDoctor);
                    cmd.Parameters.AddWithValue("middleName", doctor.MiddleName);
                    cmd.Parameters.AddWithValue("lastName", doctor.LastName);
                    cmd.Parameters.AddWithValue("birthDate", doctor.BirthDate);
                    cmd.Parameters.AddWithValue("telephone", doctor.Telephone);
                    cmd.Parameters.AddWithValue("idAddress", doctor.Address.IdAddress);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    doctorGenerated = Convert.ToInt32(cmd.Parameters["response"].Value);

                }
            }
            catch (Exception ex)
            {
                doctorGenerated = 0;
                message = ex.ToString();
            }

            Console.WriteLine(message);

            return doctorGenerated;
        }//End create VO_Doctor

        public static bool UpdateDoctor(VO_Doctor doctor)
        {
            bool response = false;
            string message = string.Empty;

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Update_Doctor", objConnection);
                    cmd.Parameters.AddWithValue("idDoctor", doctor.IdDoctor);
                    cmd.Parameters.AddWithValue("nameDoctor", doctor.NameDoctor);
                    cmd.Parameters.AddWithValue("middleName", doctor.MiddleName);
                    cmd.Parameters.AddWithValue("lastName", doctor.LastName);
                    cmd.Parameters.AddWithValue("birthDate", doctor.BirthDate);
                    cmd.Parameters.AddWithValue("telephone", doctor.Telephone);
                    cmd.Parameters.AddWithValue("idAddress", doctor.Address.IdAddress);
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

        }//End edit VO_Doctor

        public static bool DeleteDoctor(int idDoctor)
        {
            bool response = false;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {

                    SqlCommand cmd = new SqlCommand("SP_Delete_Doctor", objConnection);
                    cmd.Parameters.AddWithValue("idDoctor", idDoctor);
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

        }//End delete doctor

       

    }//End Doctor class
}//End namespace
