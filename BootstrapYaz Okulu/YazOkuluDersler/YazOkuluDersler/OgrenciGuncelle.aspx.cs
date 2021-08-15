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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
int x = Convert.ToInt32(Request.QueryString["OgrId"]);
            TextBox6.Text = x.ToString();
            TextBox6.Enabled = false;
            if(Page.IsPostBack==false)
            {
            EntityOgrenci ent = new EntityOgrenci();
            List<EntityOgrenci> OgrList = BLLOgrenci.OgrenciDetayBll(x);

            TextBox1.Text = OgrList[0].Ad.ToString();
            TextBox2.Text = OgrList[0].Soyad.ToString();
            TextBox3.Text = OgrList[0].Numara.ToString();
            TextBox4.Text = OgrList[0].Foto.ToString();
            TextBox5.Text = OgrList[0].Sifre.ToString();

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TextBox1.Text;
            ent.Soyad = TextBox2.Text;
            ent.Numara = TextBox3.Text;
            ent.Foto = TextBox4.Text;
            ent.Sifre = TextBox5.Text;
            ent.Id = Convert.ToInt32(TextBox6.Text.ToString());
            BLLOgrenci.OgrenciGuncelleBLL(ent);

            
        }
    }
}