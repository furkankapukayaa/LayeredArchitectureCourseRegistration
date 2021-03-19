using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
   public class BLL_Ogretmen
    {
        public static int OgretmenEkleBLL(EntityOgretmen p)
        {
            if (p.Ogrtad != null && p.Ogrtbrans > 0)
            {
                return DALOgretmen.OgretmenEkle(p);
            }
            return -1;
        }

        public static List<EntityOgretmen> BLLListele()
        {
            return DALOgretmen.OgretmenListesi();
        }

        public static bool OgretmenSilBLL(int p)
        {
            if (p > 0)
            {
                return DALOgretmen.OgretmenSil(p);
            }
            return false;
        }

        public static List<EntityOgretmen> BLLDetay(int p)
        {
            return DALOgretmen.OgretmenDetay(p);
        }

        public static bool OgretmenGuncelleBLL(EntityOgretmen p)
        {
            if (p.Ogrtad != null && p.Ogrtad != "" && p.Ogrtbrans > 0 &&  p.Ogrtid > 0)
            {
                return DALOgretmen.OgretmenGuncelle(p);
            }
            return false;
        }
    }
}
