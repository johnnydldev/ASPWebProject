<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsLabResult.aspx.cs" Inherits="AspWebProject.View.LabResult.DetailsLabResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card text-bg-info mb-3">
  <div class="card-header text-bg-secondary">
    Detalles de Resultado
  </div>
  <div class="card-body">
    <h5 class="card-title">Prueba:
        <asp:Label ID="lblTest" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </h5>
    <p class="card-text">Resultado:
        <asp:Label ID="result" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Fecha de realización: 
        <asp:Label ID="dateDone" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
  
    <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar a inicio" OnClick="btnBackClick" />

  </div>
</div>


</asp:Content>
