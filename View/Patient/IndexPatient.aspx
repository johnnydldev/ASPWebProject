<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexPatient.aspx.cs" Inherits="AspWebProject.View.Patient.IndexPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <!-- Content here -->
 <div class="container w-100">

      <div class="row">
          <h3>Listado de Pacientes</h3>
          <%--Botón para agregar un nuevo camión--%>
          <p>
              <%--Se genere un evento "OnClick"--%>
              <asp:Button ID="createPatient" runat="server" Text="Registrar nuevo paciente" CssClass="btn btn-primary btn-lg w-100" Width="85px" OnClick="CreatePatient" />
          </p>
      </div>

      <div class="row">

          <asp:GridView ID="GVPatients" runat="server"
              CssClass="table table-bordered table-striped table-condensed bg-info"
              AutoGenerateColumns="false"
              DataKeyNames="IdPatient"
              OnRowDeleting="OnDeletePatient"
              OnRowCommand="OnExcecuteCommand"
              OnRowEditing="OnEditPatient"
              OnRowUpdating="OnUpdatePatient"
              OnRowCancelingEdit="OnCancelingEdit">
              
              <%--arriba se generan los eventos "onrow"--%>
              
              <Columns>

                  <asp:BoundField DataField="IdPatient" HeaderText="Id de Paciente" ItemStyle-Width="50px" ReadOnly="true" />

                  <asp:BoundField DataField="namePatient" HeaderText="Nombre(s)" ItemStyle-Width="85px" />

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
