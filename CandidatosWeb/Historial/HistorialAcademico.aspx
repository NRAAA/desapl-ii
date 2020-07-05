<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="HistorialAcademico.aspx.cs" Inherits="CandidatosWeb.Historial.Historial_académico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 361px;
        }
        .auto-style3 {
            width: 254px;
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/home.png" Width="55px" OnClientClick="window.open('../Home.aspx', '_self');return false;" />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Ingresa número de documento a consultar:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbDNI" runat="server" Width="236px" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <strong>
        <asp:Label ID="lblOcurrencias" runat="server" Text="Ocurrencias" Visible="False"></asp:Label>
        </strong></p>
    <p>
        <div class="center">
        <asp:GridView ID="gvAlumno" runat="server" AutoGenerateColumns="False" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="ApeAlumno" HeaderText="Apellidos" />
                <asp:BoundField DataField="NombAlumno" HeaderText="Nombres" />
                <asp:BoundField DataField="DescOcurrencia" HeaderText="Descripción de la ocurrecia" />
                <asp:BoundField DataField="FechaOcurrencia" HeaderText="Fecha de la ocurrencia" />
            </Columns>
        </asp:GridView>
        </div>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <strong>
        <asp:Label ID="lblPromCur" runat="server" Text="Promedio por curso" Visible="False"></asp:Label>
        </strong></p>
<p class="center">
        <asp:GridView ID="gvPromedioCurso" runat="server" AutoGenerateColumns="False" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="ApeAlumno" HeaderText="Apellido" />
                <asp:BoundField DataField="NombAlumno" HeaderText="Nombres" />
                <asp:BoundField DataField="Curso" HeaderText="Curso" />
                <asp:BoundField DataField="CantInasist" HeaderText="Cantidad de inasistencias" />
                <asp:BoundField DataField="Profesor" HeaderText="Profesor" />
                <asp:BoundField DataField="CantClases" HeaderText="Cantidad de Clases" />
                <asp:BoundField DataField="ExaParc" HeaderText="Examen parcial" />
                <asp:BoundField DataField="ExaFin" HeaderText="Examen final" />
                <asp:BoundField DataField="PromEp" HeaderText="Promedio" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
<p>
        <strong>
        <asp:Label ID="lblPorcInas" runat="server" Text="Porcentaje de Inasistencias" Visible="False"></asp:Label>
        </strong></p>
<p class="center">
        <asp:GridView ID="gvPorcInas" runat="server" AutoGenerateColumns="False" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="ApeAlumno" HeaderText="Apellidos" />
                <asp:BoundField DataField="NombAlumno" HeaderText="Nombres" />
                <asp:BoundField DataField="PorcInasist" HeaderText="Porcentaje de Inasistencia" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
<p>
        <strong>
        <asp:Label ID="lblCalificacion" runat="server" Text="Calificaciones" Visible="False"></asp:Label>
        </strong></p>
    <p class="center">
        <asp:GridView ID="gvNotas" runat="server" AutoGenerateColumns="False" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="ApeAlumno" HeaderText="Apellidos" />
                <asp:BoundField DataField="NombAlumno" HeaderText="Nombres" />
                <asp:BoundField DataField="Curso" HeaderText="Curso" />
                <asp:BoundField DataField="Profesor" HeaderText="Profesor" />
                <asp:BoundField DataField="TituloAct" HeaderText="Titulo de la Actividad" />
                <asp:BoundField DataField="TemaAct" HeaderText="Tema de la Actividad" />
                <asp:BoundField DataField="ComentariosProfesor" HeaderText="Comentarios del profesor" />
                <asp:BoundField DataField="TipoNota" HeaderText="Tipo de nota" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" />
                <asp:BoundField DataField="DescAct" HeaderText="DescAct" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
