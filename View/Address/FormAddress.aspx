<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormAddress.aspx.cs" Inherits="AspWebProject.View.Address.FormAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Content here -->
    <div class="container w-100 bg-dark text-white rounded">

        <div class="row">
            <asp:Label ID="title" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
            <asp:Label ID="subTitle" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        </div>

        <div class="row">
            <div class="col-md-12">

                <%--Formulario--%>
                <div class="form-group">
                    <%--Etiquetado--%>
                    <asp:Label ID="lblStreet" runat="server" Text="Calle" CssClass="mt-3"></asp:Label>
                    <%--Campo--%>
                    <asp:TextBox ID="txtStreet" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblSuburb" runat="server" Text="Colonia" CssClass="mt-3"></asp:Label>
                    <asp:TextBox ID="txtSuburb" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblCity" runat="server" Text="Ciudad" CssClass="mt-3"></asp:Label>
                    <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblState" runat="server" Text="Estado" CssClass="mt-3"></asp:Label>
                    <asp:TextBox ID="txtState" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Button ID="btnSave" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Guardar" OnClick="btnSaveClick" />
                    <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar" OnClick="btnBackClick" />

                </div>

                </div>
            </div>

    </div>
    <!-- End content here -->


</asp:Content>
