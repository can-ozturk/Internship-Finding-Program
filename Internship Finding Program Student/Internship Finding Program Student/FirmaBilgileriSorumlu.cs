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
using Microsoft.IdentityModel.Tokens;

namespace Internship_Finding_Program_Student
{
    public partial class FirmaBilgileriSorumlu : Form
    {
        public FirmaBilgileriSorumlu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti; //SQL' e bağlantı sağlamak için baglanti adında bir SqlConnection belirledim.
        Baglanti baglanti1 = new Baglanti();

        SqlDataReader okuma; //SQL komutlarını okumak için DataReader belirledim
        public string dil, isim1, yoneticiidkontrol;
        public int firmasirano;

        private void FirmaBilgileriSorumlu_Shown(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                FirmaSıraNo_Textbox.Enabled = true;
                FirmaKonumu1_Textbox.Enabled = false;
                FirmaAlanı1_Textbox.Enabled = false;
                Getir_Button.Visible = true;
                Guncelle_Button.Visible = false;
                SifreReset_Button.Enabled = false;
                RandomSifreGoster_Textbox.Enabled = true;
                YoneticiEposta_Textbox.Enabled = false;

                FirmaBilgierli_Button.FlatAppearance.BorderSize = 1;
                FirmaBilgierli_Button.FlatStyle = FlatStyle.Standard;

                OgrencileriKaydet_Button.FlatAppearance.BorderSize = 0;
                OgrencileriKaydet_Button.FlatStyle = FlatStyle.Flat;

                Cıkıs_Button.FlatAppearance.BorderSize = 0;
                Cıkıs_Button.FlatStyle = FlatStyle.Flat;

                if (dil == "Türkçe")
                {
                    OgrencileriKaydet_Button.Text = "ÖĞRENCİ BİLGİLERİ";
                    FirmaBilgierli_Button.Text = "FİRMA BİLGİLERİ";
                    Cıkıs_Button.Text = "OTURUMU KAPAT";
                    this.Text = "FİRMA BİLGİLERİ";
                    FirmaKaydet_Groupbox.Text = "FİRMA KAYDET";
                    FirmaGirisID_Label.Text = "YÖNETİCİ ID";
                    FirmaSifre_Label.Text = "YÖNETİCİ ŞİFRE";
                    FirmaAd_Label.Text = "FİRMA ADI";
                    FirmaAlanı_Label.Text = "FİRMA ALANI";
                    FirmaKonumu_Label.Text = "FİRMA KONUMU";
                    FirmaKurulusTarihi_Label.Text = "FİRMA KURULUŞ TARİHİ";
                    FirmaEposta_Label.Text = "FİRMA E-POSTA ADRESİ";
                    Kaydet_Button.Text = "KAYDET";
                    SorunBildir_Linklabel.Text = "SORUN BİLDİR ";
                    FirmaBilgileriDegistir_Groupbox.Text = "FİRMA BİLGİLERİNİ DEĞİŞTİR";
                    FirmaSıraNo_Label.Text = "FİRMA SIRA NUMARASI";
                    Getir_Button.Text = "GETİR";
                    Guncelle_Button.Text = "GÜNCELLE";
                    FirmaAd1_Label.Text = "FİRMA ADI";
                    FirmaKonumu1_Label.Text = "FİRMA KONUMU";
                    FirmaAlanı1_Label.Text = "FİRMA ALANI";
                    YoneticiID1_Label.Text = "YÖNETİCİ ID";
                    YoneticiEposta_Label.Text = "YÖNETİCİ E-POSTA ADRESİ";
                    SifreReset_Button.Text = "ŞİFRE YENİLE";
                    SorunBildir1_Linklabel.Text = "SORUN BİLDİR ";
                    YenilenenSifre_Label.Text = "YENİLENEN ŞİFRE";
                    FirmaKaydet_TabPage.Text = "FİRMA KAYDET";
                    FirmaBilgileriDuzenle_Tabpage.Text = "FİRMA BİLGİLERİ DÜZENLE";

                }
                else if (dil == "English")
                {
                    OgrencileriKaydet_Button.Text = "STUDENT INFORMATION";
                    FirmaBilgierli_Button.Text = "COMPANY INFORMATION";
                    Cıkıs_Button.Text = "LOG OUT";
                    this.Text = "COMPANY INFORMATION";
                    FirmaKaydet_Groupbox.Text = "SAVE COMPANY";
                    FirmaGirisID_Label.Text = "MANAGER ID";
                    FirmaSifre_Label.Text = "MANAGER PASSWORD";
                    FirmaAd_Label.Text = "COMPANY NAME";
                    FirmaAlanı_Label.Text = "COMPANY FIELD";
                    FirmaKonumu_Label.Text = "COMPANY LOCATION";
                    FirmaKurulusTarihi_Label.Text = "COMPANY ESTABLISHMENT DATE";
                    FirmaEposta_Label.Text = "COMPANY EMAIL ADDRESS";
                    Kaydet_Button.Text = "SAVE";
                    SorunBildir_Linklabel.Text = "REPORT ISSUE";
                    FirmaBilgileriDegistir_Groupbox.Text = "EDIT COMPANY INFORMATION";
                    FirmaSıraNo_Label.Text = "COMPANY SERIAL NUMBER";
                    Getir_Button.Text = "FETCH";
                    Guncelle_Button.Text = "UPDATE";
                    FirmaAd1_Label.Text = "COMPANY NAME";
                    FirmaKonumu1_Label.Text = "COMPANY LOCATION";
                    FirmaAlanı1_Label.Text = "COMPANY FIELD";
                    YoneticiID1_Label.Text = "MANAGER ID";
                    YoneticiEposta_Label.Text = "MANAGER EMAIL ADDRESS";
                    SifreReset_Button.Text = "RESET PASSWORD";
                    SorunBildir1_Linklabel.Text = "REPORT ISSUE";
                    YenilenenSifre_Label.Text = "UPDATED PASSWORD";
                    FirmaKaydet_TabPage.Text = "REGISTER COMPANY";
                    FirmaBilgileriDuzenle_Tabpage.Text = "EDIT COMPANY INFORMATION";

                }
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR HATA MEYDANA GELDİ LÜTFEN TEKRARDAN DENEYİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED. PLEASE TRY AGAIN.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void Cıkıs_Button_Click(object sender, EventArgs e)
        {
            if (dil == "Türkçe") //Türkçe seçili iken oturumu kapatınca Türkçe şekilde çıkış yapıyor ve Giriş formunu Türkçe yapıyor.
            {
                MessageBox.Show("OTURUMDAN ÇIKIŞ YAPILIYOR ", "ÇIKIŞ YAPILIYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SorumluGiris giris = new SorumluGiris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
            else if (dil == "English") //İngilizce seçili iken oturumu kapatınca İngilizce şekilde çıkış yapıyor ve Giriş formunu İngilizce yapıyor.
            {
                MessageBox.Show("LOGGING OUT OF SESSION", "LOGGING OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SorumluGiris giris = new SorumluGiris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
        }

        private void OgrencileriKaydet_Button_Click(object sender, EventArgs e)
        {
            SorumluKontrolPaneli sorumluKontrolPaneli = new SorumluKontrolPaneli();
            sorumluKontrolPaneli.dil = dil;
            sorumluKontrolPaneli.Show();
            this.Hide();
        }

        private void Getir_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                firmasirano = Convert.ToInt32(FirmaSıraNo_Textbox.Text);

                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Firma_Adi from Firma_Tablosu where Firma_Sıra_No=@firmasirano1"; //SQL KOMUTU KULLANDIM
                komut.Parameters.AddWithValue("@firmasirano1", firmasirano);
                okuma = komut.ExecuteReader(); // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.
                if (okuma.Read())
                {
                    isim1 = okuma["Firma_Adi"].ToString();  // Veritabanından Firma_Adi okuyup isim1 değişkenine atadım.

                }

                baglanti.Close(); // Bağlantımı kapattım.

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.


                komut.Connection = baglanti;
                komut.CommandText = "Select Firma_Adi,Firma_Konum,Firma_Alanı from Firma_Tablosu where Firma_Sıra_No=@firmasirano"; //SQL KOMUTU KULLANDIM

                komut.Parameters.AddWithValue("@firmasirano", firmasirano);

                okuma = komut.ExecuteReader(); // Sorguyu çalıştırıp sonuçları okuma adlı değişkene.

                if (okuma.Read()) // Veri mevcutsa Textboxlara yazdırdım.
                {


                    FirmaAd1_Textbox.Text = okuma["Firma_Adi"].ToString();
                    FirmaKonumu1_Textbox.Text = okuma["Firma_Konum"].ToString();
                    FirmaAlanı1_Textbox.Text = okuma["Firma_Alanı"].ToString();



                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("KAYIT BAŞARIYLA GETİRİLDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("RECORD RETRIEVED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    baglanti.Close(); // Bağlantımı kapattım.


                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.


                    komut.Connection = baglanti;
                    komut.CommandText = "Select Yonetici_ID,Yonetici_Eposta from Yonetici_Kayit where Yonetici_Firma_Ad=@firmaadi"; // Seçim bilgilerini sorgulamak için bir SQL komutu yazdım.

                    komut.Parameters.AddWithValue("@firmaadi", isim1);

                    okuma = komut.ExecuteReader(); // Sorguyu çalıştırıp sonuçları okuma adlı değişkene attım.

                    if (okuma.Read()) // Veri mevcutsa Textboxlara yazdırdım.
                    {

                        YoneticiID1_Textbox.Text = okuma["Yonetici_ID"].ToString();
                        YoneticiEposta_Textbox.Text = okuma["Yonetici_Eposta"].ToString();

                        FirmaSıraNo_Textbox.Enabled = false;
                        FirmaKonumu1_Textbox.Enabled = true;
                        FirmaAlanı1_Textbox.Enabled = true;
                        Getir_Button.Visible = false;
                        Guncelle_Button.Visible = true;
                        SifreReset_Button.Enabled = true;
                        YoneticiEposta_Textbox.Enabled = true;
                    }
                    baglanti.Close(); // Bağlantımı kapattım.
                }
                else // Veri yoksa 
                {
                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("BÖYLE BİR KULLANICI BULUNAMADI", "HAY AKSİ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("NO SUCH USER FOUND", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                }
                baglanti.Close(); // Bağlantımı kapattım.



            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR HATA OLUŞTU ÖĞRENCİ NUMARASINI GİRDİĞİNİZDEN EMİN OLUN\nVE TEKRAR DENEYİNİZ", "HAY AKSİ", MessageBoxButtons.OK, MessageBoxIcon.Error); //programın çökmemesi için hata esnasında bu kodu çalıştımasını istedim

                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED. MAKE SURE YOU ENTERED THE STUDENT NUMBER\nAND TRY AGAIN", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }



        private void SifreReset_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.
                Random random = new Random();
                int randomsifre = random.Next(100000, 1000000); // 6 haneli bir sayı üretir
                RandomSifreGoster_Textbox.Text = randomsifre.ToString();

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                komut.CommandText = "update Yonetici_Kayit set Yonetici_Sifre=@sifre where Yonetici_Firma_Ad=@yoneticifirmaad";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                komut.Parameters.AddWithValue("@yoneticifirmaad", isim1);
                komut.Parameters.AddWithValue("@sifre", randomsifre);

                komut.ExecuteNonQuery(); // SQL komutunu çalıştırıyoruz.
                baglanti.Close();

                if (dil == "Türkçe")
                {
                    MessageBox.Show("ŞİFRE BAŞARIYLA SIFIRLANDI VE 'YENİLENEN ŞİFRE' BÖLÜMÜNDE GÖSTERİLDİ ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dil == "English")
                {
                    MessageBox.Show("PASSWORD HAS BEEN SUCCESSFULLY RESET AND DISPLAYED IN THE 'UPDATED PASSWORD' SECTION", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR SORUN OLUŞTU LÜTFEN TEKRARDAN DENEYİNİZ VEYA YÖNETİCİYE BAŞVURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN ISSUE OCCURRED. PLEASE TRY AGAIN OR CONTACT THE ADMINISTRATOR.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
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
                    // Bağlantım eğer kapalı ise bağlantımı açtım.

                    komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                    komut.CommandText = "update Firma_Tablosu set Firma_Adi=@firmaadi,Firma_Konum=@firmakonum,Firma_Alanı=@firmaalani where Firma_Sıra_No=@firmasirano";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                    komut.Parameters.AddWithValue("@firmasirano", firmasirano);
                    komut.Parameters.AddWithValue("@firmaadi", FirmaAd1_Textbox.Text);
                    komut.Parameters.AddWithValue("@firmakonum", FirmaKonumu1_Textbox.Text);
                    komut.Parameters.AddWithValue("@firmaalani", FirmaAlanı1_Textbox.Text);


                    // Kullanıcıdan alınan verileri parametre olarak ekliyoruz


                    if (FirmaAd1_Textbox.Text == "" || FirmaKonumu1_Textbox.Text == "" || FirmaAlanı1_Textbox.Text == "" || YoneticiID1_Textbox.Text == "" || YoneticiEposta_Textbox.Text == "") // Eğer herhangi bir alan boş bırakılmışsa kullanıcıyı uyarıyoruz.
                    {
                        MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        // SQL komutunu çalıştırıyoruz ve veritabanını güncelliyoruz.
                        komut.ExecuteNonQuery(); // SQL komutunu çalıştırıyoruz.
                        baglanti.Close();

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Bağlantım eğer kapalı ise bağlantımı açtım.

                        komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                        komut.CommandText = "update Yonetici_Kayit set Yonetici_ID=@yoneticiid,Yonetici_Eposta=@yoneticieposta where Yonetici_Firma_Ad=@firmaadii";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                        komut.Parameters.AddWithValue("@firmaadii", FirmaAd1_Textbox.Text);
                        komut.Parameters.AddWithValue("@yoneticiid", YoneticiID1_Textbox.Text);
                        komut.Parameters.AddWithValue("@yoneticieposta", YoneticiEposta_Textbox.Text);

                        // SQL komutunu çalıştırıyoruz ve veritabanını güncelliyoruz.
                        komut.ExecuteNonQuery(); // SQL komutunu çalıştırıyoruz.
                        MessageBox.Show("KAYIT BAŞARIYLA GÜNCELLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FirmaSıraNo_Textbox.Clear();
                        FirmaAd1_Textbox.Clear();
                        FirmaKonumu1_Textbox.Clear();
                        FirmaAlanı1_Textbox.Clear();
                        YoneticiID1_Textbox.Clear();
                        YoneticiEposta_Textbox.Clear();
                        RandomSifreGoster_Textbox.Clear();

                        FirmaSıraNo_Textbox.Enabled = true;
                        FirmaKonumu1_Textbox.Enabled = false;
                        FirmaAlanı1_Textbox.Enabled = false;
                        Getir_Button.Visible = true;
                        Guncelle_Button.Visible = false;
                        SifreReset_Button.Enabled = false;
                        YoneticiEposta_Textbox.Enabled = false;


                        // Bağlantıyı kapatıyoruz.

                    }

                    baglanti.Close();

                }




                //---------------------------------------------------------------



                else if (dil == "English")  // İngilizce dil seçeneği için aynı işlemleri yapıyoruz, fakat mesajlar İngilizce olarak değişiyor
                {

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    komut.Connection = baglanti;
                    komut.CommandText = "update Firma_Tablosu set Firma_Adi=@firmaadi,Firma_Konum=@firmakonum,Firma_Alanı=@firmaalani where Firma_Sıra_No=@firmasirano";

                    komut.Parameters.AddWithValue("@firmasirano", firmasirano);
                    komut.Parameters.AddWithValue("@firmaadi", FirmaAd1_Textbox.Text);
                    komut.Parameters.AddWithValue("@firmakonum", FirmaKonumu1_Textbox.Text);
                    komut.Parameters.AddWithValue("@firmaalani", FirmaAlanı1_Textbox.Text);

                    if (FirmaAd1_Textbox.Text == "" || FirmaKonumu1_Textbox.Text == "" || FirmaAlanı1_Textbox.Text == "" || YoneticiID1_Textbox.Text == "" || YoneticiEposta_Textbox.Text == "")
                    {
                        MessageBox.Show("PLEASE FILL IN ALL FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "update Yonetici_Kayit set Yonetici_ID=@yoneticiid,Yonetici_Eposta=@yoneticieposta where Yonetici_Firma_Ad=@firmaadii";

                        komut.Parameters.AddWithValue("@firmaadii", isim1);
                        komut.Parameters.AddWithValue("@yoneticiid", YoneticiID1_Textbox.Text);
                        komut.Parameters.AddWithValue("@yoneticieposta", YoneticiEposta_Textbox.Text);

                        komut.ExecuteNonQuery();
                        MessageBox.Show("RECORD UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FirmaSıraNo_Textbox.Clear();
                        FirmaAd1_Textbox.Clear();
                        FirmaKonumu1_Textbox.Clear();
                        FirmaAlanı1_Textbox.Clear();
                        YoneticiID1_Textbox.Clear();
                        YoneticiEposta_Textbox.Clear();
                        RandomSifreGoster_Textbox.Clear();

                        FirmaSıraNo_Textbox.Enabled = true;
                        FirmaKonumu1_Textbox.Enabled = false;
                        FirmaAlanı1_Textbox.Enabled = false;
                        Getir_Button.Visible = true;
                        Guncelle_Button.Visible = false;
                        SifreReset_Button.Enabled = false;
                        YoneticiEposta_Textbox.Enabled = false;
                    }

                    baglanti.Close();
                }
            }

            catch
            {
                if (dil == "Türkçe") //Türkçe dil seçeneği seçiliyse Türkçe bir şekilde hata verecek.
                {
                    MessageBox.Show("BİR HATA OLUŞTU LÜTFEN BÜTÜN BOŞLUKLARI DOLDURUNUZ !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dil == "English") //İnglizce dil seçeneği seçiliyse İnglizce bir şekilde hata verecek.
                {
                    MessageBox.Show("AN ERROR OCCURRED, PLEASE FILL IN ALL THE BLANKS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                baglanti.Close();
            }
        }


        private void FirmaBilgileriSorumlu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //formdan çıkış yapınca programın kapanmasını sağlıyor
        }

        private void Kaydet_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.
                string yoneticiid = FirmaID_Textbox.Text;

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti;  //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Yonetici_ID from Yonetici_Kayit where Yonetici_ID='" + yoneticiid + "'"; //Sorgulama komutu
                okuma = komut.ExecuteReader();  // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.

                while (okuma.Read())
                {
                    yoneticiidkontrol = (okuma["Yonetici_ID"].ToString()); // Komutta yer alan Yonetici_ID da hangi değer varsa onu yoneticiidkontrol ya atadım.

                }
                baglanti.Close(); // Bağlantımı kapattım.

                if (!(yoneticiidkontrol == yoneticiid))
                {
                    if (dil == "Türkçe")
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Bağlantım eğer kapalı ise bağlantımı açtım.

                        komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                        komut.CommandText = "insert into Firma_Tablosu (Firma_Adi,Firma_Kurulus,Firma_Konum,Firma_Alanı) values(@firmaadi,@firmakurulus,@firmakonum,@firmaalani)";

                        komut.Parameters.AddWithValue("@firmaadi", FirmaAd_Textbox.Text);
                        komut.Parameters.AddWithValue("@firmakurulus", FirmaKurulusTarihi_Textbox.Text);
                        komut.Parameters.AddWithValue("@firmakonum", FirmaKonumu_Textbox.Text);
                        komut.Parameters.AddWithValue("@firmaalani", FirmaAlanı_Textbox.Text);

                        // Kullanıcıdan alınan verileri parametre olarak ekliyoruz.
                        if (FirmaAd_Textbox.Text == "" || FirmaKurulusTarihi_Textbox.Text == "" || FirmaKonumu_Textbox.Text == "" || FirmaAlanı_Textbox.Text == "" || FirmaID_Textbox.Text == "" || FirmaSifre_Textbox.Text == "" || FirmaEposta_Textbox.Text == "")
                        {
                            MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                            baglanti.Close(); // Bağlantıyı kapatıyoruz.

                            if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();
                            // Bağlantım eğer kapalı ise bağlantımı açtım.

                            komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                            komut.CommandText = "insert into Yonetici_Kayit (Yonetici_ID,Yonetici_Sifre,Yonetici_Firma_Ad,Yonetici_Eposta) values(@yoneticiid,@yoneticisifre,@firmaad,@yoneticieposta)";

                            komut.Parameters.AddWithValue("@yoneticiid", FirmaID_Textbox.Text);
                            komut.Parameters.AddWithValue("@yoneticisifre", FirmaSifre_Textbox.Text);
                            komut.Parameters.AddWithValue("@firmaad", FirmaAd_Textbox.Text);
                            komut.Parameters.AddWithValue("@yoneticieposta", FirmaEposta_Textbox.Text);

                            komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                            MessageBox.Show("FİRMA KAYDI BAŞARIYLA EKLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FirmaID_Textbox.Clear();
                            FirmaSifre_Textbox.Clear();
                            FirmaAd_Textbox.Clear();
                            FirmaAlanı_Textbox.Clear();
                            FirmaKonumu_Textbox.Clear();
                            FirmaEposta_Textbox.Clear();
                            FirmaKurulusTarihi_Textbox.Clear();
                        }
                        baglanti.Close(); // Bağlantıyı kapatıyoruz.
                    }
                    else if (dil == "English") //Yukarıda ki kodların ingilizcesi
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "insert into Firma_Tablosu (Firma_Adi,Firma_Kurulus,Firma_Konum,Firma_Alanı) values(@firmaadi,@firmakurulus,@firmakonum,@firmaalani)";

                        komut.Parameters.AddWithValue("@firmaadi", FirmaAd_Textbox.Text);
                        komut.Parameters.AddWithValue("@firmakurulus", FirmaKurulusTarihi_Textbox.Text);
                        komut.Parameters.AddWithValue("@firmakonum", FirmaKonumu_Textbox.Text);
                        komut.Parameters.AddWithValue("@firmaalani", FirmaAlanı_Textbox.Text);

                        if (FirmaAd_Textbox.Text == "" || FirmaKurulusTarihi_Textbox.Text == "" || FirmaKonumu_Textbox.Text == "" || FirmaAlanı_Textbox.Text == "" || FirmaID_Textbox.Text == "" || FirmaSifre_Textbox.Text == "" || FirmaEposta_Textbox.Text == "")
                        {
                            MessageBox.Show("PLEASE FILL IN ALL FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            komut.ExecuteNonQuery();
                            baglanti.Close();

                            if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();

                            komut.Connection = baglanti;
                            komut.CommandText = "insert into Yonetici_Kayit (Yonetici_ID,Yonetici_Sifre,Yonetici_Firma_Ad,Yonetici_Eposta) values(@yoneticiid,@yoneticisifre,@firmaad,@yoneticieposta)";

                            komut.Parameters.AddWithValue("@yoneticiid", FirmaID_Textbox.Text);
                            komut.Parameters.AddWithValue("@yoneticisifre", FirmaSifre_Textbox.Text);
                            komut.Parameters.AddWithValue("@firmaad", FirmaAd_Textbox.Text);
                            komut.Parameters.AddWithValue("@yoneticieposta", FirmaEposta_Textbox.Text);

                            komut.ExecuteNonQuery();
                            MessageBox.Show("COMPANY REGISTRATION SUCCESSFULLY ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FirmaID_Textbox.Clear();
                            FirmaSifre_Textbox.Clear();
                            FirmaAd_Textbox.Clear();
                            FirmaAlanı_Textbox.Clear();
                            FirmaKonumu_Textbox.Clear();
                            FirmaEposta_Textbox.Clear();
                            FirmaKurulusTarihi_Textbox.Clear();
                        }
                        baglanti.Close();

                    }

                }
                else
                {
                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("AYNI FİRMA SİSTEMDE KAYITLI", "HAY AKSİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("THE SAME COMPANY IS ALREADY REGISTERED IN THE SYSTEM", "OH NO", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR HATA OLUŞTU TÜM ALANLARI DOLDURDUĞUNUZDAN EMİN OLUN\nVE TEKRAR DENEYİNİZ", "HAY AKSİ", MessageBoxButtons.OK, MessageBoxIcon.Error); //programın çökmemesi için hata esnasında bu kodu çalıştımasını istedim

                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED. MAKE SURE ALL FIELDS ARE FILLED IN\nAND TRY AGAIN", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close(); // Bağlantımı kapattım.
            }
        }
            
        

        private void SorunBildir_Linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SorunBildir sorunBildir = new SorunBildir();
            sorunBildir.dil = dil;
            sorunBildir.Show();
        }

        private void SorunBildir1_Linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SorunBildir sorunBildir = new SorunBildir();
            sorunBildir.dil = dil;
            sorunBildir.Show();
        }
    }
}

