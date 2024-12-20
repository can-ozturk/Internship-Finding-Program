using System.Data;
using Microsoft.Data.SqlClient;

namespace Internship_Finding_Program_Student
{
    public partial class HesapAyarlari : Form
    {
        public HesapAyarlari()
        {
            InitializeComponent();
        }

        SqlConnection baglanti; // SQL'e bağlantı sağlamak için baglanti adında bir SqlConnection belirledim.
        Baglanti baglanti1 = new Baglanti(); // Bağlantı için Baglanti sınıfı oluşturulmuş.
        SqlDataReader okuma; // SQL komutlarını okumak için DataReader belirledim.

        //---------------------------------------------------------------

        public string dil; // Dil bilgisi.
        public int no; // Öğrenci numarası.

        // Form ilk gösterildiğinde çalışacak metod
        private void OgrenciBilgileri_Shown(object sender, EventArgs e)
        {
            try
            {
                // SQL bağlantısını kurma
                baglanti = new SqlConnection(baglanti1.adres);
                this.BackColor = Color.Silver; // Form arka plan rengini belirliyoruz.

                //---------------------------------------------------------------
                SqlCommand komut = new SqlCommand(); // SQL komutlarını oluşturacak bir SqlCommand nesnesi.

                // Dil kontrolü yaparak kullanıcı arayüzünü düzenliyoruz
                if (dil == "Türkçe")
                {
                    // Türkçe dilinde etiketler ve buton metinleri
                    Ogr_Ad_Label.Text = "AD";
                    Ogr_Soyad_Label.Text = "SOYAD";
                    Ogr_No_Label.Text = "ÖĞRENCİ NUMARASI";
                    Ogr_Bolum_Label.Text = "BÖLÜM";
                    Ogr_Eposta_Label.Text = "E-POSTA ADRESİ";
                    this.Text = "HESAP AYARLARI";
                    OgrenciBilgileri_Groupbox.Text = "ÖĞRENCİ BİLGİLERİ";
                    FirmaKriter_Button.Text = "KRİTER VE FİRMA \r\nBELİRLE\r\n";
                    HesapAyalari_Button.Text = "HESAP AYARLARI";
                    UygulamaAyarlari_Button.Text = "UYGULAMA \r\nAYARLARI\r\n";
                    Cıkıs_Button.Text = "OTURUMU KAPAT";
                    SifreDegistir_Button.Text = "ŞİFREYİ DEĞİŞTİR";
                    EpostaDegistir_Button.Text = "E-POSTAYI DEĞİŞTİR";
                }
                else if (dil == "English")
                {
                    // İngilizce dilinde etiketler ve buton metinleri
                    Ogr_Ad_Label.Text = "NAME";
                    Ogr_Soyad_Label.Text = "SURNAME";
                    Ogr_No_Label.Text = "STUDENT NUMBER";
                    Ogr_Bolum_Label.Text = "DEPARTMENT";
                    Ogr_Eposta_Label.Text = "E-MAIL ADDRESS";
                    this.Text = "ACCOUNT SETTINGS";
                    OgrenciBilgileri_Groupbox.Text = "STUDENT INFORMATION";
                    FirmaKriter_Button.Text = "SET CRITERIA AND \r\nCOMPANY DEFINE";
                    HesapAyalari_Button.Text = "ACCOUNT SETTINGS";
                    UygulamaAyarlari_Button.Text = "APPLICATION \r\nSETTINGS\r\n";
                    Cıkıs_Button.Text = "LOG OUT";
                    SifreDegistir_Button.Text = "CHANGE PASSWORD";
                    EpostaDegistir_Button.Text = "CHANGE EMAIL";
                }

                //---------------------------------------------------------------
                // Buton stil ayarları
                FirmaKriter_Button.FlatAppearance.BorderSize = 0;
                FirmaKriter_Button.FlatStyle = FlatStyle.Flat;
                HesapAyalari_Button.FlatAppearance.BorderSize = 1;
                HesapAyalari_Button.FlatStyle = FlatStyle.Standard;
                UygulamaAyarlari_Button.FlatAppearance.BorderSize = 0;
                UygulamaAyarlari_Button.FlatStyle = FlatStyle.Flat;

                // SQL bağlantısı açılıyor
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                komut.Connection = baglanti; // SQL bağlantısını komuta ekliyoruz
                // Öğrencinin bilgilerini sorgulayan SQL komutu
                komut.CommandText = "Select Ogrenci_No,Ogrenci_Ad,Ogrenci_Soyad,Ogrenci_Bolum,Ogrenci_Eposta from Ogrenci_Kayit where Ogrenci_No=" + no + "";
                okuma = komut.ExecuteReader(); // Sorgu çalıştırılıyor

                if (okuma.Read()) // Eğer veri varsa, Textbox'lara yerleştiriyoruz
                {
                    Ogr_No_Textbox.Text = okuma["Ogrenci_No"].ToString();
                    Ogr_Ad_Textbox.Text = okuma["Ogrenci_Ad"].ToString();
                    Ogr_Soyad_Textbox.Text = okuma["Ogrenci_Soyad"].ToString();
                    Ogr_Bolum_Textbox.Text = okuma["Ogrenci_Bolum"].ToString();
                    Ogr_Eposta_Textbox.Text = okuma["Ogrenci_Eposta"].ToString();
                }
                else // Veri yoksa, boş olarak bırakıyoruz
                {
                    Ogr_No_Textbox.Text = "";
                    Ogr_Ad_Textbox.Text = "";
                    Ogr_Soyad_Textbox.Text = "";
                    Ogr_Bolum_Textbox.Text = "";
                    Ogr_Eposta_Textbox.Text = "";
                }
                baglanti.Close(); // Bağlantıyı kapatıyoruz

                //---------------------------------------------------------------
            }
            catch
            {
                // Hata durumunda uygun mesajları gösteriyoruz
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR HATA OLUŞTU LÜTFEN PROGRAMI YENİDEN BAŞLATIN VEYA YÖNETİCİYE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED, PLEASE RESTART THE PROGRAM OR CONTACT THE ADMINISTRATOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Form kapanmadan önce programı kapatıyoruz
        private void OgrenciBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); // Programdan çıkıyoruz
        }

