namespace Internship_Finding_Program_Student
{
    partial class YoneticiUygulamaAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiUygulamaAyarlari));
            Uyarı_Label = new Label();
            Dil_Degistir_Label = new Label();
            Dil_Degistir_Combobox = new ComboBox();
            Yonetici_Panel = new Panel();
            Cıkıs_Button = new Button();
            UygulamaAyarlari_Button = new Button();
            Hesap_Button = new Button();
            StajyerBilgileri_Button = new Button();
            Resim_Panel = new Panel();
            English_Picturebox = new PictureBox();
            Turkey_Picturebox = new PictureBox();
            Yonetici_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).BeginInit();
            SuspendLayout();
            // 
            // Uyarı_Label
            // 
            Uyarı_Label.AutoSize = true;
            Uyarı_Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Uyarı_Label.ForeColor = Color.Black;
            Uyarı_Label.ImeMode = ImeMode.NoControl;
            Uyarı_Label.Location = new Point(300, 425);
            Uyarı_Label.Name = "Uyarı_Label";
            Uyarı_Label.Size = new Size(279, 23);
            Uyarı_Label.TabIndex = 33;
            Uyarı_Label.Text = "AYARLAR OTOMATİK KAYDEDİLİR";
            // 
            // Dil_Degistir_Label
            // 
            Dil_Degistir_Label.AutoSize = true;
            Dil_Degistir_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Dil_Degistir_Label.ForeColor = Color.Black;
            Dil_Degistir_Label.ImeMode = ImeMode.NoControl;
            Dil_Degistir_Label.Location = new Point(311, 24);
            Dil_Degistir_Label.Name = "Dil_Degistir_Label";
            Dil_Degistir_Label.Size = new Size(104, 20);
            Dil_Degistir_Label.TabIndex = 32;
            Dil_Degistir_Label.Text = "DİL DEĞİŞTİR";
            Dil_Degistir_Label.Click += Dil_Degistir_Label_Click;
            // 
            // Dil_Degistir_Combobox
            // 
            Dil_Degistir_Combobox.FormattingEnabled = true;
            Dil_Degistir_Combobox.Location = new Point(311, 47);
            Dil_Degistir_Combobox.Name = "Dil_Degistir_Combobox";
            Dil_Degistir_Combobox.Size = new Size(220, 28);
            Dil_Degistir_Combobox.TabIndex = 31;
            Dil_Degistir_Combobox.SelectedIndexChanged += Dil_Degistir_Combobox_SelectedIndexChanged;
            // 
            // Yonetici_Panel
            // 
            Yonetici_Panel.BackColor = SystemColors.Highlight;
            Yonetici_Panel.Controls.Add(Cıkıs_Button);
            Yonetici_Panel.Controls.Add(UygulamaAyarlari_Button);
            Yonetici_Panel.Controls.Add(Hesap_Button);
            Yonetici_Panel.Controls.Add(StajyerBilgileri_Button);
            Yonetici_Panel.Controls.Add(Resim_Panel);
            Yonetici_Panel.Dock = DockStyle.Left;
            Yonetici_Panel.Location = new Point(0, 0);
            Yonetici_Panel.Name = "Yonetici_Panel";
            Yonetici_Panel.Size = new Size(294, 468);
            Yonetici_Panel.TabIndex = 34;
            // 
            // Cıkıs_Button
            // 
            Cıkıs_Button.Dock = DockStyle.Top;
            Cıkıs_Button.FlatAppearance.BorderSize = 0;
            Cıkıs_Button.FlatStyle = FlatStyle.Flat;
            Cıkıs_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Cıkıs_Button.Image = Properties.Resources.log_out1;
            Cıkıs_Button.ImageAlign = ContentAlignment.MiddleRight;
            Cıkıs_Button.Location = new Point(0, 357);
            Cıkıs_Button.Name = "Cıkıs_Button";
            Cıkıs_Button.Size = new Size(294, 110);
            Cıkıs_Button.TabIndex = 14;
            Cıkıs_Button.Text = "OTURUMU KAPAT";
            Cıkıs_Button.TextAlign = ContentAlignment.MiddleLeft;
            Cıkıs_Button.UseVisualStyleBackColor = true;
            Cıkıs_Button.Click += Cıkıs_Button_Click;
            // 
            // UygulamaAyarlari_Button
            // 
            UygulamaAyarlari_Button.Dock = DockStyle.Top;
            UygulamaAyarlari_Button.FlatAppearance.BorderSize = 0;
            UygulamaAyarlari_Button.FlatStyle = FlatStyle.Flat;
            UygulamaAyarlari_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UygulamaAyarlari_Button.Image = Properties.Resources.setting1;
            UygulamaAyarlari_Button.ImageAlign = ContentAlignment.MiddleRight;
            UygulamaAyarlari_Button.Location = new Point(0, 247);
            UygulamaAyarlari_Button.Name = "UygulamaAyarlari_Button";
            UygulamaAyarlari_Button.Size = new Size(294, 110);
            UygulamaAyarlari_Button.TabIndex = 13;
            UygulamaAyarlari_Button.Text = "UYGULAMA AYARLARI";
            UygulamaAyarlari_Button.TextAlign = ContentAlignment.MiddleLeft;
            UygulamaAyarlari_Button.UseVisualStyleBackColor = true;
            // 
            // Hesap_Button
            // 
            Hesap_Button.Dock = DockStyle.Top;
            Hesap_Button.FlatAppearance.BorderSize = 0;
            Hesap_Button.FlatStyle = FlatStyle.Flat;
            Hesap_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Hesap_Button.Image = Properties.Resources.portfolio1;
            Hesap_Button.ImageAlign = ContentAlignment.MiddleRight;
            Hesap_Button.Location = new Point(0, 137);
            Hesap_Button.Name = "Hesap_Button";
            Hesap_Button.Size = new Size(294, 110);
            Hesap_Button.TabIndex = 12;
            Hesap_Button.Text = "HESAP AYARLARI";
            Hesap_Button.TextAlign = ContentAlignment.MiddleLeft;
            Hesap_Button.UseVisualStyleBackColor = true;
            Hesap_Button.Click += Hesap_Button_Click;
            // 
            // StajyerBilgileri_Button
            // 
            StajyerBilgileri_Button.Dock = DockStyle.Top;
            StajyerBilgileri_Button.FlatAppearance.BorderSize = 0;
            StajyerBilgileri_Button.FlatStyle = FlatStyle.Flat;
            StajyerBilgileri_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StajyerBilgileri_Button.Image = Properties.Resources.internship__1_;
            StajyerBilgileri_Button.ImageAlign = ContentAlignment.MiddleRight;
            StajyerBilgileri_Button.Location = new Point(0, 27);
            StajyerBilgileri_Button.Name = "StajyerBilgileri_Button";
            StajyerBilgileri_Button.Size = new Size(294, 110);
            StajyerBilgileri_Button.TabIndex = 11;
            StajyerBilgileri_Button.Text = "STAJYER BİLGİLERİ";
            StajyerBilgileri_Button.TextAlign = ContentAlignment.MiddleLeft;
            StajyerBilgileri_Button.UseVisualStyleBackColor = true;
            StajyerBilgileri_Button.Click += StajyerBilgileri_Button_Click;
            // 
            // Resim_Panel
            // 
            Resim_Panel.BackgroundImageLayout = ImageLayout.None;
            Resim_Panel.Dock = DockStyle.Top;
            Resim_Panel.Location = new Point(0, 0);
            Resim_Panel.Name = "Resim_Panel";
            Resim_Panel.Size = new Size(294, 27);
            Resim_Panel.TabIndex = 1;
            // 
            // English_Picturebox
            // 
            English_Picturebox.Image = Properties.Resources.united_kingdom;
            English_Picturebox.Location = new Point(537, 45);
            English_Picturebox.Name = "English_Picturebox";
            English_Picturebox.Size = new Size(35, 30);
            English_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            English_Picturebox.TabIndex = 36;
            English_Picturebox.TabStop = false;
            English_Picturebox.Visible = false;
            // 
            // Turkey_Picturebox
            // 
            Turkey_Picturebox.Image = Properties.Resources.turkey;
            Turkey_Picturebox.Location = new Point(537, 45);
            Turkey_Picturebox.Name = "Turkey_Picturebox";
            Turkey_Picturebox.Size = new Size(35, 30);
            Turkey_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Turkey_Picturebox.TabIndex = 35;
            Turkey_Picturebox.TabStop = false;
            Turkey_Picturebox.Visible = false;
            // 
            // YoneticiUygulamaAyarlari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(721, 468);
            Controls.Add(English_Picturebox);
            Controls.Add(Turkey_Picturebox);
            Controls.Add(Yonetici_Panel);
            Controls.Add(Uyarı_Label);
            Controls.Add(Dil_Degistir_Label);
            Controls.Add(Dil_Degistir_Combobox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "YoneticiUygulamaAyarlari";
            Text = "YÖNETİCİ UYGULAMA AYARLARI";
            FormClosing += YoneticiUygulamaAyarlari_FormClosing;
            Shown += YoneticiUygulamaAyarlari_Shown;
            Yonetici_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Uyarı_Label;
        private Label Dil_Degistir_Label;
        private ComboBox Dil_Degistir_Combobox;
        private Panel Yonetici_Panel;
        private Button Cıkıs_Button;
        private Button UygulamaAyarlari_Button;
        private Button Hesap_Button;
        private Button StajyerBilgileri_Button;
        private Panel Resim_Panel;
        private PictureBox English_Picturebox;
        private PictureBox Turkey_Picturebox;
    }
}