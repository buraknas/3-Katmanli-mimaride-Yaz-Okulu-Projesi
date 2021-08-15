using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;


namespace YazOkuluDersler
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> ent = BLLDers.BLLDersListesi();
                DropDownList1.DataSource = BLLDers.BLLDersListesi();
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "DersId";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.Basdersid = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            ent.Basogrid = Convert.ToInt32(TextBox1.Text);
            BLLDers.DersTalepBLL(ent);
        }
    }



}