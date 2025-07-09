using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace HastaneYonetimSistemiUygulamasi
{
    public partial class FrmEkle : Form
    {
        public FrmEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ert = new Form1();
            ert.Show();
            this.Hide();
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
           
           
        }

        private void FrmEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
