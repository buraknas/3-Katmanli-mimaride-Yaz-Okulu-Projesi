<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DersListesi.aspx.cs" Inherits="YazOkuluDersler.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders Listesi:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            <br />
        </div>
        <div>
            <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Öğrenci Id:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            <br />

        </div>
        <div>
            <asp:Button ID="Button1" runat="server"  Text="Ders Talep Oluştur" cssClass="btn-warning" OnClick="Button1_Click" />
            
        </div>



    </form>
</asp:Content>
