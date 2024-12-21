using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using BLL;
using DAL;
using System.Web.Services;
using VO;


namespace AspWebProject.WS
{
    [ServiceContract]
    public interface IMedicamentService
    {
        //Create
        [OperationContract]
        string CreateMedicament(VO_Medicament medicament);
        //Read
        [OperationContract]
        List<VO_Medicament> ListMedicaments();
        //Update
        [OperationContract]
        string UpdateMedicament(VO_Medicament medicament);

        //Delete
        [OperationContract]
        string DeleteMedicament(int idMedicament);
        [OperationContract]
        VO_Medicament GetMedicamentById(int id);

    }//End medicament interface
}//End namespace
