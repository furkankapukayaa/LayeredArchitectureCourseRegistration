<%@ Page Title="" Language="C#" MasterPageFile="~/YazOkuluDersKayıt.Master" AutoEventWireup="true" CodeBehind="OgretmenGuncelle.aspx.cs" Inherits="YazOkuluDersKayıt.OgretmenGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="Form1" runat="server">

        <div class="form-group">
            <div>
                <asp:Label for="TxtId" runat="server" Text="Öğretmen Id:" Style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtAd" runat="server" Text="Öğretmen Adı:" Style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtBrans" runat="server" Text="Öğretmen Branş:" Style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TxtBrans" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
            </div>

            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />

        </div>
    </form>

</asp:Content>

