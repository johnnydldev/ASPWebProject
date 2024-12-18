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
    public class DALTreatment
    {
        public static string CreateTreatment(VO_Treatment treatment)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Create_Treatment",
                    "@recommendTreatment", treatment.RecommendTreatment,
                    "@startedDate", treatment.StartedDate,
                    "@idMedicament", treatment.IdMedicament
                    );

                if (response != 0)
                {
                    outputResult = "Tratamiento registrado con éxito";
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
        }//End create treatment method

        //Read
        public static List<VO_Treatment> ListTreatment(params object[] parameters)
        {
            //creo una lista de objetox VO
            List<VO_Treatment> list = new List<VO_Treatment>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet dstreatment = DataGetObject.executeDataSet("SP_List_Treatment", parameters);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in dstreatment.Tables[0].Rows)
                {
                    list.Add(new VO_Treatment(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido : " + ex.ToString());
                throw;
            }

        }//End list treatment method

        //Update
        public static string UpdateTreatment(VO_Treatment treatment)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Update_Treatment",
                    "@idTreatment", treatment.IdTreatment,
                    "@recommendTreatment", treatment.RecommendTreatment,
                    "@startedDate", treatment.StartedDate,
                    "@idMedicament", treatment.IdMedicament
                    );

                if (response != 0)
                {
                    outputResult = "Tratamiento actualizado con éxito";
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
        }//End update treatment method

        //Delete
        public static string DeleteTreatment(int id)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Delete_Treatment",
                    "@idTreatment", id
                    );

                if (response != 0)
                {
                    outputResult = "Tratamiento eliminada con éxito";
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
        }//End delete treatment method

        public static VO_Treatment GetTreatmentByMedicament(int idMed)
        {
            VO_Treatment treatment = new VO_Treatment();

            using (SqlConnection objConnection = new SqlConnection(Configuration.GetStringConnection))
            {
                SqlDataReader reader;
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_Verify_Medicament_Linked_With_Treatment", objConnection);
                    cmd.Parameters.AddWithValue("@idMedicament", idMed);
                    cmd.CommandType = CommandType.StoredProcedure;


                    objConnection.Open();
                    cmd.ExecuteNonQuery();

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            treatment = new VO_Treatment
                            {
                                IdTreatment = Convert.ToInt32(reader["idTreatment"].ToString()),
                                RecommendTreatment = reader["RecommendTreatment"].ToString(),
                                StartedDate = reader["StartedDate"].ToString(),
                                IdMedicament = Convert.ToInt32(reader["IdMedicament"].ToString())
                               
                            };

                            //End adding information LaboratoryResult

                        }
                    }//End information reading

                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                    treatment = null;
                }


            }//End using of stringConnection


            return treatment;


        }//End get diagnostic by doctor

    }//End treatment class
}//End namespace
