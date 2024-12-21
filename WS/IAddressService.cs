using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using VO;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace AspWebProject.WS
{
    [ServiceContract]
    public interface IAddressService
    {

        //Create
        [OperationContract]
        string CreateAddress(VO_Address address);
        //Read
        [OperationContract]
        List<VO_Address> ListAddresss(params object[] parameters);

        [OperationContract]
        VO_Address GetAddressById(int id);

        //Update
        [OperationContract]
        string UpdateAddress(VO_Address address);

        //Delete
        [OperationContract]
        string DeleteAddress(int id);

        [OperationContract]
        List<VO_Address> ListAddressComplete();


    }//End address interface
}//End namespace
