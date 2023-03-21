<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ASP_Web.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Página de Contacto.</h3>
    <address>
        C/Manuel Serrano XXX<br />
        Aranjuez, Madrid<br />
        <abbr title="Telf">P:</abbr>
        679073192
    </address>

    <address>
        <strong>Soporte:</strong>   <a href="mailto:Support@example.com">guryxxx@hotmail.com</a><br />
        <strong>Contacto:</strong> <a href="mailto:Marketing@example.com">youssefaounocampo1993@gmail.com</a>
    </address>
</asp:Content>
