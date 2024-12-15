using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public static List<VO_Medicament> ListMedicament(params object[] parameters)
        {
            //creo una lista de objetox VO
            List<VO_Medicament> list = new List<VO_Medicament>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet dsmedicament = DataGetObject.executeDataSet("SP_List_Medicament", parameters);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in dsmedicament.Tables[0].Rows)
                {
                    list.Add(new VO_Medicament(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido : " + ex.ToString());
                throw;
            }

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



    }//End medicament class
}//End namespace
