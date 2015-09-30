<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RevelarIdentidad.aspx.cs" Inherits="IdentidadSecreta.RevelarIdentidad" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <div class="hero-result">
            <div class="row-title row-bottom-line">
                <span class="result-title">IDENTIDAD SECRETA</span>
            </div>
            <div class="row-name">
                <div style="margin-top: 60px;">
                    <span class="value-title">NOMBRE</span>
                    <asp:Label runat="server" ID="lblNombre" CssClass="result-label"></asp:Label>                
                    <asp:Label runat="server" ID="lblApellido" CssClass="result-label"></asp:Label>
                </div>
                <asp:Image ID="imgSuperheroe" CssClass="circular" runat="server" />
            </div>
            <div class="row-power row-bottom-line">
                <span class="value-title">SUPERPODER</span>
                <asp:Label runat="server" ID="lblSuperpoder" CssClass="result-label"></asp:Label>
            </div>
            <div class="row-profession row-bottom-line">
                <span class="value-title">PROFESION</span>
                <asp:Label runat="server" ID="lblProfesion" CssClass="result-label"></asp:Label>
            </div>
            <div class="row-bottom">
                <img src="Images/codigo.png" style="float: left; margin-left: 140px; margin-top: 10px;" /><img src="Images/firma.png" style="float: right; margin-right: 150px; margin-top: 10px;" />
            </div>
            
        </div>
</asp:Content>
