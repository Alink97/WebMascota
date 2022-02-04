<%@ Page Title="Mascotas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mascotas.aspx.cs" Inherits="WebMascota.Mascotas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:GridView ID="listadoMascotas" runat="server" OnRowDataBound="GridView1_RowDataBound"></asp:GridView>
    
</asp:Content>
