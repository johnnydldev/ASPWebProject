<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsPatient.aspx.cs" Inherits="AspWebProject.View.Patient.DetailsPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="card text-bg-info mb-3">
  <div class="card-header text-bg-secondary">
    Detalles de Patient
  </div>
  <div class="card-body">
    <h5 class="card-title">Nombre(s):
        <asp:Label ID="lblNamePatient" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </h5>
    <p class="card-text">Apellido Paterno:
        <asp:Label ID="lblMiddleName" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Apellido Materno: 
        <asp:Label ID="lblLastName" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Dirección: 
        <asp:Label ID="lblAddress" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Telefono: 
         <asp:Label ID="lblTelephone" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <p class="card-text">Fecha de nacimiento: 
         <asp:Label ID="lblBirthdate" runat="server" Text="" CssClass="mt-3"></asp:Label>
    </p>
    <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar a inicio" OnClick="btnBackClick" />

  </div>
</div>


</asp:Content>
