using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataGetObject
    {

        public static DataSet executeDataSet(string sp, params object[] parameters)
        {
            //Declaring and instancing of Dataset collection to stored the info from database
            DataSet ds = new DataSet();

            //Get the string connection to use in opening of connection 
            string connection = Configuration.GetStringConnection;

            //Create a object to connect with the database
            SqlConnection connectionSQL = new SqlConnection(connection);
            try
            {
                //We verify if exists a open connection
                if (connectionSQL.State == ConnectionState.Open)
                {
                    //Close the open connection
                    connectionSQL.Close();
                }
                else
                {
                    //Create a command SQl to execute the stored procedure
                    SqlCommand cmd = new SqlCommand(sp, connectionSQL);

                    //Especify how to works the command in database (this case stored procedure)
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    //
                    cmd.CommandText = sp;

                    //Verify that the parameters long has been the size correct
                    if (parameters != null && parameters.Length % 2 != 0)
                    {
                        throw new Exception("Los parámetros deben estar en pares (clave:valor)");
                    }
                    else
                    {
                        
                        for (int i = 0; i < parameters.Length; i = i + 2)
                        {
                            //Iterate on all parameters given by the user
                            cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1].ToString());
                        }

                        //Open the sql connection
                        connectionSQL.Open();

                        //Create a object of SQL adapter
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        //Filling the adapter
                        adapter.Fill(ds);

                        //Close the connection
                        connectionSQL.Close();
                    }
                }

                //Return the ds value
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error encontrado, descripción: "+ex);
                return null;
            }
            finally
            {
                //Verify if the connection is open
                if (connectionSQL.State == ConnectionState.Open)
                {
                    //Close the connection
                    connectionSQL.Close();
                }
            }//End finally

        }//End execute data set method

        public static int executeScalar(string sp, params object[] parameters)
        {
            //Declaring and instancing of integer id
            int id = 0;

            //Get the string connection to use in opening of connection 
            string connection = Configuration.GetStringConnection;

            //Create a object to connect with the database
            SqlConnection connectionSQL = new SqlConnection(connection);
            try
            {
                //We verify if exists a open connection
                if (connectionSQL.State == ConnectionState.Open)
                {
                    //Close the open connection
                    connectionSQL.Close();
                }
                else
                {
                    //Create a command SQl to execute the stored procedure
                    SqlCommand cmd = new SqlCommand(sp, connectionSQL);

                    //Especify how to works the command in database (this case stored procedure)
                    cmd.CommandType = CommandType.StoredProcedure;

                    //
                    cmd.CommandText = sp;

                    //Verify that the parameters long has been the size correct
                    if (parameters != null && parameters.Length % 2 != 0)
                    {
                        throw new Exception("Los parámetros deben estar en pares (clave:valor)");
                    }
                    else
                    {

                        for (int i = 0; i < parameters.Length; i = i + 2)
                        {
                            //Iterate on all parameters given by the user
                            cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1].ToString());
                        }

                        //Open the sql connection
                        connectionSQL.Open();

                        //Execute the query through the database
                        cmd.ExecuteNonQuery();
                        //End assign 1 in id
                        id = 1;

                        //Close the connection
                        connectionSQL.Close();
                    }
                }

                //Return the ds value
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error encontrado, descripción: " + ex);
                return 0;
            }
            finally
            {
                //Verify if the connection is open
                if (connectionSQL.State == ConnectionState.Open)
                {
                    //Close the connection
                    connectionSQL.Close();
                }
            }//End finally

        }//End execute executeScalar method


        public static int executeNonQuery(string sp, params object[] parameters)
        {
            //Declaring and instancing of integer id
            int id = 0;

            //Get the string connection to use in opening of connection 
            string connection = Configuration.GetStringConnection;

            //Create a object to connect with the database
            SqlConnection connectionSQL = new SqlConnection(connection);
            try
            {
                //We verify if exists a open connection
                if (connectionSQL.State == ConnectionState.Open)
                {
                    //Close the open connection
                    connectionSQL.Close();
                }
                else
                {
                    //Create a command SQl to execute the stored procedure
                    SqlCommand cmd = new SqlCommand(sp, connectionSQL);

                    //Especify how to works the command in database (this case stored procedure)
                    cmd.CommandType = CommandType.StoredProcedure;

                    //
                    cmd.CommandText = sp;

                    //Verify that the parameters long has been the size correct
                    if (parameters != null && parameters.Length % 2 != 0)
                    {
                        throw new Exception("Los parámetros deben estar en pares (clave:valor)");
                    }
                    else
                    {

                        for (int i = 0; i < parameters.Length; i = i + 2)
                        {
                            //Iterate on all parameters given by the user
                            cmd.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1].ToString());
                        }

                        //Open the sql connection
                        connectionSQL.Open();

                        //Execute the query through the database
                        cmd.ExecuteNonQuery();
                        //End assign 1 in id
                        id = 1;

                        //Close the connection
                        connectionSQL.Close();
                    }
                }

                //Return the ds value
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error encontrado, descripción: " + ex);
                return 0;
            }
            finally
            {
                //Verify if the connection is open
                if (connectionSQL.State == ConnectionState.Open)
                {
                    //Close the connection
                    connectionSQL.Close();
                }
            }//End finally

        }//End execute executeNonQuery method


    }//End data get object class
}//End namespace
