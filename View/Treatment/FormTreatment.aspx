<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormTreatment.aspx.cs" Inherits="AspWebProject.View.Treatment.FormTreatment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<!-- Content here -->
<div class="container w-100 bg-dark text-white rounded">

    <div class="row">
        <asp:Label ID="title" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        <asp:Label ID="subTitle" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
    </div>

       <div class="container mb-3">

        <div class="container">
            <asp:Label ID="lblSearch" runat="server" CssClass="text-center modal-title" Text="Ingrese un medicamento:"></asp:Label>
            <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Button ID="btnSearch" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Buscar" OnClick="btnSearchClick"/>
            <asp:Button ID="btnAddMedicament" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Agregar" OnClick="btnAddMedicamentClick"/>
        </div>

       <asp:Label ID="lblMedicament" runat="server" CssClass="text-center modal-title" Text="Medicamento:"></asp:Label>
       <asp:DropDownList id="ddlMedicament" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server" CssClass="w-75">

        <asp:ListItem  Value="White">Seleciona una opción</asp:ListItem>

      </asp:DropDownList>
   </div>

    <!-- Content here -->
<div class="container w-100 rounded">

    <div class="row">
        <asp:Label ID="Label1" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
    </div>

   <div class="row">
    <div class="col-md-12">

        <%--Formulario--%>
        <div class="form-group">
            <%--Etiquetado--%>
            <asp:Label ID="lblRecommendTreatment" runat="server" Text="Nombre del tratamiento:" CssClass="mt-3"></asp:Label>
            <%--Campo--%>
            <asp:TextBox ID="txtRecommendTreatment" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="lblDoneDate" runat="server" Text="Fecha de Inicio:" CssClass="mt-12"></asp:Label>
            <div class="container mb-4">
                <asp:DropDownList ID="ddlyear"  OnSelectedIndexChanged="GetDate" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="ddlmonth"  OnSelectedIndexChanged="GetDate" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="ddlday"  OnSelectedIndexChanged="GetDate" runat="server"></asp:DropDownList>
            </div>

            <asp:Button ID="btnSave" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Guardar" OnClick="btnSaveClick" />
            <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar" OnClick="btnBackClick" />

        </div>

        </div>
    </div>

</div>
<!-- End content here -->



</asp:Content>
