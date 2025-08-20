using System.Data;
using Microsoft.Data.SqlClient;
//SQL i dorğu çalıştırması için bu kütüphaneleri kullandım

namespace Internship_Finding_Program_Student
{
    public partial class Ogrenci_Kontrol_Paneli : Form
    {
        public Ogrenci_Kontrol_Paneli()
        {
            InitializeComponent();
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------

        SqlConnection baglanti; //SQL' e bağlantı sağlamak için baglanti adında bir SqlConnection belirledim.
        Baglanti baglanti1 = new Baglanti();



        public string dil, firmaAdi, Secim, firmaSiraNo = "", firmasirano1 = "", firmakriter = "", kabul; //Üç tane public olacak şekilde string veri türünde değişken tanımladım.
        object firmaaciklama = "";
        public int no; //Bir tane public olacak şekilde int veri türünde değişken tanımladım.
        private void Ogrenci_Kontrol_Paneli_Shown(object sender, EventArgs e)
        {


            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.
                SqlDataReader okuma; //SQL komutlarını okumak için DataReader belirledim.

                if (dil == "Türkçe")
                {


                    FirmaSec_Tabpage.Text = "FİRMA SEÇ";
                    Bilgileri_Kaydet_Firma_Button.Text = "BİLGİLERİ KAYDET";
                    Acıklama_Label.Text = "NEDEN STAJYER OLARAK SİZİ SEÇELİM ? KISACA KENDİNİZDEN BAHSEDİN";
                    KriterUyarı1_Label.Text = "KRİTERLERİ EKSİKSİZ \r\nYAZDIĞINIZDAN \r\nEMİN OLUNUZ";
                    KriterUyarı_Label.Text = "KRİTER BELİRLEME \r\nSEKMESİNİ DOLDURMAYAN \r\nADAYLARIN BAŞVURULARI \r\nGEÇERSİZ SAYILABİLİR!!!";
                    SecimBilgileri_Tabpage.Text = "SEÇİM BİLGİLERİ";
                    Firma_Bilgileri_Goruntule_Label.Text = "FİRMA BİLGİLERİ";
                    Yapılan_Acıklama_Label.Text = "KABUL EDİLMEK İÇİN YAPTIĞINIZ AÇIKLAMA";
                    this.Text = "ÖĞRENCİ KONTROL PANELİ";
                    Cıkıs_Button.Text = "OTURUMU KAPAT";
                    KriterUyari2_Label.Text = "TABLO ÜZERİNDEN FİRMA SEÇMEDEN BİLGİLERİ KAYDETMEYİN!!!";
                    SecimDurumu_Label.Text = "SEÇİM DURUMU: " + Secim;
                    Secimiptal_Button.Text = "SEÇİMİ İPTAL ET";
                    Bilgiler_Label.Text = "FİRMA SEÇİMİNİZİ İPTAL ETMEK İÇİN TIKLAYIN. **BU İŞLEM GERİ ALINMAZ**";
                    SecimBilgileri_Groupbox.Text = "BİLGİLER";
                    SecimBilgileri_Linklabel.Text = "SORUN BİLDİR";
                    FirmaSec_Linklabel.Text = "SORUN BİLDİR";
                    Kriter_Belirleme_TabPage.Text = "KRİTER BELİRLEME";
                    AkademikBasari_Groupbox.Text = "AKADEMİK BAŞARI";
                    Kriter1_Label.Text = "* BÖLÜMÜNÜZLE İLGİLİ BİLGİ SAHİBİ OLDUĞUNUZ ALANLARINIZI \r\nKISACA İZAH EDİNİZ";
                    Kriter2_Label.Text = "* VARSA DAHA ÖNCEDEN ALMIŞ OLDUĞUNUZ SERTİFİKA VE \r\nEĞİTİMLERİ YAZINIZ";
                    KriterleriGuncelle_Checkbox.Text = "KRİTERLERİ GÜNCELLE";
                    Kisisel_Groupbox.Text = "KİŞİSEL";
                    Hobiler_Label.Text = "VARSA İLGİLENDİĞİNİZ HOBİLER";
                    Hobiler2_Label.Text = "HOBİLER:";
                    Eklemekist_Label.Text = "EKLEMEK İSTEDİĞİNİZ";
                    BilgileriGuncelle_Kritersec_Button.Text = "BİLGİLERİ GÜNCELLE";
                    BilgileriKaydet_Kritersec_Button.Text = "BİLGİLERİ KAYDET";
                    UyarıKritersec_Label.Text = "SEÇİMDEN SONRA KRİTERLERİ DEĞİŞTİRMEK \r\nSEÇİM KARARINI ETKİLEYEBİLİR!!!\r\n";
                    SorunBildir_LİnkLabel.Text = "SORUN BİLDİR ";
                    UygulamaAyarlari_Button.Text = "UYGULAMA \r\nAYARLARI\r\n";
                    FirmaAra_Textbox.PlaceholderText = "🔍 Ara ";

                    BilgileriGoruntule_Button.Text = "HESAP AYARLARI";
                    FirmaKriter_Button.Text = "KRİTER VE FİRMA \r\nBELİRLE\r\n";

                }
                else if (dil == "English")
                {

                    FirmaSec_Tabpage.Text = "SELECT COMPANY";
                    Bilgileri_Kaydet_Firma_Button.Text = "SAVE INFORMATION";
                    KriterUyarı1_Label.Text = "MAKE SURE \r\nYOU HAVE WRITTEN \r\nTHE CRITERIA COMPLETELY";
                    KriterUyarı_Label.Text = "APPLICATIONS FROM \r\nCANDIDATES WHO DO NOT \r\nFILL OUT THE CRITERIA \r\nDETERMINATION TAB MAY \r\nBE CONSIDERED INVALID!!!";
                    Acıklama_Label.Text = "WHY SHOULD WE CHOOSE YOU AS AN INTERN? BRIEFLY INTRODUCE YOURSELF";
                    SecimBilgileri_Tabpage.Text = "CHOOSE INFORMATION";
                    Firma_Bilgileri_Goruntule_Label.Text = "COMPANY INFORMATION";
                    Yapılan_Acıklama_Label.Text = "YOUR EXPLANATION FOR BEING ACCEPTED";
                    this.Text = "STUDENT CONTROL PANEL";
                    Cıkıs_Button.Text = "LOG OUT";
                    SecimDurumu_Label.Text = "SELECTION STATUS: " + Secim;
                    KriterUyari2_Label.Text = "DO NOT SAVE INFORMATION WITHOUT SELECTING A COMPANY FROM THE TABLE!!!";
                    Secimiptal_Button.Text = "CANCEL SELECTION";
                    Bilgiler_Label.Text = "CLICK TO CANCEL YOUR COMPANY SELECTION. **THIS ACTION CANNOT BE UNDONE**";
                    SecimBilgileri_Groupbox.Text = "INFORMATION";
                    SecimBilgileri_Linklabel.Text = "REPORT ISSUE";
                    FirmaSec_Linklabel.Text = "REPORT ISSUE";
                    AkademikBasari_Groupbox.Text = "ACADEMIC ACHIEVEMENT";
                    Kriter1_Label.Text = "* BRIEFLY EXPLAIN THE AREAS YOU HAVE KNOWLEDGE ABOUT \r\nRELATED TO YOUR FIELD OF STUDY";
                    Kriter2_Label.Text = "* LIST ANY CERTIFICATES OR TRAININGS YOU HAVE PREVIOUSLY \r\nRECEIVED, IF ANY";
                    KriterleriGuncelle_Checkbox.Text = "UPDATE CRITERIA";
                    Kisisel_Groupbox.Text = "PERSONAL";
                    Hobiler_Label.Text = "HOBBIES YOU ARE INTERESTED IN, IF ANY";
                    Hobiler2_Label.Text = "HOBBIES:";
                    Eklemekist_Label.Text = "WHAT YOU WANT TO ADD";
                    BilgileriGuncelle_Kritersec_Button.Text = "UPDATE INFORMATION";
                    BilgileriKaydet_Kritersec_Button.Text = "SAVE INFORMATION";
                    UyarıKritersec_Label.Text = "CHANGING CRITERIA AFTER SELECTION MAY \r\nAFFECT YOUR SELECTION DECISION!!!\r\n";
                    SorunBildir_LİnkLabel.Text = "REPORT AN ISSUE";
                    UygulamaAyarlari_Button.Text = "APPLICATION SETTINGS";
                    Kriter_Belirleme_TabPage.Text = "CRITERIA DETERMINATION";
                    FirmaAra_Textbox.PlaceholderText = "🔍 Search ";
                    BilgileriGoruntule_Button.Text = "ACCOUNT \r\nSETTINGS\r\n";
                    FirmaKriter_Button.Text = "SET CRITERIA AND \r\nCOMPANY DEFINE";



                }

                FirmaKriter_Button.FlatAppearance.BorderSize = 1;
                FirmaKriter_Button.FlatStyle = FlatStyle.Standard;

                BilgileriGoruntule_Button.FlatAppearance.BorderSize = 0;
                BilgileriGoruntule_Button.FlatStyle = FlatStyle.Flat;

                UygulamaAyarlari_Button.FlatAppearance.BorderSize = 0;
                UygulamaAyarlari_Button.FlatStyle = FlatStyle.Flat;

                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
                //Yukarıda kş kodlar dil kodları.


                SecimBilgileri_Tabpage.BackColor = Color.Silver;
                FirmaSec_Tabpage.BackColor = Color.Silver;
                SecimBilgieri1_Groupbox.BackColor = Color.Silver;
                SecimBilgileri_Groupbox.BackColor = Color.Silver;
                this.BackColor = Color.Silver;
                Yapılan_Acıklama_RichTextbox.Enabled = false;
                Firma_Bilgileri_Goruntule_DataGrid.Enabled = true;
                BilgileriGuncelle_Kritersec_Button.Visible = false;
                Firma_Sec_TabPage.BackColor = Color.Silver;
                KriterleriGuncelle_Checkbox.ForeColor = Color.Red;
                KriterleriGuncelle_Checkbox.Visible = false;
                Eklemekist_Label.Visible = false;
                Eklemekist_RichTextbox.Visible = false;
                Kriter_Belirleme_TabPage.BackColor = Color.Silver;
                AkademikBasari_Groupbox.BackColor = Color.Silver;
                Kisisel_Groupbox.BackColor = Color.Silver;

                //Yukarıda ki kodlar genel olarak form rengini, yazı ve görünememesi gereken bir kaç aracı gizledim ve düzenledim.

                //---------------------------------------------------------------
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti;  //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Kabul from Ogrenci_Kayit where Ogrenci_No=" + no + ""; //Kabul alan bir komut yazdım.
                okuma = komut.ExecuteReader();  // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.

                while (okuma.Read())
                {
                    kabul = (okuma["Kabul"].ToString()); // Komutta yer alan Kabul da hangi değer varsa onu kabula atadım.

                }
                baglanti.Close(); // Bağlantımı kapattım.

                if (kabul == "Kabul Edilmedi")
                {
                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("STAJ BAŞVURUNUZ KABUL EDİLMEDİ !", "RED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "update Ogrenci_Kayit set Kabul=@kabul where Ogrenci_No=" + no + "";
                        komut.Parameters.AddWithValue("@kabul", "Kabul Durumu Yok");
                        komut.ExecuteNonQuery();

                        baglanti.Close();

                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("YOUR INTERNSHIP APPLICATION HAS BEEN REJECTED!", "REJECTED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "update Ogrenci_Kayit set Kabul=@kabul where Ogrenci_No=" + no + "";
                        komut.Parameters.AddWithValue("@kabul", "Kabul Durumu Yok");
                        komut.ExecuteNonQuery();

                        baglanti.Close();


                    }

                }
                //---------------------------------------------------------------

                Hobiler hobiler = new Hobiler(); // Hobiler sınıfından bir nesne oluşturdum.
                Hobiler gym = new Gym();
                Hobiler yuzmek = new Yuzmek();
                Hobiler kitap = new Kitap();
                Hobiler film = new Film();
                Hobiler resim = new Resim();
                Hobiler yuzmeking = new Yuzmeking();
                Hobiler kitaping = new Kitaping();
                Hobiler filming = new Filming();
                Hobiler resiming = new Resiming();



               

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti;  //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select * from Secim_Tablosu where Ogrenci_No=" + no + ""; //Firma sıra noyu alan bir komut yazdım.
                okuma = komut.ExecuteReader();  // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.

                while (okuma.Read())
                {
                    firmasirano1 = (okuma["Firma_Sıra_No"].ToString()); // Komutta yer alan firma_sıra_no da hangi değer varsa onu firmasirano ya atadım.

                }

                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti;  //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select * from Secim_Tablosu where Ogrenci_No=" + no + ""; //Firma sıra noyu alan bir komut yazdım.
                okuma = komut.ExecuteReader();  // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.

                while (okuma.Read())
                {
                    firmasirano1 = (okuma["Firma_Sıra_No"].ToString()); // Komutta yer alan firma_sıra_no da hangi değer varsa onu firmasirano ya atadım.

                }

                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed) //Bağlantım eğer kapalı ise bağlantımı aç dedim.
                    baglanti.Open(); //Bağlantımı açtım.

                komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Ogrenci_Bilgi from Ogrenci_Kayit where Ogrenci_No=" + no + ""; //Bilgileri Kriter1_Richtexboxa çağırmak için komut yazdım.
                okuma = komut.ExecuteReader(); //Komutumu çalıştırdım ve okudum ve bunu okuma adlı değişkene atadım.
                if (okuma.Read())
                {
                    string ogrenciBilgi = okuma["Ogrenci_Bilgi"]?.ToString(); //SQL de Ogrenci_Bilgi adlı sütunda hangi veri varsa onu ogrencBilgi ye atadı.

                    if (!string.IsNullOrEmpty(ogrenciBilgi)) // Sütun dolu olup olmadığını kontrol ettim.
                    {
                        Kriter1_RichTextbox.Text = ogrenciBilgi; // Bilgi varsa çalışacak komut. Kriter1_Richtextboxa ogrenciBilgi yi yazdırdı.

                        Kriter1_RichTextbox.Enabled = false;
                        BilgileriKaydet_Kritersec_Button.Visible = false;
                        BilgileriGuncelle_Kritersec_Button.Visible = true;
                        KriterleriGuncelle_Checkbox.Visible = true;
                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                    }
                    else
                    {
                        Kriter1_RichTextbox.Text = ""; // Sütun boşsa çalışacak komut Kriter1_Richtextboxa Boş yazdırdı.

                        Kriter1_RichTextbox.Enabled = true;
                        BilgileriKaydet_Kritersec_Button.Visible = true;
                        BilgileriGuncelle_Kritersec_Button.Visible = false;
                        KriterleriGuncelle_Checkbox.Visible = false;
                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                    }
                }
                else
                {
                    Kriter1_RichTextbox.Text = ""; // Kayıt yoksa çalışacak komut. Kriter1_Richtextboxa Boş yazdırdı.

                    Kriter1_RichTextbox.Enabled = true;
                    BilgileriKaydet_Kritersec_Button.Visible = true;
                    BilgileriGuncelle_Kritersec_Button.Visible = false;
                    KriterleriGuncelle_Checkbox.Visible = false;
                    // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                }
                baglanti.Close();//bağlantımı kapattım

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed) //Bağlantım eğer kapalı ise bağlantımı aç dedim.
                    baglanti.Open(); //Bağlantımı açtım.

                komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Ogrenci_Sertifika_Egitim from Ogrenci_Kayit where Ogrenci_No=" + no + ""; //Bilgileri Kriter2_Richtexboxa çağırmak için komut yazdım.
                okuma = komut.ExecuteReader(); //Komutumu çalıştırdım ve okudum ve bunu okuma adlı değişkene atadım.
                if (okuma.Read())
                {
                    string OgrenciSertifika = okuma["Ogrenci_Sertifika_Egitim"]?.ToString(); //Sertifika verisini OgrenciSertifika değişkenine atadım.

                    if (!string.IsNullOrEmpty(OgrenciSertifika)) // Sertifika bilgisi varsa RichTextBox'a yazdırdım. dolu olup olmadığını kontrol ettim.
                    {
                        Kriter2_RichTextbox.Text = OgrenciSertifika;
                        Kriter2_RichTextbox.Enabled = false;
                        BilgileriKaydet_Kritersec_Button.Visible = false;
                        BilgileriGuncelle_Kritersec_Button.Visible = true;
                        KriterleriGuncelle_Checkbox.Visible = true;
                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                    }
                    else
                    {
                        Kriter2_RichTextbox.Text = "";  // Sertifika bilgisi yoksa kullanıcıya "Boş" gösterdim. Sütun boşsa çalışacak komut.

                        Kriter2_RichTextbox.Enabled = true;
                        BilgileriKaydet_Kritersec_Button.Visible = true;
                        BilgileriGuncelle_Kritersec_Button.Visible = false;
                        KriterleriGuncelle_Checkbox.Visible = false;
                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                    }


                }
                else
                {
                    Kriter2_RichTextbox.Text = ""; // Veri yoksa "Boş" mesajını gösterdim.

                    Kriter2_RichTextbox.Enabled = true;
                    BilgileriKaydet_Kritersec_Button.Visible = true;
                    BilgileriGuncelle_Kritersec_Button.Visible = false;
                    KriterleriGuncelle_Checkbox.Visible = false;
                    // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                }
                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------


                // Gym, Yuzmek, Kitap, Film ve Resim sınıflarından türetilen Hobiler nesneleri oluşturdum.

                if (dil == "Türkçe")
                {
                    Hobiler_Combobox.Items.Add(gym.hobi());
                    Hobiler_Combobox.Items.Add(yuzmek.hobi());
                    Hobiler_Combobox.Items.Add(kitap.hobi());
                    Hobiler_Combobox.Items.Add(film.hobi());
                    Hobiler_Combobox.Items.Add(resim.hobi());
                }
                else if (dil == "English")
                {
                    Hobiler_Combobox.Items.Add(gym.hobi());
                    Hobiler_Combobox.Items.Add(yuzmeking.hobi());
                    Hobiler_Combobox.Items.Add(kitaping.hobi());
                    Hobiler_Combobox.Items.Add(filming.hobi());
                    Hobiler_Combobox.Items.Add(resiming.hobi());
                }



                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Ogrenci_Hobi from Ogrenci_Kayit where Ogrenci_No=" + no + ""; // Öğrencinin hobisini "Ogrenci_No" değerine göre sorguladım.
                okuma = komut.ExecuteReader(); // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.
                if (okuma.Read())
                {
                    string OgrenciHobi = okuma["Ogrenci_Hobi"]?.ToString();  // Veritabanından hobiyi okuyup OgrenciHobi değişkenine atadım.

                    if (!string.IsNullOrEmpty(OgrenciHobi))
                    {
                        Hobiler_Combobox.Text = OgrenciHobi; // Eğer hobi mevcutsa ComboBox'ta gösterdim.

                        Eklemekist_Label.Visible = true;
                        Eklemekist_RichTextbox.Visible = true;
                        Eklemekist_RichTextbox.Enabled = false;
                        Hobiler_Combobox.Enabled = false;
                        BilgileriKaydet_Kritersec_Button.Visible = false;
                        BilgileriGuncelle_Kritersec_Button.Visible = true;
                        KriterleriGuncelle_Checkbox.Visible = true;
                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                    }
                    else // Hobi boşsa, varsayılan hobiyi ComboBox'ta gösterdim.
                    {
                        if (dil == "Türkçe")
                        {
                            Hobiler_Combobox.Text = hobiler.hobi().ToString();
                        }
                        else if (dil == "English")
                        {
                            Hobiler_Combobox.Text = hobiler.inghobi().ToString();
                        }

                        Eklemekist_Label.Visible = false;
                        Eklemekist_RichTextbox.Visible = false;
                        Eklemekist_RichTextbox.Enabled = true;
                        Hobiler_Combobox.Enabled = true;
                        BilgileriKaydet_Kritersec_Button.Visible = true;
                        BilgileriGuncelle_Kritersec_Button.Visible = false;
                        KriterleriGuncelle_Checkbox.Visible = false;
                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz.

                    }
                }
                else // Okuma başarısızsa varsayılan hobiyi gösterdim.
                {

                    if (dil == "Türkçe")
                    {
                        Hobiler_Combobox.Text = hobiler.hobi().ToString();
                    }
                    else if (dil == "English")
                    {
                        Hobiler_Combobox.Text = hobiler.inghobi().ToString();
                    }

                    Eklemekist_Label.Visible = false;
                    Eklemekist_RichTextbox.Visible = false;
                    Eklemekist_RichTextbox.Enabled = true;
                    Hobiler_Combobox.Enabled = true;
                    BilgileriKaydet_Kritersec_Button.Visible = true;
                    BilgileriGuncelle_Kritersec_Button.Visible = false;
                    KriterleriGuncelle_Checkbox.Visible = false;
                    // Formdaki belirli öğelerin durumlarını değiştiriyoruz


                }
                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti; // SQL bağlantımı komutuma ekledim.
                komut.CommandText = "Select Ogrenci_Eklemekistediginiz from Ogrenci_Kayit where Ogrenci_No=" + no + ""; // Öğrencinin eklemek istediği bilgiyi sorguladım.
                okuma = komut.ExecuteReader(); // Sorguyu çalıştırıp sonuçları okuma adlı değişkene atadım.

                if (okuma.Read())
                {
                    Eklemekist_RichTextbox.Text = okuma["Ogrenci_Eklemekistediginiz"].ToString();  // Veri mevcutsa RichTextBoxa'a yazdırdım.

                }
                else
                {
                    Eklemekist_RichTextbox.Text = "";  // Veri yoksa "Boş" mesajını gösterdim.
                }
                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti; //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select Secim from Ogrenci_Kayit where Ogrenci_No=" + no + ""; // Öğrencinin Onayını "Ogrenci_No" değerine göre sorguladım.
                okuma = komut.ExecuteReader(); // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.
                if (okuma.Read())
                {
                    Secim = okuma["Secim"]?.ToString();  // Veritabanından Onayı okuyup OgrenciHobi değişkenine atadım.

                    if (dil == "Türkçe")
                    {
                        SecimDurumu_Label.Text = "SEÇİM DURUMU: " + Secim;
                    }
                    else if (dil == "English")
                    {
                        SecimDurumu_Label.Text = "SELECTION STATUS: " + Secim;
                    }


                    if (Secim == "✓")
                    {
                        Acıklama_RichTextbox.Enabled = false;
                        FirmaAra_Textbox.Enabled = false;
                        Yenile_Picturebox.Enabled = false;
                        Firma_Bilgileri_DataGrid.Enabled = false;
                        Bilgileri_Kaydet_Firma_Button.Enabled = false;
                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                    }
                    else if (Secim == "✗")
                    {
                        Acıklama_RichTextbox.Enabled = true;
                        Yenile_Picturebox.Enabled = true;
                        Firma_Bilgileri_DataGrid.Enabled = true;
                        Bilgileri_Kaydet_Firma_Button.Enabled = true;
                        FirmaAra_Textbox.Enabled = true;
                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                    }
                }
                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.


                komut.Connection = baglanti;
                komut.CommandText = "Select * from Firma_Tablosu"; // Firma bilgilerini sorgulamak için bir SQL komutu yazdım.

                SqlDataAdapter dataadapter = new SqlDataAdapter(komut); // Sorgudan dönen verileri almak için bir DataAdapter oluşturup komutu buna bağladım.

                DataTable veritablo = new DataTable(); // Gelen verileri depolamak için bir DataTable oluşturup bunu doldurdum.
                dataadapter.Fill(veritablo); // DataTable içine verileri aktardım.
                Firma_Bilgileri_DataGrid.DataSource = veritablo; // DataGrid'e DataTable verisini bağlayarak verileri görselleştirdim.

                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------
                if (Secim == "✓")
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.


                    komut.Connection = baglanti;
                    komut.CommandText = "Select * from Firma_Tablosu where Firma_Sıra_No =" + firmasirano1 + ""; // Firma bilgilerini sorgulamak için bir SQL komutu yazdım.


                    SqlDataAdapter dataadapter1 = new SqlDataAdapter(komut); // Sorgudan dönen verileri almak için bir DataAdapter oluşturup komutu buna bağladım.

                    DataTable veritablo1 = new DataTable(); // Gelen verileri depolamak için bir DataTable oluşturup bunu doldurdum.
                    dataadapter1.Fill(veritablo1); // DataTable içine verileri aktardım.
                    Firma_Bilgileri_Goruntule_DataGrid.DataSource = veritablo1; // DataGrid'e DataTable verisini bağlayarak verileri görselleştirdim.

                    baglanti.Close(); // Bağlantımı kapattım.
                }
                else
                {
                    Firma_Bilgileri_Goruntule_DataGrid.DataSource = null; // Eğer ki gerekli veri yoksa datagridi temizle
                }

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti; // SQL bağlantımı komutuma ekledim.
                komut.CommandText = "Select Firma_Aciklama from Ogrenci_Kayit where Ogrenci_No=" + no + ""; // Öğrencinin eklemek istediği bilgiyi sorguladım.
                okuma = komut.ExecuteReader(); // Sorguyu çalıştırıp sonuçları okuma adlı değişkene atadım.

                if (okuma.Read())
                {
                    Yapılan_Acıklama_RichTextbox.Text = okuma["Firma_Aciklama"].ToString();  // Veri mevcutsa RichTextBoxa'a yazdırdım.

                }
                else
                {
                    Yapılan_Acıklama_RichTextbox.Text = "";  // Veri yoksa "Boş" mesajını gösterdim.
                }
                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("BİLİNMEYEN BİR HATA MEYDANA GELDİ\nLÜTFEN YÖNETİCİYE BAŞVURUN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dil == "English")
                {
                    MessageBox.Show("AN UNKNOWN ERROR OCCURRED\nPLEASE CONTACT THE ADMINISTRATOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }




        private void BilgileriKaydet_FirmaSec_Button_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                if (dil == "Türkçe")
                {

                 


                    SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Eğer bağlantı kapalıysa, bağlantıyı açıyoruz.


                    komut.Connection = baglanti; // Komutun bağlantısını ekliyoruz.


                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Bilgi=@bilgi,Ogrenci_Sertifika_Egitim=@egitim,Ogrenci_Hobi=@hobi,Ogrenci_Eklemekistediginiz=@eklemekist where Ogrenci_No=" + no + "";  // Güncelleme sorgusu: Veritabanındaki belirli bir öğrencinin kayıtlarını güncellemek için SQL komutunu tanımlıyoruz.

                    // Parametreler aracılığıyla formdaki verileri sorguya bağlıyoruz.
                    komut.Parameters.AddWithValue("@bilgi", Kriter1_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@egitim", Kriter2_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@hobi", Hobiler_Combobox.Text);
                    komut.Parameters.AddWithValue("@eklemekist", Eklemekist_RichTextbox.Text);


                    if (Kriter1_RichTextbox.Text == "" || Kriter2_RichTextbox.Text == "" || Hobiler_Combobox.Text == "" || Eklemekist_RichTextbox.Text == "") // Alanlardan biri boşsa hata mesajı gösteriyoruz.
                    {
                        MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Eğer tüm alanlar doluysa SQL sorgusunu çalıştırıyoruz.
                        komut.ExecuteNonQuery();
                        MessageBox.Show("KAYIT BAŞARIYLA EKLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                        Kriter1_RichTextbox.Enabled = false;
                        Kriter2_RichTextbox.Enabled = false;
                        Eklemekist_Label.Visible = true;
                        Eklemekist_RichTextbox.Visible = true;
                        Eklemekist_RichTextbox.Enabled = false;
                        Hobiler_Combobox.Enabled = false;
                        BilgileriKaydet_Kritersec_Button.Visible = false;
                        BilgileriGuncelle_Kritersec_Button.Visible = true;
                        KriterleriGuncelle_Checkbox.Visible = true;
                    }


                    baglanti.Close();// Bağlantıyı kapatıyoruz.

                    //---------------------------------------------------------------

                }
                else if (dil == "English")  // İngilizce dil seçeneği için aynı işlemleri yapıyoruz, fakat mesajlar İngilizce olarak değişiyor
                {

                    

                    SqlCommand komut = new SqlCommand();
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    komut.Connection = baglanti;
                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Bilgi=@bilgi,Ogrenci_Sertifika_Egitim=@egitim,Ogrenci_Hobi=@hobi,Ogrenci_Eklemekistediginiz=@eklemekist where Ogrenci_No=" + no + "";
                    komut.Parameters.AddWithValue("@bilgi", Kriter1_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@egitim", Kriter2_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@hobi", Hobiler_Combobox.Text);
                    komut.Parameters.AddWithValue("@eklemekist", Eklemekist_RichTextbox.Text);

                    if (Kriter1_RichTextbox.Text == "" || Kriter2_RichTextbox.Text == "" || Hobiler_Combobox.Text == "" || Eklemekist_RichTextbox.Text == "")
                    {
                        MessageBox.Show("PLEASE FILL IN ALL THE FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("RECORD ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Kriter1_RichTextbox.Enabled = false;
                        Kriter2_RichTextbox.Enabled = false;
                        Eklemekist_Label.Visible = true;
                        Eklemekist_RichTextbox.Visible = true;
                        Eklemekist_RichTextbox.Enabled = false;
                        Hobiler_Combobox.Enabled = false;
                        BilgileriKaydet_Kritersec_Button.Visible = false;
                        BilgileriGuncelle_Kritersec_Button.Visible = true;
                        KriterleriGuncelle_Checkbox.Visible = true;
                    }
                    baglanti.Close();
                }


                //---------------------------------------------------------------

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
            }
        }
        //---------------------------------------------------------------
        private void BilgileriGuncelle_FirmaSec_Button_Click(object sender, EventArgs e)
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
                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Bilgi=@bilgi,Ogrenci_Sertifika_Egitim=@egitim,Ogrenci_Hobi=@hobi,Ogrenci_Eklemekistediginiz=@eklemekist where Ogrenci_No=" + no + "";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                    komut.Parameters.AddWithValue("@bilgi", Kriter1_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@egitim", Kriter2_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@hobi", Hobiler_Combobox.Text);
                    komut.Parameters.AddWithValue("@eklemekist", Eklemekist_RichTextbox.Text);
                    // Kullanıcıdan alınan verileri parametre olarak ekliyoruz


                    if (Kriter1_RichTextbox.Text == "" || Kriter2_RichTextbox.Text == "" || Hobiler_Combobox.Text == "" || Eklemekist_RichTextbox.Text == "") // Eğer herhangi bir alan boş bırakılmışsa kullanıcıyı uyarıyoruz.
                    {
                        MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        // SQL komutunu çalıştırıyoruz ve veritabanını güncelliyoruz.
                        komut.ExecuteNonQuery(); // SQL komutunu çalıştırıyoruz.
                        MessageBox.Show("KAYIT BAŞARIYLA GÜNCELLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    komut.CommandText = "update Ogrenci_Kayit set Ogrenci_Bilgi=@bilgi,Ogrenci_Sertifika_Egitim=@egitim,Ogrenci_Hobi=@hobi,Ogrenci_Eklemekistediginiz=@eklemekist where Ogrenci_No=" + no + "";

                    komut.Parameters.AddWithValue("@bilgi", Kriter1_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@egitim", Kriter2_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@hobi", Hobiler_Combobox.Text);
                    komut.Parameters.AddWithValue("@eklemekist", Eklemekist_RichTextbox.Text);


                    if (Kriter1_RichTextbox.Text == "" || Kriter2_RichTextbox.Text == "" || Hobiler_Combobox.Text == "" || Eklemekist_RichTextbox.Text == "")
                    {
                        MessageBox.Show("PLEASE FILL IN ALL THE FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {

                        komut.ExecuteNonQuery();
                        MessageBox.Show("RECORD UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    baglanti.Close();

                }

                //---------------------------------------------------------------

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
            }
        }

        private void KriterleriGuncelle_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (KriterleriGuncelle_Checkbox.Checked == true) // Kriterlerimi güncelle Checkbox'una tik atınca Güncelle butonun açıyor.
            {
                BilgileriGuncelle_Kritersec_Button.Enabled = true;
                Kriter1_RichTextbox.Enabled = true;
                Kriter2_RichTextbox.Enabled = true;
                Hobiler_Combobox.Enabled = true;
                Eklemekist_RichTextbox.Enabled = true;
                // Formdaki belirli öğelerin durumlarını değiştiriyoruz

            }
            else // Kriterlerimi güncelle Checkbox'una tiki kaldırınca ekle butonunu açıyor.
            {
                BilgileriGuncelle_Kritersec_Button.Enabled = false;
                Kriter1_RichTextbox.Enabled = false;
                Kriter2_RichTextbox.Enabled = false;
                Hobiler_Combobox.Enabled = false;
                Eklemekist_RichTextbox.Enabled = false;
                // Formdaki belirli öğelerin durumlarını değiştiriyoruz
            }
        }

        //---------------------------------------------------------------
        private void Hobiler_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eklemekist_Label.Visible = true;
            Eklemekist_RichTextbox.Visible = true;
        }

        //---------------------------------------------------------------

        private void Bilgileri_Kaydet_Firma_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand(); // İlk SQL komutu için nesne oluşturuyoruz.

                if (dil == "Türkçe") // Kullanıcı dil tercihine göre işlem yapıyoruz.
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open(); // Bağlantı kapalıysa açıyoruz.

                    komut.Connection = baglanti; // SQL komutuna bağlantıyı ekliyoruz.
                    komut.CommandText = "insert into Secim_Tablosu (Ogrenci_No,Ogrenci_Aciklama,Firma_Sıra_No,Firma_Adi,Firma_Kriterleri,Firma_Aciklama) values(@no,@aciklama,@sira,@firmaadi,@firmakriterleri,@firmaaciklama)"; // Tabloya ekleme işlemini gerçekleştirmek için komut yazıyorum.

                    // Parametreler aracılığıyla formdaki verileri, ve değikendeki verileri sorguya bağlıyoruz.
                    komut.Parameters.AddWithValue("@no", no);
                    komut.Parameters.AddWithValue("@aciklama", Acıklama_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@sira", firmaSiraNo);
                    komut.Parameters.AddWithValue("@firmaadi", firmaAdi);
                    komut.Parameters.AddWithValue("@firmakriterleri", firmakriter);
                    komut.Parameters.AddWithValue("@firmaaciklama", firmaaciklama);


                    if (Acıklama_RichTextbox.Text == "") // Alanın boş olup olmadığını kontrol ediyoruz.
                    {
                        MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                        MessageBox.Show("KAYIT BAŞARIYLA EKLENDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Acıklama_RichTextbox.Enabled = false;
                        Yenile_Picturebox.Enabled = false;
                        Firma_Bilgileri_DataGrid.Enabled = false;
                        Bilgileri_Kaydet_Firma_Button.Enabled = false;
                        FirmaAra_Textbox.Enabled = false;

                        // Formdaki belirli öğelerin durumlarını değiştiriyoruz
                    }
                    baglanti.Close(); // Bağlantıyı kapatıyoruz.

                    //---------------------------------------------------------------
                    if (!(Acıklama_RichTextbox.Text == ""))
                    {
                        // Güncelleme işlemleri için bağlantıyı yeniden açıyoruz.
                        if (baglanti.State == ConnectionState.Closed)

                            baglanti.Open();

                        komut.Connection = baglanti; // SQL komutuna bağlantıyı ekliyoruz.

                        komut.CommandText = "update Ogrenci_Kayit set Secim=@secim,Firma_Aciklama=@aciklamaa where Ogrenci_No=" + no; // Tabloya güncelleme işlemini gerçekleştirmek için komut yazıyorum.

                        komut.Parameters.AddWithValue("@secim", "✓");
                        komut.Parameters.AddWithValue("@aciklamaa", Acıklama_RichTextbox.Text);
                        // Parametreler aracılığıyla formdaki verileri sorguya bağlıyoruz.

                        komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                        baglanti.Close(); // Bağlantıyı kapatıyoruz.
                        Acıklama_RichTextbox.Clear();
                        SecimDurumu_Label.Text = "SEÇİM DURUMU: " + "✓";
                        Secim = "✓";


                    }
                    //---------------------------------------------------------------

                }
                else if (dil == "English") // İngilizce dil seçeneği için aynı işlemleri yaptım.
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    komut.Connection = baglanti;
                    komut.CommandText = "insert into Secim_Tablosu (Ogrenci_No,Ogrenci_Aciklama,Firma_Sıra_No,Firma_Adi,Firma_Kriterleri,Firma_Aciklama) values(@no,@aciklama,@sira,@firmaadi,@firmakriterleri,@firmaaciklama)";
                    komut.Parameters.AddWithValue("@no", no);
                    komut.Parameters.AddWithValue("@aciklama", Acıklama_RichTextbox.Text);
                    komut.Parameters.AddWithValue("@sira", firmaSiraNo);
                    komut.Parameters.AddWithValue("@firmaadi", firmaAdi);
                    komut.Parameters.AddWithValue("@firmakriterleri", firmakriter);
                    komut.Parameters.AddWithValue("@firmaaciklama", firmaaciklama);

                    if (Acıklama_RichTextbox.Text == "")
                    {
                        MessageBox.Show("PLEASE FILL IN ALL FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("RECORD ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Acıklama_RichTextbox.Enabled = false;
                        Yenile_Picturebox.Enabled = false;
                        Firma_Bilgileri_DataGrid.Enabled = false;
                        Bilgileri_Kaydet_Firma_Button.Enabled = false;
                        FirmaAra_Textbox.Enabled = false;
                    }
                    baglanti.Close();

                    //---------------------------------------------------------------
                    if (!(Acıklama_RichTextbox.Text == ""))
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "update Ogrenci_Kayit set Secim=@secim,Firma_Aciklama=@aciklamaa where Ogrenci_No=" + no;
                        komut.Parameters.AddWithValue("@secim", "✓");
                        komut.Parameters.AddWithValue("@aciklamaa", Acıklama_RichTextbox.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        Acıklama_RichTextbox.Clear();
                        SecimDurumu_Label.Text = "SELECTION STATUS: " + "✓";
                        Secim = "✓";
                    }

                }
            }
            //}

            //---------------------------------------------------------------

            catch
            {
                if (dil == "Türkçe") //Türkçe dil seçeneği seçiliyse Türkçe bir şekilde hata verecek.
                {
                    MessageBox.Show("LÜTFEN AÇIKLAMA KISMINI DOLDURDUĞUNUZDAN VE FİRMA SEÇTİĞİNİZDEN EMİN OLUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dil == "English") //İnglizce dil seçeneği seçiliyse İnglizce bir şekilde hata verecek.
                {
                    MessageBox.Show("PLEASE MAKE SURE THAT YOU HAVE FILLED OUT THE DESCRIPTION SECTION AND SELECTED A COMPANY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }


        }



        //---------------------------------------------------------------
        private void Firma_Bilgileri_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Firna sıra no ve firma adını datagridviewden alıyor ve değişkene atıyor.
            try
            {

                if (Firma_Bilgileri_DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Firma_Bilgileri_DataGrid.CurrentRow.Selected = true;

                    firmaSiraNo = Firma_Bilgileri_DataGrid.Rows[e.RowIndex].Cells["Firma_Sıra_No"].FormattedValue.ToString();
                    firmaAdi = Firma_Bilgileri_DataGrid.Rows[e.RowIndex].Cells["Firma_Adi"].FormattedValue.ToString();
                    firmakriter = Firma_Bilgileri_DataGrid.Rows[e.RowIndex].Cells["Firma_Kriterleri"].FormattedValue.ToString();
                    firmaaciklama = Firma_Bilgileri_DataGrid.Rows[e.RowIndex].Cells["Firma_Aciklama"].FormattedValue.ToString();
                }
            }
            catch
            {

            }


        }
        //---------------------------------------------------------------
        private void Secimiptal_Button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand();   // Komut yazmak için yeni bir komut oluşturdum.

                if (SecimDurumu_Label.Text == "SEÇİM DURUMU: " + "✓" || SecimDurumu_Label.Text == "SELECTION STATUS: " + "✓")
                {
                    if (dil == "Türkçe")
                    {

                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        // Eğer bağlantı kapalıysa, bağlantıyı açıyoruz.


                        komut.Connection = baglanti; // Komutun bağlantısını ekliyoruz.

                        komut.CommandText = "Delete from Secim_Tablosu where Ogrenci_No=" + no + "";  // Belirtilen Öğrenci numarasına ait kişinin verileri silinmesi için komut yazdım.

                        DialogResult sonuc = MessageBox.Show("Seçiminiz silinecek emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Silme işlemi için kullanıcıdan onay alıyor.
                        if (sonuc == DialogResult.Yes)
                        {
                            komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                            MessageBox.Show("SEÇİM BAŞARIYLA SİLİNDİ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            baglanti.Close();// Bağlantıyı kapatıyoruz.

                            Acıklama_RichTextbox.Enabled = true;
                            Yenile_Picturebox.Enabled = true;
                            Firma_Bilgileri_DataGrid.Enabled = true;
                            Bilgileri_Kaydet_Firma_Button.Enabled = true;
                            FirmaAra_Textbox.Enabled = true;
                            SecimDurumu_Label.Text = "SEÇİM DURUMU: " + "✗";
                            // Formdaki belirli öğelerin durumlarını değiştiriyoruz

                            //---------------------------------------------------------------

                            if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();
                            // Bağlantım eğer kapalı ise bağlantımı açtım.

                            komut.Connection = baglanti; // Komutun bağlantısını belirtiyoruz.
                            komut.CommandText = "update Ogrenci_Kayit set Secim=@Secim,Firma_Aciklama=@aciklama where Ogrenci_No=" + no + "";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.

                            komut.Parameters.AddWithValue("@Secim", "✗");
                            komut.Parameters.AddWithValue("@aciklama", "");
                            // Kullanıcıdan alınan verileri parametre olarak ekliyoruz.

                            komut.ExecuteNonQuery(); // Komutu çalıştırıyoruz.
                            Secim = "✗"; //Seçim adlı public stringe çarpı işareti atıyoruz.

                            // Bağlantıyı kapatıyoruz.
                            baglanti.Close();

                            Yapılan_Acıklama_RichTextbox.Clear();
                            Firma_Bilgileri_Goruntule_DataGrid.DataSource = null;
                            // Araçların içini temizle.

                        }
                        baglanti.Close(); // Bağlantıyı kapatıyoruz.

                    }

                    //---------------------------------------------------------------

                    else if (dil == "English")
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut.Connection = baglanti;
                        komut.CommandText = "Delete from Secim_Tablosu where Ogrenci_No=" + no + "";

                        DialogResult sonuc1 = MessageBox.Show("Are you sure you want to delete your selection?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (sonuc1 == DialogResult.Yes)
                        {
                            komut.ExecuteNonQuery();
                            MessageBox.Show("SELECTION SUCCESSFULLY DELETED", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            baglanti.Close();

                            Acıklama_RichTextbox.Enabled = true;
                            Yenile_Picturebox.Enabled = true;
                            Firma_Bilgileri_DataGrid.Enabled = true;
                            Bilgileri_Kaydet_Firma_Button.Enabled = true;
                            FirmaAra_Textbox.Enabled = true;
                            SecimDurumu_Label.Text = "SELECTION STATUS: " + "✗";

                            if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();

                            komut.Connection = baglanti;
                            komut.CommandText = "update Ogrenci_Kayit set Secim=@Secim,Firma_Aciklama=@aciklama where Ogrenci_No=" + no + "";  // Güncelleme işlemi için SQL komutunu tanımlıyoruz.


                            komut.Parameters.AddWithValue("@Secim", "✗");
                            komut.Parameters.AddWithValue("@aciklama", "");

                            komut.ExecuteNonQuery();

                            Secim = "✗";

                            baglanti.Close();

                            Yapılan_Acıklama_RichTextbox.Clear();
                            Firma_Bilgileri_Goruntule_DataGrid.DataSource = null;
                        }
                        baglanti.Close(); // Bağlantıyı kapatıyoruz.
                    }
                }

                //---------------------------------------------------------------

                else
                {
                    if (dil == "Türkçe")
                    {
                        MessageBox.Show("SEÇİM YOK", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (dil == "English")
                    {
                        MessageBox.Show("NO SELECTION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                }

            }

            //---------------------------------------------------------------

            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("SİLME İŞLEMİ SIRASINDA BİR HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (dil == "English")
                {
                    MessageBox.Show("AN ERROR OCCURRED DURING THE DELETION PROCESS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }

        }

        //---------------------------------------------------------------


        private void BilgileriGoruntule_Button_Click(object sender, EventArgs e)
        {
            HesapAyarlari hesapAyarlari = new HesapAyarlari();
            hesapAyarlari.dil = dil;
            hesapAyarlari.no = no;
            hesapAyarlari.Show();
            this.Hide();
        }

        private void UygulamaAyarlari_Button_Click(object sender, EventArgs e)
        {
            UygulamaAyarlari uygulamaAyarlari = new UygulamaAyarlari();
            uygulamaAyarlari.dil = dil;
            uygulamaAyarlari.no = no;
            uygulamaAyarlari.Show();
            this.Hide();
        }
        private void FirmaAra_Textbox_TextChanged(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglanti1.adres);
            SqlCommand komut = new SqlCommand(); // SQL komutlarını çalıştırmak için bir SqlCommand nesnesi oluşturuyoruz.

            if (baglanti.State == ConnectionState.Closed) // SQL bağlantısı kapalıysa açıyoruz.
                baglanti.Open(); // Bağlantıyı açıyoruz.

            komut.Connection = baglanti; // Komutun hangi bağlantıya ait olduğunu belirtiyoruz.

            komut.CommandText = "Select * from Firma_Tablosu where Firma_Adi like @firmadi";  // SQL sorgusunu tanımlıyoruz: Firma_Tablosu'ndaki tüm verileri seçiyoruz.

            komut.Parameters.AddWithValue("@firmadi", "%" + FirmaAra_Textbox.Text + "%");

            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);

            DataTable veritablo = new DataTable(); // Verilerin tutulacağı DataTable nesnesini oluşturuyoruz.
            dataadapter.Fill(veritablo);  // SQL sorgusundan dönen verileri DataTable içerisine dolduruyoruz.

            Firma_Bilgileri_DataGrid.DataSource = veritablo; // DataGridView'e verileri bağlayarak ekranda gösteriyoruz.

            baglanti.Close(); // Veritabanı bağlantısını kapatıyoruz.
        }

        private void Hesap_Button_Click(object sender, EventArgs e)
        {
            HesapAyarlari hesapAyarlari = new HesapAyarlari();
            hesapAyarlari.dil = dil;
            hesapAyarlari.no = no;
            hesapAyarlari.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UygulamaAyarlari uygulamaAyarlari = new UygulamaAyarlari();
            uygulamaAyarlari.dil = dil;
            uygulamaAyarlari.no = no;
            uygulamaAyarlari.Show();
            this.Hide();
        }

        private void Cıkıs_Button_Click(object sender, EventArgs e)
        {
            if (dil == "Türkçe") //Türkçe seçili iken oturumu kapatınca Türkçe şekilde çıkış yapıyor ve Giriş formunu Türkçe yapıyor.
            {
                MessageBox.Show("OTURUMDAN ÇIKIŞ YAPILIYOR ", "ÇIKIŞ YAPILIYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ogrenci_Giris giris = new Ogrenci_Giris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
            else if (dil == "English") //İngilizce seçili iken oturumu kapatınca İngilizce şekilde çıkış yapıyor ve Giriş formunu İngilizce yapıyor.
            {
                MessageBox.Show("LOGGING OUT OF SESSION", "LOGGING OUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ogrenci_Giris giris = new Ogrenci_Giris();
                giris.dil = dil;
                giris.Show();
                this.Hide();
            }
        }
        private void Ogrenci_Kontrol_Paneli_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Yenile_Picturebox_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(baglanti1.adres);
            SqlCommand komut = new SqlCommand(); // SQL komutlarını çalıştırmak için bir SqlCommand nesnesi oluşturuyoruz.

            if (baglanti.State == ConnectionState.Closed) // SQL bağlantısı kapalıysa açıyoruz.
                baglanti.Open(); // Bağlantıyı açıyoruz.

            komut.Connection = baglanti; // Komutun hangi bağlantıya ait olduğunu belirtiyoruz.

            komut.CommandText = "Select * from Firma_Tablosu";  // SQL sorgusunu tanımlıyoruz: Firma_Tablosu'ndaki tüm verileri seçiyoruz.

            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);

            DataTable veritablo = new DataTable(); // Verilerin tutulacağı DataTable nesnesini oluşturuyoruz.
            dataadapter.Fill(veritablo);  // SQL sorgusundan dönen verileri DataTable içerisine dolduruyoruz.

            Firma_Bilgileri_DataGrid.DataSource = veritablo; // DataGridView'e verileri bağlayarak ekranda gösteriyoruz.

            baglanti.Close(); // Veritabanı bağlantısını kapatıyoruz.
        }

        private void YenileSecim_Picturebox_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection(baglanti1.adres);
                SqlCommand komut = new SqlCommand(); //Komut yazmak için yeni bir komut oluşturdum.
                SqlDataReader okuma; //SQL komutlarını okumak için DataReader belirledim.

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti;  //SQL bağlantımı komutuma ekledim
                komut.CommandText = "Select * from Secim_Tablosu where Ogrenci_No=" + no + ""; //Firma sıra noyu alan bir komut yazdım.
                okuma = komut.ExecuteReader();  // Sorgumu çalıştırdım ve sonuçları okuma adlı SqlDataReader nesnesine atadım.

                while (okuma.Read())
                {
                    firmasirano1 = (okuma["Firma_Sıra_No"].ToString()); // Komutta yer alan firma_sıra_no da hangi değer varsa onu firmasirano ya atadım.

                }

                baglanti.Close(); // Bağlantımı kapattım.

                //---------------------------------------------------------------

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantım eğer kapalı ise bağlantımı açtım.

                komut.Connection = baglanti; // SQL bağlantımı komutuma ekledim.
                komut.CommandText = "Select Firma_Aciklama from Ogrenci_Kayit where Ogrenci_No=" + no + ""; // Öğrencinin eklemek istediği bilgiyi sorguladım.
                okuma = komut.ExecuteReader(); // Sorguyu çalıştırıp sonuçları okuma adlı değişkene atadım.

                if (okuma.Read())
                {
                    Yapılan_Acıklama_RichTextbox.Text = okuma["Firma_Aciklama"].ToString();  // Veri mevcutsa RichTextBoxa'a yazdırdım.

                }
                else
                {
                    Yapılan_Acıklama_RichTextbox.Clear();   // Veri yoksa temizle yaptım.

                }
                baglanti.Close(); // Bağlantımı kapattım.


                //---------------------------------------------------------------

                if (Secim == "✓")
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantım eğer kapalı ise bağlantımı açtım.


                    komut.Connection = baglanti;
                    komut.CommandText = "Select * from Firma_Tablosu where Firma_Sıra_No =" + firmasirano1 + ""; // Firma bilgilerini sorgulamak için bir SQL komutu yazdım.


                    SqlDataAdapter dataadapter1 = new SqlDataAdapter(komut); // Sorgudan dönen verileri almak için bir DataAdapter oluşturup komutu buna bağladım.

                    DataTable veritablo1 = new DataTable(); // Gelen verileri depolamak için bir DataTable oluşturup bunu doldurdum.
                    dataadapter1.Fill(veritablo1); // DataTable içine verileri aktardım.
                    Firma_Bilgileri_Goruntule_DataGrid.DataSource = veritablo1; // DataGrid'e DataTable verisini bağlayarak verileri görselleştirdim.

                    baglanti.Close(); // Bağlantımı kapattım.
                }
                else
                {
                    Firma_Bilgileri_Goruntule_DataGrid.DataSource = null; // Eğer ki gerekli veri yoksa datagridi temizle
                }
            }
            catch
            {
                if (dil == "Türkçe")
                {
                    MessageBox.Show("KAYIT YOK VEYA BİLİNMEYEN BİR HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dil == "English")
                {
                    MessageBox.Show("NO RECORD FOUND OR AN UNKNOWN ERROR OCCURRED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void SorunBildir_LİnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SorunBildir sorunBildir = new SorunBildir();
            sorunBildir.dil = dil;
            sorunBildir.Show();
        }

        private void FirmaSec_Linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SorunBildir sorunBildir = new SorunBildir();
            sorunBildir.dil = dil;
            sorunBildir.Show();
        }

        private void SecimBilgileri_Linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SorunBildir sorunBildir = new SorunBildir();
            sorunBildir.dil = dil;
            sorunBildir.Show();
        }
    }
}














