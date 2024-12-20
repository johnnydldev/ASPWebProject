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
    public class DALDiagnostic
    {
        public static List<VO_Diagnostic> GetAllDiagnostics()
        {
            List<VO_Diagnostic> diagnostics = new List<VO_Diagnostic>();

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_List_Diagnostics", objConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diagnostics.Add(new VO_Diagnostic()
                            {
                                IdDiagnostic = Convert.ToInt32(reader["idDiagnostic"].ToString()),
                                MedicalCondition = reader["medicalCondition"].ToString(),
                                Treatment = new VO_Treatment()
                                {
                                    IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                    RecommendTreatment = reader["recommendTreatment"].ToString()
                                },
                                Doctor = new VO_Doctor()
                                {
                                    IdDoctor = Convert.ToInt32(reader["idDoctor"].ToString()),
                                    NameDoctor = reader["nameDoctor"].ToString()
                                },
                                Patient = new VO_Patient()
                                {
                                    IdPatient = Convert.ToInt32(reader["idPatient"].ToString()),
                                    NamePatient = reader["namePatient"].ToString()
                                },
                                LabResult = new VO_Laboratory_Result()
                                {
                                    IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString()),
                                    Test = reader["test"].ToString(),
                                    ResultValue = reader["resultValue"].ToString(),
                                    DateDone = reader["dateDone"].ToString()
                                }


                            });//End VO_Diagnostics listing

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    diagnostics = new List<VO_Diagnostic>();
                }


            }//End using of stringConnection


            return diagnostics;
        }//End listing VO_Diagnostics

        public static VO_Diagnostic GetById(int idDiagnostic)
        {
            VO_Diagnostic diagnostic = new VO_Diagnostic();

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;
                    SqlCommand cmd;

                    cmd = new SqlCommand("SP_Search_Diagnostic_By_Id", objConnection);
                    cmd.Parameters.AddWithValue("idDiagnostic", idDiagnostic);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diagnostic = new VO_Diagnostic
                            {
                                IdDiagnostic = Convert.ToInt32(reader["idDiagnostic"].ToString()),
                                MedicalCondition = reader["medicalCondition"].ToString(),
                                Treatment = new VO_Treatment()
                                {
                                    IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                    RecommendTreatment = reader["recommendTreatment"].ToString()
                                },
                                Doctor = new VO_Doctor()
                                {
                                    IdDoctor = Convert.ToInt32(reader["idDoctor"].ToString()),
                                    NameDoctor = reader["nameDoctor"].ToString()
                                },
                                Patient = new VO_Patient()
                                {
                                    IdPatient = Convert.ToInt32(reader["idPatient"].ToString()),
                                    NamePatient = reader["namePatient"].ToString()
                                },
                                LabResult = new VO_Laboratory_Result()
                                {
                                    IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString()),
                                    Test = reader["test"].ToString(),
                                    ResultValue = reader["resultValue"].ToString(),
                                    DateDone = reader["dateDone"].ToString()
                                }

                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                diagnostic = new VO_Diagnostic(); ;
            }

            return diagnostic;
        }//End get VO_Diagnostic id


        public static int CreateDiagnostic(VO_Diagnostic diagnostic)
        {
            int diagnosticGenerated = 0;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlCommand cmd = new SqlCommand("SP_Create_Patient", objConnection);
                    cmd.Parameters.AddWithValue("medicalCondition", diagnostic.MedicalCondition);
                    cmd.Parameters.AddWithValue("registerDate", diagnostic.RegisterDate);
                    cmd.Parameters.AddWithValue("idTreatment", diagnostic.Treatment.IdTreatment);
                    cmd.Parameters.AddWithValue("idDoctor", diagnostic.Doctor.IdDoctor);
                    cmd.Parameters.AddWithValue("idPatient", diagnostic.Patient.IdPatient);
                    cmd.Parameters.AddWithValue("idLaboratoryResult", diagnostic.LabResult.IdLaboratoryResult);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    diagnosticGenerated = Convert.ToInt32(cmd.Parameters["response"].Value);

                }
            }
            catch (Exception ex)
            {
                diagnosticGenerated = 0;
                message = ex.ToString();
            }

            Console.WriteLine(message);

            return diagnosticGenerated;
        }//End create VO_Diagnostic

        public static bool UpdateDiagnostic(VO_Diagnostic diagnostic)
        {
            bool response = false;
            string message = string.Empty;

            using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Update_Patient", objConnection);
                    cmd.Parameters.AddWithValue("idDiagnostic", diagnostic.IdDiagnostic);
                    cmd.Parameters.AddWithValue("medicalCondition", diagnostic.MedicalCondition);
                    cmd.Parameters.AddWithValue("registerDate", diagnostic.RegisterDate);
                    cmd.Parameters.AddWithValue("idTreatment", diagnostic.Treatment.IdTreatment);
                    cmd.Parameters.AddWithValue("idDoctor", diagnostic.Doctor.IdDoctor);
                    cmd.Parameters.AddWithValue("idPatient", diagnostic.Patient.IdPatient);
                    cmd.Parameters.AddWithValue("idLaboratoryResult", diagnostic.LabResult.IdLaboratoryResult);
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

        }//End edit VO_Diagnostic

        public static bool DeleteDiagnostic(int idDiagnostic)
        {
            bool response = false;
            string message = string.Empty;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {

                    SqlCommand cmd = new SqlCommand("SP_Delete_Diagnostic", objConnection);
                    cmd.Parameters.AddWithValue("idDiagnostic", idDiagnostic);
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

        }//End delete diagnostic

        public static VO_Diagnostic GetByIdLab(int idLab)
        {
            VO_Diagnostic diagnostic = new VO_Diagnostic();

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;
                    SqlCommand cmd;

                    cmd = new SqlCommand("SP_Verify_LabResult_Linked_With_Diagnostic", objConnection);
                    cmd.Parameters.AddWithValue("idLabResult", idLab);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diagnostic = new VO_Diagnostic
                            {
                                IdDiagnostic = Convert.ToInt32(reader["idDiagnostic"].ToString()),
                                MedicalCondition = reader["medicalCondition"].ToString(),
                                Treatment = new VO_Treatment()
                                {
                                    IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                    RecommendTreatment = reader["recommendTreatment"].ToString()
                                },
                                Doctor = new VO_Doctor()
                                {
                                    IdDoctor = Convert.ToInt32(reader["idDoctor"].ToString()),
                                    NameDoctor = reader["nameDoctor"].ToString()
                                },
                                Patient = new VO_Patient()
                                {
                                    IdPatient = Convert.ToInt32(reader["idPatient"].ToString()),
                                    NamePatient = reader["namePatient"].ToString()
                                },
                                LabResult = new VO_Laboratory_Result()
                                {
                                    IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString()),
                                    Test = reader["test"].ToString(),
                                    ResultValue = reader["resultValue"].ToString(),
                                    DateDone = reader["dateDone"].ToString()
                                }

                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                diagnostic = new VO_Diagnostic();
            }

            return diagnostic;
        }//End get VO_Diagnostic id

        public static VO_Diagnostic GetByIdDoctor(int idDoctor)
        {
            VO_Diagnostic diagnostic = new VO_Diagnostic();

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;
                    SqlCommand cmd;

                    cmd = new SqlCommand("SP_Verify_Doctor_Linked_With_Diagnostic", objConnection);
                    cmd.Parameters.AddWithValue("idDoctor", idDoctor);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diagnostic = new VO_Diagnostic
                            {
                                IdDiagnostic = Convert.ToInt32(reader["idDiagnostic"].ToString()),
                                MedicalCondition = reader["medicalCondition"].ToString(),
                                Treatment = new VO_Treatment()
                                {
                                    IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                    RecommendTreatment = reader["recommendTreatment"].ToString()
                                },
                                Doctor = new VO_Doctor()
                                {
                                    IdDoctor = Convert.ToInt32(reader["idDoctor"].ToString()),
                                    NameDoctor = reader["nameDoctor"].ToString()
                                },
                                Patient = new VO_Patient()
                                {
                                    IdPatient = Convert.ToInt32(reader["idPatient"].ToString()),
                                    NamePatient = reader["namePatient"].ToString()
                                },
                                LabResult = new VO_Laboratory_Result()
                                {
                                    IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString()),
                                    Test = reader["test"].ToString(),
                                    ResultValue = reader["resultValue"].ToString(),
                                    DateDone = reader["dateDone"].ToString()
                                }

                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                diagnostic = new VO_Diagnostic();
            }

            return diagnostic;
        }//End get VO_Diagnostic id


        public static VO_Diagnostic GetByIdPatient(int idPatient)
        {
            VO_Diagnostic diagnostic = new VO_Diagnostic();

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;
                    SqlCommand cmd;

                    cmd = new SqlCommand("SP_Verify_Patient_Linked_With_Diagnostic", objConnection);
                    cmd.Parameters.AddWithValue("idPatient", idPatient);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    objConnection.Open();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diagnostic = new VO_Diagnostic
                            {
                                IdDiagnostic = Convert.ToInt32(reader["idDiagnostic"].ToString()),
                                MedicalCondition = reader["medicalCondition"].ToString(),
                                Treatment = new VO_Treatment()
                                {
                                    IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                    RecommendTreatment = reader["recommendTreatment"].ToString()
                                },
                                Doctor = new VO_Doctor()
                                {
                                    IdDoctor = Convert.ToInt32(reader["idDoctor"].ToString()),
                                    NameDoctor = reader["nameDoctor"].ToString()
                                },
                                Patient = new VO_Patient()
                                {
                                    IdPatient = Convert.ToInt32(reader["idPatient"].ToString()),
                                    NamePatient = reader["namePatient"].ToString()
                                },
                                LabResult = new VO_Laboratory_Result()
                                {
                                    IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString()),
                                    Test = reader["test"].ToString(),
                                    ResultValue = reader["resultValue"].ToString(),
                                    DateDone = reader["dateDone"].ToString()
                                }

                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                diagnostic = new VO_Diagnostic();
            }

            return diagnostic;
        }//End get VO_Diagnostic id


    }//End diagnostic class
}//End namespace
