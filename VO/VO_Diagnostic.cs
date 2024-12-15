using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class VO_Diagnostic
    {
        //Declaring of variables
        private int idDiagnostic;
        private string medicalCondition;
        private string registerDate ;
        private int idTreatment ;
        private int idDoctor ;
        private int idPatient ;
        private int idLaboratoryResult;

        //Declaring of getters and setters
        public int IdDiagnostic { get => idDiagnostic; set => idDiagnostic = value; }
        public string MedicalCondition { get => medicalCondition; set => medicalCondition = value; }
        public string RegisterDate { get => registerDate; set => registerDate = value; }
        public int IdTreatment { get => idTreatment; set => idTreatment = value; }
        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public int IdPatient { get => idPatient; set => idPatient = value; }
        public int IdLaboratoryResult { get => idLaboratoryResult; set => idLaboratoryResult = value; }

        public VO_Diagnostic()
        {
            idDiagnostic = 0;
            medicalCondition = string.Empty;
            registerDate = string.Empty;
            idTreatment = 0;
            idDoctor = 0;
            idPatient = 0;
            idLaboratoryResult = 0;
        }//End constructor method

        public VO_Diagnostic(DataRow row)
        {
            idDiagnostic = int.Parse(row["idDiagnostic"].ToString());
            medicalCondition = row["medicalCondition"].ToString();
            registerDate = row["registerDate"].ToString();
            idTreatment = int.Parse(row["idTreatment"].ToString());
            idDoctor = int.Parse(row["idDoctor"].ToString());
            idPatient = int.Parse(row["idPatient"].ToString());
            idLaboratoryResult = int.Parse(row["idLaboratoryResult"].ToString());
        }//End constructor method


    }//End diagnostic
}//End namespace
