using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DALPatient
    {
        public static string CreatePatient(VO_Patient patient)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Create_Patient",
                    "@namePatient", patient.NamePatient,
                    "@middleName", patient.MiddleName,
                    "@lastName", patient.LastName,
                    "@telephone", patient.Telephone,
                    "@idAddress", patient.IdAddress
                    );

                if (response != 0)
                {
                    outputResult = "Paciente registrado con éxito";
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
        }//End create patient method

        //Read
        public static List<VO_Patient> ListPatient(params object[] parameters)
        {
            //creo una lista de objetox VO
            List<VO_Patient> list = new List<VO_Patient>();
            try
            {
                //creo un DataSet el cuál recibirá lo que devuelva la ejecución del método "execute_DataSet" de la clase "metodos_datos"
                DataSet dspatient = DataGetObject.executeDataSet("SP_List_Patient", parameters);
                //recorro cada renglón existente de nuestro ds creando objetos del tipo VO y añadiendolos a la lista
                foreach (DataRow dr in dspatient.Tables[0].Rows)
                {
                    list.Add(new VO_Patient(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido : " + ex.ToString());
                throw;
            }

        }//End list patient method

        //Update
        public static string UpdatePatient(VO_Patient patient)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Update_P   atient",
                    "@idPatient", patient.IdPatient,
                    "@namePatient", patient.NamePatient,
                    "@middleName", patient.MiddleName,
                    "@lastName", patient.LastName,
                    "@telephone", patient.Telephone,
                    "@idAddress", patient.IdAddress
                    );

                if (response != 0)
                {
                    outputResult = "Paciente actualizado con éxito";
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
        }//End update patient method

        //Delete
        public static string SP_Delete_Patient(int id)
        {
            string outputResult = "";
            int response = 0;
            try
            {
                response = DataGetObject.executeNonQuery("SP_Delete_Patient",
                    "@idPatient", id
                    );

                if (response != 0)
                {
                    outputResult = "Paciente eliminada con éxito";
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
        }//End delete patient method



    }//End patient class
}//End namespace
