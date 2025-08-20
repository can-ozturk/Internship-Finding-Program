using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship_Finding_Program_Student
{
    public partial class YoneticiUygulamaAyarlari : Form
    {
        public YoneticiUygulamaAyarlari()
        {
            InitializeComponent();
        }

        public int id;
        public string dil, isim1, firmano;

        // Form gösterildikten sonra ayarların yapılması
        private void YoneticiUygulamaAyarlari_Shown(object sender, EventArgs e)
        {
            // Butonların görünümlerinin ayarlanması
            StajyerBilgileri_Button.FlatAppearance.BorderSize = 0;
            StajyerBilgileri_Button.FlatStyle = FlatStyle.Flat;

            Hesap_Button.FlatAppearance.BorderSize = 0;
            Hesap_Button.FlatStyle = FlatStyle.Flat;

            UygulamaAyarlari_Button.FlatAppearance.BorderSize = 1;
            UygulamaAyarlari_Button.FlatStyle = FlatStyle.Standard;

            //---------------------------------------------------------------

            // Dil nesneleri oluşturuluyor
            Language turkce = new Language();
            Language english = new English();

            //---------------------------------------------------------------

            // Dil değiştirme combobox'ına diller ekleniyor
            Dil_Degistir_Combobox.Items.Add(turkce);
            Dil_Degistir_Combobox.Items.Add(english);

            // Önceki dil seçimi kontrol edilip uygun index seçiliyor
            if (dil == "Türkçe")
            {
                Dil_Degistir_Combobox.SelectedIndex = 0;
            }
            else if (dil == "English")
            {
                Dil_Degistir_Combobox.SelectedIndex = 1;
            }
            //---------------------------------------------------------------
        }

        // Dil değiştirme combobox'ı seçildiğinde yapılan işlem
        private void Dil_Degistir_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Türkçe seçildiğinde
            if (Dil_Degistir_Combobox.SelectedIndex == 0)
            {
                // Dil değişiminde görsellerin değiştirilmesi
                English_Picturebox.Visible = false;
                Turkey_Picturebox.Visible = true;

                // Buton metinlerinin Türkçe'ye çevrilmesi
                StajyerBilgileri_Button.Text = "STAJYER BİLGİLERİ";
                Hesap_Button.Text = "HESAP AYARLARI";
                UygulamaAyarlari_Button.Text = "UYGULAMA AYARLARI";
                Cıkıs_Button.Text = "OTURUMU KAPAT";
                Dil_Degistir_Label.Text = "DİL DEĞİŞTİR";
                Uyarı_Label.Text = "AYARLAR OTOMATİK KAYDEDİLİR";
                this.Text = "YÖNETİCİ UYGULAMA AYARLARI";
                dil = "Türkçe";  // Dil değişkeni güncelleniyor
            }
            // İngilizce seçildiğinde
            else if (Dil_Degistir_Combobox.SelectedIndex == 1)
            {
                // Dil değişiminde görsellerin değiştirilmesi
                English_Picturebox.Visible = true;
                Turkey_Picturebox.Visible = false;

                // Buton metinlerinin İngilizce'ye çevrilmesi
                StajyerBilgileri_Button.Text = "INTERN INFORMATION";
                Hesap_Button.Text = "ACCOUNT SETTINGS";
                UygulamaAyarlari_Button.Text = "APPLICATION SETTINGS";
                Cıkıs_Button.Text = "LOG OUT";
                Dil_Degistir_Label.Text = "CHANGE LANGUAGE";
                Uyarı_Label.Text = "SETTINGS ARE AUTOMATICALLY SAVED";
                this.Text = "ADMIN APPLICATION SETTINGS";
                dil = "English";  // Dil değişkeni güncelleniyor
            }
        }

        // Form kapanmadan önce yapılacak işlem
        private void YoneticiUygulamaAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Uygulama kapanıyor
            Environment.Exit(0);
        }

        // Stajyer Bilgileri butonuna tıklanınca yapılan işlem
        private void StajyerBilgileri_Button_Click(object sender, EventArgs e)
        {
            YoneticiKontrolPaneli yoneticiKontrolPaneli = new YoneticiKontrolPaneli();
            yoneticiKontrolPaneli.id = id;
            yoneticiKontrolPaneli.dil = Dil_Degistir_Combobox.Text;
            yoneticiKontrolPaneli.isim1 = isim1;
            yoneticiKontrolPaneli.firmano = firmano;
            yoneticiKontrolPaneli.Show();
            this.Hide();  // Bu formu gizle
        }

        // Hesap Ayarları butonuna tıklanınca yapılan işlem
        private void Hesap_Button_Click(object sender, EventArgs e)
        {
            FirmaHesapAyarlari firmaHesapAyarlari = new FirmaHesapAyarlari();
            firmaHesapAyarlari.id = id;
            firmaHesapAyarlari.dil = Dil_Degistir_Combobox.Text;
            firmaHesapAyarlari.isim1 = isim1;
            firmaHesapAyarlari.firmano = firmano;
            firmaHesapAyarlari.Show();
            this.Hide();  // Bu formu gizle
        }

        // Çıkış butonuna tıklanınca yapılan işlem
        private void Cıkıs_Button_Click(object sender, EventArgs e)
        {
            // Dil Türkçe ise
            if (dil == "Türkçe")
            {
                MessageBox.Show("OTURUMDAN ÇIKIŞ YAPILIYOR ", "ÇIKIŞ YAPILIYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YoneticiGiris giris = new YoneticiGiris();
                giris.dil = Dil_Degistir_Combobox.Text;
                giris.Show();
                this.Hide();  // Bu formu gizle
            }
            // Dil İngilizce ise
            else if (dil == "English")
            {
                MessageBox.Show("LOGGING OUT OF SESSION", "LOGGING OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YoneticiGiris giris = new YoneticiGiris();
                giris.dil = Dil_Degistir_Combobox.Text;
                giris.Show();
                this.Hide();  // Bu formu gizle
            }
        }

        private void Dil_Degistir_Label_Click(object sender, EventArgs e)
        {
            // Bu metod şu anda boş, tıklama işlemine dair bir işlem yapılmamış.
        }
    }
}
