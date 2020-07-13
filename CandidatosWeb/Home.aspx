<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CandidatosWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 245px;
            height: 142px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="center">
        Validación de postulantes</h1>
    <p class="center">
        &nbsp;</p>
<p class="center">
    <img alt="" class="auto-style1" src="Images/logo.jpg" /></p>
    <p class="center">
        &nbsp;</p>
<p class="center">
    <strong>TOP 5 ALUMNOS EN ISIL</strong></p>
    <div class="center">
    <asp:GridView ID="gvTop5" runat="server" CellPadding="10" HorizontalAlign="Center" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="DniAlumno" HeaderText="DNI" />
            <asp:BoundField DataField="NombAlumno" HeaderText="Nombre" />
            <asp:BoundField DataField="ApeAlumno" HeaderText="Apellidos" />
            <asp:BoundField DataField="EmailAlumno" HeaderText="Email" />
            <asp:BoundField DataField="TelAlumno" HeaderText="Teléfono" />
            <asp:BoundField DataField="PromGlobal" HeaderText="Promedio Global" />
            <asp:BoundField DataField="FecInscrip" HeaderText="Fecha de Inscripción" />
            <asp:BoundField DataField="UbiAlumno" HeaderText="Zip" />
        </Columns>
    </asp:GridView>
    </div>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
<p class="center">
    Ver información del alumno por:</p>
<p class="center">
            <asp:Button ID="btnConsultaDNI" runat="server" Text="DNI" OnClientClick="window.open('Consultas/ByDNI.aspx', '_self');return false;"  />
            <asp:Button ID="btnTelefono" runat="server" Text="Teléfono" OnClientClick="window.open('Consultas/ByTelefono.aspx', '_self');return false;"/>
            <asp:Button ID="btnCorreo" runat="server" Text="Correo" OnClientClick="window.open('Consultas/ByCorreo.aspx', '_self');return false;"/>
            <asp:Button ID="btnNomApe" runat="server" Text="Nombre y apellido" OnClientClick="window.open('Consultas/ByNomApe.aspx', '_self');return false;"/>
        </p>

    <p class="center">
        &nbsp;</p>
    <p class="center">
        Si ya conoces el DNI, mira su historial directamente:</p>
    <p class="center">
        <asp:Button ID="btnHistorial" runat="server" Text="Ver historial" OnClientClick="window.open('Historial/HistorialAcademico.aspx', '_self');return false;"/>
    </p>
</asp:Content>
