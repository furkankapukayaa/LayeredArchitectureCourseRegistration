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
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre.Ad);
            komut.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut.Parameters.AddWithValue("@p3", parametre.Numara);
            komut.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("select * from TBLOGRENCI", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("delete from TBLOGRENCI where OGRID=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("select * from TBLOGRENCI where OGRID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("update TBLOGRENCI set OGRAD=@P1,OGRSOYAD=@P2,OGRNUMARA=@P3,OGRSIFRE=@P4,OGRFOTO=@P5 where OGRID=@P6", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", deger.Ad);
            komut.Parameters.AddWithValue("@P2", deger.Soyad);
            komut.Parameters.AddWithValue("@P3", deger.Numara);
            komut.Parameters.AddWithValue("@P4", deger.Sifre);
            komut.Parameters.AddWithValue("@P5", deger.Fotograf);
            komut.Parameters.AddWithValue("@P6", deger.Id);
            return komut.ExecuteNonQuery() > 0;
        }

    }
}
