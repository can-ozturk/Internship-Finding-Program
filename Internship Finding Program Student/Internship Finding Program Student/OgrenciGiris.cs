using Microsoft.Data.SqlClient;
//SQL i dorğu çalıştırması için bu kütüphaneleri kullandım

namespace Internship_Finding_Program_Student
{
    public partial class Ogrenci_Giris : Form
    {
        Baglanti baglanti1 = new Baglanti();
        SqlConnection baglanti;

        SqlDataReader okuma, isim; //SQL komutlarını okumak için DataReader belirledim
        public string dil;



        public Ogrenci_Giris()
        {
            InitializeComponent();
        }
        
        private void Ogrenci_Giris_Shown(object sender, EventArgs e)
        {
            Language turkce = new Language();
            Language english = new English();
            DilDegistir_Combobox.Items.Add(turkce);
            DilDegistir_Combobox.Items.Add(english);
            DilDegistir_Combobox.SelectedIndex = 0;


            if (dil == "Türkçe")
            {
                DilDegistir_Combobox.SelectedIndex = 0;
            }
            else if (dil == "English")
            {
                DilDegistir_Combobox.SelectedIndex = 1;
            }
            //bu kısımda dil değiştirme comboboxına classtan aldığım dillerin adını yazdırdım.


        }

        private void Giris_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);

                int ogrenciNo = Convert.ToInt32(OgrNo_Textbox.Text);
                string ogrenciSifre = OgrSifre_Textbox.Text;
                //Ogr_No ve Ogr_Sifre yi alabilmem için değişken tanımladım ve textboxlardan veriyi çektim
                

                SqlCommand komut = new SqlCommand(); //Komut yazmak için yeni bir komut oluşturdum
                baglanti.Open();
                string aktiflik = "";
                komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Aktiflik from Ogrenci_Kayit where Ogrenci_No='" + ogrenciNo + "'";

                okuma = komut.ExecuteReader();
                if (okuma.Read())
                {
                    aktiflik = (okuma["Aktiflik"].ToString());
                }
                baglanti.Close();

                baglanti.Open();//Bağlantıyı açtım

                komut.Connection = baglanti;  //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Ogrenci_Ad from Ogrenci_Kayit where Ogrenci_No=" + ogrenciNo + ""; //Öğrencinin adını alan bir komut yazdım
                isim = komut.ExecuteReader(); //isim adlı değişkene atarak bu komutu çalıştırıp okuttum
                object isim1 = ""; //object veri tipinde isim1 diye değişken belirledim ve içini boş bıraktım
                while (isim.Read()) // isim adlı komutumu okudum
                {
                    isim1 = (isim["Ogrenci_Ad"].ToString()); //SQL de Ogrenci_Ad sütununda hangi değer varsa bunu çekip isim1 e atadım

                }
                baglanti.Close();

