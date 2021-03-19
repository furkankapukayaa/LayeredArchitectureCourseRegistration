<%@ Page Title="" Language="C#" MasterPageFile="~/YazOkuluDersKayıt.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YazOkuluDersKayıt.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        /* Make the image fully responsive */
        .carousel-inner img {
            width: 100%;
            height: 100%;
        }

        h1 {
            text-align: center;
            color: red;
            text-transform: uppercase;
        }
        .bildirim{
            display:inline-block;
        }
    </style>

</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div id="demo" class="carousel slide" data-ride="carousel">
        <ul class="carousel-indicators">
            <li data-target="#demo" data-slide-to="0" class="active"></li>
            <li data-target="#demo" data-slide-to="1"></li>
            <li data-target="#demo" data-slide-to="2"></li>
        </ul>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="images/1.png" alt="Los Angeles" width="1100" height="500">
                <div class="carousel-caption">
                    <h3>Sistem Yenilendi</h3>
                    <p>Her Şey Tek Tuşta!</p>
                </div>
            </div>
            <div class="carousel-item">
                <img src="images/2.png" alt="Chicago" width="1100" height="500">
                <div class="carousel-caption">
                    <h3>Kontenjanlar Eklendi</h3>
                    <p>Hemen Kontrol Et!</p>
                </div>
            </div>
            <div class="carousel-item">
                <img src="images/3.png" alt="New York" width="1100" height="500">
                <div class="carousel-caption">
                    <h3>Yardıma Mı İhtiyacın Var</h3>
                    <p>Yardım Merkezi Seni Bekliyor!</p>
                </div>
            </div>
        </div>
        <a class="carousel-control-prev" href="#demo" data-slide="prev">
            <span class="carousel-control-prev-icon"></span>
        </a>
        <a class="carousel-control-next" href="#demo" data-slide="next">
            <span class="carousel-control-next-icon"></span>
        </a>
    </div>
    <br>
    <h1>Ders Kayıt Sistemi</h1>

    <div class="bildirim alert alert-info alert-dismissible fade show">
        <button type="button" class="close" data-dismiss="alert">&times;</button>
        <strong>Bilgi!</strong> YAZILAR LOREM IPSUM'DAN SAYFA DOLU GÖZÜKSÜN DİYE ALINMIŞTIR :)
    </div>

    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. <strong>Nunc consectetur blandit fermentum.</strong> Etiam ut tincidunt turpis. Donec ut ultricies orci. Etiam arcu sem, malesuada ut lectus nec, laoreet egestas velit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam faucibus dictum lectus, et sagittis quam semper sit amet. Sed sollicitudin, nibh nec ullamcorper ultrices, urna purus tincidunt diam, et sollicitudin dui sem in lacus. Pellentesque sapien augue, viverra vel aliquam pharetra, tincidunt at sem. Integer tempus ullamcorper arcu ut maximus. Etiam sed sem id eros sollicitudin dictum non quis dui.</p>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc consectetur blandit fermentum. Etiam ut tincidunt turpis. Donec ut ultricies orci.   <del>Etiam arcu sem, malesuada ut lectus nec, laoreet egestas velit. Class aptent taciti sociosqu ad litora torquent per con  </del>ubia nostra, per inceptos himenaeos. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam faucibus dictum lectus, et sagittis quam semper sit amet. Sed sollicitudin, nibh nec ullamcorper ultrices, urna purus tincidunt diam, et sollicitudin dui sem in lacus. Pellentesque sapien augue, viverra vel aliquam pharetra, tincidunt at sem. Integer tempus ullamcorper arcu ut maximus. Etiam sed sem id eros sollicitudin dictum non quis dui.</p>
    <ul>
        <li>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc consectetur blandit fermentum.</li>
        <li>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc consectetur blandit fermentum.</li>
        <li>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc consectetur blandit fermentum.</li>
    </ul>
    <p>Lorem ipsum dolor sit <ins>amet, consectetur adipiscing elit.</ins> Nunc consectetur blandit fermentum. <i>Etiam ut tincidunt turpis.</i> Donec ut ultricies orci. Etiam arcu sem, malesuada ut lectus nec, laoreet egestas velit. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam faucibus dictum lectus, et sagittis quam semper sit amet. Sed sollicitudin, nibh nec ullamcorper ultrices, urna purus tincidunt diam, et sollicitudin dui sem in lacus. Pellentesque sapien augue, viverra vel aliquam pharetra, tincidunt at sem. Integer tempus ullamcorper arcu ut maximus. Etiam sed sem id eros sollicitudin dictum non quis dui.</p>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc consectetur blandit fermentum. Etiam ut tincidunt turpis. Done<i>c ut ultricies orci. Etiam arcu sem, malesuada ut lectus nec, laoreet egestas velit.</i> Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam faucibus dictum lectus, et sagittis quam semper sit amet. Sed sollicitudin, nibh nec ullamcorper ultrices, urna purus tincidunt diam, et sollicitudin dui sem in lacus. Pellentesque sapien augue, viverra vel aliquam pharetra, tincidunt at sem. Integer tempus ullamcorper arcu ut maximus. Etiam sed sem id eros sollicitudin dictum non quis dui.</p>



</asp:Content>
