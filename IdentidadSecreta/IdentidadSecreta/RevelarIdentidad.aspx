<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RevelarIdentidad.aspx.cs" Inherits="IdentidadSecreta.RevelarIdentidad" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <div class="hero-result">
            <div>
                <asp:Image ID="imgSuperheroe" Height="100px" BackColor="Blue" Width="100px" runat="server" />
            </div>
            <div>
                <asp:Label ID="Label5" Text="Nombre de superhéroe:" runat="server" />
                <asp:TextBox ID="txtNombreSuper" runat="server" />
            </div>
            <div>
                <asp:Label ID="Label6" Text="Profesión pública:" runat="server" />
                <asp:TextBox ID="txtProfesionPublica" runat="server" />
            </div>
            <div>
                <asp:Label ID="Label7" Text="Superpoder:" runat="server" />
                <asp:TextBox ID="txtSuperpoder" runat="server" />
            </div>
        </div>
</asp:Content>
