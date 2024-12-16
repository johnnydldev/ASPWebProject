<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexAddress.aspx.cs" Inherits="AspWebProject.View.Address.IndexAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Content here -->
    <div class="container w-100">

         <div class="row">
             <h3>Listado de Direcciones</h3>
             <%--Botón para agregar un nuevo camión--%>
             <p>
                 <%--Se genere un evento "OnClick"--%>
                 <asp:Button ID="createAddress" runat="server" Text="Crear nueva dirección" CssClass="btn btn-primary btn-lg w-100" Width="85px" OnClick="CreateAddress" />
             </p>
         </div>

         <div class="row">
             <asp:GridView ID="GVAddress" runat="server"
                 CssClass="table table-bordered table-striped table-condensed bg-info"
                 AutoGenerateColumns="false"
                 DataKeyNames="IdAddress"
                 OnRowDeleting="OnDeleteAddress"
                 OnRowCommand="OnExcecuteCommand"
                 OnRowEditing="OnEditAddress"
                 OnRowUpdating="OnUpdateAddress"
                 OnRowCancelingEdit="OnCancelingEdit">
                 <%--arriba se generan los eventos "onrow"--%>
                 <Columns>
                     <asp:BoundField DataField="IdAddress" HeaderText="Id de dirección" ItemStyle-Width="50px" ReadOnly="true" />

                     <asp:BoundField DataField="street" HeaderText="Calle" ItemStyle-Width="85px" />

                     <asp:BoundField DataField="suburb" HeaderText="Colonia" ItemStyle-Width="85px" />
             
                     <asp:BoundField DataField="city" HeaderText="Ciudad" ItemStyle-Width="85px" />
             
                     <asp:BoundField DataField="state" HeaderText="Estado" ItemStyle-Width="85px" />

                     <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Ver información" Text="Ver Detalles" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="50px" />
             
                     <asp:CommandField ButtonType="Button" HeaderText="Editar" ShowEditButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-secondary btn-xs" ItemStyle-Width="50px" />
             
                     <asp:CommandField ButtonType="Button" HeaderText="Borrar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />
         
                 </Columns>
             </asp:GridView>

         </div>


   </div>
    <!-- End content here -->


</asp:Content>
