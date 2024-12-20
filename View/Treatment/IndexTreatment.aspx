<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexTreatment.aspx.cs" Inherits="AspWebProject.View.Treatment.IndexTreatment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <!-- Content here -->
 <div class="container w-100">

      <div class="row">
          <h3>Listado de Tratamientos</h3>
          <%--Botón para agregar un nuevo Treatmento--%>
          <p>
              <%--Se genere un evento "OnClick"--%>
              <asp:Button ID="createTreatment" runat="server" Text="Crear nuevo tratamiento" CssClass="btn btn-primary btn-lg w-100" Width="85px" OnClick="CreateTreatment" />
          </p>
      </div>

      <div class="row">

          <asp:GridView ID="GVTreatments" runat="server"
              CssClass="table table-bordered table-striped table-condensed bg-info"
              AutoGenerateColumns="false"
              DataKeyNames="IdTreatment"
              OnRowDeleting="OnDeleteTreatment"
              OnRowCommand="OnExcecuteCommand"
              OnRowEditing="OnEditTreatment"
              OnRowUpdating="OnUpdateTreatment"
              OnRowCancelingEdit="OnCancelingEdit">
              
              <%--arriba se generan los eventos "onrow"--%>
              
              <Columns>

                  <asp:BoundField DataField="IdTreatment" HeaderText="Id de Treatmento" ItemStyle-Width="50px" ReadOnly="true" />

                  <asp:BoundField DataField="Treatment.recommendTreatment" HeaderText="Nombre" ItemStyle-Width="85px" />
                  
                  <asp:BoundField DataField="Medicament.nameMedicament" HeaderText="Nombre" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="Medicament.dose" HeaderText="Dosis" ItemStyle-Width="85px" />
          
                  <asp:BoundField DataField="Medicament.useInstruction" HeaderText="Instruciones de uso" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="StartedDate" HeaderText="Fecha de inicio" ItemStyle-Width="85px" />
          
                  <asp:ButtonField CommandName="Select" HeaderText="Ver información" Text="Ver Detalles" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="50px" />
          
                  <asp:ButtonField CommandName="Edit" HeaderText="Editar" Text="Editar" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px" />
                  
                  <asp:CommandField ButtonType="Button" HeaderText="Borrar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />
      
              </Columns>

          </asp:GridView>

      </div>

</div>
<!-- End content here -->

</asp:Content>
