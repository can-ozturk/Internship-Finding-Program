using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Internship_Finding_Program_Student
{
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti; // SQL veritabanı bağlantısı için SqlConnection nesnesi oluşturuluyor.
        Baglanti baglanti1 = new Baglanti(); // Bağlantı bilgilerini tutan sınıfın örneği
        SqlDataReader okuma, isim; // SQL verilerini okuma işlemi için DataReader nesneleri
        public string isim1 = "", dil; // Yönetici adı ve dil değişkenleri tanımlanıyor.

        private void YoneticiGiris_Shown(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglanti1.adres); // Bağlantı adresiyle SqlConnection nesnesi oluşturuluyor.
            Language turkce = new Language(); // Türkçe dil seçeneği
            Language english = new English(); // İngilizce dil seçeneği
            DilDegistir_Combobox.Items.Add(turkce); // ComboBox'a dil seçenekleri ekleniyor
            DilDegistir_Combobox.Items.Add(english); // ComboBox'a dil seçenekleri ekleniyor
            DilDegistir_Combobox.SelectedIndex = 0; // Varsayılan dil Türkçe olarak seçiliyor.

            // Dil ayarları kontrol ediliyor ve ComboBox'ta uygun dil seçiliyor.
            if (dil == "Türkçe")
            {
                DilDegistir_Combobox.SelectedIndex = 0;
            }
            else if (dil == "English")
            {
                DilDegistir_Combobox.SelectedIndex = 1;
            }
        }

        private void DilDegistir_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DilDegistir_Combobox.SelectedIndex == 0)
            {
                English_Picturebox.Visible = false; // İngilizce görseli gizleniyor
                Turkey_Picturebox.Visible = true; // Türkçe görseli gösteriliyor
                Giris_Label.Text = "YÖNETİCİ STAJ SİSTEMİ GİRİŞ"; // Başlık Türkçe olarak değiştiriliyor.
                ID_Label.Text = "ID"; // ID etiketinin metni Türkçe olarak değiştiriliyor.
                YoneticiSifre_Label.Text = "ŞİFRE"; // Şifre etiketinin metni Türkçe olarak değiştiriliyor.
                Giris_Button.Text = "GİRİŞ"; // Giriş butonunun metni Türkçe olarak değiştiriliyor.
                DilDegistir_Label.Text = "DİL DEĞİŞTİR"; // Dil değiştir etiketinin metni Türkçe olarak değiştiriliyor.
                SorunBildir_Linklabel.Text = "SORUN BİLDİR "; // Sorun bildir linkinin metni Türkçe olarak değiştiriliyor.
                ID_Textbox.PlaceholderText = "ID"; // ID TextBox'ının placeholder metni Türkçe olarak değiştiriliyor.
                YoneticiSifre_Textbox.PlaceholderText = "Şifre"; // Şifre TextBox'ının placeholder metni Türkçe olarak değiştiriliyor.
                this.Text = "Yönetici Giriş"; // Form başlığı Türkçe olarak değiştiriliyor.
            }
            else if (DilDegistir_Combobox.SelectedIndex == 1)
            {
                English_Picturebox.Visible = true; // İngilizce görseli gösteriliyor
                Turkey_Picturebox.Visible = false; // Türkçe görseli gizleniyor
                Giris_Label.Text = "ADMIN INTERNSHIP SYSTEM LOGIN"; // Başlık İngilizce olarak değiştiriliyor.
                ID_Label.Text = "ID"; // ID etiketinin metni İngilizce olarak değiştiriliyor.
                YoneticiSifre_Label.Text = "PASSWORD"; // Şifre etiketinin metni İngilizce olarak değiştiriliyor.
                Giris_Button.Text = "LOGIN"; // Giriş butonunun metni İngilizce olarak değiştiriliyor.
                DilDegistir_Label.Text = "CHANGE LANGUAGE"; // Dil değiştir etiketinin metni İngilizce olarak değiştiriliyor.
                SorunBildir_Linklabel.Text = "REPORT AN ISSUE"; // Sorun bildir linkinin metni İngilizce olarak değiştiriliyor.
                ID_Textbox.PlaceholderText = "ID"; // ID TextBox'ının placeholder metni İngilizce olarak değiştiriliyor.
                YoneticiSifre_Textbox.PlaceholderText = "Password"; // Şifre TextBox'ının placeholder metni İngilizce olarak değiştiriliyor.
                this.Text = "Admin Login"; // Form başlığı İngilizce olarak değiştiriliyor.
            }
            // Bu kısımda dil değişikliği için gerekli işlemler yapılmaktadır.
        }

        private void Giris_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres); // Bağlantı adresi ile SqlConnection nesnesi oluşturuluyor.
                SqlCommand komut = new SqlCommand(); // SQL komutları için yeni bir SqlCommand nesnesi oluşturuluyor.

                int id = Convert.ToInt32(ID_Textbox.Text); // ID TextBox'ından alınan veri tamsayıya dönüştürülüyor.
                string sifre = YoneticiSifre_Textbox.Text; // Şifre TextBox'ından alınan veri string türünde saklanıyor.

                // Bağlantı açılıyor ve komut için bağlantı ayarlanıyor.
                baglanti.Open(); // Bağlantı açılıyor.
                komut.Connection = baglanti; // SQL komutunun bağlantısı ayarlanıyor.
                komut.CommandText = "Select Yonetici_Firma_Ad from Yonetici_Kayit where Yonetici_ID=" + id + ""; // Firma adı için SQL komutu yazılıyor.
                isim = komut.ExecuteReader(); // Veritabanından veri okuma işlemi başlatılıyor.
                while (isim.Read()) // Veriler okunuyor.
                {
                    isim1 = (isim["Yonetici_Firma_Ad"].ToString()); // Firma adı alınarak isim1 değişkenine atanıyor.
                }
                baglanti.Close(); // Bağlantı kapatılıyor.

                baglanti.Open(); // Bağlantı yeniden açılıyor.
                komut.Connection = baglanti; // SQL komutunun bağlantısı ayarlanıyor.
                komut.CommandText = "Select * from Yonetici_Kayit where Yonetici_ID='" + id + "'and Yonetici_Sifre='" + sifre + "'"; // ID ve şifrenin doğruluğu kontrol ediliyor.
                okuma = komut.ExecuteReader(); // Veritabanından veri okuma işlemi başlatılıyor.
                if (okuma.Read()) // Eğer doğru ID ve şifre varsa
                {
                    if (DilDegistir_Combobox.SelectedIndex == 0)
                    {
                        MessageBox.Show("Giriş Başarılı\nHoşgeldiniz Şu anda Sizi *" + isim1.ToString() + "* Adlı Firmanın Yönetici Paneline Yönlendiriyoruz..", "HOŞGELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information); // Başarı mesajı Türkçe olarak gösteriliyor.
                        YoneticiKontrolPaneli yoneticikontrolpaneli = new YoneticiKontrolPaneli(); // Yönetici kontrol paneli formu oluşturuluyor.
                        yoneticikontrolpaneli.dil = DilDegistir_Combobox.Text; // Dil seçeneği form nesnesine aktarılıyor.
                        yoneticikontrolpaneli.id = Convert.ToInt32(ID_Textbox.Text); // ID bilgisi form nesnesine aktarılıyor.
                        yoneticikontrolpaneli.isim1 = isim1; // Firma adı form nesnesine aktarılıyor.
                        baglanti.Close(); // Bağlantı kapatılıyor.
                        yoneticikontrolpaneli.Show(); // Yönetici kontrol paneli formu gösteriliyor.
                        this.Hide(); // Mevcut form gizleniyor.
                    }
                    else if (DilDegistir_Combobox.SelectedIndex == 1)
                    {
                        MessageBox.Show("Login Successful\nWelcome! We are currently redirecting you to the *" + isim1.ToString() + "* company's Admin Panel..", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        YoneticiKontrolPaneli yoneticikontrolpaneli = new YoneticiKontrolPaneli(); 
                        yoneticikontrolpaneli.dil = DilDegistir_Combobox.Text;
                        yoneticikontrolpaneli.id = Convert.ToInt32(ID_Textbox.Text); 
                        yoneticikontrolpaneli.isim1 = isim1; 
                        baglanti.Close(); 
                        yoneticikontrolpaneli.Show(); 
                        this.Hide(); 
                    }
                }
                else
                {
                    if (DilDegistir_Combobox.SelectedIndex == 0)
                    {
                        MessageBox.Show("GİRİLEN BİLGİLER YANLIŞ\nLÜTFEN ID VE ŞİFRENİZİ KONTROL EDİNİZ", "GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                    else if (DilDegistir_Combobox.SelectedIndex == 1)
                    {
                        MessageBox.Show("THE ENTERED INFORMATION IS INCORRECT\nPLEASE CHECK YOUR ID AND PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
                baglanti.Close(); // Bağlantı kapatılıyor.

            }
            catch
            {
                if (DilDegistir_Combobox.SelectedIndex == 0)
                {
                    MessageBox.Show("BİR HATA OLUŞTU TÜM ALANLARI DOLDURDUĞUNUZDAN EMİN OLUN\nVE TEKRAR DENEYİNİZ", "HAY AKSİ", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hata mesajı Türkçe olarak gösteriliyor.
                }
                else if (DilDegistir_Combobox.SelectedIndex == 1)
                {
                    MessageBox.Show("AN ERROR OCCURRED. MAKE SURE ALL FIELDS ARE FILLED IN\nAND TRY AGAIN", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void YoneticiGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); // Program sonlanıyor form kapatıldığında.
        }

        private void ID_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Yalnızca rakamların girilmesine izin veriliyor.
            }
        }

        private void Geridon_Picturebox_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris(); // Giriş formu oluşturuluyor.
            giris.dil = DilDegistir_Combobox.Text; // Dil bilgisi bir sonraki forma aktarılıyor.
            giris.Show(); // Giriş formu gösteriliyor.
            this.Hide(); // Mevcut form gizleniyor.
        }

        private void Gorunur_Picturebox_Click(object sender, EventArgs e)
        {
            Gorunur_Picturebox.Visible = false; // Şifreyi göster butonu gizleniyor.
            Gorunmez_Picturebox.Visible = true; // Şifreyi gizle butonu gösteriliyor.
            YoneticiSifre_Textbox.PasswordChar = '\0'; // Şifreyi gösteriyor.
        }

        private void Gorunmez_Picturebox_Click(object sender, EventArgs e)
        {
            Gorunur_Picturebox.Visible = true; // Şifreyi göster butonu gösteriliyor.
            Gorunmez_Picturebox.Visible = false; // Şifreyi gizle butonu gizleniyor.
            YoneticiSifre_Textbox.PasswordChar = '*'; // Şifreyi gizli tutuyor.
        }

        private void SorunBildir_Linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SorunBildir sorunBildir = new SorunBildir(); // Sorun bildir formu oluşturuluyor.
            sorunBildir.dil = DilDegistir_Combobox.Text; // Dil bilgisi form nesnesine aktarılıyor.
            sorunBildir.Show(); // Sorun bildir formu gösteriliyor.
        }
    }
}
