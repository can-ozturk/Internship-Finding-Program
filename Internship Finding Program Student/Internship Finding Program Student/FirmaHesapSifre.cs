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
    public partial class FirmaHesapSifre : Form
    {
        public FirmaHesapSifre()
        {
            InitializeComponent();
        }

        SqlConnection baglanti; // SQL'e bağlantı sağlamak için 'baglanti' adında bir SqlConnection belirledim.
        Baglanti baglanti1 = new Baglanti(); // Bağlantı adresi için 'Baglanti' sınıfından bir nesne oluşturdum.
        SqlDataReader okuma; // SQL komutlarını okumak için 'DataReader' belirledim.

        public int id;
        public string dil, isim1, firmano;

        private void YoneticiHesapSifre_Shown(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglanti1.adres); // Bağlantıyı 'adres' ile başlatıyorum.
            YeniSifre_Label.Visible = false; // Yeni şifre etiketini başlangıçta görünmez yapıyorum.
            YeniSifre_Textbox.Visible = false; // Yeni şifre kutusunu başlangıçta görünmez yapıyorum.
            Guncelle_Button.Visible = false; // Güncelle butonunu başlangıçta görünmez yapıyorum.
            YeniSifre_Textbox.Clear(); // Yeni şifre kutusunu temizliyorum.

            // Dil seçimlerine göre dildeki metinleri ayarlıyorum
            if (dil == "Türkçe")
            {
                MevcutSifre_Label.Text = "MEVCUT ŞİFRE"; // Türkçe dilinde mevcut şifre etiketi
                MevcutSifre_Textbox.PlaceholderText = "Mevcut Şifrenizi Girin"; // Placeholder (yardımcı metin)
                Onayla_Button.Text = "ONAYLA"; // Onayla butonu metni
                YeniSifre_Label.Text = "YENİ ŞİFRE"; // Yeni şifre etiketi
                YeniSifre_Textbox.PlaceholderText = "Yeni Şifrenizi Giriniz"; // Placeholder
                Guncelle_Button.Text = "GÜNCELLE"; // Güncelle butonu metni
                this.Text = "ŞİFRE DEĞİŞTİR"; // Form başlığı
            }
            else if (dil == "English")
            {
                MevcutSifre_Label.Text = "CURRENT PASSWORD"; // İngilizce dilinde mevcut şifre etiketi
                Onayla_Button.Text = "CONFIRM"; // Onayla butonu metni
                YeniSifre_Label.Text = "NEW PASSWORD"; // Yeni şifre etiketi
                YeniSifre_Textbox.PlaceholderText = "Enter Your New Password"; // Placeholder
                Guncelle_Button.Text = "UPDATE"; // Güncelle butonu metni
                MevcutSifre_Textbox.PlaceholderText = "Enter Your Current Password"; // Placeholder
                this.Text = "CHANGE PASSWORD"; // Form başlığı
            }
        }

        private void YoneticiHesapSifre_FormClosing(object sender, FormClosingEventArgs e)
        {
            FirmaHesapAyarlari firmaHesapAyarlari = new FirmaHesapAyarlari(); // Firma hesap ayarları formu oluşturuluyor.
            firmaHesapAyarlari.id = id; // Formda kullanıcı ID'si atanıyor.
            firmaHesapAyarlari.dil = dil; // Dil ayarı atanıyor.
            firmaHesapAyarlari.isim1 = isim1; // İsim atanıyor.
            firmaHesapAyarlari.firmano = firmano; // Firma numarası atanıyor.
            firmaHesapAyarlari.Show(); // Firma hesap ayarları formunu gösteriyorum.
            this.Hide(); // Mevcut formu gizliyorum.
        }

        private void Guncelle_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres); // Bağlantıyı açıyorum.
                SqlCommand komut = new SqlCommand(); // SQL komutları için yeni bir komut oluşturuyorum.

                if (dil == "Türkçe")
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open(); // Bağlantı kapalıysa, bağlantıyı açıyorum.
                    komut.Connection = baglanti; // Komutun bağlantısını ekliyorum.
                    komut.CommandText = "update Yonetici_Kayit set Yonetici_Sifre=@sifre where Yonetici_ID=" + id + ""; // Şifre güncelleme SQL komutu.
                    komut.Parameters.AddWithValue("@sifre", YeniSifre_Textbox.Text); // Yeni şifreyi parametre olarak ekliyorum.

                    if (YeniSifre_Textbox.Text == "") // Yeni şifre kutusu boşsa uyarı gösteriyorum.
                    {
                        MessageBox.Show("LÜTFEN LÜTFEN YENİ ŞİFRENİZİ GİRİN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut.ExecuteNonQuery(); // SQL komutunu çalıştırıyorum.
                        MessageBox.Show("BAŞARIYLA GÜNCELLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Formdaki öğeleri güncelliyorum.
                        YeniSifre_Textbox.Clear();
                        MevcutSifre_Textbox.Clear();
                        YeniSifre_Label.Visible = false;
                        YeniSifre_Textbox.Visible = false;
                        Guncelle_Button.Visible = false;
                        MevcutSifre_Label.Visible = true;
                        MevcutSifre_Textbox.Visible = true;
                        Onayla_Button.Visible = true;
                        baglanti.Close(); // Bağlantıyı kapatıyorum.
                    }
                    baglanti.Close(); // Bağlantıyı tekrar kapatıyorum.
                }
                else if (dil == "English")
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open(); // Bağlantıyı açıyorum.
                    komut.Connection = baglanti;
                    komut.CommandText = "update Yonetici_Kayit set Yonetici_Sifre=@sifre where Yonetici_ID=" + id + ""; // Şifre güncelleme SQL komutu.
                    komut.Parameters.AddWithValue("@sifre", YeniSifre_Textbox.Text); // Yeni şifreyi parametre olarak ekliyorum.

                    if (YeniSifre_Textbox.Text == "") // Yeni şifre kutusu boşsa uyarı gösteriyorum.
                    {
                        MessageBox.Show("PLEASE ENTER YOUR NEW PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut.ExecuteNonQuery(); // SQL komutunu çalıştırıyorum.
                        MessageBox.Show("SUCCESSFULLY UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Formdaki öğeleri güncelliyorum.
                        YeniSifre_Textbox.Clear();
                        MevcutSifre_Textbox.Clear();
                        YeniSifre_Label.Visible = false;
                        YeniSifre_Textbox.Visible = false;
                        Guncelle_Button.Visible = false;
                        MevcutSifre_Label.Visible = true;
                        MevcutSifre_Textbox.Visible = true;
                        Onayla_Button.Visible = true;
                        baglanti.Close(); // Bağlantıyı kapatıyorum.
                    }
                    baglanti.Close(); // Bağlantıyı tekrar kapatıyorum.
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
                baglanti = new SqlConnection(baglanti1.adres); // Bağlantıyı açıyorum.
                string sifre = MevcutSifre_Textbox.Text; // Mevcut şifreyi alıyorum.

                SqlCommand komut = new SqlCommand(); // SQL komutları için yeni bir komut oluşturuyorum.

                baglanti.Open(); // Bağlantıyı açıyorum.
                komut.Connection = baglanti; // Komutun bağlantısını ekliyorum.
                komut.CommandText = "Select * from Yonetici_Kayit where Yonetici_Sifre='" + sifre + "'"; // Mevcut şifreyi kontrol etme komutu.
                okuma = komut.ExecuteReader(); // SQL komutunu çalıştırıp, okuma işlemi yapıyorum.
                if (okuma.Read()) // Eğer şifre doğruysa
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
                        baglanti.Close(); // Bağlantıyı kapatıyorum.
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
                        baglanti.Close(); // Bağlantıyı kapatıyorum.
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
                    baglanti.Close(); // Bağlantıyı kapatıyorum.
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
            Gorunur_Picturebox.Visible = true; // Şifreyi görünüre açan butonu gösteriyorum.
            Gorunmez_Picturebox.Visible = false; // Şifreyi görünür yapabilen butonu gizliyorum.
            MevcutSifre_Textbox.PasswordChar = '*'; // Şifreyi '*' olarak gizliyorum.
            YeniSifre_Textbox.PasswordChar = '*'; // Yeni şifreyi '*' olarak gizliyorum.
        }

        private void Gorunur_Picturebox_Click(object sender, EventArgs e)
        {
            Gorunur_Picturebox.Visible = false; // Şifreyi göstermeye yarayan butonu gizliyorum.
            Gorunmez_Picturebox.Visible = true; // Şifreyi gizleyen butonu gösteriyorum.
            YeniSifre_Textbox.PasswordChar = '\0'; // Şifreyi açık olarak gösteriyorum.
            MevcutSifre_Textbox.PasswordChar = '\0'; // Mevcut şifreyi açık olarak gösteriyorum.
        }
    }
}
