using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VO;

namespace AspWebProject.WS
{

    public class AddressService : IAddressService
    {

        //Create
        [WebMethod]
        public string CreateAddress(VO_Address address)
        {
            return DALAddress.CreateAddress(address);
        }

        //Read
        [WebMethod]
        public List<VO_Address> ListAddresss(params object[] parameters)
        {
            return DALAddress.ListAddress(parameters);
        }

        [WebMethod]
        public VO_Address GetAddressById(int id)
        {
            return DALAddress.GetAddressById(id);
        }

        //Update
        [WebMethod]
        public string UpdateAddress(VO_Address address)
        {
            return DALAddress.UpdateAddress(address);
        }

        //Delete
        [WebMethod]
        public string DeleteAddress(int id)
        {
            return DALAddress.DeleteAddress(id);
        }//End delete method

        [WebMethod]
        public List<VO_Address> ListAddressComplete()
        {

            return DALAddress.ListAddressComplete();

        }//End delete method


    }//End address service class
}//End namespace
