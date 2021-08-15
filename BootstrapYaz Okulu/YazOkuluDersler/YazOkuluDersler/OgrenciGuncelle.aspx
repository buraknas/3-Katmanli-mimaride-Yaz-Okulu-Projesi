<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluDersler.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <form id="Form1" runat="server">
      <div class="form-group">
          <div>
              <asp:Label for="TextBox6" runat="server" Text="Öğrenci Id:" style="font-weight: bold"></asp:Label>
              <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br />
          <div>
              <asp:Label for="TextBox1" runat="server" Text="Öğrenci Adı:" style="font-weight: bold"></asp:Label>
              <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br />
          <div>
              <asp:Label for="TextBox2" runat="server" Text="Öğrenci Soyadı:" style="font-weight: bold"></asp:Label>
              <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br />
          <div>
              <asp:Label for="TextBox3" runat="server" Text="Öğrenci Numara:" style="font-weight: bold"></asp:Label>
              <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br />
          <div>
              <asp:Label for="TextBox4" runat="server" Text="Öğrenci Şifre:" style="font-weight: bold"></asp:Label>
              <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br />
          <div>
              <asp:Label for="TextBox5" runat="server" Text="Öğrenci Foto:" style="font-weight: bold"></asp:Label>
              <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
         

      </div>
      <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn-warning" OnClick="Button1_Click" />

  </form>
</asp:Content>
