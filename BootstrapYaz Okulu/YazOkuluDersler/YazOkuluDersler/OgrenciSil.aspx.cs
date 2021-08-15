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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrId"]);
            EntityOgrenci ent = new EntityOgrenci();
            ent.Id = x;
            BLLOgrenci.OgrenciSilBLL(ent.Id);
            Response.Redirect("OgrenciListesi.aspx");
            
        }
    }
}