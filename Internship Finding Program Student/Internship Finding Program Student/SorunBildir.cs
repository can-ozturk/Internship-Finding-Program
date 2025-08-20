using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship_Finding_Program_Student
{
    public partial class SorunBildir : Form
    {
        public SorunBildir()
        {
            InitializeComponent();
        }
        // Formda dil seçeneği için bir değişken tanımlanıyor
        public string dil;

        // Mail adreslerini yöneten bir nesne oluşturuluyor
        MailAdresileri mailAdresileri = new MailAdresileri();
        private void SorunBildir_Shown(object sender, EventArgs e)
        {
            // Eğer dil "Türkçe" ise
            if (dil == "Türkçe")
            {
               
                // ComboBox için başlık atanıyor
                Mailler_Combobox.Text = mailAdresileri.MailBaslık();

                // Türkçe mail adresleri listeye ekleniyor
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Canoztr));
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Tarkksl));
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Emntmbl));
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Berkayylz));
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Talhktn));

                // Formdaki metinler Türkçe olarak düzenleniyor
                Yazı2_Label.Text = "SORUN OLDUĞUNU DÜŞÜNÜYORSANIZ LÜTFEN AŞAĞIDAKİ MAİLLERDEN BİR TANESİNE\r\nSORUNUN EKRAN GÖRÜNTÜSÜNÜ GÖNDEREREK KISACA İZAH EDİNİZ.";
                Yazı3_Label.Text = "İlginiz için teşekkür ederiz.";
                Yazı4_Label.Text = "Veya";
                Yazı6_Label.Text = "Intership Finding Program Forum için";
                Yazı_Linkkabel.Text = "tıklayınız";
                Yazı8_Label.Text = "Bizim için değerlisiniz...";
                this.Text = "SORUN BİLDİR";
            }
            // Kodlar İngilizce için yazılmış hali
            else if (dil == "English")
            {
                Mailler_Combobox.Text = mailAdresileri.MailBaslıkING();
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Canoztr));
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Tarkksl));
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Emntmbl));
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Berkayylz));
                Mailler_Combobox.Items.Add(MailAdresler.Mailler(MailAdresler.Cesit.Talhktn));
                Yazı2_Label.Text = "IF YOU THINK THERE IS A PROBLEM, PLEASE SEND THE SCREENSHOT OF THE ISSUE TO\r\nONE OF THE EMAILS BELOW AND BRIEFLY EXPLAIN IT.";
                Yazı3_Label.Text = "Thank you for your attention.";
                Yazı4_Label.Text = "Or";
                Yazı6_Label.Text = "For the Internship Finding Program Forum";
                Yazı_Linkkabel.Text = "click here";
                Yazı8_Label.Text = "You are valuable to us...";
                this.Text = "REPORT ISSUE";

            }
        }

        private void SorunBildir_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide(); //Bu formu gizliyor.
        }

        private void Yazı_Linkkabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.canztrk.wuaze.com/iletisim/"; // Hedef URL
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Varsayılan tarayıcıda açar
            });
        }
    }
}
