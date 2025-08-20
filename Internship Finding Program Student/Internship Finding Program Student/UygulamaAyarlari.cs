namespace Internship_Finding_Program_Student
{
    public partial class UygulamaAyarlari : Form
    {
        public UygulamaAyarlari()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------
        // Dil ve numara değişkenleri tanımlanmış
        public string dil;  // Kullanıcı dil tercihi
        public int no;      // Öğrenci numarası
        //---------------------------------------------------------------

        private void UygulamaAyarlari_Shown(object sender, EventArgs e)
        {
            // Buton görsel ayarları yapılmış
            FirmaKriter_Button.FlatAppearance.BorderSize = 0;
            FirmaKriter_Button.FlatStyle = FlatStyle.Flat;

            BilgileriGoruntule_Button.FlatAppearance.BorderSize = 0;
            BilgileriGoruntule_Button.FlatStyle = FlatStyle.Flat;

            UygulamaAyarlari_Button.FlatAppearance.BorderSize = 1;
            UygulamaAyarlari_Button.FlatStyle = FlatStyle.Standard;

            //---------------------------------------------------------------
            // Dil seçenekleri tanımlanmış
            Language turkce = new Language();
            Language english = new English();

            //---------------------------------------------------------------
            // Dil combobox'ına seçenekler ekleniyor
            Dil_Degistir_Combobox.Items.Add(turkce);
            Dil_Degistir_Combobox.Items.Add(english);

            // Kullanıcı dil tercihi kontrol edilerek combobox'ta önceden seçili dil gösteriliyor
            if (dil == "Türkçe")
            {
                Dil_Degistir_Combobox.SelectedIndex = 0;
            }
            else if (dil == "English")
            {
                Dil_Degistir_Combobox.SelectedIndex = 1;
            }
        }

        private void Dil_Degistir_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dil değişimi yapılırken, arayüz elemanları da buna göre güncelleniyor
            if (Dil_Degistir_Combobox.SelectedIndex == 0)
            {
                // Türkçe dil seçildiğinde Türk bayrağı gösteriliyor, İngilizce bayrağı gizleniyor
                English_Picturebox.Visible = false;
                Turkey_Picturebox.Visible = true;
                Dil_Degistir_Label.Text = "DİL DEĞİŞTİR";
                Uyarı_Label.Text = "AYARLAR OTOMATİK KAYDEDİLİR";
                this.Text = "UYGULAMA AYARLARI";
                FirmaKriter_Button.Text = "KRİTER VE FİRMA \r\nBELİRLE\r\n";
                BilgileriGoruntule_Button.Text = "HESAP AYARLARI";
                UygulamaAyarlari_Button.Text = "UYGULAMA \r\nAYARLARI\r\n";
                Cıkıs_Button.Text = "OTURUMU KAPAT";
            }
            else if (Dil_Degistir_Combobox.SelectedIndex == 1)
            {
                // İngilizce dil seçildiğinde İngilizce bayrağı gösteriliyor, Türk bayrağı gizleniyor
                English_Picturebox.Visible = true;
                Turkey_Picturebox.Visible = false;
                Dil_Degistir_Label.Text = "CHANGE LANGUAGE";
                Uyarı_Label.Text = "SETTINGS ARE SAVED AUTOMATICALLY";
                this.Text = "APPLICATION SETTINGS";
                UygulamaAyarlari_Button.Text = "APPLICATION SETTINGS";
                Cıkıs_Button.Text = "LOG OUT";
                BilgileriGoruntule_Button.Text = "ACCOUNT \r\nSETTINGS\r\n";
                FirmaKriter_Button.Text = "SET CRITERIA AND \r\nCOMPANY DEFINE";
            }
        }

        private void UygulamaAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Uygulama kapanırken otomatik çıkış yapılıyor
            Environment.Exit(0);
        }

        private void FirmaKriter_Button_Click(object sender, EventArgs e)
        {
            // Firma kriterleri butonuna tıklandığında, öğrenci kontrol paneline yönlendirilir
            Ogrenci_Kontrol_Paneli ogrenci_Kontrol_Paneli = new Ogrenci_Kontrol_Paneli();
            ogrenci_Kontrol_Paneli.dil = Dil_Degistir_Combobox.Text;
            ogrenci_Kontrol_Paneli.no = no;
            ogrenci_Kontrol_Paneli.Show();
            this.Hide();
        }

        private void BilgileriGoruntule_Button_Click(object sender, EventArgs e)
        {
            // Hesap bilgileri butonuna tıklandığında, hesap ayarlarına yönlendirilir
            HesapAyarlari hesapAyarlari = new HesapAyarlari();
            hesapAyarlari.dil = Dil_Degistir_Combobox.Text;
            hesapAyarlari.no = no;
            hesapAyarlari.Show();
            this.Hide();
        }

        private void Cıkıs_Button_Click(object sender, EventArgs e)
        {
            // Çıkış yapıldığında dil tercihine göre mesaj gösteriliyor ve giriş formuna dönülüyor
            if (dil == "Türkçe") // Türkçe seçili ise çıkış yaparken Türkçe mesaj gösterilir
            {
                MessageBox.Show("OTURUMDAN ÇIKIŞ YAPILIYOR ", "ÇIKIŞ YAPILIYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ogrenci_Giris giris = new Ogrenci_Giris();
                giris.dil = Dil_Degistir_Combobox.Text;
                giris.Show();
                this.Hide();
            }
            else if (dil == "English") // İngilizce seçili ise çıkış yaparken İngilizce mesaj gösterilir
            {
                MessageBox.Show("LOGGING OUT OF SESSION", "LOGGING OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ogrenci_Giris giris = new Ogrenci_Giris();
                giris.dil = Dil_Degistir_Combobox.Text;
                giris.Show();
                this.Hide();
            }
        }

        private void English_Picturebox_Click(object sender, EventArgs e)
        {
            // İngilizce bayrağına tıklanabilir ama burada herhangi bir işlem yapılmamış
        }

        private void UygulamaAyarlari_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde herhangi bir işlem yapılmamış
        }
    }
}
