using System;
using System.Collections.Generic;
using System.Data;
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



    }//End diagnostic class
}//End namespace
