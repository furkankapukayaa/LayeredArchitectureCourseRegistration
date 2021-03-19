<%@ Page Title="" Language="C#" MasterPageFile="~/YazOkuluDersKayıt.Master" AutoEventWireup="true" CodeBehind="Yardim.aspx.cs" Inherits="YazOkuluDersKayıt.Yardim" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .bildirim{
            display:inline-block;
        }
    </style>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <h2>Ders Kayıt Sistemi Yardım Merkezi</h2>
    <br />
    <p>
        Bu sistem <strong>Murat Yücedağ</strong>'ın <strong><a href="https://www.youtube.com/playlist?list=PLKnjBHu2xXNMSPomGvyjG19YGXIdgdTka" target="_blank">30 Derste Asp.Net Bootstrap ile Katmanlı Mimaride Yaz Okulu Kayıt Projesi</a></strong>'nden esinlenerek yapılmıştır.
        <br />
        Aşağıdaki tabloda ise yapılan sistem tek tek başlıklar halinde anlatılmıştır.
    </p>
    <div id="accordion">
        <div class="card">
            <div class="card-header">
                <a class="card-link" data-toggle="collapse" href="#collapseOne">Tanıtım
                </a>
            </div>
            <div id="collapseOne" class="collapse show" data-parent="#accordion">
                <div class="card-body">
                    <ul>
                        <li>Proje katmanlı mimari olarak tasarlanmıştır.</li>
                        <li>Projede 
                            <ul>
                                <li>EntityLayer </li>
                                <li>DataAccessLayer</li>
                                <li>BusinessLogicLayer</li>
                            </ul>
                            katmanları bulunmaktadır.</li>
                        <li>Projede 
                            <ul>
                                <li>Asp.NET</li>
                                <li>HTML</li>
                                <li>CSS</li>
                                <li>Boostrap</li>
                            </ul>
                            kullanılmıştır.</li>
                        <li>Microsoft SQL Server bağlantılıdır.</li>
                    </ul>
                    <div class=" bildirim alert alert-danger">
                        <strong>Dikkat!</strong> Projede kullanılan isimler herhangi bir gerçeklik ifade etmemektedir.
                    </div>
                </div>
            </div>
        </div>
        <div class="card">
            <div class="card-header">
                <a class="collapsed card-link" data-toggle="collapse" href="#collapseTwo">Proje Kaynak Kodları
                </a>
            </div>
            <div id="collapseTwo" class="collapse" data-parent="#accordion">
                <div class="card-body">
                    Projenin kaynak kodlarını <a href="https://github.com/furkankapukayaa" target="_blank">github.com/furkankapukayaa</a> adresinden bulabilirsiniz.
                </div>
            </div>
        </div>
    </div>

</asp:Content>
