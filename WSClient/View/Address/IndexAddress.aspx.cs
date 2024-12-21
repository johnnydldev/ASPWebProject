using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSClient.ServiceAddress;
using WSClient.Tools;

namespace WSClient.View.Address
{
    public partial class IndexAddress : System.Web.UI.Page
    {
        AddressServiceSoapClient AddressWSClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            AddressWSClient = new AddressServiceSoapClient();
            if (!IsPostBack)
            {
                loadGrid();
            }
        }//End load page event

        public void loadGrid()
        {
            //cargar la información desde la BLL al GV
            GVAddress.DataSource = AddressWSClient.ListAddresss(new ArrayOfAnyType { });
            //mostramos los resultados renderizando la información
            GVAddress.DataBind();
        }

        protected void CreateAddress(object sender, EventArgs e)
        {
            Response.Redirect("FormAddress.aspx");

        }//End load page event

        protected void OnDeleteAddress(object sender, GridViewDeleteEventArgs e)
        {
            //Got the id address of row specified
            int idAddress = int.Parse(GVAddress.DataKeys[e.RowIndex].Values["IdAddress"].ToString());

            //Calling the delete address method to get a response
            string response = AddressWSClient.DeleteAddress(idAddress);

            //Configuring the sweet alert created
            string title, msg, type;
            if (response.ToUpper().Contains("ERROR"))
            {
                title = "Error";
                msg = response;
                type = "error";
                SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

            }
            else
            {
                title = "Correcto!";
                msg = response;
                type = "success";
                SweetAlert.Sweet_Alert(title, response, type, this.Page, this.GetType());

            }

            //reload
            loadGrid();

        }//End load page event

        protected void OnExcecuteCommand(object sender, GridViewCommandEventArgs e)
        {
            //Verify that the element clicked had the select event
            if (e.CommandName == "Select")
            {
                //Got the index of the data grid view of row selected
                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of address accordint to the row selected early
                string id = GVAddress.Rows[varIndex].Cells[0].Text;

                //Redirecting to the form address with values of address selected
                Response.Redirect($"DetailsAddress.aspx?Id={id}");
            }
            else if (e.CommandName == "Edit")
            {


                int varIndex = int.Parse(e.CommandArgument.ToString());

                //Got the id of address accordint to the row selected early
                string idAddress = GVAddress.Rows[varIndex].Cells[0].Text;

                //string idAddress = row.Cells[0].Text;

                //Redirecting to the form address with values of address selected
                Response.Redirect($"FormAddress.aspx?Id={idAddress}");
            }

        }//End load page event


        protected void OnEditAddress(object sender, GridViewEditEventArgs e)
        {

        }

        protected void OnUpdateAddress(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void OnCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }


    }//End class
}//End namespace