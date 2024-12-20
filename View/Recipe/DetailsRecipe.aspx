<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsRecipe.aspx.cs" Inherits="AspWebProject.View.Recipe.DetailsRecipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card text-bg-info mb-3">
  <div class="card-header text-bg-secondary">
    Detalles de Receta
  </div>
  <div class="card-body">
    <h5 class="card-title">Nombre del paciente:
        <asp:Label ID="lblNamePatient" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </h5>
    <p class="card-text">Condición medica:
        <asp:Label ID="lblMedicalCondition" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Tratamiento:
        <asp:Label ID="lblTreatment" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Prueba: 
        <asp:Label ID="lblTest" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Resultado: 
        <asp:Label ID="lblTestResult" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Medicamento: 
         <asp:Label ID="lblMedicament" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Medico: 
         <asp:Label ID="lblDoctor" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Fecha de realización: 
        <asp:Label ID="lblRegisterDate" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>

    <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar a inicio" OnClick="btnBackClick" />

  </div>
</div>


</asp:Content>
