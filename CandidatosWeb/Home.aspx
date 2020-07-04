<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CandidatosWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style4 {
        width: 405px;
        text-align: center;
    }
    .auto-style5 {
        width: 379px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="center">
    Candidatos: Home</p>
<p class="center">
    &nbsp;</p>
<p class="center">
    <asp:Button ID="btnTop5" runat="server" Text="Ver top 5 Alumnos en Isil" OnClick="btnTop5_Click"/>
</p>
<p class="center">
    &nbsp;</p>
<p>
    <asp:GridView ID="gvTop5" runat="server">
    </asp:GridView>
</p>
<p class="center">
    &nbsp;</p>
<p class="center">
    &nbsp;</p>
<p class="center">
    Ver información del alumno por:</p>
<p class="center">
    &nbsp;</p>
<table class="auto-style1">
    <tr>
        <td class="auto-style5">
            <asp:Button ID="btnConsultaDNI" runat="server" Text="DNI" OnClientClick="window.open('Consultas/ByDNI.aspx', '_self');return false;" />
        </td>
        <td class="auto-style4">
            <asp:Button ID="btnTelefono" runat="server" Text="Teléfono" OnClientClick="window.open('Consultas/ByTelefono.aspx', '_self');return false;"/>
        </td>
        <td class="center">
            <asp:Button ID="btnCorreo" runat="server" Text="Correo" OnClientClick="window.open('Consultas/ByCorreo.aspx', '_self');return false;"/>
        </td>
        <td class="center">
            <asp:Button ID="btnNomApe" runat="server" Text="Nombre y apellido" OnClientClick="window.open('Consultas/ByNomApe.aspx', '_self');return false;"/>
        </td>
    </tr>
</table>
</asp:Content>
