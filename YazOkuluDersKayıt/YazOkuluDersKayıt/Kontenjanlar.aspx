<%@ Page Title="" Language="C#" MasterPageFile="~/YazOkuluDersKayıt.Master" AutoEventWireup="true" CodeBehind="Kontenjanlar.aspx.cs" Inherits="YazOkuluDersKayıt.Kontenjanlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçiniz"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="TEST" CssClass="alert alert-success"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="TEST2" CssClass="alert alert-danger"></asp:Label>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Sorgula" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>

