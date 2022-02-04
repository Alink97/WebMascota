<%@ Page Title="Nueva mascota" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="WebMascota.Agregar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Nueva mascota</h1>
    Rellene los campos:
    <div>
        <asp:Label Text="Nombre: " runat="server"></asp:Label>
        <asp:TextBox ID="tbNewNombre" runat="server" MaxLength="20" />
    </div>
    <div>
        <asp:Label Text="Raza: " runat="server"></asp:Label>
        <asp:TextBox ID="tbNewRaza" runat="server" MaxLength="50" />
    </div>
    <div>
        <asp:Label Text="Edad: " runat="server"></asp:Label>
        <asp:TextBox ID="tbNewEdad" runat="server" MaxLength="2" TextMode="Number"  />
    </div>
    <div>
        <asp:Button ID="btnNewMascota" runat="server" Text="Agregar" OnClick="btnNewMascota_Click"/>
    </div>
</asp:Content>
