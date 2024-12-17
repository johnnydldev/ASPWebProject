<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormLabResult.aspx.cs" Inherits="AspWebProject.View.LabResult.FormLabResult" %>
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
                    <asp:Label ID="lblTest" runat="server" Text="Prueba" CssClass="mt-3"></asp:Label>
                    <%--Campo--%>
                    <asp:TextBox ID="txtTest" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lblResult" runat="server" Text="Resultado" CssClass="mt-3"></asp:Label>
                    <asp:TextBox ID="txtResult" runat="server" CssClass="form-control" TextMode="MultiLine" Style="width:300px; height:150px;"></asp:TextBox>

                    <asp:Label ID="lblDateDone" runat="server" Text="Fecha de realización" CssClass="mt-3"></asp:Label>
                    <asp:TextBox ID="txtDateDone" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Button ID="btnSave" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Guardar" OnClick="btnSaveClick" />
                    <asp:Button ID="btnBack" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Regresar" OnClick="btnBackClick" />

                </div>

                </div>
            </div>

    </div>
    <!-- End content here -->


</asp:Content>
