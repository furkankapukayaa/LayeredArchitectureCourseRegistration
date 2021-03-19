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
    public partial class OgretmenKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtad = TxtAd.Text;
            ent.Ogrtbrans = Convert.ToInt32(TxtBrans.Text);
            BLL_Ogretmen.OgretmenEkleBLL(ent);
        }
    }
}