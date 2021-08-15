<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluDersler.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci Id:</th>
            <th>Öğrenci Adı:</th>
            <th>Öğrenci Soyadı:</th>
            <th>Öğrenci Numara:</th>
            <th>Öğrenci Şifre:</th>
            <th>Öğrenci Foto:</th>
            <th>Öğrenci Bakiye:</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Id")%></td>
                        <td><%#Eval("Ad") %></td>
                        <td><%#Eval("Soyad")%></td>
                        <td><%#Eval("Numara")%></td>
                        <td><%# Eval("Sifre")%></td>
                        <td><%#Eval("Foto")%></td>
                        <td><%#Eval("Bakiye")%></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"OgrenciSil.aspx?OgrId="+Eval("Id") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl=<%#"OgrenciGuncelle.aspx?OgrId="+Eval("Id") %> CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td%
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
