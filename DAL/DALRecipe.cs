using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class DALRecipe
    {

        public static List<VO_Recipe> GetAllRecipes()
        {
            List<VO_Recipe> allVO_Recipes = new List<VO_Recipe>();

            try
            {
                SqlDataReader reader;

                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlCommand cmd = new SqlCommand("SP_Get_All_Recipes", objConnection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    objConnection.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allVO_Recipes.Add(new VO_Recipe
                            {
                                IdRecipe = Convert.ToInt32(reader["idRecipe"]),
                                MedicalCondition = reader["medicalCondition"].ToString(),
                                Treatment = reader["treatment"].ToString(),
                                Test = reader["test"].ToString(),
                                TestResult = reader["testResult"].ToString(),
                                Medicament = reader["medicament"].ToString(),
                                Doctor = reader["doctor"].ToString(),
                                RegisterDate = reader["registerDate"].ToString(),
                                Patience = new VO_Patient()
                                {
                                    IdPatient = Convert.ToInt32(reader["idPatience"].ToString()),
                                    NamePatient = reader["namePatient"].ToString(),
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                allVO_Recipes = new List<VO_Recipe>();
            }

            return allVO_Recipes;
        }//End listing all VO_Recipees

        public static VO_Recipe GetById(int idRecipe)
        {
            VO_Recipe recipe = new VO_Recipe();
            string message;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlDataReader reader;
                    SqlCommand cmd;

                    cmd = new SqlCommand("SP_Get_Recipe_By_Id", objConnection);
                    cmd.Parameters.AddWithValue("idRecipe", idRecipe);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                     objConnection.OpenAsync();

                    using (reader = cmd.ExecuteReader())
                    {
                        while ( reader.Read())
                        {
                            recipe = new VO_Recipe
                            {
                                IdRecipe = Convert.ToInt32(reader["idRecipe"].ToString()),
                                NamePatient = reader["namePatient"].ToString(),
                                MedicalCondition = reader["medicalCondition"].ToString(),
                                Treatment = reader["treatment"].ToString(),
                                Test = reader["test"].ToString(),
                                TestResult = reader["testResult"].ToString(),
                                Medicament = reader["medicament"].ToString(),
                                Doctor = reader["doctor"].ToString(),
                                RegisterDate = reader["registerDate"].ToString(),
                                Patience = new VO_Patient()
                                {
                                    IdPatient = Convert.ToInt32(reader["idPatient"].ToString()),
                                    NamePatient = reader["namePatient"].ToString()
                                }

                            };

                        }

                    }
                }

                message = "Recogida con exito";

            }
            catch (Exception ex)
            {
                message = ex.Message.ToString();
                recipe = new VO_Recipe();
            }

            Console.WriteLine(message);

            return recipe;
        }//End get VO_Recipe id


        public static int CreateRecipe(VO_Recipe recipe)
        {
            int generatedResponse = 0;

            try
            {
                using (var objConnection = new SqlConnection(Configuration.GetStringConnection))
                {
                    SqlCommand cmd = new SqlCommand("SP_Create_Recipe", objConnection);
                    cmd.Parameters.AddWithValue("@namePatient", recipe.Patience.NamePatient);
                    cmd.Parameters.AddWithValue("@medicalCondition", recipe.MedicalCondition);
                    cmd.Parameters.AddWithValue("@treatment", recipe.Treatment);
                    cmd.Parameters.AddWithValue("@test", recipe.Test);
                    cmd.Parameters.AddWithValue("@testResult", recipe.TestResult);
                    cmd.Parameters.AddWithValue("@medicament", recipe.Medicament);
                    cmd.Parameters.AddWithValue("@doctor", recipe.Doctor);
                    cmd.Parameters.AddWithValue("@registerDate", recipe.RegisterDate);
                    cmd.Parameters.AddWithValue("@idPatient", recipe.Patience.IdPatient);
                    cmd.Parameters.Add("response", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                     objConnection.Open();
                     cmd.ExecuteNonQuery();

                    generatedResponse = Convert.ToInt32(cmd.Parameters["response"].Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                generatedResponse = 0;
            }

            Console.WriteLine(generatedResponse);

            return generatedResponse;
        }//End create VO_Recipe


    }//End recipe class
}//End namespace
