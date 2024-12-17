using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DALMedicament
    {
        public static string CreateMedicament(VO_Medicament medicament)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Create_Medicament",
                    "@nameMedicament", medicament.NameMedicament,
                    "@dose", medicament.Dose,
                    "@useInstruction", medicament.UseInstruction
                    );

                if (response != 0)
                {
                    outputResult = "Medicamento registrado con éxito";
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
        }//End create medicament method

        //Read
        public static List<VO_Medicament> ListMedicament()
        {
            //creo una lista de objetox VO
            List<VO_Medicament> list = new List<VO_Medicament>();

            using (SqlConnection objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_List_medicaments", objConnection);
                    cmd.CommandType = CommandType.StoredProcedure;


                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new VO_Medicament
                            {
                                IdMedicament = Convert.ToInt32(reader["idMedicament"].ToString()),
                                NameMedicament = reader["nameMedicament"].ToString(),
                                Dose = reader["dose"].ToString(),
                                UseInstruction = reader["useInstruction"].ToString()

                            });

                            //End adding information medicament

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    list = new List<VO_Medicament>();
                }


            }//End using of stringConnection

            return list;

        }//End list medicament method

        //Update
        public static string UpdateMedicament(VO_Medicament medicament)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Update_Medicament",
                    "@idMedicament", medicament.IdMedicament,
                    "@nameMedicament", medicament.NameMedicament,
                    "@dose", medicament.Dose,
                    "@useInstruction", medicament.UseInstruction
                    );

                if (response != 0)
                {
                    outputResult = "Medicamento actualizado con éxito";
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
        }//End update medicament method

        //Delete
        public static string DeleteMedicament(int id)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Delete_Medicament",
                    "@idMedicament", id
                );

                if (response != 0)
                {
                    outputResult = "Medicamento eliminado con éxito";
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
        }//End delete medicament method

        public static VO_Medicament GetMedicamentById(int id)
        {
            VO_Medicament medicament = new VO_Medicament();

            using (SqlConnection objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_Get_Medicament_By_Id", objConnection);
                    cmd.Parameters.AddWithValue("idMedicament", id);
                    cmd.CommandType = CommandType.StoredProcedure;


                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            medicament = new VO_Medicament
                            {
                                IdMedicament = Convert.ToInt32(reader["idMedicament"].ToString()),
                                NameMedicament = reader["nameMedicament"].ToString(),
                                Dose = reader["dose"].ToString(),
                                UseInstruction = reader["useInstruction"].ToString()

                            };

                            //End adding information medicament

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    medicament = new VO_Medicament();
                }


            }//End using of stringConnection


            return medicament;

        }//End list medicament method


    }//End medicament class
}//End namespace
