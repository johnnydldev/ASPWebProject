<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsTreatment.aspx.cs" Inherits="WSClient.View.Treatment.DetailsTreatment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="card text-bg-info mb-3">
  <div class="card-header text-bg-secondary">
    Detalles de tratamiento
  </div>
  <div class="card-body">
    <h5 class="card-title">Tratamiento recomendado:
        <asp:Label ID="lblTreatment" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </h5>
    <p class="card-text">Nombre del medicamento:
        <asp:Label ID="lblMedicament" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Dosis:
        <asp:Label ID="lblDose" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Instruciones de uso: 
        <asp:Label ID="lblUseInstruction" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Fecha de inicio: 
        <asp:Label ID="lblStartedDate" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    
    <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar a inicio" OnClick="btnBackClick" />

  </div>
</div>

</asp:Content>
