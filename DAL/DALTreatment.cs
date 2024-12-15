using System;
using System.Collections.Generic;
using System.Data;
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
        public static List<VO_Treatment> Listtreatment(params object[] parameters)
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
        public static string Updatetreatment(VO_Treatment treatment)
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
        public static string SP_Delete_treatment(int id)
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



    }//End treatment class
}//End namespace
