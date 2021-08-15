using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Dersler", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Dersid = Convert.ToInt32(oku["DersId"].ToString());
                ent.Dersad = oku["DersAd"].ToString();
                degerler.Add(ent);
            }
            oku.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parameters)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_BasvuruForm (OgrenciId,DersId) values(@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parameters.Basogrid);
            komut.Parameters.AddWithValue("@p2", parameters.Basdersid);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
