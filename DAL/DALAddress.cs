using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DALAddress
    {

        public static string CreateAddress(VO_Address address)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Create_Address",
                    "@street", address.Street,
                    "@suburb", address.Suburb,
                    "@city", address.City,
                    "@state", address.State
                    );

                if (response != 0)
                {
                    outputResult = "Dirección registrado con éxito";
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
        }//End create address method

        //Read
        public static List<VO_Address> ListAddress(params object[] parameters)
        {
            //creo una lista de objetox VO
            List<VO_Address> list = new List<VO_Address>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet dsAddress = DataGetObject.executeDataSet("SP_List_Address", parameters);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in dsAddress.Tables[0].Rows)
                {
                    list.Add(new VO_Address(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido : " + ex.ToString());
                throw;
            }

        }//End list address method

        //Update
        public static string UpdateAddress(VO_Address address)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Update_Address",
                    "@idAddress", address.IdAddress,
                    "@street", address.Street,
                    "@suburb", address.Suburb,
                    "@city", address.City,
                    "@state", address.State
                    );

                if (response != 0)
                {
                    outputResult = "Dirección actualizada con éxito";
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
        }//End update address method

        //Delete
        public static string SP_Delete_Address(int id)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Delete_Address",
                    "@idAddress", id
                    );

                if (response != 0)
                {
                    outputResult = "Dirección eliminada con éxito";
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
        }//End delete address method


    }//End address class
}//End namespace
