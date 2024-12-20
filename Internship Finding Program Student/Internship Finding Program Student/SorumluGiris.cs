using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Internship_Finding_Program_Student
{
    public partial class SorumluGiris : Form
    {
        public SorumluGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti; // SQL veritabanına bağlantı sağlamak için SqlConnection oluşturuldu.
        Baglanti baglanti1 = new Baglanti(); // Bağlantı sınıfından bir nesne oluşturuldu.
        SqlDataReader okuma, isim; // SQL komutlarını çalıştırmak ve veri almak için SqlDataReader kullanıldı.
        public string dil, isim1;
        public int id;

        private void SorumluGiris_Shown(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglanti1.adres); // Bağlantıyı açmak için bağlantı adresi alındı.
            Language turkce = new Language();
            Language english = new English();
            DilDegistir_Combobox.Items.Add(turkce); // Dil değiştirme comboboxına Türkçe dil seçeneği eklendi.
            DilDegistir_Combobox.Items.Add(english); // Dil değiştirme comboboxına İngilizce dil seçeneği eklendi.
            DilDegistir_Combobox.SelectedIndex = 0; // Varsayılan dil Türkçe olarak seçildi.

            if (dil == "Türkçe")
            {
                DilDegistir_Combobox.SelectedIndex = 0; // Eğer dil Türkçe ise, Türkçe seçeneği aktif edildi.
            }
            else if (dil == "English")
            {
                DilDegistir_Combobox.SelectedIndex = 1; // Eğer dil İngilizce ise, İngilizce seçeneği aktif edildi.
            }
        }

        private void Giris_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres); // Bağlantıyı yeniden açtık.
                int id = Convert.ToInt32(ID_Textbox.Text); // Kullanıcıdan alınan ID bilgisi tamsayıya dönüştürüldü.
                string sifre = Sifre_Textbox.Text; // Kullanıcıdan alınan şifre metin olarak saklandı.

                SqlCommand komut = new SqlCommand(); // SQL komutlarını çalıştırmak için yeni bir SqlCommand nesnesi oluşturuldu.

                baglanti.Open(); // Veritabanı bağlantısı açıldı.
                komut.Connection = baglanti;  // SQL bağlantısı komuta eklendi.
                komut.CommandText = "Select Sorumlu_Ad from Sorumlu_Tablosu where Sorumlu_ID=" + id + ""; // Sorumlu adı almak için SQL komutu yazıldı.
                isim = komut.ExecuteReader(); // Komut çalıştırıldı ve veri okundu.

                while (isim.Read()) // Okunan veriler üzerinde işlem yapılacak.
                {
                    isim1 = (isim["Sorumlu_Ad"].ToString()); // Sorumlu adı alındı ve isim1 değişkenine atandı.
                }
                baglanti.Close(); // Bağlantı kapatıldı.

                baglanti.Open(); // Bağlantı tekrar açıldı.
                komut.Connection = baglanti; // SQL bağlantısı komuta eklendi.
                komut.CommandText = "Select * from Sorumlu_Tablosu where Sorumlu_ID='" + id + "'and Sorumlu_Sifre='" + sifre + "'"; // ID ve şifre doğrulaması için SQL komutu yazıldı.
                okuma = komut.ExecuteReader(); // Komut çalıştırıldı ve veri okundu.

                if (okuma.Read()) // Eğer veritabanındaki ID ve şifre eşleşiyorsa.
                {
                    if (DilDegistir_Combobox.SelectedIndex == 0)
                    {
                        MessageBox.Show("Giriş Başarılı\nHoşgeldin: *" + isim1.ToString() + "* Sizi Yetkili Paneline Yönlendiriyoruz", "HOŞGELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information); // Türkçe hoşgeldiniz mesajı gösterildi.
                        SorumluKontrolPaneli sorumluKontrolPaneli = new SorumluKontrolPaneli(); // Yetkili panel için yeni bir nesne oluşturuldu.
                        sorumluKontrolPaneli.dil = DilDegistir_Combobox.Text; // Dil bilgisi yeni panele aktarıldı.
                        baglanti.Close(); // Bağlantı kapatıldı.
                        sorumluKontrolPaneli.Show(); // Yetkili panel gösterildi.
                        this.Hide(); // Bu form gizlendi.
                    }
                    else if (DilDegistir_Combobox.SelectedIndex == 1)
                    {
                        MessageBox.Show("Login Successful\nWelcome: *" + isim1.ToString() + "* We are redirecting you to the Admin Panel", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information); // İngilizce hoşgeldiniz mesajı gösterildi.
                        SorumluKontrolPaneli sorumluKontrolPaneli = new SorumluKontrolPaneli(); // Yetkili panel için yeni bir nesne oluşturuldu.
                        sorumluKontrolPaneli.dil = DilDegistir_Combobox.Text; // Dil bilgisi yeni panele aktarıldı.
                        baglanti.Close(); // Bağlantı kapatıldı.
                        sorumluKontrolPaneli.Show(); // Yetkili panel gösterildi.
                        this.Hide(); // Bu form gizlendi.
                    }
                }
                else
                {
                    if (DilDegistir_Combobox.SelectedIndex == 0)
                    {
                        MessageBox.Show("GİRİLEN BİLGİLER YANLIŞ\nLÜTFEN ID VE ŞİFRENİZİ KONTROL EDİNİZ", "GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error); // Yanlış bilgi girildiğinde hata mesajı gösterildi (Türkçe).
                    }
                    else if (DilDegistir_Combobox.SelectedIndex == 1)
                    {
                        MessageBox.Show("THE ENTERED INFORMATION IS INCORRECT\nPLEASE CHECK YOUR ID AND PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Yanlış bilgi girildiğinde hata mesajı gösterildi (İngilizce).
                    }
                }

                baglanti.Close(); // Bağlantı kapatıldı.

            }
            catch
            {
                if (DilDegistir_Combobox.SelectedIndex == 0)
                {
                    MessageBox.Show("BİR HATA OLUŞTU TÜM ALANLARI DOLDURDUĞUNUZDAN EMİN OLUN\nVE TEKRAR DENEYİNİZ", "HAY AKSİ", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hata durumunda kullanıcıya mesaj gösterildi (Türkçe).
                }
                else if (DilDegistir_Combobox.SelectedIndex == 1)
                {
                    MessageBox.Show("AN ERROR OCCURRED. MAKE SURE ALL FIELDS ARE FILLED IN\nAND TRY AGAIN", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hata durumunda kullanıcıya mesaj gösterildi (İngilizce).
                }
            }
        }

        private void ID_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // ID textboxına yalnızca rakam girilmesine izin verilir.
            {
                e.Handled = true; // Karakteri engeller.
            }
        }

        private void DilDegistir_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DilDegistir_Combobox.SelectedIndex == 0)
            {
                English_Picturebox.Visible = false; // Türkçe dil seçildiğinde İngilizce bayrağı gizlendi.
                Turkey_Picturebox.Visible = true; // Türkçe bayrağı gösterildi.
                Giris_Label.Text = "SORUMLU GİRİŞ SİSTEMİ"; // Türkçe başlık.
                ID_Label.Text = "ID"; // Türkçe ID etiket.
                Sifre_Label.Text = "ŞİFRE"; // Türkçe şifre etiket.
                Giris_Button.Text = "GİRİŞ"; // Türkçe giriş butonu.
                DilDegistir_Label.Text = "DİL DEĞİŞTİR"; // Türkçe dil değiştirme etiketi.
                SorunBildir_Linklabel.Text = "SORUN BİLDİR "; // Türkçe sorun bildir etiketi.
                ID_Textbox.PlaceholderText = "ID"; // Türkçe ID placeholder.
                Sifre_Textbox.PlaceholderText = "Şifre"; // Türkçe şifre placeholder.
                this.Text = "SORUMLU GİRİŞ"; // Form başlığı Türkçe.
            }
            else if (DilDegistir_Combobox.SelectedIndex == 1)
            {
                English_Picturebox.Visible = true; // İngilizce dil seçildiğinde İngilizce bayrağı gösterildi.
                Turkey_Picturebox.Visible = false; // Türkçe bayrağı gizlendi.
                Giris_Label.Text = "RESPONSIBLE ENTRY SYSTEM"; // İngilizce başlık.
                ID_Label.Text = "ID"; // İngilizce ID etiket.
                Sifre_Label.Text = "PASSWORD"; // İngilizce şifre etiket.
                Giris_Button.Text = "LOGIN"; // İngilizce giriş butonu.
                DilDegistir_Label.Text = "CHANGE LANGUAGE"; // İngilizce dil değiştirme etiketi.
                SorunBildir_Linklabel.Text = "REPORT ISSUE"; // İngilizce sorun bildir etiketi.
                ID_Textbox.PlaceholderText = "ID"; // İngilizce ID placeholder.
                Sifre_Textbox.PlaceholderText = "Password"; // İngilizce şifre placeholder.
                this.Text = "RESPONSIBLE ENTRY"; // Form başlığı İngilizce.
            }
        }

        private void SorumluGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); // Form kapatıldığında programın tamamen kapanması sağlandı.
        }

        private void Gorunur_Picturebox_Click(object sender, EventArgs e)
        {
            Gorunur_Picturebox.Visible = false; // Şifreyi göster butonuna tıklandığında şifre görünür yapılır.
            Gorunmez_Picturebox.Visible = true; // Şifreyi gizle butonu görünür yapılır.
            Sifre_Textbox.PasswordChar = '\0'; // Şifreyi görünür yapar.
        }

        private void Gorunmez_Picturebox_Click(object sender, EventArgs e)
        {
            Gorunur_Picturebox.Visible = true; // Şifreyi göster butonuna tıklanınca, şifreyi gizle butonu görünür yapılır.
            Gorunmez_Picturebox.Visible = false; // Şifreyi gizle butonu gizlenir.
            Sifre_Textbox.PasswordChar = '*'; // Şifreyi gizler.
        }

        private void Geridon_Picturebox_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris(); // Giriş formu oluşturuldu.
            giris.dil = DilDegistir_Combobox.Text; // Dil bilgisi yeni forma aktarıldı.
            giris.Show(); // Giriş formu gösterildi.
            this.Hide(); // Bu form gizlendi.
        }

        private void SorunBildir_Linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SorunBildir sorunBildir = new SorunBildir(); // Sorun bildir formu oluşturuldu.
            sorunBildir.dil = DilDegistir_Combobox.Text; // Dil bilgisi yeni forma aktarıldı.
            sorunBildir.Show(); // Sorun bildir formu gösterildi.
        }
    }
}
