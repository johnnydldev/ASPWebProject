﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceAddress;
using WSClient.ServiceDoctor;

namespace WSClient.View.Doctor
{
    public partial class DetailsDoctor : System.Web.UI.Page
    {
        DoctorServiceSoapClient doctorWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            doctorWSClient = new DoctorServiceSoapClient();
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("IndexDoctor.aspx");
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Doctor doctor = doctorWSClient.searchById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (doctor.IdDoctor >= 1)
                    {
                        //Assign the new values to record according to the id address selected
                        lblNameDoctor.Text = doctor.NameDoctor;
                        lblMiddleName.Text = doctor.MiddleName;
                        lblLastName.Text = doctor.LastName;
                        lblTelephone.Text = doctor.Telephone;
                        lblAddress.Text = doctor.Address.Street;
                        lblBirthdate.Text = doctor.BirthDate;

                        Console.WriteLine("El objeto es: " + doctor);
                    }

                }

            }

        }//End load event


        protected void btnBackClick(object sender, EventArgs e)
        {
            Response.Redirect("IndexDoctor.aspx");
        }//End back event


    }//End doctor class
}//End namespace