        // Firma kriterleri butonuna tıklanması durumunda başka bir forma geçiş yapılıyor
        private void FirmaKriter_Button_Click(object sender, EventArgs e)
        {
            Ogrenci_Kontrol_Paneli kontrol_Paneli = new Ogrenci_Kontrol_Paneli();
            kontrol_Paneli.no = no;
            kontrol_Paneli.dil = dil;
            kontrol_Paneli.Show();
            this.Hide();
        }

        // Uygulama ayarları butonuna tıklanması durumunda başka bir forma geçiş yapılıyor
        private void UygulamaAyarlari_Button_Click(object sender, EventArgs e)
        {
            UygulamaAyarlari uygulamaAyarlari = new UygulamaAyarlari();
            uygulamaAyarlari.no = no;
            uygulamaAyarlari.dil = dil;
            uygulamaAyarlari.Show();
            this.Hide();
        }

        // Çıkış butonuna tıklanması durumunda oturum kapanıyor
        private void Cıkıs_Button_Click(object sender, EventArgs e)
        {
            if (dil == "Türkçe") // Türkçe dil seçiliyken çıkış yapılırken Türkçe mesaj gösteriyoruz
            {
                MessageBox.Show("OTURUMDAN ÇIKIŞ YAPILIYOR ", "ÇIKIŞ YAPILIYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ogrenci_Giris giris = new Ogrenci_Giris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
            else if (dil == "English") // İngilizce dil seçiliyken çıkış yapılırken İngilizce mesaj gösteriyoruz
            {
                MessageBox.Show("LOGGING OUT OF SESSION", "LOGGING OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ogrenci_Giris giris = new Ogrenci_Giris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
        }

        // Şifre değiştirme butonuna tıklanması durumunda şifre değiştirme formuna geçiş yapılıyor
        private void SifreDegistir_Textbox_Click(object sender, EventArgs e)
        {
            SifreDegistir sifreDegistir = new SifreDegistir();
            sifreDegistir.dil = dil;
            sifreDegistir.no = no;
            sifreDegistir.Show();
            this.Hide();
        }

        // E-posta değiştirme butonuna tıklanması durumunda e-posta değiştirme formuna geçiş yapılıyor
        private void EpostaDegistir_Textbox_Click(object sender, EventArgs e)
        {
            EpostaDegistir epostaDegistir = new EpostaDegistir();
            epostaDegistir.dil = dil;
            epostaDegistir.no = no;
            epostaDegistir.Show();
            this.Hide();
        }
    }
}
