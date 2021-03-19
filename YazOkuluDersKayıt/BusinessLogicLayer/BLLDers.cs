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
        public static List<EntityDers> BLLListele()
        {
            return DALDers.DersListesi();
        }
        
        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if (p.Basogrid > 0 && p.Basdersid > 0)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
