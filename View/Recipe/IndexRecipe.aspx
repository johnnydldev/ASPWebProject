<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexRecipe.aspx.cs" Inherits="AspWebProject.View.Recipe.IndexRecipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <!-- Content here -->
 <div class="container w-100">

      <div class="row">
          <h3>Listado de recetas pacientes</h3>
          <%--Botón para agregar un nuevo camión--%>
      </div>

      <div class="row">

          <asp:GridView ID="GVRecipes" runat="server"
              CssClass="table table-bordered table-striped table-condensed bg-info"
              AutoGenerateColumns="false"
              DataKeyNames="IdRecipe"
              OnRowCommand="OnExcecuteCommand">
              
              <%-- arriba se generan los eventos "onrow" --%>
              
              <Columns>

                  <asp:BoundField DataField="IdRecipe" HeaderText="Id de receta" ItemStyle-Width="50px" ReadOnly="true" />

                  <asp:BoundField DataField="Patient.namePatient" HeaderText="Paciente" ItemStyle-Width="85px" />

                  <asp:BoundField DataField="medicalCondition" HeaderText="Condición Medica" ItemStyle-Width="85px" />
          
                  <asp:BoundField DataField="treatment" HeaderText="Tratamiento" ItemStyle-Width="85px" />
          
                  <asp:BoundField DataField="test" HeaderText="Prueba" ItemStyle-Width="85px" />
                  
                  <asp:BoundField DataField="testResult" HeaderText="Resultado" ItemStyle-Width="85px" />
                  
                  <asp:BoundField DataField="medicament" HeaderText="Medicamento" ItemStyle-Width="85px" />
                  
                  <asp:BoundField DataField="doctor" HeaderText="Medico" ItemStyle-Width="85px" />
                  
                  <asp:BoundField DataField="registerDate" HeaderText="Fecha de realización" ItemStyle-Width="85px" />
                  
                  <asp:ButtonField CommandName="Select" HeaderText="Ver información" Text="Ver Detalles" ControlStyle-CssClass="btn btn-success btn-xs" ItemStyle-Width="50px" />
          
              </Columns>

          </asp:GridView>

      </div>

</div>
<!-- End content here -->

</asp:Content>
