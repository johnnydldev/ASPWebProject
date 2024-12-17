<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsMedicament.aspx.cs" Inherits="AspWebProject.View.Medicament.DetailsMedicament" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="card text-bg-info mb-3">
  <div class="card-header text-bg-secondary">
    Detalles de Medicamento
  </div>
  <div class="card-body">
    <h5 class="card-title">Medicamento:
        <asp:Label ID="lblNameMedicament" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </h5>
    <p class="card-text">Dosis:
        <asp:Label ID="dose" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Instrucciones de uso: 
        <asp:Label ID="useInstruction" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
  
    <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar a inicio" OnClick="btnBackClick" />

  </div>
</div>


</asp:Content>
