<%@ Page Title="Página de inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebMascota._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Bienvenido a, Adopta tu mascota</h1>
    <div>Por favor, use los botones para navegar por la página.</div>
    <div></div>
    <asp:Button ID="btnIniListar" runat="server" Text="Ver Mascotas" ToolTip="Ver listado de las mascotas" Width="180px" OnClick="btnIniListar_Click" />
    <div></div>
    <asp:Button ID="btnIniAgregar" runat="server" Text="Agregar Mascota" ToolTip="Ver listado de las mascotas" Width="180px" OnClick="btnIniAgregar_Click" />
    <div></div>
    <asp:Button ID="btnIniVer" runat="server" Text="Visualizar Mascota" ToolTip="Ver listado de las mascotas" Width="180px" />
    <div></div>
    <asp:Button ID="Button3" runat="server" Text="Borrar" ToolTip="Ver listado de las mascotas" Width="180px" />

</asp:Content>
