using Microsoft.Data.SqlClient;

namespace Internship_Finding_Program_Student
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        public string dil;

        //---------------------------------------------------------------

        SqlDataReader okuma; // SQL komutlarını okumak için DataReader belirledim.
        SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

        private void Giris_Shown(object sender, EventArgs e)
        {
            // Dil seçeneklerini eklemek için Language sınıflarını kullanıyoruz.
            Language turkce = new Language();
            Language english = new English();
            DilDegistir_Combobox.Items.Add(turkce); // Türkçe dil seçeneği ekleniyor.
            DilDegistir_Combobox.Items.Add(english); // İngilizce dil seçeneği ekleniyor.
            DilDegistir_Combobox.SelectedIndex = 0; // Başlangıçta Türkçe seçili olacak.

            //---------------------------------------------------------------

            // Eğer 'dil' değişkeni Türkçe ise, DilDegistir_Combobox'da Türkçe seçili olmalı.
            if (dil == "Türkçe")
            {
                DilDegistir_Combobox.SelectedIndex = 0;
            }
            else if (dil == "English") // Eğer dil İngilizce ise, İngilizce seçili olmalı.
            {
                DilDegistir_Combobox.SelectedIndex = 1;
            }
            //---------------------------------------------------------------

        }

        // Öğrenci giriş butonuna tıklanınca Öğrenci_Giris formu açılır.
        private void Ogrenci_Giris_Button_Click(object sender, EventArgs e)
        {
            Ogrenci_Giris ogrenci_Giris = new Ogrenci_Giris();
            ogrenci_Giris.dil = DilDegistir_Combobox.Text; // Dil bilgisi aktarılıyor.
            ogrenci_Giris.Show();
            this.Hide();
        }

        // Form kapanmadan önce programın kapanması sağlanır.
        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); // Programı kapatır.
        }

        // Dil değiştirildiğinde dilin güncellenmesi sağlanır.
        private void DilDegistir_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dil Türkçe seçildiyse:
            if (DilDegistir_Combobox.SelectedIndex == 0)
            {
                English_Picturebox.Visible = false; // İngilizce bayrağını gizle
                Turkey_Picturebox.Visible = true;  // Türk bayrağını göster
                Giris_Label.Text = "GİRİŞ EKRANINA HOŞ GELDİNİZ"; // Türkçe giriş mesajı
                Ogrenci_Giris_Button.Text = "ÖĞRENCİ\r\nGİRİŞ"; // Türkçe buton yazısı
                YoneticiGiris_Button.Text = "YÖNETİCİ\r\nGİRİŞ"; // Türkçe buton yazısı
                Giris_Button.Text = "GİRİŞ SAĞLA"; // Türkçe buton yazısı
                this.Text = "Giriş"; // Form başlığı
                DilDegistir_Label.Text = "DİL DEĞİŞTİR"; // Türkçe dil değiştirme etiket
                Admin_Button.Text = "SORUMLU\r\nGİRİŞ"; // Türkçe buton yazısı
            }
            // Dil İngilizce seçildiyse:
            else if (DilDegistir_Combobox.SelectedIndex == 1)
            {
                English_Picturebox.Visible = true; // İngilizce bayrağını göster
                Turkey_Picturebox.Visible = false; // Türk bayrağını gizle
                Giris_Label.Text = "WELCOME TO THE LOGIN SCREEN"; // İngilizce giriş mesajı
                this.Text = "Login"; // Form başlığı
                DilDegistir_Label.Text = "CHANGE LANGUAGE"; // İngilizce dil değiştirme etiket
                Ogrenci_Giris_Button.Text = "STUDENT\r\nLOGIN"; // İngilizce buton yazısı
                YoneticiGiris_Button.Text = "ADMIN\r\nLOGIN"; // İngilizce buton yazısı
                Giris_Button.Text = "LOGIN"; // İngilizce buton yazısı
                Admin_Button.Text = "RESPONSIBLE\r\nLOGIN"; // İngilizce buton yazısı
            }
        }

        // Giriş butonuna hover (fare ile üzerine gelme) olduğunda buton görünümünü değiştirir.
        private void Giris_Button_MouseEnter(object sender, EventArgs e)
        {
            Giris_Button.Visible = false; // Giriş butonunu gizle
            Ogrenci_Giris_Button.Visible = true; // Öğrenci giriş butonunu göster
            YoneticiGiris_Button.Visible = true; // Yönetici giriş butonunu göster
            Admin_Button.Visible = true; // Admin giriş butonunu göster
        }

        // Giriş ekranına fare ile girildiğinde butonları tekrar görünür hale getirir.
        private void Giris_MouseEnter(object sender, EventArgs e)
        {
            Ogrenci_Giris_Button.Visible = false; // Öğrenci giriş butonunu gizle
            YoneticiGiris_Button.Visible = false; // Yönetici giriş butonunu gizle
            Admin_Button.Visible = false; // Admin giriş butonunu gizle
            Giris_Button.Visible = true; // Giriş butonunu tekrar göster
        }

        // Yönetici giriş butonuna tıklanınca Yönetici_Giris formu açılır.
        private void YoneticiGiris_Button_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            yoneticiGiris.dil = DilDegistir_Combobox.Text; // Dil bilgisi aktarılıyor.
            yoneticiGiris.Show();
            this.Hide();
        }

        // Admin giriş butonuna tıklanınca SorumluGiris formu açılır.
        private void Admin_Button_Click(object sender, EventArgs e)
        {
            SorumluGiris sorumluGiris = new SorumluGiris();
            sorumluGiris.dil = DilDegistir_Combobox.Text; // Dil bilgisi aktarılıyor.
            sorumluGiris.Show();
            this.Hide();
        }
    }
}
