<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RevelarIdentidad.aspx.cs" Inherits="IdentidadSecreta.RevelarIdentidad" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <div class="hero-result">
            
            <div class="row-title row-bottom-line">
                <span class="result-title">IDENTIDAD SECRETA</span>
            </div>
            <div class="row-name">
                <span class="value-title">NOMBRE</span>
                <asp:Label runat="server" ID="Name1" CssClass="result-label">Prueba</asp:Label>                
                <asp:Label runat="server" ID="Name2" CssClass="result-label">Prueba</asp:Label>
            </div>
            <div class="row-power row-bottom-line">
                <span class="value-title">SUPERPODER</span>
                <asp:Label runat="server" ID="SuperPower" CssClass="result-label">Prueba</asp:Label>
            </div>
            <div class="row-profession row-bottom-line">
                <span class="value-title">PROFESION</span>
                <asp:Label runat="server" ID="Profession" CssClass="result-label">Prueba</asp:Label>
            </div>
            <div class="row-bottom">
                
            </div>
        </div>
</asp:Content>
