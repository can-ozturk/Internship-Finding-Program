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
    public partial class SorumluKontrolPaneli : Form
    {
        public SorumluKontrolPaneli()
        {
            InitializeComponent();
        }



        SqlConnection baglanti; //SQL' e bağlantı sağlamak için baglanti adında bir SqlConnection belirledim.
        Baglanti baglanti1 = new Baglanti();
        SqlDataReader okuma; //SQL komutlarını okumak için DataReader belirledim
        public string dil, ogrnokontrol;


        //Yeni nesne belirledim
        Aktif aktif = new Aktif();

        Pasif pasif = new Pasif();

        KabulEdildi kabulEdildi = new KabulEdildi();

        KabulDurumuYok kabulDurumuYok = new KabulDurumuYok();

        KabulEdilmedi kabulEdilmedi = new KabulEdilmedi();

        private void SorumluKontrolPaneli_Shown(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);

                Ogrno_Textbox.Enabled = true;
                OgrAd_Textbox.Enabled = false;
                OgrSoyad_Textbox.Enabled = false;
                OgrBolum_Textbox.Enabled = false;
                OgrEposta_Textbox.Enabled = false;
                OgrAktiflik_Combo.Enabled = false;
                OgrKabul_Combo.Enabled = false;
                Getir_Button.Visible = true;
                Guncelle_Button.Visible = false;
                SifreReset_Button.Enabled = false;





                if (dil == "Türkçe")
                {
                    OgrAktiflik_Combobox.Text = aktif.HesapDurumuBaslik();
                    OgrenciKabul_Combobox.Text = kabulEdildi.HesapKabulBaslik();

                   
                }
                else if (dil == "English")
                {
                    OgrAktiflik_Combobox.Text = aktif.HesapDurumuBaslikING();
                    OgrenciKabul_Combobox.Text = kabulEdildi.HesapKabulBaslikING();

                }

                OgrAktiflik_Combobox.Items.Add(aktif.HesapDurumu());
                OgrAktiflik_Combobox.Items.Add(pasif.HesapDurumu());
                OgrenciKabul_Combobox.Items.Add(kabulEdildi.HesapDurumu());
                OgrenciKabul_Combobox.Items.Add(kabulDurumuYok.HesapDurumu());
                OgrenciKabul_Combobox.Items.Add(kabulEdilmedi.HesapDurumu());

                OgrAktiflik_Combo.Items.Add(aktif.HesapDurumu());
                OgrAktiflik_Combo.Items.Add(pasif.HesapDurumu());
                OgrKabul_Combo.Items.Add(kabulEdildi.HesapDurumu());
                OgrKabul_Combo.Items.Add(kabulDurumuYok.HesapDurumu());
                OgrKabul_Combo.Items.Add(kabulEdilmedi.HesapDurumu());

                FirmaBilgierli_Button.FlatAppearance.BorderSize = 0;
                FirmaBilgierli_Button.FlatStyle = FlatStyle.Flat;

                OgrencileriKaydet_Button.FlatAppearance.BorderSize = 1;
                OgrencileriKaydet_Button.FlatStyle = FlatStyle.Standard;

                Cıkıs_Button.FlatAppearance.BorderSize = 0;
                Cıkıs_Button.FlatStyle = FlatStyle.Flat;

                if (dil == "Türkçe")
                {
                    OgrencileriKaydet_Button.Text = "ÖĞRENCİ BİLGİLERİ";
                    FirmaBilgierli_Button.Text = "FİRMA BİLGİLERİ";
                    Cıkıs_Button.Text = "OTURUMU KAPAT";
                    OgrenciKaydet_Groupbox.Text = "ÖĞRENCİ KAYDET";
                    Ogr_Ad_Label.Text = "ÖĞRENCİ ADI";
                    Ogr_Soyad_Label.Text = "ÖĞRENCİ SOYADI";
                    Ogr_No_Label.Text = "ÖĞRENCİ NUMARASI";
                    Ogr_Bolum_Label.Text = "ÖĞRENCİ BÖLÜMÜ";
                    Ogr_Eposta_Label.Text = "ÖĞRENCİ E-POSTA ADRESİ";
                    Sifre_Label.Text = "ÖĞRENCİ ŞİFRE";
                    OgrAktiflik_Label.Text = "ÖĞRENCİ AKTİFLİK DURUMU";
                    Ogr_Durumu_Label.Text = "ÖĞRENCİ STAJ KABUL DURUMU";
                    Kaydet_Button.Text = "KAYDET";
                    this.Text = "SORUMLU KONTROL PANELİ";
                    OgrenciKaydet_TabPage.Text = "ÖĞRENCİ KAYDET";
                    OgrenciBilgileriDuzenle_Tabpage.Text = "ÖĞRENCİ BİLGİLERİ DÜZENLE";
                    OgrenciBilgileriDegistir_Groupbox.Text = "ÖĞRENCİ BİLGİLERİ DEĞİŞTİR";
                    Ogrno_Label.Text = "ÖĞRENCİ NUMARASI";
                    Getir_Button.Text = "GETİR";
                    Guncelle_Button.Text = "GÜNCELLE";
                    OgrAd_Label.Text = "ÖĞRENCİ ADI";
                    OgrSoyad_Label1.Text = "ÖĞRENCİ SOYADI";
                    OgrBolum_Label1.Text = "ÖĞRENCİ BÖLÜMÜ";
                    OgrEposta_Label1.Text = "ÖĞRENCİ E-POSTA ADRESİ";
                    OgrAktiflik_Label1.Text = "ÖĞRENCİ AKTİFLİK DURUMU";
                    OgrKabul_Label.Text = "ÖĞRENCİ STAJ KABUL DURUMU";
                    SifreReset_Button.Text = "ŞİFRE YENİLE";
                    YenilenenSifre_Label.Text = "YENİLENEN ŞİFRE";
                    SorunBildir_Linklabel.Text = "SORUN BİLDİR ";
                    SorunBildir1_Linklabel.Text = "SORUN BİLDİR ";
                }
                else if (dil == "English")
                {
                    OgrencileriKaydet_Button.Text = "STUDENT INFORMATION";
                    FirmaBilgierli_Button.Text = "COMPANY INFORMATION";
                    Cıkıs_Button.Text = "LOG OUT";
                    OgrenciKaydet_Groupbox.Text = "REGISTER STUDENT";
                    Ogr_Ad_Label.Text = "STUDENT NAME";
                    Ogr_Soyad_Label.Text = "STUDENT SURNAME";
                    Ogr_No_Label.Text = "STUDENT NUMBER";
                    Ogr_Bolum_Label.Text = "STUDENT DEPARTMENT";
                    Ogr_Eposta_Label.Text = "STUDENT EMAIL ADDRESS";
                    Sifre_Label.Text = "STUDENT PASSWORD";
                    OgrAktiflik_Label.Text = "STUDENT ACTIVE STATUS";
                    Ogr_Durumu_Label.Text = "STUDENT INTERNSHIP APPROVAL STATUS";
                    Kaydet_Button.Text = "SAVE";
                    this.Text = "ADMIN CONTROL PANEL";
                    OgrenciKaydet_TabPage.Text = "REGISTER STUDENT";
                    OgrenciBilgileriDuzenle_Tabpage.Text = "EDIT STUDENT INFORMATION";
                    OgrenciBilgileriDegistir_Groupbox.Text = "MODIFY STUDENT INFORMATION";
                    Ogrno_Label.Text = "STUDENT NUMBER";
                    Getir_Button.Text = "FETCH";
                    Guncelle_Button.Text = "UPDATE";
                    OgrAd_Label.Text = "STUDENT NAME";
                    OgrSoyad_Label1.Text = "STUDENT SURNAME";
                    OgrBolum_Label1.Text = "STUDENT DEPARTMENT";
                    OgrEposta_Label1.Text = "STUDENT EMAIL ADDRESS";
                    OgrAktiflik_Label1.Text = "STUDENT ACTIVE STATUS";
                    OgrKabul_Label.Text = "STUDENT INTERNSHIP APPROVAL STATUS";
                    SifreReset_Button.Text = "RESET PASSWORD";
                    YenilenenSifre_Label.Text = "UPDATED PASSWORD";
                    SorunBildir_Linklabel.Text = "REPORT ISSUE";
                    SorunBildir1_Linklabel.Text = "REPORT ISSUE";

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
                baglanti.Close(); // Bağlantımı kapattım.

            }
        }

        private void Kaydet_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.
                string ogrno = Ogr_No_Textbox.Text;

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti;  //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Ogrenci_No from Ogrenci_Kayit where Ogrenci_No='" + ogrno + "'"; //Firma sıra noyu alan bir komut yazdım.
                okuma = komut.ExecuteReader();  // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.

                while (okuma.Read())
                {
                    ogrnokontrol = (okuma["Ogrenci_No"].ToString()); // Komutta yer alan firma_sıra_no da hangi değer varsa onu firmasirano ya atadım.

                }
                baglanti.Close(); // Bağlantımı kapattım.

                if (!(ogrnokontrol == ogrno))
                {
                    if (dil == "Türkçe")
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Bağlantım eğer kapalı ise bağlantımı açtım.

                        komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                        komut.CommandText = "insert into Ogrenci_Kayit (Ogrenci_No,Ogrenci_Sifre,Ogrenci_Ad,Ogrenci_Soyad,Ogrenci_Bolum,Ogrenci_Eposta,Secim,Aktiflik,Kabul) values(@ogrno,@sifre,@ad,@soyad,@bolum,@eposta,@secim,@aktiflik,@kabul)";  // Ekleme işlemi için SQL komutunu tanımlıyoruz.

                        komut.Parameters.AddWithValue("@ogrno", Ogr_No_Textbox.Text);
                        komut.Parameters.AddWithValue("@sifre", Sifre_Textbox.Text);
                        komut.Parameters.AddWithValue("@ad", Ogr_Ad_Textbox.Text);
                        komut.Parameters.AddWithValue("@soyad", Ogr_Soyad_Textbox.Text);
                        komut.Parameters.AddWithValue("@bolum", Ogr_Bolum_Textbox.Text);
                        komut.Parameters.AddWithValue("@eposta", Ogr_Eposta_Textbox.Text);
                        komut.Parameters.AddWithValue("@aktiflik", OgrAktiflik_Combobox.Text);
                        komut.Parameters.AddWithValue("@secim", "✗");
                        komut.Parameters.AddWithValue("@kabul", OgrenciKabul_Combobox.Text);

                        // Kullanıcıdan alınan verileri parametre olarak ekliyoruz.
                        if (Ogr_No_Textbox.Text == "" || Sifre_Textbox.Text == "" || Ogr_Ad_Textbox.Text == "" || Ogr_Soyad_Textbox.Text == "" || Ogr_Bolum_Textbox.Text == "" || Ogr_Eposta_Textbox.Text == "" || OgrAktiflik_Combobox.Text == "Aktif / Pasif" || OgrenciKabul_Combobox.Text == "Kabul Durumu") // Alanın boş olup olmadığını kontrol ediyoruz.
                        {
                            MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                            MessageBox.Show("ÖĞRENCİ KAYDI BAŞARIYLA EKLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Ogr_No_Textbox.Clear();
                            Sifre_Textbox.Clear();
                            Ogr_Ad_Textbox.Clear();
                            Ogr_Soyad_Textbox.Clear();
                            Ogr_Bolum_Textbox.Clear();
                            Ogr_Eposta_Textbox.Clear();
                            OgrAktiflik_Combobox.Text = aktif.HesapDurumuBaslik();
                            OgrenciKabul_Combobox.Text = kabulEdildi.HesapKabulBaslik();


                        }
                        baglanti.Close(); // Bağlantıyı kapatıyoruz.


                    }
                    else if (dil == "English")
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();


                        komut.Connection = baglanti;
                        komut.CommandText = "insert into Ogrenci_Kayit (Ogrenci_No,Ogrenci_Sifre,Ogrenci_Ad,Ogrenci_Soyad,Ogrenci_Bolum,Ogrenci_Eposta,Secim,Aktiflik,Kabul) values(@ogrno,@sifre,@ad,@soyad,@bolum,@eposta,@secim,@aktiflik,@kabul)";

                        komut.Parameters.AddWithValue("@ogrno", Ogr_No_Textbox.Text);
                        komut.Parameters.AddWithValue("@sifre", Sifre_Textbox.Text);
                        komut.Parameters.AddWithValue("@ad", Ogr_Ad_Textbox.Text);
                        komut.Parameters.AddWithValue("@soyad", Ogr_Soyad_Textbox.Text);
                        komut.Parameters.AddWithValue("@bolum", Ogr_Bolum_Textbox.Text);
                        komut.Parameters.AddWithValue("@eposta", Ogr_Eposta_Textbox.Text);
                        komut.Parameters.AddWithValue("@aktiflik", OgrAktiflik_Combobox.Text);
                        komut.Parameters.AddWithValue("@secim", "✗");
                        komut.Parameters.AddWithValue("@kabul", OgrenciKabul_Combobox.Text);


                        if (Ogr_No_Textbox.Text == "" || Sifre_Textbox.Text == "" || Ogr_Ad_Textbox.Text == "" || Ogr_Soyad_Textbox.Text == "" || Ogr_Bolum_Textbox.Text == "" || Ogr_Eposta_Textbox.Text == "" || OgrAktiflik_Combobox.Text == "Aktif / Pasif" || OgrenciKabul_Combobox.Text == "Kabul Durumu")
                        {
                            MessageBox.Show("PLEASE FILL IN ALL FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            komut.ExecuteNonQuery();
                            MessageBox.Show("STUDENT RECORD SUCCESSFULLY ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Ogr_No_Textbox.Clear();
                            Sifre_Textbox.Clear();
                            Ogr_Ad_Textbox.Clear();
                            Ogr_Soyad_Textbox.Clear();
                            Ogr_Bolum_Textbox.Clear();
                            Ogr_Eposta_Textbox.Clear();
                            OgrAktiflik_Combobox.Text = aktif.HesapDurumuBaslikING();
                            OgrenciKabul_Combobox.Text = kabulEdildi.HesapKabulBaslikING();
                        }
                        baglanti.Close();
                    }


                }
                else
                {
                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("AYNI ÖĞRENCİ SİSTEMDE KAYITLI", "HAY AKSİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("THE SAME STUDENT IS ALREADY REGISTERED IN THE SYSTEM", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Getir_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                int ogrno = Convert.ToInt32(Ogrno_Textbox.Text);

                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.


                komut.Connection = baglanti;
                komut.CommandText = "Select Ogrenci_Ad,Ogrenci_Soyad,Ogrenci_Bolum,Ogrenci_Eposta,Aktiflik,Kabul from Ogrenci_Kayit where Ogrenci_No=@ogrno"; // Bazı bilgileri sorgulamak için bir SQL komutu yazdım.

                komut.Parameters.AddWithValue("@ogrno", ogrno);

                okuma = komut.ExecuteReader(); // Sorguyu çalıştırıp sonuçları okuma adlı değişkene.

                if (okuma.Read()) // Veri mevcutsa Textboxlara yazdırdım.
                {


                    OgrAd_Textbox.Text = okuma["Ogrenci_Ad"].ToString();
                    OgrSoyad_Textbox.Text = okuma["Ogrenci_Soyad"].ToString();
                    OgrBolum_Textbox.Text = okuma["Ogrenci_Bolum"].ToString();
                    OgrEposta_Textbox.Text = okuma["Ogrenci_Eposta"].ToString();
                    OgrAktiflik_Combo.Text = okuma["Aktiflik"].ToString();
                    OgrKabul_Combo.Text = okuma["Kabul"].ToString();

                    Ogrno_Textbox.Enabled = false;
                    OgrAd_Textbox.Enabled = true;
                    OgrSoyad_Textbox.Enabled = true;
                    OgrBolum_Textbox.Enabled = true;
                    OgrEposta_Textbox.Enabled = true;
                    OgrAktiflik_Combo.Enabled = true;
                    OgrKabul_Combo.Enabled = true;
                    Getir_Button.Visible = false;
                    Guncelle_Button.Visible = true;
                    SifreReset_Button.Enabled = true;



                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("KAYIT BAŞARIYLA GETİRİLDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("RECORD RETRIEVED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }



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
                baglanti.Close(); // Bağlantımı kapattım.
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

        private void SorumluKontrolPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //formdan çıkış yapınca programın kapanmasını sağlıyor
        }

        private void Guncelle_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int ogrno = Convert.ToInt32(Ogrno_Textbox.Text);

                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

                if (dil == "Türkçe")
                {


                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.

                    komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Ad=@ograd,Ogrenci_Soyad=@ogrsoyad,Ogrenci_Bolum=@ogrbolum,Ogrenci_Eposta=@ogreposta,Aktiflik=@aktiflik,Kabul=@kabul where Ogrenci_No=@ogrno";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                    komut.Parameters.AddWithValue("@ogrno", Ogrno_Textbox.Text);
                    komut.Parameters.AddWithValue("@ograd", OgrAd_Textbox.Text);
                    komut.Parameters.AddWithValue("@ogrsoyad", OgrSoyad_Textbox.Text);
                    komut.Parameters.AddWithValue("@ogrbolum", OgrBolum_Textbox.Text);
                    komut.Parameters.AddWithValue("@ogreposta", OgrEposta_Textbox.Text);
                    komut.Parameters.AddWithValue("@aktiflik", OgrAktiflik_Combo.Text);
                    komut.Parameters.AddWithValue("@kabul", OgrKabul_Combo.Text);
                    // Kullanıcıdan alınan verileri parametre olarak ekliyoruz


                    if (OgrAd_Textbox.Text == "" || OgrSoyad_Textbox.Text == "" || OgrBolum_Textbox.Text == "" || OgrEposta_Textbox.Text == "" || OgrAktiflik_Combo.Text == "" || OgrKabul_Combo.Text == "") // Eğer herhangi bir alan boş bırakılmışsa kullanıcıyı uyarıyoruz.
                    {
                        MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        // SQL komutunu çalıştırıyoruz ve veritabanını güncelliyoruz.
                        komut.ExecuteNonQuery(); // SQL komutunu çalıştırıyoruz.
                        MessageBox.Show("KAYIT BAŞARIYLA GÜNCELLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ogrno_Textbox.Clear();
                        OgrAd_Textbox.Clear();
                        OgrSoyad_Textbox.Clear();
                        OgrBolum_Textbox.Clear();
                        OgrEposta_Textbox.Clear();
                        OgrAktiflik_Combo.Text = "";
                        OgrKabul_Combo.Text = "";
                        RandomSifreGoster_Textbox.Clear();

                        Ogrno_Textbox.Enabled = true;
                        OgrAd_Textbox.Enabled = false;
                        OgrSoyad_Textbox.Enabled = false;
                        OgrBolum_Textbox.Enabled = false;
                        OgrEposta_Textbox.Enabled = false;
                        OgrAktiflik_Combo.Enabled = false;
                        OgrKabul_Combo.Enabled = false;
                        Getir_Button.Visible = true;
                        Guncelle_Button.Visible = false;
                        SifreReset_Button.Enabled = false;
                    }

                    // Bağlantıyı kapatıyoruz.
                    baglanti.Close();

                    //---------------------------------------------------------------


                }
                else if (dil == "English")  // İngilizce dil seçeneği için aynı işlemleri yapıyoruz, fakat mesajlar İngilizce olarak değişiyor
                {

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    komut.Connection = baglanti;
                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Ad=@ograd,Ogrenci_Soyad=@ogrsoyad,Ogrenci_Bolum=@ogrbolum,Ogrenci_Eposta=@ogreposta,Aktiflik=@aktiflik,Kabul=@kabul where Ogrenci_No=@ogrno";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                    komut.Parameters.AddWithValue("@ogrno", Ogrno_Textbox.Text);
                    komut.Parameters.AddWithValue("@ograd", OgrAd_Textbox.Text);
                    komut.Parameters.AddWithValue("@ogrsoyad", OgrSoyad_Textbox.Text);
                    komut.Parameters.AddWithValue("@ogrbolum", OgrBolum_Textbox.Text);
                    komut.Parameters.AddWithValue("@ogreposta", OgrEposta_Textbox.Text);
                    komut.Parameters.AddWithValue("@aktiflik", OgrAktiflik_Combo.Text);
                    komut.Parameters.AddWithValue("@kabul", OgrKabul_Combo.Text);



                    if (OgrAd_Textbox.Text == "" || OgrSoyad_Textbox.Text == "" || OgrBolum_Textbox.Text == "" || OgrEposta_Textbox.Text == "" || OgrAktiflik_Combo.Text == "" || OgrKabul_Combo.Text == "") // Eğer herhangi bir alan boş bırakılmışsa kullanıcıyı uyarıyoruz.
                    {
                        MessageBox.Show("PLEASE FILL IN ALL THE FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {

                        komut.ExecuteNonQuery();
                        MessageBox.Show("RECORD UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ogrno_Textbox.Clear();
                        Ogrno_Textbox.Clear();
                        OgrAd_Textbox.Clear();
                        OgrSoyad_Textbox.Clear();
                        OgrBolum_Textbox.Clear();
                        OgrEposta_Textbox.Clear();
                        OgrAktiflik_Combo.Text = "";
                        OgrKabul_Combo.Text = "";

                        Ogrno_Textbox.Enabled = true;
                        OgrAd_Textbox.Enabled = false;
                        OgrSoyad_Textbox.Enabled = false;
                        OgrBolum_Textbox.Enabled = false;
                        OgrEposta_Textbox.Enabled = false;
                        OgrAktiflik_Combo.Enabled = false;
                        OgrKabul_Combo.Enabled = false;
                        Getir_Button.Visible = true;
                        Guncelle_Button.Visible = false;
                        SifreReset_Button.Enabled = false;
                        RandomSifreGoster_Textbox.Clear();

                    }


                    baglanti.Close();

                    //---------------------------------------------------------------

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
                baglanti.Close(); // Bağlantımı kapattım.
            }
        }

        private void FirmaBilgierli_Button_Click(object sender, EventArgs e)
        {
            FirmaBilgileriSorumlu firmaBilgileriSorumlu = new FirmaBilgileriSorumlu();
            firmaBilgileriSorumlu.dil = dil;
            firmaBilgileriSorumlu.Show();
            this.Hide();
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
                komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Sifre=@sifre where Ogrenci_No=@ogrno";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                komut.Parameters.AddWithValue("@ogrno", Ogrno_Textbox.Text);
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
