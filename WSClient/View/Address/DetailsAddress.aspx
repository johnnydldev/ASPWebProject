<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsAddress.aspx.cs" Inherits="WSClient.View.Address.DetailsAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card text-bg-info mb-3">
      <div class="card-header text-bg-secondary">
        Detalles de Dirección
      </div>
      <div class="card-body">
        <h5 class="card-title">Calle:
            <asp:Label ID="lblStreet" runat="server" Text="" CssClass="mt-3"></asp:Label>
        </h5>
        <p class="card-text">Colonia:
            <asp:Label ID="suburb" runat="server" Text="" CssClass="mt-3"></asp:Label>
        </p>
        <p class="card-text">Ciudad: 
            <asp:Label ID="city" runat="server" Text="" CssClass="mt-3"></asp:Label>
        </p>
        <p class="card-text">Estado: 
            <asp:Label ID="state" runat="server" Text="" CssClass="mt-3"></asp:Label>
        </p>
        <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar a inicio" OnClick="btnBackClick" />

      </div>
    </div>


</asp:Content>
