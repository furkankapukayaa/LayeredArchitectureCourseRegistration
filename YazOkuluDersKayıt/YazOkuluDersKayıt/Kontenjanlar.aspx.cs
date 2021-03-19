using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace YazOkuluDersKayıt
{
    public partial class Kontenjanlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.BLLListele();
                DropDownList1.DataSource = BLLDers.BLLListele();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "Max";
                DropDownList1.DataBind();
                Label2.Visible = false;
                Label3.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            Label3.Visible = true;
            Label2.Text = "Dersin Maksimum Kontenjanı: "+ DropDownList1.SelectedValue.ToString();
            Label3.Text = "DİKKAT! Her Dersin Minimum Kontenjanı 5'dir.";
           
        }
    }
}