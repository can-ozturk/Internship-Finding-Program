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
    public partial class EpostaDegistir : Form
    {
        public EpostaDegistir()
        {
            InitializeComponent();
        }

        SqlConnection baglanti; //SQL' e bağlantı sağlamak için baglanti adında bir SqlConnection belirledim.
        Baglanti baglanti1 = new Baglanti(); //SQL Bağlantımı almam için yeni nesne tanımladım.
        SqlDataReader okuma; //SQL komutlarını okumak için DataReader belirledim.

        public string dil;
        public int no;
        private void EpostaDegistir_Shown(object sender, EventArgs e)
        {
            try
            {

                baglanti = new SqlConnection(baglanti1.adres); //SQL Komutumu class'tan çağırdım
                SqlCommand komut = new SqlCommand(); //Komut yazmak için yeni bir komut oluşturdum.

                // Dil seçeneğine göre form üzerindeki metinler ayarlanıyor
                if (dil == "Türkçe")
                {
                    Ogr_Eposta_Label.Text = "MEVCUT E-POSTA ADRESİ";
                    YeniEposta_Label.Text = "YENİ E-POSTA ADRESİ";
                    EpostayıGuncelle_Textbox.PlaceholderText = "Yeni E-Posta Adresi";
                    this.Text = "E-POSTAYI DEĞİŞTİR";
                    Guncelle_Button.Text = "GÜNCELLE";

                }
                else if (dil == "English")
                {
                    Ogr_Eposta_Label.Text = "CURRENT EMAIL ADDRESS";
                    YeniEposta_Label.Text = "NEW EMAIL ADDRESS";
                    EpostayıGuncelle_Textbox.PlaceholderText = "New Email Address";
                    this.Text = "CHANGE EMAIL";
                    Guncelle_Button.Text = "UPDATE";


                }

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti; // SQL bağlantımı komutuma ekledim.
                komut.CommandText = "Select Ogrenci_Eposta from Ogrenci_Kayit where Ogrenci_No=" + no + "";  // Öğrenci numarasına göre mevcut e-posta adresini sorgulayan komut.
                okuma = komut.ExecuteReader(); // Sorguyu çalıştırıp sonuçları okuma adlı değişkene.

                if (okuma.Read()) // Veri mevcutsa Textboxlara yazdırdım.
                {
                    Ogr_Eposta_Textbox.Text = okuma["Ogrenci_Eposta"].ToString();

                }
                else // Veri yoksa "Boş" mesajını gösterdim.
                {
                    Ogr_Eposta_Textbox.Text = "";
                }
                baglanti.Close(); // Bağlantımı kapattım.
            }
            catch
            {
                // Hata durumunda dil seçeneğine göre kullanıcı bilgilendirilir.
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR SORUN MEYDANA GELDİ \nLÜTFEN TEKRAR DENEYİN VEYA YÖNETİCİYE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (dil == "English")
                {
                    MessageBox.Show("AN ISSUE OCCURRED \nPLEASE TRY AGAIN OR CONTACT THE ADMINISTRATOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close(); // Bağlantımı kapattım.
            }
        }

        private void EpostaDegistir_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapatıldığında Hesap Ayarları formuna geri dönülür.
            HesapAyarlari hesapAyarlari = new HesapAyarlari();
            hesapAyarlari.dil = dil; // Dil bilgisi aktarılır.
            hesapAyarlari.no = no; 
            hesapAyarlari.Show(); // Hesap Ayarları formu gösterilir.
            this.Hide(); // Mevcut form gizlenir.
        }

        private void Guncelle_Button_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti = new SqlConnection(baglanti1.adres); // Yeni SQL bağlantısı oluşturulur.

                SqlCommand komut = new SqlCommand();   // Komut nesnesi oluşturulur.

                if (dil == "Türkçe") // Türkçe dil seçeneği
                {

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Eğer bağlantı kapalıysa, bağlantıyı açıyoruz.


                    komut.Connection = baglanti; // Komutun bağlantısını ekliyoruz.


                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Eposta=@eposta where Ogrenci_No=" + no + "";    // SQL sorgusu: Öğrenci e-posta adresini güncelleme.

                    // Yeni e-posta parametre olarak eklenir.
                    komut.Parameters.AddWithValue("@eposta", EpostayıGuncelle_Textbox.Text);


                    if (EpostayıGuncelle_Textbox.Text == "") // E-posta alanı boşsa
                    {
                        MessageBox.Show("LÜTFEN YENİ E-POSTA ADRESİNİZİ GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // SQL sorgusu çalıştırılır.
                        komut.ExecuteNonQuery();
                        MessageBox.Show("BAŞARIYLA GÜNCELLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        // Formdaki metin kutusu temizlenir.
                        EpostayıGuncelle_Textbox.Clear();

                        baglanti.Close();

                        // Güncellenmiş e-posta adresini tekrar yüklemek için sorgu yapılır.
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        

                        komut.Connection = baglanti; 
                        komut.CommandText = "Select Ogrenci_Eposta from Ogrenci_Kayit where Ogrenci_No=" + no + "";
                        okuma = komut.ExecuteReader(); 

                        if (okuma.Read()) 
                        {
                            Ogr_Eposta_Textbox.Text = okuma["Ogrenci_Eposta"].ToString();

                        }
                        else // Veri yoksa "Boş" mesajını gösterdim.
                        {
                            Ogr_Eposta_Textbox.Text = "";
                        }
                        baglanti.Close(); // Bağlantı kapatılır.

                    }


                    baglanti.Close();// Bağlantıyı kapatıyoruz.
                }
                else if (dil == "English") // İngilizceye çevrilmiş hali.
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    komut.Connection = baglanti;

                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Eposta=@eposta where Ogrenci_No=" + no + "";

                    komut.Parameters.AddWithValue("@eposta", EpostayıGuncelle_Textbox.Text);

                    if (EpostayıGuncelle_Textbox.Text == "")
                    {
                        MessageBox.Show("PLEASE ENTER YOUR NEW EMAIL ADDRESS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EpostayıGuncelle_Textbox.Clear();
                        baglanti.Close();

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "Select Ogrenci_Eposta from Ogrenci_Kayit where Ogrenci_No=" + no + "";
                        okuma = komut.ExecuteReader();

                        if (okuma.Read())
                        {
                            Ogr_Eposta_Textbox.Text = okuma["Ogrenci_Eposta"].ToString();
                        }
                        else
                        {
                            Ogr_Eposta_Textbox.Text = "";
                        }
                        baglanti.Close();
                    }

                    baglanti.Close();

                }
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR SORUN MEYDANA GELDİ \nLÜTFEN BÜTÜN ALANLARI DOLDURUNUZ VEYA YÖNETİCİYE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (dil == "English")
                {
                    MessageBox.Show("AN ISSUE OCCURRED \nPLEASE FILL OUT ALL FIELDS OR CONTACT THE ADMINISTRATOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }
    }
}
