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
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["DERSID"].ToString());
                ent.Dersad = dr["DERSAD"].ToString();
                ent.Min = int.Parse(dr["DERSMINKONT"].ToString());
                ent.Max = int.Parse(dr["DERSMAKSKONT"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBASVURUFORM (OGRENCIID,DERSID) values (@P1,@P2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", parametre.Basogrid);
            komut.Parameters.AddWithValue("@P2", parametre.Basdersid);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
