using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO.Tools;
using VO;

namespace AspWebProject.View.Diagnostic
{
    public partial class FormDiagnostic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    //Header of form
                    title.Text = "Registrar Diagnostico";
                    subTitle.Text = "Registro de nuevo Diagnostico";
                    chargeDropdownList();
                    string dateComplete = DateTime.Now.ToString();
                    string year = dateComplete.Substring(6, 4);
                    string month = dateComplete.Substring(3, 2);
                    string day = dateComplete.Substring(0, 2);
                    ddlyear.Items.FindByText(year).Selected = true;
                    ddlmonth.Items.FindByText(month).Selected = true;
                    ddlday.Items.FindByText(day).Selected = true;


                }
                else
                {
                    chargeDropdownList();

                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Diagnostic diagnostic = BLLDiagnostic.GetDiagnosticById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (diagnostic.IdDiagnostic > 0)
                    {
                        string dateComplete = diagnostic.RegisterDate.ToString();
                        string year = dateComplete.Substring(6, 4);
                        string month = dateComplete.Substring(3, 2);
                        string day = dateComplete.Substring(0, 2);
                        string doctor = diagnostic.Doctor.NameDoctor.ToString();
                        string patient = diagnostic.Patient.NamePatient.ToString();
                        string labResult = diagnostic.LabResult.ResultValue.ToString();
                        string treatment = diagnostic.Treatment.RecommendTreatment.ToString();
                        //Assign the new values to record according to the id Diagnostic selected
                        title.Text = "Actualizar Diagnostic";
                        subTitle.Text = $"Modificar los datos del Diagnostic #{_id}";
                        txtMedicalCondition.Text = diagnostic.MedicalCondition;
                        ddlyear.Items.FindByText(year).Selected = true;
                        ddlmonth.Items.FindByText(month).Selected = true;
                        ddlday.Items.FindByText(day).Selected = true;
                        ddlDoctor.Items.FindByText(doctor).Selected = true;
                        ddlPatient.Items.FindByText(patient).Selected = true;
                        ddlLabResult.Items.FindByText(labResult).Selected = true;
                        ddlTreatment.Items.FindByText(treatment).Selected = true;

                        Console.WriteLine("El objeto es: " + diagnostic);
                    }
                    else
                    {
                        //Return to index page of Diagnostic
                        Response.Redirect("IndexDiagnostic.aspx");
                    }

                }//End verify of record or new 

            }//End evaluate of postback

        }//End load event

        string date = string.Empty;


        protected void Selection_Change(object sender, EventArgs e)
        {
            //almacenos la fecha seleccionada en el calendario de salida de forma global
            //birthDate = clcBirthdate.SelectedDate;

            //clcBirthdate.SelectedDate = birthDate;
            //clcBirthdate.VisibleDate = birthDate;
        }


        protected void btnSaveClick(object sender, EventArgs e)
        {

            string title = "", response = "", type = "";
            int outputCreate = 0; bool outputUpdate = false;

            try
            {
                //Create the instance of new object Diagnostic
                VO_Diagnostic Diagnostic = new VO_Diagnostic();
                Diagnostic.MedicalCondition = txtMedicalCondition.Text;
                Diagnostic.Doctor.IdDoctor = Convert.ToInt32(ddlDoctor.SelectedValue.ToString());
                Diagnostic.Patient.IdPatient = Convert.ToInt32(ddlPatient.SelectedValue.ToString());
                Diagnostic.LabResult.IdLaboratoryResult = Convert.ToInt32(ddlLabResult.SelectedValue.ToString());
                Diagnostic.Treatment.IdTreatment = Convert.ToInt32(ddlTreatment.SelectedValue.ToString());
                Diagnostic.RegisterDate = GetDateSelected();

                //Verify if the info is to create or update
                if (Request.QueryString["Id"] == null)
                {
                    outputCreate = BLLDiagnostic.CreateDiagnostic(Diagnostic);

                    if (outputCreate == 0)
                    {
                        title = "Ops...";
                        response = "No se ha podido registrar el nuevo tratamiento.";
                        type = "warning";
                        SweetAlert.Sweet_Alert(title,response,type, this.Page, this.GetType(), "IndexDiagnostic.aspx");
                    }

                }
                else
                {
                    //Update
                    Diagnostic.IdDiagnostic = int.Parse(Request.QueryString["Id"]);
                    outputUpdate = BLLDiagnostic.UpdateDiagnostic(Diagnostic);
                }

                //Preparing the info to show the errors through the Seet Alert
                if (!outputUpdate)
                {
                    title = "Ops...";
                    response = "No se ha podido registrar o actualizar el tratamiento.";
                    type = "warning";
                    SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType(), "IndexDiagnostic.aspx");
                }
                else
                {
                    title = "Correcto!";
                    response = "Actualización del tratamiento o registro exitoso.";
                    type = "success";
                    SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType(), "IndexDiagnostic.aspx");

                }
            }
            catch (Exception ex)
            {
                title = "Error";
                response = ex.Message;
                type = "error";
                SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType(), "IndexDiagnostic.aspx");

            }
            


        }

        protected void btnBackClick(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("IndexDiagnostic.aspx");
        }

        protected void btnSearchDoctorClick(object sender, EventArgs e)
        {

        }

        protected void btnAddDoctorClick(object sender, EventArgs e)
        {

        }

        protected void btnSearchPatientClick(object sender, EventArgs e)
        {

        }

        protected void btnAddPatientClick(object sender, EventArgs e)
        {

        }

        protected void btnSearchTreatmentClick(object sender, EventArgs e)
        {

        }

        protected void btnAddTreatmentClick(object sender, EventArgs e)
        {

        }

        protected void btnSearchLabResultClick(object sender, EventArgs e)
        {

        }

        protected void btnAddLabResultClick(object sender, EventArgs e)
        {

        }

        protected void GetDate(object sender, EventArgs e)
        {

        }

   

        private void chargeDropdownList()
        {
            List<string> years = ChargeDateValues.ChargeYears();
            List<string> months = ChargeDateValues.ChargeMonths();
            List<string> days = ChargeDateValues.ChargeDays();

            List<VO_Doctor> doctors = BLLDoctor.GetAllDoctorsWithNameCompete();
            List<VO_Laboratory_Result> labResults = BLLLaboratoryResult.ListLabResults();
            List<VO_Patient> patients = BLLPatient.GetAllPatientsWithNameComplete();
            List<VO_Treatment>  treatments = BLLTreatment.GetAllTreatments();

            foreach (string year in years)
            {
                ddlyear.Items.Add(year);
            }

            foreach (string month in months)
            {
                ddlmonth.Items.Add(month);
            }

            foreach (string day in days)
            {
                ddlday.Items.Add(day);
            }

            foreach (VO_Doctor doctor in doctors)
            {
                ddlDoctor.Items.Add(new ListItem(doctor.NameDoctor, doctor.IdDoctor.ToString()));
            }

            foreach (VO_Laboratory_Result labResult in labResults)
            {
                ddlLabResult.Items.Add(new ListItem(labResult.ResultValue, labResult.IdLaboratoryResult.ToString()));
            }

            foreach (VO_Treatment treatment in treatments)
            {
                ddlTreatment.Items.Add(new ListItem(treatment.RecommendTreatment, treatment.IdTreatment.ToString()));
            }

            foreach (VO_Patient patient in patients)
            {
                ddlPatient.Items.Add(new ListItem(patient.NamePatient, patient.IdPatient.ToString()));
            }

        }//End charge dropdowns


        private string GetDateSelected()
        {
            string date = ddlyear.Text + "/" + ddlmonth.Text + "/" + ddlday.Text;
            return date;
        }//End get date selected


    }//End diagnostic class
}//End namespace