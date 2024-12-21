<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsDiagnostic.aspx.cs" Inherits="WSClient.View.Diagnostic.DetailsDiagnostic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


 <div class="card text-bg-info mb-3">
   <div class="card-header text-bg-secondary">
     Detalles de Diagnostico
   </div>
   <div class="card-body">
     <h5 class="card-title">Condición medica:
         <asp:Label ID="lblMedicalCondition" runat="server" Text="" CssClass="mt-3"></asp:Label>
     </h5>
     <p class="card-text">Tratamiento recomendado:
         <asp:Label ID="lblRecommendTreatment" runat="server" Text="" CssClass="mt-3"></asp:Label>
     </p>
     <p class="card-text">Doctor que diagnostica: 
         <asp:Label ID="lblDoctorName" runat="server" Text="" CssClass="mt-3"></asp:Label>
     </p>
     <p class="card-text">Nombre del paciente: 
         <asp:Label ID="lblPatientName" runat="server" Text="" CssClass="mt-3"></asp:Label>
     </p>
     <p class="card-text">Prueba: 
          <asp:Label ID="lblTest" runat="server" Text="" CssClass="mt-3"></asp:Label>
     </p>
     <p class="card-text">Resultado de prueba: 
          <asp:Label ID="lblResultValue" runat="server" Text="" CssClass="mt-3"></asp:Label>
     </p>
     <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar a inicio" OnClick="btnBackClick" />

   </div>
 </div>



</asp:Content>
