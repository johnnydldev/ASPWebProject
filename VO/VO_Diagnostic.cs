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
        private VO_Treatment treatment ;
        private VO_Doctor doctor ;
        private VO_Patient patient;
        private VO_Laboratory_Result labResult;

        //Declaring of getters and setters
        public int IdDiagnostic { get => idDiagnostic; set => idDiagnostic = value; }
        public string MedicalCondition { get => medicalCondition; set => medicalCondition = value; }
        public string RegisterDate { get => registerDate; set => registerDate = value; }
        public VO_Treatment Treatment { get => treatment; set => treatment = value; }
        public VO_Doctor Doctor { get => doctor; set => doctor = value; }
        public VO_Patient Patient{ get => patient; set => patient = value; }
        public VO_Laboratory_Result LabResult { get => labResult; set => labResult = value; }

        public VO_Diagnostic()
        {
            idDiagnostic = 0;
            medicalCondition = string.Empty;
            registerDate = string.Empty;
            treatment  = new VO_Treatment();
            doctor  = new VO_Doctor();
            patient = new VO_Patient();
            labResult  = new VO_Laboratory_Result();
        }//End constructor method

        public VO_Diagnostic(DataRow row)
        {
            idDiagnostic = int.Parse(row["idDiagnostic"].ToString());
            medicalCondition = row["medicalCondition"].ToString();
            registerDate = row["registerDate"].ToString();
            treatment = new VO_Treatment() 
            { 
                IdTreatment = int.Parse(row["idTreatment"].ToString()),
                RecommendTreatment = row["recommendTreatment"].ToString(),
                Medicament = new VO_Medicament()
                {
                    IdMedicament = int.Parse(row["idMedicament"].ToString()),
                    NameMedicament = row["nameMedicament"].ToString(),
                    Dose = row["dose"].ToString(),
                    UseInstruction = row["useInstruction"].ToString()
                }
            };
            doctor = new VO_Doctor()
            {
                IdDoctor = int.Parse(row["idDoctor"].ToString()),
                NameDoctor = row["nameDoctor"].ToString(),
                MiddleName = row["middleNPatient"].ToString(),
                LastName = row["lastNPatient"].ToString(),
            };
            patient = new VO_Patient()
            {
                IdPatient = int.Parse(row["idPatient"].ToString()),
                NamePatient = row["namePatient"].ToString(),
                MiddleName = row["middleNDoctor"].ToString(),
                LastName = row["lastNDoctor"].ToString(),
            };
            labResult = new VO_Laboratory_Result()
            {
                IdLaboratoryResult = int.Parse(row["IdLaboratoryResult"].ToString()),
                Test = row["test"].ToString(), 
                ResultValue = row["resultValue"].ToString()
            };

        }//End constructor method


    }//End diagnostic
}//End namespace
