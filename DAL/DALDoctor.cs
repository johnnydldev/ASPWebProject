using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DALDoctor
    {
        public static string CreateDoctor(VO_Doctor doctor)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Create_Doctor",
                    "@nameDoctor", doctor.NameDoctor,
                    "@middleName", doctor.MiddleName,
                    "@lastName", doctor.LastName,
                    "@birthDate", doctor.BirthDate,
                    "@telephone", doctor.Telephone,
                    "@idAddress", doctor.IdAddress
                    );

                if (response != 0)
                {
                    outputResult = "Doctor registrado con éxito";
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
        }//End create doctor method

        //Read
        public static List<VO_Doctor> ListDoctor(params object[] parameters)
        {
            //creo una lista de objetox VO
            List<VO_Doctor> list = new List<VO_Doctor>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet dsdoctor = DataGetObject.executeDataSet("SP_List_Doctor", parameters);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in dsdoctor.Tables[0].Rows)
                {
                    list.Add(new VO_Doctor(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido : " + ex.ToString());
                throw;
            }

        }//End list doctor method

        //Update
        public static string UpdateDoctor(VO_Doctor doctor)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Update_Doctor",
                    "@idDoctor", doctor.IdDoctor,
                    "@nameDoctor", doctor.NameDoctor,
                    "@middleName", doctor.MiddleName,
                    "@lastName", doctor.LastName,
                    "@birthDate", doctor.BirthDate,
                    "@telephone", doctor.Telephone,
                    "@idAddress", doctor.IdAddress
                    );

                if (response != 0)
                {
                    outputResult = "Doctor actualizada con éxito";
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
        }//End update doctor method

        //Delete
        public static string SP_Delete_Doctor(int id)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Delete_Doctor",
                    "@idDoctor", id
                    );

                if (response != 0)
                {
                    outputResult = "Doctor eliminada con éxito";
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
        }//End delete doctor method



    }//End Doctor class
}//End namespace
