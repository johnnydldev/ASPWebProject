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
        public static string CreateDiagnostic(VO_Diagnostic diagnostic)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Create_Diagnostic",
                    "@medicalCondition", diagnostic.MedicalCondition,
                    "@registerDate", diagnostic.RegisterDate,
                    "@idTreatment", diagnostic.IdTreatment,
                    "@idDoctor", diagnostic.IdDoctor,
                    "@idPatient", diagnostic.IdPatient,
                    "@idLaboratoryResult", diagnostic.IdLaboratoryResult
                );

                if (response != 0)
                {
                    outputResult = "Diagnostico registrado con éxito";
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
        }//End create diagnostic method

        //Read
        public static List<VO_Diagnostic> ListDiagnostics(params object[] parameters)
        {
            //creo una lista de objetox VO
            List<VO_Diagnostic> list = new List<VO_Diagnostic>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet dsdiagnostic = DataGetObject.executeDataSet("SP_List_Diagnostic", parameters);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in dsdiagnostic.Tables[0].Rows)
                {
                    list.Add(new VO_Diagnostic(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido : " + ex.ToString());
                throw;
            }

        }//End list diagnostic method

        //Update
        public static string UpdateDiagnostic(VO_Diagnostic diagnostic)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Update_Diagnostic",
                    "@idDiagnostic", diagnostic.IdDiagnostic,
                    "@medicalCondition", diagnostic.MedicalCondition,
                    "@registerDate", diagnostic.RegisterDate,
                    "@idTreatment", diagnostic.IdTreatment,
                    "@idDoctor", diagnostic.IdDoctor,
                    "@idPatient", diagnostic.IdPatient,
                    "@idLaboratoryResult", diagnostic.IdLaboratoryResult
                );

                if (response != 0)
                {
                    outputResult = "Diagnostico actualizado con éxito";
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
        }//End update diagnostic method

        //Delete
        public static string DeleteDiagnostic(int id)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Delete_Diagnostic",
                    "@idDiagnostic", id
                    );

                if (response != 0)
                {
                    outputResult = "Diagnostico eliminado con éxito";
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
        }//End delete diagnostic method

        public static VO_Diagnostic GetDiagnosticByLabResult(int idLabResult)
        {
            VO_Diagnostic diagnostic = new VO_Diagnostic();

            using (SqlConnection objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_Verify_LabResult_Linked_With_Diagnostic", objConnection);
                    cmd.Parameters.AddWithValue("idLabResult", idLabResult);
                    cmd.CommandType = CommandType.StoredProcedure;


                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diagnostic = new VO_Diagnostic
                            {
                                IdDiagnostic = Convert.ToInt32(reader["IdDiagnostic"].ToString()),
                                MedicalCondition = reader["MedicalCondition"].ToString(),
                                RegisterDate = reader["RegisterDate"].ToString(),
                                IdTreatment = Convert.ToInt32(reader["IdTreatment"].ToString()),
                                IdDoctor = Convert.ToInt32(reader["IdDoctor"].ToString()),
                                IdPatient = Convert.ToInt32(reader["IdPatient"].ToString()),
                                IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString())

                            };

                            //End adding information LaboratoryResult

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    diagnostic = null;
                }


            }//End using of stringConnection


            return diagnostic;


        }//End get diagnostic by lab

        public static VO_Diagnostic GetDiagnosticByDoctor(int idDoctor)
        {
            VO_Diagnostic diagnostic = new VO_Diagnostic();

            using (SqlConnection objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_Verify_Doctor_Linked_With_Diagnostic", objConnection);
                    cmd.Parameters.AddWithValue("idDoctor", idDoctor);
                    cmd.CommandType = CommandType.StoredProcedure;


                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diagnostic = new VO_Diagnostic
                            {
                                IdDiagnostic = Convert.ToInt32(reader["IdDiagnostic"].ToString()),
                                MedicalCondition = reader["MedicalCondition"].ToString(),
                                RegisterDate = reader["RegisterDate"].ToString(),
                                IdTreatment = Convert.ToInt32(reader["IdTreatment"].ToString()),
                                IdDoctor = Convert.ToInt32(reader["IdDoctor"].ToString()),
                                IdPatient = Convert.ToInt32(reader["IdPatient"].ToString()),
                                IdLaboratoryResult = Convert.ToInt32(reader["idLaboratoryResult"].ToString())

                            };

                            //End adding information LaboratoryResult

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    diagnostic = null;
                }


            }//End using of stringConnection


            return diagnostic;


        }//End get diagnostic by doctor

    }//End diagnostic class
}//End namespace
