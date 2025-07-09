using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Npgsql;

namespace HastaneYonetimSistemiUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection(
        "server=localHost; port=5432; Database=HastaneYonetimSistemi; user ID=postgres; password=182103");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu =
            "SELECT ad, soyad ,uzmanlik_adi,dogum_tarihi,telefon,ulke_adi,il_adi ,ilce_adi,cinsiyet,maas_tutari,odeme_durumu " +
            "FROM doktor " +
            "INNER JOIN personel ON personel.personel_id = doktor.personel_id " +
            "INNER JOIN uzmanlik_alani ON uzmanlik_alani.uzmanlik_id = doktor.uzmanlik_id " +
            "INNER JOIN iletisim_bilgileri ON personel.iletisim_bilgileri_id = iletisim_bilgileri.iletisim_id " +
            "INNER JOIN ulke_bilgileri ON iletisim_bilgileri.ulke_id = ulke_bilgileri.ulke_id " +
            "INNER JOIN il_bilgileri ON ulke_bilgileri.il_id = il_bilgileri.il_id " +
            "INNER JOIN ilce_bilgileri ON il_bilgileri.ilce_id = ilce_bilgileri.ilce_id " +
            "INNER JOIN cinsiyet ON personel.cinsiyet_id = cinsiyet.cinsiyet_id " +
            "INNER JOIN maas_bilgileri ON personel.maas_id = maas_bilgileri.maas_id " +
            "INNER JOIN maas_odeme_durumu ON maas_bilgileri.odeme_durumu_id = maas_odeme_durumu.odeme_durumu_id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            //////////////////////////////////////////////////////////////////////////////////////////////////
            string sorgu2 =
            "SELECT ad, soyad,uzmanlik_adi ,dogum_tarihi,telefon,ulke_adi,il_adi ,ilce_adi,cinsiyet,maas_tutari,odeme_durumu " +
            "FROM teknisyen " +
            "INNER JOIN personel ON personel.personel_id = teknisyen.personel_id "+
            "INNER JOIN uzmanlik_alani ON uzmanlik_alani.uzmanlik_id = teknisyen.uzmanlik_id "+
            "INNER JOIN iletisim_bilgileri ON personel.iletisim_bilgileri_id = iletisim_bilgileri.iletisim_id " +
            "INNER JOIN ulke_bilgileri ON iletisim_bilgileri.ulke_id = ulke_bilgileri.ulke_id " +
            "INNER JOIN il_bilgileri ON ulke_bilgileri.il_id = il_bilgileri.il_id " +
            "INNER JOIN ilce_bilgileri ON il_bilgileri.ilce_id = ilce_bilgileri.ilce_id " +
            "INNER JOIN cinsiyet ON personel.cinsiyet_id = cinsiyet.cinsiyet_id " +
            "INNER JOIN maas_bilgileri ON personel.maas_id = maas_bilgileri.maas_id " +
            "INNER JOIN maas_odeme_durumu ON maas_bilgileri.odeme_durumu_id = maas_odeme_durumu.odeme_durumu_id";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
            //////////////////////////////////////////////////////////////////////////////////////////////////
            string sorgu3 =
            "SELECT ad, soyad ,uzmanlik_adi,dogum_tarihi,telefon,ulke_adi,il_adi ,ilce_adi,cinsiyet,maas_tutari,odeme_durumu " +
            "FROM hemsire " +
            "INNER JOIN personel ON personel.personel_id = hemsire.personel_id "+
            "INNER JOIN uzmanlik_alani ON uzmanlik_alani.uzmanlik_id = hemsire.uzmanlik_id "+
            "INNER JOIN iletisim_bilgileri ON personel.iletisim_bilgileri_id = iletisim_bilgileri.iletisim_id " +
            "INNER JOIN ulke_bilgileri ON iletisim_bilgileri.ulke_id = ulke_bilgileri.ulke_id " +
            "INNER JOIN il_bilgileri ON ulke_bilgileri.il_id = il_bilgileri.il_id " +
            "INNER JOIN ilce_bilgileri ON il_bilgileri.ilce_id = ilce_bilgileri.ilce_id " +
            "INNER JOIN cinsiyet ON personel.cinsiyet_id = cinsiyet.cinsiyet_id " +
            "INNER JOIN maas_bilgileri ON personel.maas_id = maas_bilgileri.maas_id " +
            "INNER JOIN maas_odeme_durumu ON maas_bilgileri.odeme_durumu_id = maas_odeme_durumu.odeme_durumu_id";
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu3, baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            dataGridView3.DataSource = ds3.Tables[0];
            //////////////////////////////////////////////////////////////////////////////////////////////////
            string sorgu4 =
            "SELECT ad, soyad ,tarih,baslama_saati,bitis_saati "+
            "FROM personel_vardiyalari "+
            "INNER JOIN personel ON personel.personel_id = personel_vardiyalari.personel_id "+
            "INNER JOIN vardiyalar ON personel_vardiyalari.vardiya_id = vardiyalar.vardiya_id ";
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sorgu4, baglanti);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            dataGridView4.DataSource = ds4.Tables[0];
            //////////////////////////////////////////////////////////////////////////////////////////////////
            string sorgu5 =
            "SELECT personel.ad , personel.soyad ,personel_yakini.ad, personel_yakini.soyad "+
            "FROM personel_yakini "+
            "INNER JOIN personel ON personel.personel_id = personel_yakini.personel_id";
            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(sorgu5, baglanti);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            dataGridView5.DataSource = ds5.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
