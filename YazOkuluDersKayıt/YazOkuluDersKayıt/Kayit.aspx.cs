using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


namespace YazOkuluDersKayıt
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Numara = TxtNumara.Text;
            ent.Sifre = TxtSifre.Text;
            ent.Fotograf = TxtFoto.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);

        }
    }
}