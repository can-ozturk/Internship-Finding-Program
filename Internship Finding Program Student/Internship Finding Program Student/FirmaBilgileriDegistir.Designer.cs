namespace Internship_Finding_Program_Student
{
    partial class FirmaBilgileriDegistir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaBilgileriDegistir));
            FirmaKriterleri_Richtext = new RichTextBox();
            FirmaKonumu_Textbox = new TextBox();
            FirmaAciklamasi_RichText = new RichTextBox();
            FirmaKonumu_Label = new Label();
            FirmaKriteri_Label = new Label();
            FirmaAciklama_Label = new Label();
            Guncelle_Button = new Button();
            FirmaWeb_Label = new Label();
            FirmaWeb_Textbox = new TextBox();
            SuspendLayout();
            // 
            // FirmaKriterleri_Richtext
            // 
            FirmaKriterleri_Richtext.Location = new Point(54, 78);
            FirmaKriterleri_Richtext.Name = "FirmaKriterleri_Richtext";
            FirmaKriterleri_Richtext.Size = new Size(308, 251);
            FirmaKriterleri_Richtext.TabIndex = 0;
            FirmaKriterleri_Richtext.Text = "";
            // 
            // FirmaKonumu_Textbox
            // 
            FirmaKonumu_Textbox.Location = new Point(54, 376);
            FirmaKonumu_Textbox.Name = "FirmaKonumu_Textbox";
            FirmaKonumu_Textbox.Size = new Size(223, 27);
            FirmaKonumu_Textbox.TabIndex = 1;
            // 
            // FirmaAciklamasi_RichText
            // 
            FirmaAciklamasi_RichText.Location = new Point(379, 78);
            FirmaAciklamasi_RichText.Name = "FirmaAciklamasi_RichText";
            FirmaAciklamasi_RichText.Size = new Size(308, 251);
            FirmaAciklamasi_RichText.TabIndex = 2;
            FirmaAciklamasi_RichText.Text = "";
            // 
            // FirmaKonumu_Label
            // 
            FirmaKonumu_Label.AutoSize = true;
            FirmaKonumu_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FirmaKonumu_Label.ImeMode = ImeMode.NoControl;
            FirmaKonumu_Label.Location = new Point(54, 353);
            FirmaKonumu_Label.Name = "FirmaKonumu_Label";
            FirmaKonumu_Label.Size = new Size(130, 20);
            FirmaKonumu_Label.TabIndex = 68;
            FirmaKonumu_Label.Text = "FİRMA KONUMU";
            // 
            // FirmaKriteri_Label
            // 
            FirmaKriteri_Label.AutoSize = true;
            FirmaKriteri_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FirmaKriteri_Label.ImeMode = ImeMode.NoControl;
            FirmaKriteri_Label.Location = new Point(54, 55);
            FirmaKriteri_Label.Name = "FirmaKriteri_Label";
            FirmaKriteri_Label.Size = new Size(144, 20);
            FirmaKriteri_Label.TabIndex = 69;
            FirmaKriteri_Label.Text = "FİRMA KRİTERLERİ";
            // 
            // FirmaAciklama_Label
            // 
            FirmaAciklama_Label.AutoSize = true;
            FirmaAciklama_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FirmaAciklama_Label.ImeMode = ImeMode.NoControl;
            FirmaAciklama_Label.Location = new Point(379, 55);
            FirmaAciklama_Label.Name = "FirmaAciklama_Label";
            FirmaAciklama_Label.Size = new Size(153, 20);
            FirmaAciklama_Label.TabIndex = 70;
            FirmaAciklama_Label.Text = "FİRMA AÇIKLAMASI";
            // 
            // Guncelle_Button
            // 
            Guncelle_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guncelle_Button.Image = Properties.Resources._1reload__1_;
            Guncelle_Button.ImageAlign = ContentAlignment.MiddleRight;
            Guncelle_Button.Location = new Point(408, 376);
            Guncelle_Button.Name = "Guncelle_Button";
            Guncelle_Button.Size = new Size(231, 98);
            Guncelle_Button.TabIndex = 71;
            Guncelle_Button.Text = "GÜNCELLE";
            Guncelle_Button.TextAlign = ContentAlignment.MiddleLeft;
            Guncelle_Button.UseVisualStyleBackColor = true;
            Guncelle_Button.Click += Guncelle_Button_Click;
            // 
            // FirmaWeb_Label
            // 
            FirmaWeb_Label.AutoSize = true;
            FirmaWeb_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FirmaWeb_Label.ImeMode = ImeMode.NoControl;
            FirmaWeb_Label.Location = new Point(54, 435);
            FirmaWeb_Label.Name = "FirmaWeb_Label";
            FirmaWeb_Label.Size = new Size(141, 20);
            FirmaWeb_Label.TabIndex = 73;
            FirmaWeb_Label.Text = "FİRMA WEB SİTESİ";
            // 
            // FirmaWeb_Textbox
            // 
            FirmaWeb_Textbox.Location = new Point(54, 458);
            FirmaWeb_Textbox.Name = "FirmaWeb_Textbox";
            FirmaWeb_Textbox.Size = new Size(223, 27);
            FirmaWeb_Textbox.TabIndex = 72;
            // 
            // FirmaBilgileriDegistir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(748, 516);
            Controls.Add(FirmaWeb_Label);
            Controls.Add(FirmaWeb_Textbox);
            Controls.Add(Guncelle_Button);
            Controls.Add(FirmaAciklama_Label);
            Controls.Add(FirmaKriteri_Label);
            Controls.Add(FirmaKonumu_Label);
            Controls.Add(FirmaAciklamasi_RichText);
            Controls.Add(FirmaKonumu_Textbox);
            Controls.Add(FirmaKriterleri_Richtext);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FirmaBilgileriDegistir";
            Text = "FİRMA BİLGİLERİ DEĞİŞTİR";
            FormClosing += FirmaBilgileriDegistir_FormClosing;
            Shown += FirmaBilgileriDegistir_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox FirmaKriterleri_Richtext;
        private TextBox FirmaKonumu_Textbox;
        private RichTextBox FirmaAciklamasi_RichText;
        private Label FirmaKonumu_Label;
        private Label FirmaKriteri_Label;
        private Label FirmaAciklama_Label;
        private Button Guncelle_Button;
        private Label FirmaWeb_Label;
        private TextBox FirmaWeb_Textbox;
    }
}