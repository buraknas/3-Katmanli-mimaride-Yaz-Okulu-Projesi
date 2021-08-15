using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BLLDersListesi()
        {
            return DALDers.DersListesi();
        }
        public static int DersTalepBLL(EntityBasvuruForm p)
        {
            if (p.Basogrid != null && p.Basdersid != null)
            {
                return DALDers.TalepEkle(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
