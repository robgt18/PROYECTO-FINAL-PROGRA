<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PROYECTO_FINAL_PROGRA._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CONTROL DE GASTOS</h1>
        <p class="lead">&nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INGRESAR COMUNIDADES" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="INGRESAR GASTOS" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="INGRESAR PROPIEDADES" />
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="INGRESAR PROPIETARIOS" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" Text="VARIACIONES DE GASTOS" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
            </h2>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