                baglanti.Open(); //bağlantımı açtım
                komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select * from Ogrenci_Kayit where Ogrenci_No='" + ogrenciNo + "'and Ogrenci_Sifre='" + ogrenciSifre + "'"; //Öğrenci numarası ve şifrenin doğru olup olmadığını bulamam için Select komutunu kullandım
                okuma = komut.ExecuteReader(); //okuma adlı değişkene atarak bu komutu çalıştırdım
                if (okuma.Read())//Ogr_no ve Ogr_Sifre doğru ise çalışacak komut
                {
                    if (DilDegistir_Combobox.SelectedIndex == 0)
                    {
                        if (aktiflik == "Aktif")
                        {
                            MessageBox.Show("Giriş Başarılı\nHoşgeldin: *" + isim1.ToString() + "* Sizi Yönlendiriyoruz", "HOŞGELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information); //Hoşgeldiniz mesajı
                            Ogrenci_Kontrol_Paneli kontrol_Paneli = new Ogrenci_Kontrol_Paneli(); // Kontrol_Paneli adlı formdan yeni nesne oluşturdum
                            kontrol_Paneli.dil = DilDegistir_Combobox.Text;
                            kontrol_Paneli.no = Convert.ToInt32(OgrNo_Textbox.Text);
                            baglanti.Close();
                            kontrol_Paneli.Show(); //kontrol_paneli adlı formu göster dedim
                            this.Hide(); // bu formu gizle dedim

                        }
                        else
                        {
                            MessageBox.Show("STAJ BAŞVURUNUZ ONAYLANDI, ARTIK HESABINIZ AKTİF DEĞİL", "HESABINIZ AKTİF DEĞİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            baglanti.Close();
                        }

                    }
                    else if (DilDegistir_Combobox.SelectedIndex == 1)
                    {
                        if (aktiflik == "Aktif")
                        {
                            MessageBox.Show("Login Successful\nWelcome: *" + isim1.ToString() + "* Redirecting you", "LOGIN SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Ogrenci_Kontrol_Paneli kontrol_Paneli = new Ogrenci_Kontrol_Paneli();
                            kontrol_Paneli.dil = DilDegistir_Combobox.Text;
                            kontrol_Paneli.no = Convert.ToInt32(OgrNo_Textbox.Text);
                            baglanti.Close();
                            kontrol_Paneli.Show();
                            this.Hide();


                        }
                        else
                        {
                            MessageBox.Show("YOUR INTERNSHIP APPLICATION HAS BEEN APPROVED, YOUR ACCOUNT IS NO LONGER ACTIVE", "YOUR ACCOUNT IS INACTIVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            baglanti.Close();
                        }

                    }




                }
                else
                {
                    if (DilDegistir_Combobox.SelectedIndex == 0)
                    {
                        MessageBox.Show("GİRİLEN BİLGİLER YANLIŞ\nLÜTFEN NUMARANIZI VE ŞİFRENİZİ KONTROL EDİNİZ", "GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error); //eğer numara ve şifre yanlışsa bu kodu çalıştıracak
                    }
                    else if (DilDegistir_Combobox.SelectedIndex == 1)
                    {
                        MessageBox.Show("THE ENTERED INFORMATION IS INCORRECT\nPLEASE CHECK YOUR NUMBER AND PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                baglanti.Close();//bağlantımı kapattım

            }
            catch
            {

                if (DilDegistir_Combobox.SelectedIndex == 0)
                {
                    MessageBox.Show("BİR HATA OLUŞTU TÜM ALANLARI DOLDURDUĞUNUZDAN EMİN OLUN\nVE TEKRAR DENEYİNİZ", "HAY AKSİ", MessageBoxButtons.OK, MessageBoxIcon.Error); //programın çökmemesi için hata esnasında bu kodu çalıştımasını istedim

                }
                else if (DilDegistir_Combobox.SelectedIndex == 1)
                {
                    MessageBox.Show("AN ERROR OCCURRED. MAKE SURE ALL FIELDS ARE FILLED IN\nAND TRY AGAIN", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void OgrNo_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Ogr_No textboxuna sadece sayı girişi yapabilmek için kontrol mekanizması kurdum
        }



        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //formdan çıkış yapınca programın kapanmasını sağlıyor
        }


        private void DilDegistir_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DilDegistir_Combobox.SelectedIndex == 0)
            {
                English_Picturebox.Visible = false;
                Turkey_Picturebox.Visible = true;
                Giris_Label.Text = "ÖĞRENCİ STAJ SİSTEMİ GİRİŞ";
                OgrNo_Label.Text = "ÖĞRENCİ NUMARASI";
                OgrenciSifre_Label.Text = "ŞİFRE";
                Giris_Button.Text = "GİRİŞ";
                DilDegistir_Label.Text = "DİL DEĞİŞTİR";
                SorunBildir_Linklabel.Text = "SORUN BİLDİR ";
                OgrNo_Textbox.PlaceholderText = "Öğrenci Numarası";
                OgrSifre_Textbox.PlaceholderText = "Şifre";
                this.Text = "ÖĞRENCİ GİRİŞ";


            }
            else if (DilDegistir_Combobox.SelectedIndex == 1)
            {
                English_Picturebox.Visible = true;
                Turkey_Picturebox.Visible = false;
                Giris_Label.Text = "STUDENT INTERNSHIP SYSTEM LOGIN";
                OgrNo_Label.Text = "STUDENT NUMBER";
                OgrenciSifre_Label.Text = "PASSWORD";
                Giris_Button.Text = "LOGIN";
                DilDegistir_Label.Text = "CHANGE LANGUAGE";
                SorunBildir_Linklabel.Text = "REPORT AN ISSUE";
                OgrNo_Textbox.PlaceholderText = "Student Number";
                OgrSifre_Textbox.PlaceholderText = "Password";
                this.Text = "STUDENT LOGIN";




            }

            //Bu kodlar çeviri için
        }

        private void Geridon_Picturebox_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.dil = DilDegistir_Combobox.Text;
            giris.Show();
            this.Hide();
        }

        private void Gorunur_Picturebox_Click(object sender, EventArgs e)
        {
            OgrSifre_Textbox.PasswordChar = '\0'; //sifreyi göster tikli ise şifreyi gösterecek
            Gorunur_Picturebox.Visible = false;
            Gorunmez_Picturebox.Visible = true;

        }

        private void Gorunmez_Picturebox_Click(object sender, EventArgs e)
        {
            Gorunur_Picturebox.Visible = true;
            Gorunmez_Picturebox.Visible = false;
            OgrSifre_Textbox.PasswordChar = '*'; //tikli değil ise göstermeyecek
        }

        private void SorunBildir_Linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SorunBildir sorunBildir = new SorunBildir();
            sorunBildir.dil = DilDegistir_Combobox.Text;
            sorunBildir.Show();

        }
    }
}
