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
    public class DALOgretmen
    {
        public static int OgretmenEkle(EntityOgretmen parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLOGRETMEN (OGRTADSOYAD,OGRTBRANS) values (@p1,@p2)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre.Ogrtad);
            komut.Parameters.AddWithValue("@p2", parametre.Ogrtbrans);
            return komut.ExecuteNonQuery();
        }

        public static List<EntityOgretmen> OgretmenListesi()
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("select * from TBLOGRETMEN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.Ogrtid = Convert.ToInt32(dr["OGRTID"].ToString());
                ent.Ogrtad = dr["OGRTADSOYAD"].ToString();
                ent.Ogrtbrans = Convert.ToInt32(dr["OGRTBRANS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgretmenSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("delete from TBLOGRETMEN where OGRTID=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgretmen> OgretmenDetay(int id)
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("select * from TBLOGRETMEN where OGRTID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.Ogrtad = dr["OGRTADSOYAD"].ToString();
                ent.Ogrtbrans = Convert.ToInt32(dr["OGRTBRANS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgretmenGuncelle(EntityOgretmen deger)
        {
            SqlCommand komut = new SqlCommand("update TBLOGRETMEN set OGRTADSOYAD=@P1,OGRTBRANS=@P2 where OGRTID=@P3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", deger.Ogrtad);
            komut.Parameters.AddWithValue("@P2", deger.Ogrtbrans);
            komut.Parameters.AddWithValue("@P3", deger.Ogrtid);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
