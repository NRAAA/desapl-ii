﻿<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="ByNomApe.aspx.cs" Inherits="CandidatosWeb.Consultas.ByNomApe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 149px;
        }
        .auto-style3 {
            width: 296px;
        }
        .auto-style4 {
            width: 165px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 263px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/home.png" Width="55px" OnClientClick="window.open('../Home.aspx', '_self');return false;" />
    <br />
    <p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Ingrese nombre:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbNombre" runat="server" Width="220px"></asp:TextBox>
                </td>
                <td class="auto-style4">Ingrese apellido:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbApellido" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnConsultar" runat="server" CssClass="auto-style5" OnClick="btnConsultar_Click" Text="Consultar" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="gvAlumno" runat="server" AutoGenerateColumns="False" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="DniAlumno" HeaderText="DNI" />
                <asp:BoundField DataField="ApeAlumno" HeaderText="Apellidos" />
                <asp:BoundField DataField="NombAlumno" HeaderText="Nombre" />
                <asp:BoundField DataField="EmailAlumno" HeaderText="Email" />
                <asp:BoundField DataField="TelAlumno" HeaderText="Teléfono" />
                <asp:BoundField DataField="PromGlobal" HeaderText="Promedio Global" />
                <asp:BoundField DataField="FecInscrip" HeaderText="Fecha de Inscripción" />
                <asp:BoundField DataField="UbiAlumno" HeaderText="Zip" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
