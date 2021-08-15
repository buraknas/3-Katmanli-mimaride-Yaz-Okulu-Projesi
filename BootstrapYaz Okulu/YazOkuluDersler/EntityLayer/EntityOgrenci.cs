using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int id;
        private string ad;
        private string soyad;
        private string numara;
        private string foto;
        private string sifre;
        private double bakiye;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
    }
}
