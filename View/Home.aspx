<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AspWebProject.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" CssClass="bg-black">

    <!-- Content here -->    
    <div class="container">

        <!-- link card to Address -->
        <div class="card mt-3">
          <div class="card-header">
            Direcciones
          </div>
          <div class="card-body">
            <h5 class="card-title"></h5>
            <p class="card-text">Ventana para ver el listado de las direcciones y navegar para crear uno nuevo.</p>
            <a href="#" class="btn btn-primary w-50">
                <asp:Button ID="toAddress" runat="server" Text="Ir a direciones" CssClass="btn btn-primary w-100" Width="85px" OnClick="ShowAddress" />
            </a>
          </div>
        </div>
        <!-- link card to Address -->

        <!-- link card to diagnostic -->
        <div class="card mt-3">
          <div class="card-header">
            Diagnosticos
          </div>
          <div class="card-body">
            <h5 class="card-title"></h5>
            <p class="card-text">Ventana para ver el listado de los diagnosticos y navegar para crear uno nuevo.</p>
            <a href="#" class="btn btn-primary w-50">
                <asp:Button ID="toDiagnostic" runat="server" Text="Ir a diagnosticos" CssClass="btn btn-primary w-100" Width="85px" OnClick="ShowDiagnostic" />
            </a>
          </div>
        </div>
        <!-- link card to diagnostic -->

        <!-- link card to doctor -->
        <div class="card mt-3">
          <div class="card-header">
            Doctores
          </div>
          <div class="card-body">
            <h5 class="card-title"></h5>
            <p class="card-text">Ventana para ver el listado de los doctores y navegar para crear uno nuevo.</p>
            <a href="#" class="btn btn-primary w-50">
                <asp:Button ID="toDoctor" runat="server" Text="Ir a doctores" CssClass="btn btn-primary w-100" Width="85px" OnClick="ShowDoctor" />
            </a>
          </div>
        </div>
        <!-- link card to doctor -->

        <!-- link card to lab result -->
        <div class="card mt-3">
          <div class="card-header">
            Resultados de laboratorio
          </div>
          <div class="card-body">
            <h5 class="card-title"></h5>
            <p class="card-text">Ventana para ver el listado de los resultados de laboratorio y navegar para crear uno nuevo.</p>
            <a href="#" class="btn btn-primary w-50">
                <asp:Button ID="toLabResult" runat="server" Text="Ir a resultados de laboratorio" CssClass="btn btn-primary w-100" Width="85px" OnClick="ShowLabResult" />
            </a>
          </div>
        </div>
        <!-- link card to lab result -->

        <!-- link card to medicament -->
        <div class="card mt-3">
          <div class="card-header">
            Medicamentos
          </div>
          <div class="card-body">
            <h5 class="card-title"></h5>
            <p class="card-text">Ventana para ver el listado de los medicamentos y navegar para crear uno nuevo.</p>
            <a href="#" class="btn btn-primary w-50">
                <asp:Button ID="toMedicament" runat="server" Text="Ir a medicamentos" CssClass="btn btn-primary w-100" Width="85px" OnClick="ShowMedicament" />
            </a>
          </div>
        </div>
        <!-- link card to medicament -->


        <!-- link card to patient -->
        <div class="card mt-3">
          <div class="card-header">
            Pacientes
          </div>
          <div class="card-body">
            <h5 class="card-title"></h5>
            <p class="card-text">Ventana para ver el listado de los pacientes y navegar para crear uno nuevo.</p>
            <a href="#" class="btn btn-primary w-50">
                <asp:Button ID="toPatient" runat="server" Text="Ir a pacientes" CssClass="btn btn-primary w-100" Width="85px" OnClick="ShowPatient" />
            </a>
          </div>
        </div>
        <!-- link card to patient -->

        <!-- link card to recipe -->
        <div class="card mt-3">
          <div class="card-header">
            Recetas
          </div>
          <div class="card-body">
            <h5 class="card-title"></h5>
            <p class="card-text">Ventana para ver el listado de las recetas y navegar para crear uno nuevo.</p>
            <a href="#" class="btn btn-primary w-50">
                <asp:Button ID="toRecipe" runat="server" Text="Ir a recetas" CssClass="btn btn-primary w-100" Width="85px" OnClick="ShowRecipe" />
            </a>
          </div>
        </div>
        <!-- link card to recipe -->

        <!-- link card to treatment -->
        <div class="card mt-3">
          <div class="card-header">
            Tratamientos
          </div>
          <div class="card-body">
            <h5 class="card-title"></h5>
            <p class="card-text">Ventana para ver el listado de los tratamientos y navegar para crear uno nuevo.</p>
            <a href="#" class="btn btn-primary w-50">
                <asp:Button ID="toTreatment" runat="server" Text="Ir a tratamientos" CssClass="btn btn-primary w-100" Width="85px" OnClick="ShowTreatment" />
            </a>
          </div>
        </div>
        <!-- link card to treatment -->

    </div>
    <!-- End content here -->


</asp:Content>
