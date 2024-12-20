﻿using WSClient.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceDoctor;
using WSClient.ServiceAddress;

namespace WSClient.View.Doctor
{
    public partial class FormDoctor : System.Web.UI.Page
    {
        public DateTime birthDate;

        DoctorServiceSoapClient doctorWSClient;
        AddressServiceSoapClient addressWSClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            doctorWSClient = new DoctorServiceSoapClient();
            addressWSClient = new AddressServiceSoapClient();

            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    //Header of form
                    title.Text = "Registrar Doctor";
                    subTitle.Text = "Registro de nuevo doctor";
                    chargeDropdownList();
                }
                else
                {
                    chargeDropdownList();

                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    ServiceDoctor.VO_Doctor doctor = doctorWSClient.searchById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (doctor.IdDoctor > 0)
                    {
                        string dateComplete = doctor.BirthDate.ToString();
                        string year = dateComplete.Substring(6,4);
                        string month = dateComplete.Substring(3,2);
                        string day = dateComplete.Substring(0,2);
                        string address = doctor.Address.Street.ToString();
                        //Assign the new values to record according to the id doctor selected
                        title.Text = "Actualizar doctor";
                        subTitle.Text = $"Modificar los datos del doctor #{_id}";
                        txtNameDoctor.Text = doctor.NameDoctor;
                        txtMiddlename.Text = doctor.MiddleName;
                        txtLastname.Text = doctor.LastName;
                        txtTelephone.Text = doctor.Telephone;
                        ddlyear.Items.FindByText(year).Selected = true;
                        ddlmonth.Items.FindByText(month).Selected = true;
                        ddlday.Items.FindByText(day).Selected = true;
                        ddlAddress.Items.FindByText(address).Selected = true;

                        Console.WriteLine("El objeto es: " + doctor);
                    }
                    else
                    {
                        //Return to index page of doctor
                        Response.Redirect("IndexDoctor.aspx");
                    }

                }//End verify of record or new 

            }//End evaluate of postback

        }//End load event

        string date = string.Empty;
        protected void GetBirthdate(object sender, EventArgs e)
        {
            
        }

        protected void Selection_Change(object sender, EventArgs e)
        {
            
        }
        

        protected void btnSaveClick(object sender, EventArgs e)
        {

            string title = "", response = "", type = ""; 
            int outputCreate = 0; bool outputUpdate = false;

            try
            {
                //Create the instance of new object doctor
                ServiceDoctor.VO_Doctor doctor = new VO_Doctor();
                doctor.NameDoctor = txtNameDoctor.Text;
                doctor.MiddleName = txtMiddlename.Text;
                doctor.LastName = txtLastname.Text;
                doctor.Telephone = txtTelephone.Text;
                doctor.BirthDate = GetDateSelected();
                doctor.Address.IdAddress = Convert.ToInt32(ddlAddress.SelectedValue.ToString());

                //Verify if the info is to create or update
                if (Request.QueryString["Id"] == null)
                {
                    outputCreate = doctorWSClient.CreateDoctor(doctor);

                    if (outputCreate == 0)
                    {
                        title = "Ops...";
                        response = "No se ha podido registrar el nuevo doctor.";
                        type = "warning";
                        SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

                    }

                    HttpContext.Current.Response.Redirect("IndexDoctor.aspx");

                }
                else
                {
                    //Update
                    doctor.IdDoctor = int.Parse(Request.QueryString["Id"]);
                    outputUpdate = doctorWSClient.UpdateDoctor(doctor);
                    HttpContext.Current.Response.Redirect("Indexdoctor.aspx");
                }

                //Preparing the info to show the errors through the Seet Alert
                if (!outputUpdate)
                {
                    title = "Ops...";
                    response = "No se ha podido registrar o actualizar el doctor.";
                    type = "warning";
                    SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

                }
                else
                {
                    title = "Correcto!";
                    response = "Actualización del doctor o registro exitoso.";
                    type = "success";
                    SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

                }
            }
            catch (Exception ex)
            {
                title = "Error";
                response = ex.Message;
                type = "error";
            }
            //sweet alert
            SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType(), "/view/doctor/Indexdoctor.aspx");




        }

        protected void btnBackClick(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("IndexDoctor.aspx");
        }

        protected void btnSearchClick(object sender, EventArgs e)
        {
           
        }

        protected void btnAddAddressClick(object sender, EventArgs e)
        {
            
        }

        private void chargeDropdownList()
        {
            List<string> years = ChargeDateValues.ChargeYears();
            List<string> months = ChargeDateValues.ChargeMonths();
            List<string> days = ChargeDateValues.ChargeDays();

            List<ServiceAddress.VO_Address> addresses = addressWSClient.ListAddressComplete().ToList();

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

            foreach (ServiceAddress.VO_Address doctor in addresses)
            {
                ddlAddress.Items.Add(new ListItem(doctor.Street, doctor.IdAddress.ToString()));
            }

        }//End charge dropdowns


        private string GetDateSelected()
        {
            string birthdate = ddlyear.Text+"/"+ddlmonth.Text+"/"+ddlday.Text;
            return birthdate;
        }//End get date selected

    }//End doctor class
}//End namespace