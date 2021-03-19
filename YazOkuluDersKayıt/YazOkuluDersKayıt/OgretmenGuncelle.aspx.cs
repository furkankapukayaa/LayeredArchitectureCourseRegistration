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
    public partial class OgretmenGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRTID"].ToString());
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgretmen> OgrtList = BLL_Ogretmen.BLLDetay(x);
                TxtAd.Text = OgrtList[0].Ogrtad.ToString();
                TxtBrans.Text = OgrtList[0].Ogrtbrans.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtad = TxtAd.Text;
            ent.Ogrtbrans = Convert.ToInt32(TxtBrans.Text);
            ent.Ogrtid = Convert.ToInt32(TxtId.Text);
            BLL_Ogretmen.OgretmenGuncelleBLL(ent);
            Response.Redirect("Ogretmenler.aspx");
        }
    }
}