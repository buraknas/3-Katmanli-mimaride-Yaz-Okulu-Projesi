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
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Ogrenci (OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSifre) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre.Ad);
            komut.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut.Parameters.AddWithValue("@p3", parametre.Numara);
            komut.Parameters.AddWithValue("@p4", parametre.Foto);
            komut.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListele()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogrenci", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(oku["OgrId"].ToString());
                ent.Ad = oku["OgrAd"].ToString();
                ent.Soyad = oku["OgrSoyad"].ToString();
                ent.Numara = oku["OgrNumara"].ToString();
                ent.Foto = oku["OgrFoto"].ToString();
                ent.Sifre = oku["OgrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(oku["OgrBakiye"].ToString());
                degerler.Add(ent);
            }
            oku.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Ogrenci Where OgrId=@p1", Baglanti.bgl);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int p)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();

            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogrenci Where OgrId=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", p);
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = (oku["OgrAd"].ToString());
                ent.Soyad =(oku["OgrSoyad"].ToString());
                ent.Numara = (oku["OgrNumara"].ToString());
                ent.Foto = (oku["OgrFoto"].ToString());
                ent.Sifre = (oku["OgrSifre"].ToString());
                ent.Bakiye = Convert.ToDouble(oku["OgrBakiye"].ToString());
                degerler.Add(ent);

            }
            oku.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci p)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Ogrenci set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrFoto=@p4,OgrSifre=@p5 Where OgrId=@p6",Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", p.Ad);
            komut.Parameters.AddWithValue("@p2", p.Soyad);
            komut.Parameters.AddWithValue("@p3", p.Numara);
            komut.Parameters.AddWithValue("@p4", p.Foto);
            komut.Parameters.AddWithValue("@p5", p.Sifre);
            komut.Parameters.AddWithValue("@p6", p.Id);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
