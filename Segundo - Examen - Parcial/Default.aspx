<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Segundo___Examen___Parcial._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="Medium">
        <h1>Registro </h1>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h1>Album</h1>
            <p>Ingrese el titulo del album
                <asp:TextBox ID="TextBoxUniversidad" runat="server" Width="298px"></asp:TextBox>
            &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="TextBoxUniversidad" ErrorMessage="  Debe ingresar el nombre del alumno" SetFocusOnError="True"></asp:RequiredFieldValidator>
               <p>Nombre del artista
                <asp:TextBox ID="TextBoxid_universidad" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorUniversidad" runat="server" ControlToValidate="TextBoxUniversidad" ErrorMessage="Debe ingresar el ID de la universidad" SetFocusOnError="True"></asp:RequiredFieldValidator>
                 <p>
                     <strong>Tipo de canción:</strong> &nbsp;&nbsp;
                     <asp:DropDownList ID="DropDownList_registro" runat="server" Height="17px" Width="109px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                         <asp:ListItem>Pop</asp:ListItem>
                         <asp:ListItem>Electronica</asp:ListItem>
                         <asp:ListItem>Rock</asp:ListItem>
                     </asp:DropDownList>
            </div>
    </div>
        <div class="row">
                    <div class="col-xs-3" style="left: 0px; top: 0px">
                                <strong>Nombre de la canción:</strong>
                     <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                            </div>
                        <div class="col-xs-3">
                            <strong>Artista:</strong>
                            <asp:TextBox ID="TextBoxartista" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-xs-3">
                            <strong>Tiempo d:</strong>
                            <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
                        </div>
              <div class="col-xs-3">
                     <asp:Label ID="LabelCarnet" runat="server" Text="Carnet:" ForeColor="Black"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox_carnet" runat="server"></asp:TextBox>
                </div> 
            </div>
        <br />
          <asp:Label ID="Label1" runat="server" Text="Codigo IGSS :" ForeColor="Black"></asp:Label>
         <asp:TextBox ID="TextBox_codigo" runat="server"></asp:TextBox>  
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Profesión"></asp:Label>
        <asp:Label ID="Label2" runat="server" ForeColor="Black" Text="Titulo"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBoxTitulo" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    <div class="row">
        <div class="col-xs-3" style="background-color:aliceblue; top: 3px; left: 0px; height: 202px;">
             <br />
            <strong>Fecha de nacimiento:</strong>
            <asp:Calendar ID="CalendarNacimiento" runat="server"></asp:Calendar>  
             </div>
            <div class="col-xs-3" style="background-color:aliceblue; height: 203px;">
            &nbsp;<asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Fecha de inicio de labores:"></asp:Label>
            <br />
            <asp:Calendar ID="Calendarfecha_inicio" runat="server"></asp:Calendar>   
                <br />
                </div> 
    <div class="col-xs-3" style="background-color:aliceblue; top: 2px; left: -9px; height: 204px;">
            <asp:Label ID="Label4" runat="server" ForeColor="Black" Text="Fecha de fin de labores:"></asp:Label>
&nbsp;<br />
            <asp:Calendar ID="Calendarfecha_final" runat="server"></asp:Calendar>   
                </div>  </div> 
    <br />
    <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="Ingresar" Width="118px" />
        <asp:Button ID="Button2" runat="server" Height="32px" Text="Guardar Datos" Width="180px" BackColor="#0066FF" ForeColor="White" OnClick="Button_guardar_Click" />
          
    <div>
    </div>
</asp:Content>
