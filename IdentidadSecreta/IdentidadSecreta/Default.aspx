<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IdentidadSecreta._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="user-data">
        <div class="title">
            <span class="page-title">Ingrese sus datos para conocer su Identidad Secreta</span>
        </div>
        <div class="row">
            <asp:Label ID="Label1" Text="Nombre:" runat="server" CssClass="input-title" />
            <asp:TextBox ID="txtNombreReal" runat="server" CssClass="data-input" />
        </div>
        <div class="row">
            <asp:Label ID="Label2" Text="Apellido:" runat="server" CssClass="input-title" />
            <asp:TextBox ID="txtApellidoReal" runat="server" CssClass="data-input" />
        </div>
        <div class="row">
            <asp:Label ID="Label3" Text="Mes:" runat="server" CssClass="input-title" />
            <asp:TextBox ID="txtMes" runat="server" CssClass="data-input" />
        </div>
        <div class="row">
            <asp:Label ID="Label4" Text="Otro Campo:" runat="server" CssClass="input-title" />
            <asp:TextBox ID="txtCampoExtra" runat="server" CssClass="data-input" />
        </div>
        <div class="row" style="margin-top: 17px;">
            <div style="width: 405px; margin-left: 200px; text-align: right; padding-top: 17px;">
                <asp:Button ID="btnObtener" Text="Obtener Identidad" CssClass="btn-submit" OnClick="btnObtener_Click" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
