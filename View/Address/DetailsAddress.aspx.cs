using AspWebProject.Tools;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;

namespace AspWebProject.View.Address
{
    public partial class DetailsAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validate of this is Postback
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("IndexAddress.aspx");
                }
                else
                {
                    //To update
                    //Got the id arrived of URL
                    int _id = Convert.ToInt32(Request.QueryString["Id"]);

                    //Gettting the info according to the id specified
                    VO_Address address = BLLAddress.GetAddressById(_id);

                    Console.WriteLine("El id es: " + _id);

                    //Validate that exist the record in the table, if isn't that return to form
                    if (address.IdAddress != 0)
                    {
                        //Assign the new values to record according to the id address selected
                        lblStreet.Text = address.Street;
                        suburb.Text = address.Suburb;
                        city.Text = address.City;
                        state.Text = address.State;

                        Console.WriteLine("El objeto es: " + address);
                    }

                }

            }

        }//End load event

        protected void btnBackClick(object sender, EventArgs e)
        {
            Response.Redirect("IndexAddress.aspx");
        }//End back event


    }//End details address class
}//End namespace