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
    public partial class YoneticiKontrolPaneli : Form
    {
        public YoneticiKontrolPaneli()
        {
            InitializeComponent();
        }
        public string dil, isim1, ogrno, ogrencihobi, ogrencieklemekist, ogrencisertifika, ogrencibilgi, firmano;
        public int id;

        SqlConnection baglanti; //SQL' e bağlantı sağlamak için baglanti adında bir SqlConnection belirledim.
        Baglanti baglanti1 = new Baglanti();

        private void YoneticiKontrolPaneli_Shown(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.
                SqlDataReader okuma; //SQL komutlarını okumak için DataReader belirledim.

                StajyerBilgileri_Button.FlatAppearance.BorderSize = 1;
                StajyerBilgileri_Button.FlatStyle = FlatStyle.Standard;

                Hesap_Button.FlatAppearance.BorderSize = 0;
                Hesap_Button.FlatStyle = FlatStyle.Flat;

                UygulamaAyarlari_Button.FlatAppearance.BorderSize = 0;
                UygulamaAyarlari_Button.FlatStyle = FlatStyle.Flat;

                if (dil == "Türkçe")
                {
                    GirisYazi_Label.Text = "Hoşgeldiniz " + isim1.ToString() ;
                    StajyerBilgileri_Button.Text = "STAJYER BİLGİLERİ";
                    Hesap_Button.Text = "HESAP AYARLARI";
                    UygulamaAyarlari_Button.Text = "UYGULAMA AYARLARI";
                    Cıkıs_Button.Text = "OTURUMU KAPAT";
                    StajyerGoruntule_Groupbox.Text = "STAJYER GÖRÜNTÜLE";
                    StajyerYazi_Label.Text = "STAJYER BAŞVURULARI";
                    Onayla_Button.Text = "ONAYLA";
                    Reddet_Button.Text = "REDDET";
                    OgrenciBilgileri_Groupbox.Text = "ÖĞRENCİ BİLGİLERİ";
                    OgrenciBilgi_Label.Text = "BİLGİ SAHİBİ OLDUĞU ALANLAR";
                    OgrenciBilgi1_Label.Text = "ÖĞRENCİ HAKKINDA";
                    FirmaAra_Textbox.PlaceholderText = "🔍 Ara ";
                    this.Text = "YÖNETİCİ KONTROL PANELİ";

                }
                else if (dil == "English")
                {
                    GirisYazi_Label.Text = "Welcome " + isim1.ToString();
                    StajyerBilgileri_Button.Text = "INTERN INFORMATION";
                    Hesap_Button.Text = "ACCOUNT SETTINGS";
                    UygulamaAyarlari_Button.Text = "APPLICATION SETTINGS";
                    Cıkıs_Button.Text = "LOG OUT";
                    StajyerGoruntule_Groupbox.Text = "VIEW INTERN";
                    StajyerYazi_Label.Text = "INTERN APPLICATIONS";
                    Onayla_Button.Text = "APPROVE";
                    Reddet_Button.Text = "REJECT";
                    OgrenciBilgileri_Groupbox.Text = "STUDENT INFORMATION";
                    OgrenciBilgi_Label.Text = "FIELDS OF EXPERTISE";
                    OgrenciBilgi1_Label.Text = "ABOUT THE STUDENT";
                    FirmaAra_Textbox.PlaceholderText = "🔍 Search ";
                    this.Text = "ADMIN CONTROL PANEL";

                }


                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.


                komut.Connection = baglanti;
                komut.CommandText = "Select * from Secim_Tablosu where Firma_Adi='" + isim1 + "'"; // Seçim bilgilerini sorgulamak için bir SQL komutu yazdım.

                SqlDataAdapter dataadapter = new SqlDataAdapter(komut); // Sorgudan dönen verileri almak için bir DataAdapter oluşturup komutu buna bağladım.

                DataTable veritablo = new DataTable(); // Gelen verileri depolamak için bir DataTable oluşturup bunu doldurdum.
                dataadapter.Fill(veritablo); // DataTable içine verileri aktardım.
                StajyerGoster_Datagrid.DataSource = veritablo; // DataGrid'e DataTable verisini bağlayarak verileri görselleştirdim.

                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------

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

        private void StajyerGoster_Datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti = new SqlConnection(baglanti1.adres);
            try
            {

                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.
                SqlDataReader okuma; //SQL komutlarını okumak için DataReader belirledim.

                OgrenciBilgi_Richtextbox.Clear();
                OgrenciBilgi_Datagrid.DataSource = null;
                try
                {
                    //---------------------------------------------------------------

                    if (StajyerGoster_Datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {

                        StajyerGoster_Datagrid.CurrentRow.Selected = true;

                        ogrno = StajyerGoster_Datagrid.Rows[e.RowIndex].Cells["Ogrenci_No"].FormattedValue.ToString();
                    }
                }
                catch
                {

                }
                //---------------------------------------------------------------
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.

                    komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                    komut.CommandText = "Select Ogrenci_Bilgi from Ogrenci_Kayit where Ogrenci_No=" + ogrno + ""; // Öğrencinin hobisini "Ogrenci_No" değerine göre sorguladım.
                    okuma = komut.ExecuteReader(); // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.
                    if (okuma.Read())
                    {
                        ogrencibilgi = okuma["Ogrenci_Bilgi"]?.ToString();  // Veritabanından hobiyi okuyup OgrenciHobi değişkenine atadım.

                        if (!string.IsNullOrEmpty(ogrencibilgi))
                        {
                            OgrenciBilgi_Richtextbox.Text = ogrencibilgi; // Eğer hobi mevcutsa ComboBox'ta gösterdim.
                        }
                    }
                    baglanti.Close(); // Bağlantımı kapattım.
                }
                catch
                {
                    baglanti.Close();
                }
                //---------------------------------------------------------------
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.

                    komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                    komut.CommandText = "Select Ogrenci_Sertifika_Egitim from Ogrenci_Kayit where Ogrenci_No=" + ogrno + ""; // Öğrencinin hobisini "Ogrenci_No" değerine göre sorguladım.
                    okuma = komut.ExecuteReader(); // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.
                    if (okuma.Read())
                    {
                        ogrencisertifika = okuma["Ogrenci_Sertifika_Egitim"]?.ToString();  // Veritabanından hobiyi okuyup OgrenciHobi değişkenine atadım.

                        if (!string.IsNullOrEmpty(ogrencisertifika))
                        {
                            OgrenciBilgi_Richtextbox.Text = ogrencisertifika; // Eğer hobi mevcutsa ComboBox'ta gösterdim.
                        }
                    }
                    baglanti.Close(); // Bağlantımı kapattım.
                }
                catch
                {
                    baglanti.Close();
                }
                //---------------------------------------------------------------
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.

                    komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                    komut.CommandText = "Select Ogrenci_Hobi from Ogrenci_Kayit where Ogrenci_No=" + ogrno + ""; // Öğrencinin hobisini "Ogrenci_No" değerine göre sorguladım.
                    okuma = komut.ExecuteReader(); // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.
                    if (okuma.Read())
                    {
                        ogrencihobi = okuma["Ogrenci_Hobi"]?.ToString();  // Veritabanından hobiyi okuyup OgrenciHobi değişkenine atadım.

                    }
                    baglanti.Close(); // Bağlantımı kapattım.
                }
                catch
                {
                    baglanti.Close();
                }
                //---------------------------------------------------------------
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.

                    komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                    komut.CommandText = "Select Ogrenci_Eklemekistediginiz from Ogrenci_Kayit where Ogrenci_No=" + ogrno + ""; // Öğrencinin hobisini "Ogrenci_No" değerine göre sorguladım.
                    okuma = komut.ExecuteReader(); // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.
                    if (okuma.Read())
                    {
                        ogrencieklemekist = okuma["Ogrenci_Eklemekistediginiz"]?.ToString();  // Veritabanından hobiyi okuyup OgrenciHobi değişkenine atadım.

                        if (!string.IsNullOrEmpty(ogrencieklemekist))
                        {
                            OgrenciBilgi_Richtextbox.Text = "Bilgi Sahibi Olduğu Unsurlar: " + ogrencibilgi + "\n------------------------------------------------------\n" + "Varsa Sertifika veya Eğitim: " + ogrencisertifika + "\n------------------------------------------------------\n" + "Hobileri: " + ogrencihobi + "\n------------------------------------------------------\n" + "Ek Eklediği Hobiler: \n " + ogrencieklemekist; // Eğer hobi mevcutsa ComboBox'ta gösterdim.
                        }
                    }
                    baglanti.Close(); // Bağlantımı kapattım.
                }
                catch
                {
                    baglanti.Close();
                }
                //---------------------------------------------------------------
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.


                    komut.Connection = baglanti;
                    komut.CommandText = "Select Ogrenci_No,Ogrenci_Ad,Ogrenci_Soyad,Ogrenci_Bolum,Ogrenci_Eposta from Ogrenci_Kayit where Ogrenci_No=" + ogrno + ""; // Sorgulamak için bir SQL komutu yazdım.

                    SqlDataAdapter dataadapter = new SqlDataAdapter(komut); // Sorgudan dönen verileri almak için bir DataAdapter oluşturup komutu buna bağladım.

                    DataTable veritablo = new DataTable(); // Gelen verileri depolamak için bir DataTable oluşturup bunu doldurdum.
                    dataadapter.Fill(veritablo); // DataTable içine verileri aktardım.
                    OgrenciBilgi_Datagrid.DataSource = veritablo; // DataGrid'e DataTable verisini bağlayarak verileri görselleştirdim.

                    baglanti.Close(); // Bağlantımı kapattım.
                }
                catch
                {
                    baglanti.Close();
                }
                //---------------------------------------------------------------
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



        private void FirmaAra_Textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand(); // SQL komutlarını çalıştırmak için bir SqlCommand nesnesi oluşturuyoruz.

                if (baglanti.State == ConnectionState.Closed) // SQL bağlantısı kapalıysa açıyoruz.
                    baglanti.Open(); // Bağlantıyı açıyoruz.

                komut.Connection = baglanti; // Komutun hangi bağlantıya ait olduğunu belirtiyoruz.

                komut.CommandText = "Select * from Secim_Tablosu where Firma_Adi='" + isim1 + "' and Ogrenci_No like @ogrencino";  // SQL sorgusunu tanımlıyoruz: Secim_Tablosu'ndaki tüm verileri seçiyoruz.

                komut.Parameters.AddWithValue("@ogrencino", "%" + FirmaAra_Textbox.Text + "%");

                SqlDataAdapter dataadapter = new SqlDataAdapter(komut);

                DataTable veritablo = new DataTable(); // Verilerin tutulacağı DataTable nesnesini oluşturuyoruz.
                dataadapter.Fill(veritablo);  // SQL sorgusundan dönen verileri DataTable içerisine dolduruyoruz.

                StajyerGoster_Datagrid.DataSource = veritablo; // DataGridView'e verileri bağlayarak ekranda gösteriyoruz.

                baglanti.Close(); // Veritabanı bağlantısını kapatıyoruz.
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("ARAMA YAPARKEN BİLİNMEYEN BİR HATA MEYDANA GELDİ LÜTFEN TEKRAR DENEYİN\nVEYA PROGRAMI YENİDEN BAŞLATIN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN UNKNOWN ERROR OCCURRED WHILE SEARCHING. PLEASE TRY AGAIN\nOR RESTART THE PROGRAM.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                baglanti.Close();
            }
        }

        private void YoneticiKontrolPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //formdan çıkış yapınca programın kapanmasını sağlıyor
        }

        private void Cıkıs_Button_Click(object sender, EventArgs e)
        {
            if (dil == "Türkçe") //Türkçe seçili iken oturumu kapatınca Türkçe şekilde çıkış yapıyor ve Giriş formunu Türkçe yapıyor.
            {
                MessageBox.Show("OTURUMDAN ÇIKIŞ YAPILIYOR ", "ÇIKIŞ YAPILIYOR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                YoneticiGiris giris = new YoneticiGiris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
            else if (dil == "English") //İngilizce seçili iken oturumu kapatınca İngilizce şekilde çıkış yapıyor ve Giriş formunu İngilizce yapıyor.
            {
                MessageBox.Show("LOGGING OUT OF SESSION", "LOGGING OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YoneticiGiris giris = new YoneticiGiris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
        }

        private void Onayla_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

                if (dil == "Türkçe")
                {

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Eğer bağlantı kapalıysa, bağlantıyı açıyoruz.

                    komut.Connection = baglanti; // Komutun bağlantısını ekliyoruz.
                    komut.CommandText = "update Ogrenci_Kayit set Aktiflik=@aktiflik,Kabul=@kabul where Ogrenci_No=" + ogrno + "";  // Güncelleme sorgusu: Veritabanındaki belirli bir öğrencinin kayıtlarını güncellemek için SQL komutunu tanımlıyoruz.

                    // Parametreler aracılığıyla formdaki verileri sorguya bağlıyoruz.
                    komut.Parameters.AddWithValue("@aktiflik", "Pasif");
                    komut.Parameters.AddWithValue("@kabul", "Kabul Edildi");

                    DialogResult sonuc = MessageBox.Show("Bu İşlem Geri Döndürülemez !\nSeçiminiz Onaylanacak Eminmisiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); //Silme işlemi için kullanıcıdan onay alıyor.
                    if (sonuc == DialogResult.Yes)
                    {
                        komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                        MessageBox.Show("SEÇİM BAŞARIYLA ONAYLANDI\nÖĞRENCİYE MAİL GÖNDERİLDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baglanti.Close();// Bağlantıyı kapatıyoruz.

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Eğer bağlantı kapalıysa, bağlantıyı açıyoruz.

                        komut.Connection = baglanti; // Komutun bağlantısını ekliyoruz.

                        komut.CommandText = "Delete from Secim_Tablosu where Ogrenci_No=" + ogrno + "";  // Belirtilen Öğrenci numarasına ait kişinin verileri silinmesi için komut yazdım.

                        komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                        baglanti.Close();// Bağlantıyı kapatıyoruz.

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Bağlantım eğer kapalı ise bağlantımı açtım.

                        komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                        komut.CommandText = "update Ogrenci_Kayit set Secim=@Secim,Firma_Aciklama=@aciklama where Ogrenci_No=" + ogrno + "";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                        komut.Parameters.AddWithValue("@Secim", "✗");
                        komut.Parameters.AddWithValue("@aciklama", "");
                        // Kullanıcıdan alınan verileri parametre olarak ekliyoruz.

                        komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                                                 // Bağlantıyı kapatıyoruz.
                        baglanti.Close();

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Bağlantım eğer kapalı ise bağlantımı açtım.


                        komut.Connection = baglanti;
                        komut.CommandText = "Select * from Secim_Tablosu where Firma_Adi='" + isim1 + "'"; // Seçim bilgilerini sorgulamak için bir SQL komutu yazdım.

                        SqlDataAdapter dataadapter = new SqlDataAdapter(komut); // Sorgudan dönen verileri almak için bir DataAdapter oluşturup komutu buna bağladım.

                        DataTable veritablo = new DataTable(); // Gelen verileri depolamak için bir DataTable oluşturup bunu doldurdum.
                        dataadapter.Fill(veritablo); // DataTable içine verileri aktardım.
                        StajyerGoster_Datagrid.DataSource = veritablo; // DataGrid'e DataTable verisini bağlayarak verileri görselleştirdim.

                        baglanti.Close(); // Bağlantımı kapattım.

                        OgrenciBilgi_Richtextbox.Clear();
                        OgrenciBilgi_Datagrid.DataSource = null;
                        FirmaAra_Textbox.Clear();
                    }

                    baglanti.Close();// Bağlantıyı kapatıyoruz.

                    //---------------------------------------------------------------

                }

                if (dil == "English")
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    komut.Connection = baglanti;
                    komut.CommandText = "update Ogrenci_Kayit set Aktiflik=@aktiflik,Kabul=@kabul where Ogrenci_No=" + ogrno + "";

                    komut.Parameters.AddWithValue("@aktiflik", "Pasif");
                    komut.Parameters.AddWithValue("@kabul", "Kabul Edildi");

                    DialogResult sonuc = MessageBox.Show("This Action Cannot Be Undone!\nYour Selection Will Be Approved. Are You Sure?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (sonuc == DialogResult.Yes)
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("SELECTION SUCCESSFULLY APPROVED\nAN EMAIL HAS BEEN SENT TO THE STUDENT", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baglanti.Close();

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;

                        komut.CommandText = "Delete from Secim_Tablosu where Ogrenci_No=" + ogrno + "";

                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "update Ogrenci_Kayit set Secim=@Secim,Firma_Aciklama=@aciklama where Ogrenci_No=" + ogrno + "";

                        komut.Parameters.AddWithValue("@Secim", "✗");
                        komut.Parameters.AddWithValue("@aciklama", "");

                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();


                        komut.Connection = baglanti;
                        komut.CommandText = "Select * from Secim_Tablosu where Firma_Adi='" + isim1 + "'";

                        SqlDataAdapter dataadapter = new SqlDataAdapter(komut);

                        DataTable veritablo = new DataTable();
                        dataadapter.Fill(veritablo);
                        StajyerGoster_Datagrid.DataSource = veritablo;

                        baglanti.Close();

                        OgrenciBilgi_Richtextbox.Clear();
                        OgrenciBilgi_Datagrid.DataSource = null;
                        FirmaAra_Textbox.Clear();
                        //---------------------------------------------------------------
                    }

                    baglanti.Close();


                }



            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("LÜTFEN TABLODAN SEÇİMİNİZ YAPINIZ VEYA TEKRARDAN DENEYİNİZ","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dil == "English")
                {
                    MessageBox.Show("PLEASE MAKE A SELECTION FROM THE TABLE OR TRY AGAIN","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void Reddet_Button_Click(object sender, EventArgs e)
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
                    komut.CommandText = "update Ogrenci_Kayit set Kabul=@kabul where Ogrenci_No=" + ogrno + "";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                    komut.Parameters.AddWithValue("@kabul", "Kabul Edilmedi");
                    // Kullanıcıdan alınan verileri parametre olarak ekliyoruz.
                    DialogResult sonuc = MessageBox.Show("Bu İşlem Geri Döndürülemez !\nSeçiminiz Reddedilecek Eminmisiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (sonuc == DialogResult.Yes)
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("SEÇİM REDDEDİLDİ\nÖĞRENCİYE MESAJ GÖNDERİLDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        baglanti.Close();

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Eğer bağlantı kapalıysa, bağlantıyı açıyoruz.

                        komut.Connection = baglanti; // Komutun bağlantısını ekliyoruz.

                        komut.CommandText = "Delete from Secim_Tablosu where Ogrenci_No=" + ogrno + "";  // Belirtilen Öğrenci numarasına ait kişinin verileri silinmesi için komut yazdım.

                        komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.

                        baglanti.Close();// Bağlantıyı kapatıyoruz.

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Bağlantım eğer kapalı ise bağlantımı açtım.

                        komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                        komut.CommandText = "update Ogrenci_Kayit set Secim=@Secim,Firma_Aciklama=@aciklama where Ogrenci_No=" + ogrno + "";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                        komut.Parameters.AddWithValue("@Secim", "✗");
                        komut.Parameters.AddWithValue("@aciklama", "");
                        // Kullanıcıdan alınan verileri parametre olarak ekliyoruz.

                        komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                                                 // Bağlantıyı kapatıyoruz.
                        baglanti.Close();

                        //---------------------------------------------------------------

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Bağlantım eğer kapalı ise bağlantımı açtım.


                        komut.Connection = baglanti;
                        komut.CommandText = "Select * from Secim_Tablosu where Firma_Adi='" + isim1 + "'"; // Seçim bilgilerini sorgulamak için bir SQL komutu yazdım.

                        SqlDataAdapter dataadapter = new SqlDataAdapter(komut); // Sorgudan dönen verileri almak için bir DataAdapter oluşturup komutu buna bağladım.

                        DataTable veritablo = new DataTable(); // Gelen verileri depolamak için bir DataTable oluşturup bunu doldurdum.
                        dataadapter.Fill(veritablo); // DataTable içine verileri aktardım.
                        StajyerGoster_Datagrid.DataSource = veritablo; // DataGrid'e DataTable verisini bağlayarak verileri görselleştirdim.

                        baglanti.Close(); // Bağlantımı kapattım.

                        OgrenciBilgi_Richtextbox.Clear();
                        OgrenciBilgi_Datagrid.DataSource = null;
                        FirmaAra_Textbox.Clear();

                        //---------------------------------------------------------------

                    }
                    // Bağlantıyı kapatıyoruz.
                    baglanti.Close();
                }
                else if (dil == "English")
                {

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    komut.Connection = baglanti;
                    komut.CommandText = "update Ogrenci_Kayit set Kabul=@kabul where Ogrenci_No=" + ogrno + "";

                    komut.Parameters.AddWithValue("@kabul", "Kabul Edilmedi");

                    DialogResult sonuc = MessageBox.Show("This Action Cannot Be Undone!\nYour selection will be rejected. Are you sure?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (sonuc == DialogResult.Yes)
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("SELECTION REJECTED\nA MESSAGE HAS BEEN SENT TO THE STUDENT", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        baglanti.Close();

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;

                        komut.CommandText = "Delete from Secim_Tablosu where Ogrenci_No=" + ogrno + "";

                        komut.ExecuteNonQuery();

                        baglanti.Close();

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "update Ogrenci_Kayit set Secim=@Secim,Firma_Aciklama=@aciklama where Ogrenci_No=" + ogrno + "";

                        komut.Parameters.AddWithValue("@Secim", "✗");
                        komut.Parameters.AddWithValue("@aciklama", "");

                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "Select * from Secim_Tablosu where Firma_Adi='" + isim1 + "'";

                        SqlDataAdapter dataadapter = new SqlDataAdapter(komut);

                        DataTable veritablo = new DataTable();
                        dataadapter.Fill(veritablo);
                        StajyerGoster_Datagrid.DataSource = veritablo;

                        baglanti.Close();

                        OgrenciBilgi_Richtextbox.Clear();
                        OgrenciBilgi_Datagrid.DataSource = null;
                        FirmaAra_Textbox.Clear();
                    }
                    baglanti.Close();

                }

            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("LÜTFEN TABLODAN SEÇİMİNİZ YAPINIZ VEYA TEKRARDAN DENEYİNİZ","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dil == "English")
                {
                    MessageBox.Show("PLEASE MAKE A SELECTION FROM THE TABLE OR TRY AGAIN","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void Hesap_Button_Click(object sender, EventArgs e)
        {
            FirmaHesapAyarlari firmaHesapAyarlari = new FirmaHesapAyarlari();
            firmaHesapAyarlari.id = id;
            firmaHesapAyarlari.dil = dil;
            firmaHesapAyarlari.isim1 = isim1;
            firmaHesapAyarlari.firmano = firmano;
            firmaHesapAyarlari.Show();
            this.Hide();
        }

        private void UygulamaAyarlari_Button_Click(object sender, EventArgs e)
        {
            YoneticiUygulamaAyarlari yoneticiUygulamaAyarlari = new YoneticiUygulamaAyarlari();
            yoneticiUygulamaAyarlari.id = id;
            yoneticiUygulamaAyarlari.dil = dil;
            yoneticiUygulamaAyarlari.isim1 = isim1;
            yoneticiUygulamaAyarlari.firmano = firmano;
            yoneticiUygulamaAyarlari.Show();
            this.Hide();
        }
    }
}