<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexMedicament.aspx.cs" Inherits="AspWebProject.View.Medicament.IndexMedicament" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <!-- Content here -->
 <div class="container w-100">

      <div class="row">
          <h3>Listado de Medicamentos</h3>
          <%--Botón para agregar un nuevo camión--%>
          <p>
              <%--Se genere un evento "OnClick"--%>
              <asp:Button ID="createMedicament" runat="server" Text="Crear nuevo medicamento" CssClass="btn btn-primary btn-lg w-100" Width="85px" OnClick="CreateMedicament" />
          </p>
      </div>

      <div class="row">

          <asp:GridView ID="GVMedicaments" runat="server"
              CssClass="table table-bordered table-striped table-condensed bg-info"
              AutoGenerateColumns="false"
              DataKeyNames="IdMedicament"
              OnRowDeleting="OnDeleteMedicament"
              OnRowCommand="OnExcecuteCommand"
              OnRowEditing="OnEditMedicament"
              OnRowUpdating="OnUpdateMedicament"
              OnRowCancelingEdit="OnCancelingEdit">
              
              <%--arriba se generan los eventos "onrow"--%>
              
              <Columns>

                  <asp:BoundField DataField="IdMedicament" HeaderText="Id de medicamento" ItemStyle-Width="50px" ReadOnly="true" />

                  <asp:BoundField DataField="nameMedicament" HeaderText="Nombre" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="dose" HeaderText="Dosis" ItemStyle-Width="85px" />
          
                  <asp:BoundField DataField="useInstruction" HeaderText="Instruciones de uso" ItemStyle-Width="85px" />
          

                  <asp:ButtonField CommandName="Select" HeaderText="Ver información" Text="Ver Detalles" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="50px" />
          
                  <asp:ButtonField CommandName="Edit" HeaderText="Editar" Text="Editar" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px" />
                  
                  <asp:CommandField ButtonType="Button" HeaderText="Borrar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />
      
              </Columns>

          </asp:GridView>

      </div>

</div>
<!-- End content here -->


</asp:Content>
