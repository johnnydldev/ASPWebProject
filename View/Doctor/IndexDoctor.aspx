<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexDoctor.aspx.cs" Inherits="AspWebProject.View.Doctor.IndexDoctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <!-- Content here -->
 <div class="container w-100">

      <div class="row">
          <h3>Listado de Doctores</h3>
          <%--Botón para agregar un nuevo camión--%>
          <p>
              <%--Se genere un evento "OnClick"--%>
              <asp:Button ID="createDoctor" runat="server" Text="Registrar nuevo doctor" CssClass="btn btn-primary btn-lg w-100" Width="85px" OnClick="CreateDoctor" />
          </p>
      </div>

      <div class="row">

          <asp:GridView ID="GVDoctors" runat="server"
              CssClass="table table-bordered table-striped table-condensed bg-info"
              AutoGenerateColumns="false"
              DataKeyNames="IdDoctor"
              OnRowDeleting="OnDeleteDoctor"
              OnRowCommand="OnExcecuteCommand"
              OnRowEditing="OnEditDoctor"
              OnRowUpdating="OnUpdateDoctor"
              OnRowCancelingEdit="OnCancelingEdit">
              
              <%--arriba se generan los eventos "onrow"--%>
              
              <Columns>

                  <asp:BoundField DataField="IdDoctor" HeaderText="Id de doctor" ItemStyle-Width="50px" ReadOnly="true" />

                  <asp:BoundField DataField="nameDoctor" HeaderText="Nombre(s)" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="middleName" HeaderText="Apellido materno" ItemStyle-Width="85px" />
          
                  <asp:BoundField DataField="lastName" HeaderText="Apellido paterno" ItemStyle-Width="85px" />
          
                  <asp:BoundField DataField="birthDate" HeaderText="Fecha de nacimiento" ItemStyle-Width="85px" />
                  
                  <asp:BoundField DataField="telephone" HeaderText="Telefono" ItemStyle-Width="85px" />

                  <asp:ButtonField CommandName="Select" HeaderText="Ver información" Text="Ver Detalles" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="50px" />
          
                  <asp:ButtonField CommandName="Edit" HeaderText="Editar" Text="Editar" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px" />
                  
                  <asp:CommandField ButtonType="Button" HeaderText="Borrar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />
      
              </Columns>

          </asp:GridView>

      </div>

</div>
<!-- End content here -->

</asp:Content>
