<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexLabResult.aspx.cs" Inherits="AspWebProject.View.LabResult.IndexLabResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <!-- Content here -->
 <div class="container w-100">

      <div class="row">
          <h3>Listado de Resultados de Laboratorio</h3>
          <%--Botón para agregar un nuevo resultado--%>
          <p>
              <%--Se genere un evento "OnClick"--%>
              <asp:Button ID="createLabResult" runat="server" Text="Crear nuevo resultado" CssClass="btn btn-primary btn-lg w-100" Width="85px" OnClick="CreateLabResult" />
          </p>
      </div>

      <div class="row">

          <asp:GridView ID="GVLabResults" runat="server"
              CssClass="table table-bordered table-striped table-condensed bg-info"
              AutoGenerateColumns="false"
              DataKeyNames="IdLaboratoryResult"
              OnRowDeleting="OnDeleteLabResult"
              OnRowCommand="OnExcecuteCommand"
              OnRowEditing="OnEditLabResult"
              OnRowUpdating="OnUpdateLabResult"
              OnRowCancelingEdit="OnCancelingEdit">
              
              <%--arriba se generan los eventos "onrow"--%>
              
              <Columns>

                  <asp:BoundField DataField="IdLaboratoryResult" HeaderText="Id de resultado" ItemStyle-Width="50px" ReadOnly="true" />

                  <asp:BoundField DataField="test" HeaderText="Prueba" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="resultValue" HeaderText="Resultados" ItemStyle-Width="85px" />
          
                  <asp:BoundField DataField="dateDone" HeaderText="Fecha de realización:" ItemStyle-Width="85px" />
          

                  <asp:ButtonField CommandName="Select" HeaderText="Ver información" Text="Ver Detalles" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="50px" />
          
                  <asp:ButtonField CommandName="Edit" HeaderText="Editar" Text="Editar" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px" />
                  
                  <asp:CommandField ButtonType="Button" HeaderText="Borrar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />
      
              </Columns>

          </asp:GridView>

      </div>

</div>
<!-- End content here -->



</asp:Content>
