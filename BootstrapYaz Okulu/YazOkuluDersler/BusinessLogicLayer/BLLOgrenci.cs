using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;


namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Foto != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static List<EntityOgrenci> OgrenciListesiBLL()
        {
            return DALOgrenci.OgrenciListele();

        }
        public static bool OgrenciSilBLL(int parametre)
        {
            if(parametre>=0)
            {
                 return DALOgrenci.OgrenciSil(parametre);
            }
            else
            {
                return false;
            }
        }
        public static List<EntityOgrenci> OgrenciDetayBll(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Foto != null && p.Id>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            else
            {
                return false;
            }
        }
    }
}
