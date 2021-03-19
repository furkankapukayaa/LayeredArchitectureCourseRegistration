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
    public partial class Ogretmenler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgretmen> OgrtList = BLL_Ogretmen.BLLListele();
            Repeater1.DataSource = OgrtList;
            Repeater1.DataBind();
        }
    }
}