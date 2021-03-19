<%@ Page Title="" Language="C#" MasterPageFile="~/YazOkuluDersKayıt.Master" AutoEventWireup="true" CodeBehind="Ogretmenler.aspx.cs" Inherits="YazOkuluDersKayıt.Ogretmenler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğretmen ID</th>
            <th>Öğretmen Ad Soyad</th>
            <th>Öğretmen Branş</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Ogrtid") %></td>
                        <td><%#Eval("Ogrtad") %></td>
                        <td><%#Eval("Ogrtbrans") %></td>
                        <td>
                            
                            <asp:HyperLink NavigateUrl='<%# "~/OgretmenGuncelle.aspx?OGRTID=" + Eval("Ogrtid")  %>' ID="HyperLink1" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgretmenSil.aspx?OGRTID=" + Eval("Ogrtid")  %>' ID="HyperLink2" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                            
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>
