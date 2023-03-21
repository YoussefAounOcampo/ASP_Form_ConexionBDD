<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Primer uso de APS.NET</h1>
        <p class="lead">Primer uso de ASP.NET, en este ejemplo hago un CRUD en la pestaña de empleados conectandome a una base de datos. He usado: HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">APS.NET link &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Empezando...</h2>
            <p>
                Aplicación de prueba</p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Link info &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Consigue más librerías</h2>
            <p>
                NuGet es una extensión gratutita de Visual Studio que hace fácil el añadir, quitar y actualizar librerías y herramientas en los proyectos de Visual Studio.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Más &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                Pincha aquí para encontrar host que ofrezcan las caracteristicas que necesites para tus aplicaciones.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Más aquí &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
