<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="ASP_Web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Formulario Empleados</h1>
    <asp:Label ID="lbl_codigo" runat="server" Text="Código" CssClass="badge" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="txt_codigo" runat="server" CssClass="form-control" placeholder="Eje:001"></asp:TextBox>
    <asp:Label ID="LabelNombres" runat="server" Text="Nombres" CssClass="badge" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="TextNombres" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
    <asp:Label ID="Label_apellidos" runat="server" Text="Apellidos" CssClass="badge" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="Txt_apellidos" runat="server" CssClass="form-control" placeholder="Apellido"></asp:TextBox>
    <asp:Label ID="Label_direccion" runat="server" Text="Dirección" CssClass="badge" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="Txt_direccioni" runat="server" CssClass="form-control" placeholder="Dirección"></asp:TextBox>
    <asp:Label ID="Label_telefono" runat="server" Text="Teléfono" CssClass="badge" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="TextBox_telefono" runat="server" CssClass="form-control" placeholder="Teléfono" TextMode="Number"></asp:TextBox>
    <asp:Label ID="Label_fecha" runat="server" Text="Fecha" CssClass="badge" Font-Size="Medium"></asp:Label>
    <asp:TextBox ID="TextBox_fecha" runat="server" CssClass="form-control" placeholder="Fecha yyyy-mm-dd" TextMode="Date"></asp:TextBox>
    <asp:Label ID="lbl_puesto" runat="server" Text="Puesto" CssClass="badge" Font-Size="Medium"></asp:Label>
    <asp:DropDownList ID="drop_puesto" runat="server" CssClass="form-control"></asp:DropDownList>
    <asp:Button ID="Btn_crear" runat="server" Text="Crear" CssClass=" btn btn-primary" OnClick="Btn_crear_Click" />
    <asp:Button ID="Btn_actualizar" runat="server" Text="Actualizar" CssClass="btn btn-success" />
   
    <asp:GridView ID="grid_empleados" runat="server" AutoGenerateColumns="False" CssClass="table-condensed" DataKeyNames="id,id_puesto">
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Btn_select" runat="server" CausesValidation="False" CssClass="btn btn-info" CommandName="Select" Text="Ver" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Btn_eliminar" runat="server" CausesValidation="False"  CssClass="btn btn-danger" CommandName="Delete" Text="Borrar" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="codigo" HeaderText="Código" />
            <asp:BoundField DataField="nombre" HeaderText="Nombres" />
            <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
            <asp:BoundField DataField="direccion" HeaderText="Dirección" />
            <asp:BoundField DataField="telefono" HeaderText="Teléfono" />
            <asp:BoundField DataField="fecha_nacimiento" HeaderText="Nacimiento" SortExpression="fecha_nacimiento" DataFormatString="{0:d}" />
            <asp:BoundField DataField="puesto" HeaderText="Puesto" SortExpression="puesto" />
        </Columns>
    </asp:GridView>


</asp:Content>

