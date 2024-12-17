﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class VO_Recipe
    {
        //Declaring of variables according to sql database
        private int idRecipe ;
        private string namePatient;
        private string medicalCondition;
        private string treatment ;
        private string test ;
        private string testResult;
        private string medicament;
        private string doctor;
        private string registerDate;
        private int idPatience;

        //Declaring of getters and setters
        public int IdRecipe { get => idRecipe; set => idRecipe = value; }
        public string NamePatient { get => namePatient; set => namePatient = value; }
        public string MedicalCondition { get => medicalCondition; set => medicalCondition = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public string Test { get => test; set => test = value; }
        public string TestResult { get => testResult; set => testResult = value; }
        public string Medicament { get => medicament; set => medicament = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string RegisterDate { get => registerDate; set => registerDate = value; }
        public int IdPatience { get => idPatience; set => idPatience = value; }



        public VO_Recipe()
        {
            idRecipe = 0;
            namePatient = string.Empty;
            medicalCondition = string.Empty;
            treatment = string.Empty;
            test = string.Empty;
            testResult = string.Empty;
            medicament = string.Empty;
            doctor = string.Empty;
            registerDate = string.Empty;
            idPatience = 0;

        }//End constructor method

        public VO_Recipe(DataRow row)
        {
            idRecipe = int.Parse(row["idRecipe"].ToString());
            namePatient = row["namePatient"].ToString();
            medicalCondition = row["medicalCondition"].ToString();
            treatment = row["treatment"].ToString();
            test = row["test"].ToString();
            testResult = row["testResult"].ToString();
            medicament = row["medicament"].ToString();
            doctor = row["doctor"].ToString();
            registerDate = row["registerDate"].ToString();
            idPatience = int.Parse(row["idPatience"].ToString());
        }//End override constructor method


    }//End Recipe class
}//End namespace