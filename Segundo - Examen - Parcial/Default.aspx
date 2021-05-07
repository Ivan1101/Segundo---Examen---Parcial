<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Segundo___Examen___Parcial._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="Medium">
        <h1>Registro </h1>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h1>Album</h1>
            <p>Ingrese el titulo del album
                <asp:TextBox ID="TextBoxtitulo" runat="server" Width="298px"></asp:TextBox>
            &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="TextBoxUniversidad" ErrorMessage="  Debe ingresar el titulo del album" SetFocusOnError="True"></asp:RequiredFieldValidator>
               <p>Nombre del artista
                <asp:TextBox ID="TextBoxnombre_artista" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorUniversidad" runat="server" ControlToValidate="TextBoxUniversidad" ErrorMessage="Debe ingresar el nombre del artista" SetFocusOnError="True"></asp:RequiredFieldValidator>
                 <p>
            &nbsp;<asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Fecha de publicación:"></asp:Label>
            <br />
            <asp:Calendar ID="Calendarfecha_publicación" runat="server"></asp:Calendar>   
                <br /> <br />
                     <strong>Tipo de canciones del album:</strong> &nbsp;&nbsp;
                     <asp:DropDownList ID="DropDownList_registro" runat="server" Height="17px" Width="109px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                         <asp:ListItem>Pop</asp:ListItem>
                         <asp:ListItem>Electronica</asp:ListItem>
                         <asp:ListItem>Rock</asp:ListItem>
                     </asp:DropDownList>
            </div>
    </div>
        <div class="row">
                    <div class="col-xs-3" style="left: 0px; top: 0px">
                                <asp:Label ID="Label4" runat="server" Text="Nombre de la canción:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                            </div>
                        <div class="col-xs-3">
                            <asp:Label ID="Label5" runat="server" Text="Artista:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxartista" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-xs-3">
                            <asp:Label ID="Label6" runat="server" Text="Tiempo de duración:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxtiempo" runat="server"></asp:TextBox>   </div>
    <br />
    <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="Ingresar" Width="118px" />
        <asp:Button ID="Button2" runat="server" Height="32px" Text="Guardar Datos" Width="180px" BackColor="#0066FF" ForeColor="White" OnClick="Button_guardar_Click" />
            </div> 
    <div>
    </div>
</asp:Content>
