﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceDiagnostic;

namespace WSClient.View.Diagnostic
{
    public partial class DetailsDiagnostic : System.Web.UI.Page
    {
        DiagnosticServiceSoapClient diagnosticWSClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            diagnosticWSClient = new DiagnosticServiceSoapClient();

            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("IndexDiagnostic.aspx");
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Diagnostic diagnostic = diagnosticWSClient.GetDiagnosticById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (diagnostic.IdDiagnostic >= 1)
                    {
                        //Assign the new values to record according to the id address selected
                        lblMedicalCondition.Text = diagnostic.MedicalCondition;
                        lblRecommendTreatment.Text = diagnostic.Treatment.RecommendTreatment;
                        lblDoctorName.Text = diagnostic.Doctor.NameDoctor;
                        lblPatientName.Text = diagnostic.Patient.NamePatient;
                        lblTest.Text = diagnostic.LabResult.Test;
                        lblResultValue.Text = diagnostic.LabResult.ResultValue;

                        Console.WriteLine("El objeto es: " + diagnostic);
                    }

                }

            }

        }//End load

        protected void btnBackClick(object sender, EventArgs e)
        {
            Response.Redirect("IndexDiagnostic.aspx");
        }//End back event


    }//End details class
}//End namespace