<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormDiagnostic.aspx.cs" Inherits="AspWebProject.View.Diagnostic.FormDiagnostic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<!-- Content here -->
<div class="container w-100 rounded">

    <div class="row">
        <asp:Label ID="title" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        <asp:Label ID="subTitle" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
    </div>

   <%-- Container search doctor --%>
    <div class="card text-bg-info mb-3">
      <div class="card-header text-bg-secondary">
            Buscador de doctor
      </div>
      <div class="card-body">

            <div class="container">
                <asp:Label ID="lblSearchDoctor" runat="server" CssClass="text-center modal-title" Text="Ingrese un medico:"></asp:Label>
                <asp:TextBox ID="txtSearchDoctor" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Button ID="btnSearchDoctor" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Buscar" OnClick="btnSearchDoctorClick"/>
                <asp:Button ID="btnAddDoctor" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Agregar" OnClick="btnAddDoctorClick"/>
            </div>

           <asp:Label ID="lblDoctor" runat="server" CssClass="text-center modal-title" Text="Doctor:"></asp:Label>
            <asp:DropDownList id="ddlDoctor" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server" CssClass="w-75">

             <asp:ListItem  Value="White">Seleciona una opción</asp:ListItem>

           </asp:DropDownList>

      </div>
    </div>
   <%-- End Container search doctor --%>

    <%-- Container search treatment --%>
 <div class="card text-bg-info mb-3">
   <div class="card-header text-bg-secondary">
         Buscador de tratamiento
   </div>
   <div class="card-body">

         <div class="container">
             <asp:Label ID="lblTreatment" runat="server" CssClass="text-center modal-title" Text="Ingrese un tratamiento:"></asp:Label>
             <asp:TextBox ID="txtTreatment" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:Button ID="btnCreateTreatment" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Buscar" OnClick="btnSearchTreatmentClick"/>
             <asp:Button ID="btnAddTreament" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Agregar" OnClick="btnAddTreatmentClick"/>
         </div>

        <asp:Label ID="Label4" runat="server" CssClass="text-center modal-title" Text="Tratamiento:"></asp:Label>
         <asp:DropDownList id="ddlTreatment" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server" CssClass="w-75">

          <asp:ListItem  Value="White">Seleciona una opción</asp:ListItem>

        </asp:DropDownList>

   </div>
 </div>
<%-- End Container search treatment --%>

<%-- Container search lab result --%>
 <div class="card text-bg-info mb-3">
   <div class="card-header text-bg-secondary">
         Buscador de resultado de laboratorio
   </div>
   <div class="card-body">

         <div class="container">
             <asp:Label ID="lblLabResult" runat="server" CssClass="text-center modal-title" Text="Ingrese un resultado:"></asp:Label>
             <asp:TextBox ID="txtLabResult" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:Button ID="btnLabResult" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Buscar" OnClick="btnSearchLabResultClick"/>
             <asp:Button ID="btnAddLabResult" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Agregar" OnClick="btnAddLabResultClick"/>
         </div>

        <asp:Label ID="Label6" runat="server" CssClass="text-center modal-title" Text="Resultado de laboratorio:"></asp:Label>
         <asp:DropDownList id="ddlLabResult" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server" CssClass="w-75">

          <asp:ListItem  Value="White">Seleciona una opción</asp:ListItem>

        </asp:DropDownList>

   </div>
 </div>
<%-- End Container search lab result  --%>

<%-- Container search patient --%>
 <div class="card text-bg-info mb-3">
   <div class="card-header text-bg-secondary">
         Buscador de paciente
   </div>
   <div class="card-body">

         <div class="container">
             <asp:Label ID="lblPatient" runat="server" CssClass="text-center modal-title" Text="Ingrese un paciente:"></asp:Label>
             <asp:TextBox ID="txtPatient" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:Button ID="btnPatient" CssClass="btn btn-primary mt-3 mb-5" runat="server" Text="Buscar" OnClick="btnSearchPatientClick"/>
             <asp:Button ID="btnAddPatient" CssClass="btn btn-success mt-3 mb-5" runat="server" Text="Agregar" OnClick="btnAddPatientClick"/>
         </div>

        <asp:Label ID="Label8" runat="server" CssClass="text-center modal-title" Text="Paciente:"></asp:Label>
         <asp:DropDownList id="ddlPatient" AutoPostBack="True" OnSelectedIndexChanged="Selection_Change" runat="server" CssClass="w-75">

          <asp:ListItem  Value="White">Seleciona una opción</asp:ListItem>

        </asp:DropDownList>

   </div>
 </div>
<%-- End Container search patient --%>


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
            <asp:Label ID="lblMedicalCondition" runat="server" Text="Condición medica:" CssClass="mt-3"></asp:Label>
            <%--Campo--%>
            <asp:TextBox ID="txtMedicalCondition" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="lblRegisterDate" runat="server" Text="Fecha de registro:" CssClass="mt-12"></asp:Label>
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
