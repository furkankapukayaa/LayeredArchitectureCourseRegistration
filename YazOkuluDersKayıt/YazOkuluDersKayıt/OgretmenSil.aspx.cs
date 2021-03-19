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
    public partial class OgretmenSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRTID"]);
            Response.Write(x);
            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtid = x;
            BLL_Ogretmen.OgretmenSilBLL(ent.Ogrtid);
            Response.Redirect("Ogretmenler.aspx");
        }
    }
}