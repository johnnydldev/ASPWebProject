<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexDiagnostic.aspx.cs" Inherits="AspWebProject.View.Diagnostic.IndexDiagnostic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <!-- Content here -->
 <div class="container w-100">

      <div class="row">
          <h3>Listado de Diagnosticos</h3>
          <%--Botón para agregar un nuevo Treatmento--%>
          <p>
              <%--Se genere un evento "OnClick"--%>
              <asp:Button ID="createDiagnostic" runat="server" Text="Crear nuevo diagnostico" CssClass="btn btn-primary btn-lg w-100" Width="85px" OnClick="CreateDiagnostic" />
          </p>
      </div>

      <div class="row">

          <asp:GridView ID="GVDiagnostics" runat="server"
              CssClass="table table-bordered table-striped table-condensed bg-info"
              AutoGenerateColumns="false"
              DataKeyNames="IdDiagnostic"
              OnRowDeleting="OnDeleteDiagnostic"
              OnRowCommand="OnExcecuteCommand"
              OnRowEditing="OnEditDiagnostic"
              OnRowUpdating="OnUpdateDiagnostic"
              OnRowCancelingEdit="OnCancelingEdit">
              
              <%--arriba se generan los eventos "onrow"--%>
              
              <Columns>

                  <asp:BoundField DataField="IdDiagnostic" HeaderText="Id de Diagnostico" ItemStyle-Width="50px" ReadOnly="true" />

                  <asp:BoundField DataField="medicalCondition" HeaderText="Condición medica" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="Treatment.recommendTreatment" HeaderText="Tratamiento recomendado" ItemStyle-Width="85px" />
                  
                  <asp:BoundField DataField="Doctor.nameDoctor" HeaderText="Doctor" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="LabResult.test" HeaderText="Prueba" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="LabResult.resultValue" HeaderText="Resultado" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="LabResult.dateDone" HeaderText="Fecha de realización" ItemStyle-Width="85px" />

    
                  <asp:ButtonField CommandName="Select" HeaderText="Ver información" Text="Ver Detalles" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="50px" />
          
                  <asp:ButtonField CommandName="Edit" HeaderText="Editar" Text="Editar" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px" />
                  
                  <asp:CommandField ButtonType="Button" HeaderText="Borrar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px" />
      
              </Columns>

          </asp:GridView>

      </div>

</div>
<!-- End content here -->

</asp:Content>
