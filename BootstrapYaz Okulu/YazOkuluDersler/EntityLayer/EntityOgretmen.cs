using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogrtid;
        private int ogrtbrans;
        private string ogrtadsoyad;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public int Ogrtbrans { get => ogrtbrans; set => ogrtbrans = value; }
        public string Ogrtadsoyad { get => ogrtadsoyad; set => ogrtadsoyad = value; }
    }
}
