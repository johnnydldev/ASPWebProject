<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormMedicament.aspx.cs" Inherits="AspWebProject.View.Medicament.FormMedicament" %>
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
                <asp:Label ID="lblNameMedicament" runat="server" Text="Nombre:" CssClass="mt-3"></asp:Label>
                <%--Campo--%>
                <asp:TextBox ID="txtNameMedicament" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblDose" runat="server" Text="Dosis:" CssClass="mt-3"></asp:Label>
                <asp:TextBox ID="txtDose" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblUseInstruction" runat="server" Text="Instrucciones de uso:" CssClass="mt-3"></asp:Label>
                <asp:TextBox ID="txtUseInstruction" runat="server" CssClass="form-control"></asp:TextBox>

               
                <asp:Button ID="btnSave" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Guardar" OnClick="btnSaveClick" />

            </div>

            </div>
        </div>

</div>
<!-- End content here -->


</asp:Content>
