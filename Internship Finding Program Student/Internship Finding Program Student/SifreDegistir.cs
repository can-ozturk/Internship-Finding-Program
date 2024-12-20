using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Internship_Finding_Program_Student
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti; //SQL' e bağlantı sağlamak için baglanti adında bir SqlConnection belirledim.
        Baglanti baglanti1 = new Baglanti();
        SqlDataReader okuma; //SQL komutlarını okumak için DataReader belirledim.

        public string dil;
        public int no;

        private void SifreDegistir_Shown(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglanti1.adres);
            YeniSifre_Label.Visible = false;
            YeniSifre_Textbox.Visible = false;
            Guncelle_Button.Visible = false;
            YeniSifre_Textbox.Clear();

            if (dil == "Türkçe")
            {
                MevcutSifre_Label.Text = "MEVCUT ŞİFRE";
                MevcutSifre_Textbox.PlaceholderText = "Mevcut Şifrenizi Girin";
                Onayla_Button.Text = "ONAYLA";
                YeniSifre_Label.Text = "YENİ ŞİFRE";
                YeniSifre_Textbox.PlaceholderText = "Yeni Şifrenizi Giriniz";
                Guncelle_Button.Text = "GÜNCELLE";
                this.Text = "ŞİFRE DEĞİŞTİR";

            }
            else if (dil == "English")
            {
                MevcutSifre_Label.Text = "CURRENT PASSWORD";
                Onayla_Button.Text = "CONFIRM";
                YeniSifre_Label.Text = "NEW PASSWORD";
                YeniSifre_Textbox.PlaceholderText = "Enter Your New Password";
                Guncelle_Button.Text = "UPDATE";
                MevcutSifre_Textbox.PlaceholderText = "Enter Your Current Password";
                this.Text = "CHANGE PASSWORD";


            }
        }

        private void SifreDegistir_FormClosing(object sender, FormClosingEventArgs e)
        {
            HesapAyarlari hesapAyarlari = new HesapAyarlari();
            hesapAyarlari.dil = dil;
            hesapAyarlari.no = no;
            hesapAyarlari.Show();
            this.Hide();
        }

        private void Guncelle_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);

                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

                if (dil == "Türkçe")
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Eğer bağlantı kapalıysa, bağlantıyı açıyoruz.
                    komut.Connection = baglanti; // Komutun bağlantısını ekliyoruz.
                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Sifre=@sifre where Ogrenci_No=" + no + "";  // E-Posta adresini değiştrimek için SQL komutu yazdım.

                    komut.Parameters.AddWithValue("@sifre", YeniSifre_Textbox.Text);
                    if (YeniSifre_Textbox.Text == "") // Alanlardan biri boşsa hata mesajı gösteriyoruz.
                    {
                        MessageBox.Show("LÜTFEN LÜTFEN YENİ ŞİFRENİZİ GİRİN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Eğer tüm alanlar doluysa SQL sorgusunu çalıştırıyoruz.
                        komut.ExecuteNonQuery();
                        MessageBox.Show("BAŞARIYLA GÜNCELLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                        YeniSifre_Textbox.Clear();
                        MevcutSifre_Textbox.Clear();
                        YeniSifre_Label.Visible = false;
                        YeniSifre_Textbox.Visible = false;
                        Guncelle_Button.Visible = false;
                        MevcutSifre_Label.Visible = true;
                        MevcutSifre_Textbox.Visible = true;
                        Onayla_Button.Visible = true;
                        baglanti.Close();
                    }
                    baglanti.Close();// Bağlantıyı kapatıyoruz.
                }
                else if (dil == "English")
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "UPDATE Ogrenci_Kayit SET Ogrenci_Sifre=@password WHERE Ogrenci_No=" + no + "";
                    komut.Parameters.AddWithValue("@password", YeniSifre_Textbox.Text);
                    if (YeniSifre_Textbox.Text == "")
                    {
                        MessageBox.Show("PLEASE ENTER YOUR NEW PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("SUCCESSFULLY UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YeniSifre_Textbox.Clear();
                        MevcutSifre_Textbox.Clear();
                        YeniSifre_Label.Visible = false;
                        YeniSifre_Textbox.Visible = false;
                        Guncelle_Button.Visible = false;
                        MevcutSifre_Label.Visible = true;
                        MevcutSifre_Textbox.Visible = true;
                        Onayla_Button.Visible = true;
                        baglanti.Close();
                    }
                    baglanti.Close();
                }
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR SORUN MEYDANA GELDİ \nLÜTFEN TEKRAR ŞİFREYİ GİRİNİZ VEYA YÖNETİCİYE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED \nPLEASE RE-ENTER YOUR PASSWORD OR CONTACT THE ADMINISTRATOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Onayla_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                string sifre = MevcutSifre_Textbox.Text;

                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

                baglanti.Open(); //bağlantımı açtım
                komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select * from Ogrenci_Kayit where Ogrenci_Sifre='" + sifre + "'"; 
                okuma = komut.ExecuteReader(); //okuma adlı değişkene atarak bu komutu çalıştırdım
                if (okuma.Read())//Ogr_Sifre doğru ise çalışacak komut
                {
                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("DOĞRU ŞİFRE ŞİMDİ YENİ ŞİFRENİZİ GİRİNİZ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YeniSifre_Label.Visible = true;
                        MevcutSifre_Textbox.Clear();
                        YeniSifre_Textbox.Visible = true;
                        Guncelle_Button.Visible = true;
                        MevcutSifre_Label.Visible = false;
                        MevcutSifre_Textbox.Visible = false;
                        Onayla_Button.Visible = false;
                        baglanti.Close();
                    }
                    else if (dil == "English")
                    {

                        MessageBox.Show("CORRECT PASSWORD, NOW ENTER YOUR NEW PASSWORD", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YeniSifre_Label.Visible = true;
                        MevcutSifre_Textbox.Clear();
                        YeniSifre_Textbox.Visible = true;
                        Guncelle_Button.Visible = true;
                        MevcutSifre_Label.Visible = false;
                        MevcutSifre_Textbox.Visible = false;
                        Onayla_Button.Visible = false;
                        baglanti.Close();
                    }

                }
                else
                {
                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("ŞİFRE YANLIŞ TEKRARDAN DENEYİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (dil == "English")
                    {
                        MessageBox.Show("WRONG PASSWORD, PLEASE TRY AGAIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    baglanti.Close();
                }
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR SORUN MEYDANA GELDİ \nLÜTFEN TEKRAR ŞİFREYİ GİRİNİZ VEYA YÖNETİCİYE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED \nPLEASE RE-ENTER YOUR PASSWORD OR CONTACT THE ADMINISTRATOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        }

        private void Gorunmez_Picturebox_Click(object sender, EventArgs e)
        {
            Gorunur_Picturebox.Visible = true;
            Gorunmez_Picturebox.Visible = false;
            MevcutSifre_Textbox.PasswordChar = '*'; //tikli değil ise göstermeyecek
            YeniSifre_Textbox.PasswordChar = '*';
        }

        private void Gorunur_Picturebox_Click(object sender, EventArgs e)
        {
            Gorunur_Picturebox.Visible = false;
            Gorunmez_Picturebox.Visible = true;
            YeniSifre_Textbox.PasswordChar = '\0';
            MevcutSifre_Textbox.PasswordChar = '\0'; //sifreyi göster tikli ise şifreyi gösterecek
           
        }
    }
}
        
    

