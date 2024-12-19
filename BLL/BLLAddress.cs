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

        public static List<VO_Address> ListAddressComplete()
        {

            return DALAddress.ListAddressComplete();

        }//End delete method

    }//End address class
}//End namespace
