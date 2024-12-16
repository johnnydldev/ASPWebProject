using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLLAddress
    {

        //Create
        public static string CreateAddress(VO_Address address)
        {
            return DALAddress.CreateAddress(address);
        }
        //Read
        public static List<VO_Address> ListAddresss(params object[] parameters)
        {
            return DALAddress.ListAddress(parameters);
        }

        /* Method to list the results by patient
        public static List<VO_Address> ListAddressByPatient(int idPatient)
        {
            List<VO_Address> listPatient = DAL_Camiones.Get_Camiones();

            return lista_vacia;
        }*/


        public static VO_Address GetAddressById(int id)
        {
            return DALAddress.GetAddressById(id);
        }

        //Update
        public static string UpdateAddress(VO_Address address)
        {
            return DALAddress.UpdateAddress(address);
        }

        //Delete
        public static string DeleteAddress(int id)
        {

            return DALAddress.DeleteAddress(id);

        }//End delete method




    }//End address class
}//End namespace
