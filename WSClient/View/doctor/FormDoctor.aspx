<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormDoctor.aspx.cs" Inherits="WSClient.View.Doctor.FormDoctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mb-3">

        <div class="container">
            <asp:Label ID="lblSearch" runat="server" CssClass="text-center modal-title" Text="Ingrese una dirección:"></asp:Label>
            <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Button ID="btnSearch" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Buscar" OnClick="btnSearchClick"/>
            <asp:Button ID="btnAddAddress" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Agregar" OnClick="btnAddAddressClick"/>
        </div>

       <asp:Label ID="lblAddress" runat="server" CssClass="text-center modal-title" Text="Dirección:"></asp:Label>
       <asp:DropDownList id="ddlAddress" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server" CssClass="w-75">

        <asp:ListItem  Value="White">Seleciona una opción</asp:ListItem>

      </asp:DropDownList>
   </div>

    <!-- Content here -->
<div class="container w-100 rounded">

    <div class="row">
        <asp:Label ID="title" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        <asp:Label ID="subTitle" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
    </div>

   <div class="row">
    <div class="col-md-12">

        <%--Formulario--%>
        <div class="form-group">
            <%--Etiquetado--%>
            <asp:Label ID="lblNameDoctor" runat="server" Text="Nombre:" CssClass="mt-3"></asp:Label>
            <%--Campo--%>
            <asp:TextBox ID="txtNameDoctor" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="lblMiddlename" runat="server" Text="Apellido paterno:" CssClass="mt-3"></asp:Label>
            <asp:TextBox ID="txtMiddlename" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="lblLastname" runat="server" Text="Apellido materno:" CssClass="mt-3"></asp:Label>
            <asp:TextBox ID="txtLastname" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="lblTelephone" runat="server" Text="Telefono:" CssClass="mt-3"></asp:Label>
            <asp:TextBox ID="txtTelephone" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="lblBirthdate" runat="server" Text="Fecha de nacimiento:" CssClass="mt-12"></asp:Label>
            <div class="container mb-4">
                <asp:DropDownList ID="ddlyear"  OnSelectedIndexChanged="GetBirthdate" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="ddlmonth"  OnSelectedIndexChanged="GetBirthdate" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="ddlday"  OnSelectedIndexChanged="GetBirthdate" runat="server"></asp:DropDownList>
            </div>

            <asp:Button ID="btnSave" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Guardar" OnClick="btnSaveClick" />
            <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar" OnClick="btnBackClick" />

        </div>

        </div>
    </div>

</div>
<!-- End content here -->


</asp:Content>
