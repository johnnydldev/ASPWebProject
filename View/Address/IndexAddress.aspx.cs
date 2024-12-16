using BLL;
using System;
using AspWebProject.Tools;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebProject.View.Address
{
    public partial class IndexAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGrid();
            }
        }//End load page event

        public void loadGrid()
        {
            //Load the data grid view with the information record
            GVAddress.DataSource = BLLAddress.ListAddresss();

            //Rendering the information
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
            string response = BLLAddress.DeleteAddress(idAddress);

            //Configuring the sweet alert created
            string title, msg, type;
            if (response.ToUpper().Contains("ERROR"))
            {
                title = "Error";
                msg = response;
                type = "error";
            }
            else
            {
                title = "Correcto!";
                msg = response;
                type = "success";
            }

            //sweet alert
            SweetAlert.Sweet_Alert(title, msg, type, this.Page, this.GetType());
            
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
                string id = GVAddress.DataKeys[varIndex].Values["IdAddress"].ToString();
                
                //Redirecting to the form address with values of address selected
                Response.Redirect($"FormAddress.aspx?Id={id}");
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