using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace AspWebProject.View.Address
{
    public partial class FormAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    //Header of form
                    title.Text = "Agregar Dirección";
                    subTitle.Text = "Registro de una nueva dirección";
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);
                    
                    //Gettting the info according to the id specified
                    VO_Address address = BLLAddress.GetAddressById(_id);

                    Console.WriteLine("El id es: "+_id);
                    
                    //Validate that exist the record in the table, if isn't that return to form
                    if (address.IdAddress != 0)
                    {
                        //Assign the new values to record according to the id address selected
                        title.Text = "Actualizar dirección";
                        subTitle.Text = $"Modificar los datos de la dirección #{_id}";
                        txtStreet.Text = address.Street;
                        txtSuburb.Text = address.Suburb;
                        txtCity.Text = address.City;
                        txtState.Text = address.State;

                        Console.WriteLine("El objeto es: "+ address);
                    }
                    else
                    {
                        //Return to index page of address
                        Response.Redirect("IndexAddress.aspx");
                    }
                }

            }
        }//End load event

        protected void btnSaveClick(object sender, EventArgs e)
        {
            string title = "", response = "", type = "", outputResult = "";
            try
            {
                //Create the instance of new object address
                VO_Address address = new VO_Address();
                address.Street = txtStreet.Text;
                address.Suburb = txtSuburb.Text;
                address.City = txtCity.Text;
                address.State = txtState.Text;

                //Verify if the info is to create or update
                if (Request.QueryString["Id"] == null)
                {
                    outputResult = BLLAddress.CreateAddress(address);

                    if (!outputResult.ToUpper().Contains("ERROR"))
                    {
                        title = "Ops...";
                        response = outputResult;
                        type = "warning";
                        
                    }

                    HttpContext.Current.Response.Redirect("IndexAddress.aspx");

                }
                else
                {
                    //Update
                    address.IdAddress = int.Parse(Request.QueryString["Id"]);
                    outputResult = BLLAddress.UpdateAddress(address);
                    HttpContext.Current.Response.Redirect("IndexAddress.aspx");
                }

                //Preparing the info to show the errors through the Seet Alert
                if (outputResult.ToUpper().Contains("ERROR"))
                {
                    title = "Ops...";
                    response = outputResult;
                    type = "warning";
                }
                else
                {
                    title = "Correcto!";
                    response = outputResult;
                    type = "success";
                }
            }
            catch (Exception ex)
            {
                title = "Error";
                response = ex.Message;
                type = "error";
            }
            //sweet alert
            SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType(), "/view/address/IndexAddress.aspx");

        }//End save event



    }//End form address class
}//End namespace