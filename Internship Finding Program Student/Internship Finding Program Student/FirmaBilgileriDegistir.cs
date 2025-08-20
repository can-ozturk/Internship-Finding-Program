using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // SQL bağlantıları için gerekli kütüphane

namespace Internship_Finding_Program_Student
{
    public partial class FirmaBilgileriDegistir : Form
    {
        public FirmaBilgileriDegistir()
        {
            InitializeComponent(); // Form bileşenlerini başlat
        }

        
        public int id;
        public string dil, isim1, firmano;

        SqlConnection baglanti; // SQL bağlantısı için kullanılan nesne
        Baglanti baglanti1 = new Baglanti(); // SQL bağlantı adresini içeren bir nesne

        // Form gösterildiğinde çalışacak olan metod
        private void FirmaBilgileriDegistir_Shown(object sender, EventArgs e)
        {
            try
            {
                // SQL bağlantısını başlat
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand(); // SQL komut nesnesi oluştur
                SqlDataReader okuma; // SQL sorgularını okumak için DataReader nesnesi

                // Dil seçeneğine göre form üzerindeki metinleri ayarla
                if (dil == "Türkçe")
                {
                    this.Text = "FİRMA BİLGİLERİ DEĞİŞTİR";
                    FirmaKriteri_Label.Text = "FİRMA KRİTERLERİ";
                    FirmaAciklama_Label.Text = "FİRMA AÇIKLAMASI";
                    FirmaKonumu_Label.Text = "FİRMA KONUMU";
                    FirmaWeb_Label.Text = "FİRMA WEB SİTESİ";
                    Guncelle_Button.Text = "GÜNCELLE";
                }
                else if (dil == "English")
                {
                    this.Text = "EDIT COMPANY INFORMATION";
                    FirmaKriteri_Label.Text = "COMPANY CRITERIA";
                    FirmaAciklama_Label.Text = "COMPANY DESCRIPTION";
                    FirmaKonumu_Label.Text = "COMPANY LOCATION";
                    FirmaWeb_Label.Text = "COMPANY WEBSITE";
                    Guncelle_Button.Text = "UPDATE";
                }

                // Firma Kriterleri bilgilerini SQL'den al ve form alanına yaz
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                komut.Connection = baglanti;
                komut.CommandText = "Select Firma_Kriterleri from Firma_Tablosu where Firma_Sıra_No='" + firmano + "'";
                okuma = komut.ExecuteReader();

                if (okuma.Read())
                {
                    string firmakriter = okuma["Firma_Kriterleri"]?.ToString();

                    if (!string.IsNullOrEmpty(firmakriter))
                    {
                        FirmaKriterleri_Richtext.Text = firmakriter;
                    }
                }
                baglanti.Close();

                // Firma Açıklaması bilgilerini SQL'den al ve form alanına yaz
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                komut.CommandText = "Select Firma_Aciklama from Firma_Tablosu where Firma_Sıra_No='" + firmano + "'";
                okuma = komut.ExecuteReader();

                if (okuma.Read())
                {
                    string firmaaciklama = okuma["Firma_Aciklama"]?.ToString();

                    if (!string.IsNullOrEmpty(firmaaciklama))
                    {
                        FirmaAciklamasi_RichText.Text = firmaaciklama;
                    }
                }
                baglanti.Close();

                // Firma Konum bilgilerini SQL'den al ve form alanına yaz
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                komut.CommandText = "Select Firma_Konum from Firma_Tablosu where Firma_Sıra_No='" + firmano + "'";
                okuma = komut.ExecuteReader();

                if (okuma.Read())
                {
                    string firmakonum = okuma["Firma_Konum"]?.ToString();

                    if (!string.IsNullOrEmpty(firmakonum))
                    {
                        FirmaKonumu_Textbox.Text = firmakonum;
                    }
                }
                baglanti.Close();

                // Firma Web bilgilerini SQL'den al ve form alanına yaz
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                komut.CommandText = "Select Firma_Web from Firma_Tablosu where Firma_Sıra_No='" + firmano + "'";
                okuma = komut.ExecuteReader();

                if (okuma.Read())
                {
                    string firmaweb = okuma["Firma_Web"]?.ToString();

                    if (!string.IsNullOrEmpty(firmaweb))
                    {
                        FirmaWeb_Textbox.Text = firmaweb;
                    }
                }
                baglanti.Close();

            }
            catch
            {
                // Hata durumunda uygun dilde mesaj göster
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

        // Form kapatılırken yapılacak işlemler
        private void FirmaBilgileriDegistir_FormClosing(object sender, FormClosingEventArgs e)
        {
            FirmaHesapAyarlari firmaHesapAyarlari = new FirmaHesapAyarlari();
            firmaHesapAyarlari.id = id;
            firmaHesapAyarlari.dil = dil;
            firmaHesapAyarlari.isim1 = isim1;
            firmaHesapAyarlari.firmano = firmano;
            firmaHesapAyarlari.Show(); // Firma hesap ayarları formunu göster
            this.Hide(); // Bu formu gizle
        }

        // Güncelle butonuna basıldığında çalışacak metod
        private void Guncelle_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand(); // SQL komut nesnesi oluştur

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                komut.Connection = baglanti;
                komut.CommandText = "update Firma_Tablosu set Firma_Konum=@konum,Firma_Aciklama=@aciklama,Firma_Kriterleri=@kriter,Firma_Web=@firmaweb where Firma_Sıra_No=" + firmano;

                // Kullanıcıdan alınan verileri parametre olarak ekle
                komut.Parameters.AddWithValue("@konum", FirmaKonumu_Textbox.Text);
                komut.Parameters.AddWithValue("@aciklama", FirmaAciklamasi_RichText.Text);
                komut.Parameters.AddWithValue("@kriter", FirmaKriterleri_Richtext.Text);
                komut.Parameters.AddWithValue("@firmaweb", FirmaWeb_Textbox.Text);

                // Boş alan kontrolü yap
                if (string.IsNullOrWhiteSpace(FirmaKonumu_Textbox.Text) || string.IsNullOrWhiteSpace(FirmaAciklamasi_RichText.Text) || string.IsNullOrWhiteSpace(FirmaKriterleri_Richtext.Text) || string.IsNullOrWhiteSpace(FirmaWeb_Textbox.Text))
                {
                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("PLEASE FILL IN ALL THE FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    komut.ExecuteNonQuery(); // Güncelleme işlemini çalıştır

                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("KAYIT BAŞARIYLA GÜNCELLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("RECORD UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                baglanti.Close(); // Bağlantıyı kapat
            }
            catch
            {
                // Hata durumunda uygun dilde mesaj göster
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİR HATA OLUŞTU LÜTFEN BÜTÜN BOŞLUKLARI DOLDURUNUZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED, PLEASE FILL IN ALL THE BLANKS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
