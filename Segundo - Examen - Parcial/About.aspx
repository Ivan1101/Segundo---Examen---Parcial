<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Segundo___Examen___Parcial.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
      <h1> Control de Datos </h1>
    <br />
   
    </div>

        <div class="row">
                    <div class="col-xs-4" style="left: 0px; top: 0px">
                                <strong>Dato de:</strong>
                                <asp:DropDownList ID="DropDownList_mostrar" runat="server" Height="20px" Width="109px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                                    <asp:ListItem></asp:ListItem>
                         <asp:ListItem>Alumno</asp:ListItem>
                         <asp:ListItem>Catedrático</asp:ListItem>
                         <asp:ListItem>Personal Administrativo</asp:ListItem>
                     </asp:DropDownList>
                         <br />
                                <asp:Label ID="Label_noexiste" runat="server"></asp:Label>
                     </div>
                        <div class="col-xs-3">
                            <div class="row">
                            &nbsp; 
                        </div>
                              <div class="row">
                        <asp:Label ID="Label2" runat="server" Text="Ingrese el nombre del artista"></asp:Label>
       &nbsp;<asp:TextBox ID="TextBox_codigo" runat="server" Height="20px"></asp:TextBox>
       <br />  
                        </div>
                            <div class="row">
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary btn-sm" Height="31px" OnClick="Button1_Click" Text="Buscar" Width="106px" />
       <br />
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
       &nbsp;&nbsp; 
                            </div></div>
            <div class="col-xs-3">
                <asp:GridView ID="GridView_Universidades" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="GridView_Universidades_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                </div>
                    <br />
                    <br />
             </div>
     <br />
  <div class="row"> <!-- Código para mostrar los datos de la persona a modificar -->
       <div class="col-xs-3" style="left: 0px; top: 0px">
                                <asp:Label ID="Label6" runat="server" ForeColor="Black" Text="Nombre:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                            </div>
                        <div class="col-xs-3">
                            <asp:Label ID="Label9" runat="server" Text="Artista"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxartista" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-xs-3">
                            <asp:Label ID="Label8" runat="server" ForeColor="Black" Text="Duración:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxtiempo" runat="server"></asp:TextBox>
                        </div>
              <div class="col-xs-3">
&nbsp;</div> 
            </div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        

    <br />
    <asp:Button ID="Button2_editar" runat="server" Height="32px" OnClick="Button2_Click" Text="Editar" Width="118px" CssClass="btn btn-warning btn-sm" />
     <asp:Button ID="Button3_eliminar" runat="server" Height="32px" OnClick="Button4_Click" Text="Eliminar" Width="118px" CssClass="btn btn-danger btn-sm" />
    <br />
    <asp:Button ID="Button3_modificar" runat="server" Height="32px" OnClick="Button3_Click" Text="Modificar" Width="118px" CssClass="btn btn-primary btn-sm" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
       
</asp:Content>