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
    public partial class FirmaHesapAyarlari : Form
    {
        public FirmaHesapAyarlari()
        {
            InitializeComponent();
        }

        public int id;
        public string dil, isim1, firmano;

        SqlConnection baglanti; // SQL bağlantısı için baglanti adında bir SqlConnection nesnesi oluşturuyoruz.
        Baglanti baglanti1 = new Baglanti(); // Bağlantı bilgileri için Baglanti sınıfını kullanıyoruz.

        private void FirmaHesapAyarlari_Shown(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres); // Bağlantıyı açıyoruz.
                SqlCommand komut = new SqlCommand();   // SQL komutu oluşturuyoruz.
                SqlDataReader okuma; // Verileri okumak için DataReader nesnesi oluşturuyoruz.

                // Butonların stil ayarları
                StajyerBilgileri_Button.FlatAppearance.BorderSize = 0;
                StajyerBilgileri_Button.FlatStyle = FlatStyle.Flat;

                Hesap_Button.FlatAppearance.BorderSize = 1;
                Hesap_Button.FlatStyle = FlatStyle.Standard;

                UygulamaAyarlari_Button.FlatAppearance.BorderSize = 0;
                UygulamaAyarlari_Button.FlatStyle = FlatStyle.Flat;

                // Dil seçimlerine göre buton ve etiket metinlerini ayarlıyoruz.
                if (dil == "Türkçe")
                {
                    StajyerBilgileri_Button.Text = "STAJYER BİLGİLERİ";
                    Hesap_Button.Text = "HESAP AYARLARI";
                    UygulamaAyarlari_Button.Text = "UYGULAMA AYARLARI";
                    Cıkıs_Button.Text = "OTURUMU KAPAT";
                    FirmaBilgileri_Groupbox.Text = "FİRMA BİLGİLERİ";
                    Firma_Ad_Label.Text = "FİRMA ADI";
                    FirmaKurulusTarihi_Label.Text = "FİRMA KURULUŞ TARİHİ";
                    FirmaKonumu_Label.Text = "FİRMA KONUMU";
                    FirmaAlani_Label.Text = "FİRMA ALANI";
                    FirmaWebSite_Label.Text = "FİRMA WEB SİTESİ";
                    FirmaBilgileriniDegistir_Button.Text = "FİRMA BİLGİLERİNİ\r\nDEĞİŞTİR";
                    YoneticiPanelSif_Button.Text = "YÖNETİCİ PANEL\r\nŞİFRESİNİ DEĞİŞTİR";
                    this.Text = "FİRMA HESAP AYARLARI";
                }
                else if (dil == "English")
                {
                    StajyerBilgileri_Button.Text = "INTERN INFORMATION";
                    Hesap_Button.Text = "ACCOUNT SETTINGS";
                    UygulamaAyarlari_Button.Text = "APPLICATION SETTINGS";
                    Cıkıs_Button.Text = "LOG OUT";
                    FirmaBilgileri_Groupbox.Text = "COMPANY INFORMATION";
                    Firma_Ad_Label.Text = "COMPANY NAME";
                    FirmaKurulusTarihi_Label.Text = "COMPANY ESTABLISHMENT DATE";
                    FirmaKonumu_Label.Text = "COMPANY LOCATION";
                    FirmaAlani_Label.Text = "COMPANY FIELD";
                    FirmaWebSite_Label.Text = "COMPANY WEBSITE";
                    FirmaBilgileriniDegistir_Button.Text = "EDIT COMPANY\r\nINFORMATION";
                    YoneticiPanelSif_Button.Text = "CHANGE ADMIN PANEL\r\nPASSWORD";
                    this.Text = "COMPANY ACCOUNT SETTINGS";
                }

                //---------------------------------------------------------------

                // SQL bağlantısını açıyoruz.
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                komut.Connection = baglanti;  // SQL bağlantısını komutumuza ekliyoruz.
                komut.CommandText = "Select Firma_Sıra_No from Firma_Tablosu where Firma_Adi='" + isim1 + "'"; // Firma sıra numarasını alacak SQL komutunu yazıyoruz.
                okuma = komut.ExecuteReader();  // Sorguyu çalıştırıyor ve sonucu okuma nesnesine alıyoruz.

                // Firma sıra numarasını okuma nesnesinden alıyoruz.
                while (okuma.Read())
                {
                    firmano = (okuma["Firma_Sıra_No"].ToString()); // Firma sıra numarasını firmano değişkenine atıyoruz.
                }
                baglanti.Close(); // Bağlantıyı kapatıyoruz.

                //---------------------------------------------------------------

                // SQL bağlantısını tekrar açıyoruz.
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                komut.Connection = baglanti; // SQL bağlantısını komutumuza ekliyoruz.
                komut.CommandText = "Select Firma_Adi,Firma_Kurulus,Firma_Konum,Firma_Alanı,Firma_Web from Firma_Tablosu where Firma_Sıra_No=" + firmano + ""; // Firma bilgilerini sorguluyoruz.
                okuma = komut.ExecuteReader(); // Sorguyu çalıştırıyoruz.

                if (okuma.Read()) // Eğer veri varsa, Textbox'lara firma bilgilerini yazdırıyoruz.
                {
                    Firma_Ad_Textbox.Text = okuma["Firma_Adi"].ToString();
                    FirmaKurulusTarihi_Textbox.Text = okuma["Firma_Kurulus"].ToString();
                    FirmaKonumu_Textbox.Text = okuma["Firma_Konum"].ToString();
                    FirmaAlani_Textbox.Text = okuma["Firma_Alanı"].ToString();
                    FirmaWebSite_Textbox.Text = okuma["Firma_Web"].ToString();
                }
                else // Veri yoksa, Textbox'ları boş bırakıyoruz.
                {
                    Firma_Ad_Textbox.Text = "";
                    FirmaKurulusTarihi_Textbox.Text = "";
                    FirmaKonumu_Textbox.Text = "";
                    FirmaAlani_Textbox.Text = "";
                    FirmaWebSite_Textbox.Text = "";
                }
                baglanti.Close(); // Bağlantıyı kapatıyoruz.
            }
            catch
            {
                // Hata durumunda kullanıcıya mesaj gösteriyoruz.
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR HATA MEYDANA GELDİ\nPROGRAMI YENİDEN BAŞLATMAYI DENEYİNİZ VEYA YÖNETİCİYE BAŞVURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED\nTRY RESTARTING THE PROGRAM OR CONTACT THE ADMINISTRATOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FirmaBilgileriniDegistir_Button_Click(object sender, EventArgs e)
        {
            // Firma bilgilerini değiştirme formunu açıyoruz.
            FirmaBilgileriDegistir firmaBilgileriDegistir = new FirmaBilgileriDegistir();
            firmaBilgileriDegistir.id = id;
            firmaBilgileriDegistir.dil = dil;
            firmaBilgileriDegistir.isim1 = isim1;
            firmaBilgileriDegistir.firmano = firmano;
            firmaBilgileriDegistir.Show();
            this.Hide();
        }

        private void FirmaHesapAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); // Formdan çıkış yapıldığında programı kapatıyoruz.
        }

        private void StajyerBilgileri_Button_Click(object sender, EventArgs e)
        {
            // Stajyer bilgileri formunu açıyoruz.
            YoneticiKontrolPaneli yoneticiKontrol = new YoneticiKontrolPaneli();
            yoneticiKontrol.id = id;
            yoneticiKontrol.dil = dil;
            yoneticiKontrol.isim1 = isim1;
            yoneticiKontrol.firmano = firmano;
            yoneticiKontrol.Show();
            this.Hide();
        }

        private void UygulamaAyarlari_Button_Click(object sender, EventArgs e)
        {
            // Uygulama ayarları formunu açıyoruz.
            YoneticiUygulamaAyarlari yoneticiUygulamaAyarlari = new YoneticiUygulamaAyarlari();
            yoneticiUygulamaAyarlari.id = id;
            yoneticiUygulamaAyarlari.dil = dil;
            yoneticiUygulamaAyarlari.isim1 = isim1;
            yoneticiUygulamaAyarlari.firmano = firmano;
            yoneticiUygulamaAyarlari.Show();
            this.Hide();
        }

        private void YoneticiPanelSif_Button_Click(object sender, EventArgs e)
        {
            // Yöneticinin şifresini değiştirme formunu açıyoruz.
            FirmaHesapSifre firmaHesapSifre = new FirmaHesapSifre();
            firmaHesapSifre.id = id;
            firmaHesapSifre.dil = dil;
            firmaHesapSifre.isim1 = isim1;
            firmaHesapSifre.firmano = firmano;
            firmaHesapSifre.Show();
            this.Hide();
        }

        private void Cıkıs_Button_Click(object sender, EventArgs e)
        {
            // Oturumdan çıkma işlemi
            if (dil == "Türkçe")
            {
                MessageBox.Show("OTURUMDAN ÇIKIŞ YAPILIYOR ", "ÇIKIŞ YAPILIYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YoneticiGiris giris = new YoneticiGiris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
            else if (dil == "English")
            {
                MessageBox.Show("LOGGING OUT OF SESSION", "LOGGING OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YoneticiGiris giris = new YoneticiGiris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
        }
    }
}
