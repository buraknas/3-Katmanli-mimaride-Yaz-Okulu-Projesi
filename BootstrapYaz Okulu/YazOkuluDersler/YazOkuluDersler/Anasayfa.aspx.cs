using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad= TextBox1.Text;
            ent.Soyad =TextBox2.Text ;
            ent.Sifre =TextBox4.Text;
            ent.Foto =TextBox5.Text ;
            ent.Numara =TextBox3.Text ;
            BLLOgrenci.OgrenciEkleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}