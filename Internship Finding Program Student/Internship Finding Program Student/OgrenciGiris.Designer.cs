namespace Internship_Finding_Program_Student
{
    partial class Ogrenci_Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Giris));
            Giris_Label = new Label();
            OgrNo_Textbox = new TextBox();
            OgrSifre_Textbox = new TextBox();
            OgrNo_Label = new Label();
            OgrenciSifre_Label = new Label();
            Giris_Button = new Button();
            SorunBildir_Linklabel = new LinkLabel();
            Giris_Picturebox = new PictureBox();
            DilDegistir_Combobox = new ComboBox();
            DilDegistir_Label = new Label();
            Geridon_Picturebox = new PictureBox();
            Gorunur_Picturebox = new PictureBox();
            Gorunmez_Picturebox = new PictureBox();
            English_Picturebox = new PictureBox();
            Turkey_Picturebox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Giris_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Geridon_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Giris_Label
            // 
            Giris_Label.AutoSize = true;
            Giris_Label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Giris_Label.ForeColor = SystemColors.MenuHighlight;
            Giris_Label.Location = new Point(83, 9);
            Giris_Label.Name = "Giris_Label";
            Giris_Label.Size = new Size(491, 46);
            Giris_Label.TabIndex = 0;
            Giris_Label.Text = "ÖĞRENCİ STAJ SİSTEMİ GİRİŞ";
            // 
            // OgrNo_Textbox
            // 
            OgrNo_Textbox.Location = new Point(264, 266);
            OgrNo_Textbox.MaxLength = 10;
            OgrNo_Textbox.Name = "OgrNo_Textbox";
            OgrNo_Textbox.PlaceholderText = "Öğrenci Numarası";
            OgrNo_Textbox.Size = new Size(183, 27);
            OgrNo_Textbox.TabIndex = 1;
            OgrNo_Textbox.Tag = "";
            OgrNo_Textbox.KeyPress += OgrNo_Textbox_KeyPress;
            // 
            // OgrSifre_Textbox
            // 
            OgrSifre_Textbox.Location = new Point(264, 345);
            OgrSifre_Textbox.MaxLength = 15;
            OgrSifre_Textbox.Name = "OgrSifre_Textbox";
            OgrSifre_Textbox.PasswordChar = '*';
            OgrSifre_Textbox.PlaceholderText = "Şifre";
            OgrSifre_Textbox.Size = new Size(183, 27);
            OgrSifre_Textbox.TabIndex = 2;
            OgrSifre_Textbox.Tag = "";
            // 
            // OgrNo_Label
            // 
            OgrNo_Label.AutoSize = true;
            OgrNo_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OgrNo_Label.Location = new Point(264, 235);
            OgrNo_Label.Name = "OgrNo_Label";
            OgrNo_Label.Size = new Size(217, 28);
            OgrNo_Label.TabIndex = 3;
            OgrNo_Label.Text = "ÖĞRENCİ NUMARASI:";
            // 
            // OgrenciSifre_Label
            // 
            OgrenciSifre_Label.AutoSize = true;
            OgrenciSifre_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OgrenciSifre_Label.Location = new Point(264, 314);
            OgrenciSifre_Label.Name = "OgrenciSifre_Label";
            OgrenciSifre_Label.Size = new Size(68, 28);
            OgrenciSifre_Label.TabIndex = 4;
            OgrenciSifre_Label.Text = "ŞİFRE:";
            // 
            // Giris_Button
            // 
            Giris_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Giris_Button.Image = Properties.Resources.l1ogin;
            Giris_Button.ImageAlign = ContentAlignment.MiddleRight;
            Giris_Button.Location = new Point(297, 389);
            Giris_Button.Name = "Giris_Button";
            Giris_Button.Size = new Size(130, 40);
            Giris_Button.TabIndex = 6;
            Giris_Button.Text = "GİRİŞ";
            Giris_Button.TextAlign = ContentAlignment.MiddleLeft;
            Giris_Button.UseVisualStyleBackColor = true;
            Giris_Button.Click += Giris_Button_Click;
            // 
            // SorunBildir_Linklabel
            // 
            SorunBildir_Linklabel.ActiveLinkColor = Color.Gold;
            SorunBildir_Linklabel.AutoSize = true;
            SorunBildir_Linklabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SorunBildir_Linklabel.LinkColor = Color.Red;
            SorunBildir_Linklabel.Location = new Point(619, 451);
            SorunBildir_Linklabel.Name = "SorunBildir_Linklabel";
            SorunBildir_Linklabel.Size = new Size(95, 17);
            SorunBildir_Linklabel.TabIndex = 7;
            SorunBildir_Linklabel.TabStop = true;
            SorunBildir_Linklabel.Text = "SORUN BİLDİR ";
            SorunBildir_Linklabel.LinkClicked += SorunBildir_Linklabel_LinkClicked;
            // 
            // Giris_Picturebox
            // 
            Giris_Picturebox.Image = Properties.Resources.graduated;
            Giris_Picturebox.Location = new Point(248, 75);
            Giris_Picturebox.Name = "Giris_Picturebox";
            Giris_Picturebox.Size = new Size(243, 157);
            Giris_Picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            Giris_Picturebox.TabIndex = 8;
            Giris_Picturebox.TabStop = false;
            // 
            // DilDegistir_Combobox
            // 
            DilDegistir_Combobox.FormattingEnabled = true;
            DilDegistir_Combobox.Location = new Point(12, 430);
            DilDegistir_Combobox.Name = "DilDegistir_Combobox";
            DilDegistir_Combobox.Size = new Size(151, 28);
            DilDegistir_Combobox.TabIndex = 9;
            DilDegistir_Combobox.SelectedIndexChanged += DilDegistir_Combobox_SelectedIndexChanged;
            // 
            // DilDegistir_Label
            // 
            DilDegistir_Label.AutoSize = true;
            DilDegistir_Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DilDegistir_Label.Location = new Point(12, 404);
            DilDegistir_Label.Name = "DilDegistir_Label";
            DilDegistir_Label.Size = new Size(122, 23);
            DilDegistir_Label.TabIndex = 10;
            DilDegistir_Label.Text = "DİL DEĞİŞTİR:";
            // 
            // Geridon_Picturebox
            // 
            Geridon_Picturebox.Image = Properties.Resources.undo;
            Geridon_Picturebox.Location = new Point(12, 12);
            Geridon_Picturebox.Name = "Geridon_Picturebox";
            Geridon_Picturebox.Size = new Size(40, 36);
            Geridon_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Geridon_Picturebox.TabIndex = 12;
            Geridon_Picturebox.TabStop = false;
            Geridon_Picturebox.Click += Geridon_Picturebox_Click;
            // 
            // Gorunur_Picturebox
            // 
            Gorunur_Picturebox.Image = Properties.Resources.view;
            Gorunur_Picturebox.Location = new Point(453, 347);
            Gorunur_Picturebox.Name = "Gorunur_Picturebox";
            Gorunur_Picturebox.Size = new Size(30, 25);
            Gorunur_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunur_Picturebox.TabIndex = 13;
            Gorunur_Picturebox.TabStop = false;
            Gorunur_Picturebox.Click += Gorunur_Picturebox_Click;
            // 
            // Gorunmez_Picturebox
            // 
            Gorunmez_Picturebox.Image = Properties.Resources.hide;
            Gorunmez_Picturebox.Location = new Point(453, 347);
            Gorunmez_Picturebox.Name = "Gorunmez_Picturebox";
            Gorunmez_Picturebox.Size = new Size(30, 25);
            Gorunmez_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunmez_Picturebox.TabIndex = 14;
            Gorunmez_Picturebox.TabStop = false;
            Gorunmez_Picturebox.Visible = false;
            Gorunmez_Picturebox.Click += Gorunmez_Picturebox_Click;
            // 
            // English_Picturebox
            // 
            English_Picturebox.Image = Properties.Resources.united_kingdom;
            English_Picturebox.Location = new Point(169, 430);
            English_Picturebox.Name = "English_Picturebox";
            English_Picturebox.Size = new Size(35, 28);
            English_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            English_Picturebox.TabIndex = 21;
            English_Picturebox.TabStop = false;
            English_Picturebox.Visible = false;
            // 
            // Turkey_Picturebox
            // 
            Turkey_Picturebox.Image = Properties.Resources.turkey;
            Turkey_Picturebox.Location = new Point(169, 428);
            Turkey_Picturebox.Name = "Turkey_Picturebox";
            Turkey_Picturebox.Size = new Size(35, 30);
            Turkey_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Turkey_Picturebox.TabIndex = 20;
            Turkey_Picturebox.TabStop = false;
            Turkey_Picturebox.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.attention;
            pictureBox1.Location = new Point(580, 440);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Ogrenci_Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(740, 477);
            Controls.Add(pictureBox1);
            Controls.Add(English_Picturebox);
            Controls.Add(Turkey_Picturebox);
            Controls.Add(Gorunmez_Picturebox);
            Controls.Add(Gorunur_Picturebox);
            Controls.Add(Geridon_Picturebox);
            Controls.Add(DilDegistir_Label);
            Controls.Add(DilDegistir_Combobox);
            Controls.Add(Giris_Picturebox);
            Controls.Add(SorunBildir_Linklabel);
            Controls.Add(Giris_Button);
            Controls.Add(OgrenciSifre_Label);
            Controls.Add(OgrNo_Label);
            Controls.Add(OgrSifre_Textbox);
            Controls.Add(OgrNo_Textbox);
            Controls.Add(Giris_Label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Ogrenci_Giris";
            Text = "ÖĞRENCİ GİRİŞ";
            FormClosing += Giris_FormClosing;
            Shown += Ogrenci_Giris_Shown;
            ((System.ComponentModel.ISupportInitialize)Giris_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Geridon_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Giris_Label;
        private TextBox OgrNo_Textbox;
        private TextBox OgrSifre_Textbox;
        private Label OgrNo_Label;
        private Label OgrenciSifre_Label;
        private Button Giris_Button;
        private LinkLabel SorunBildir_Linklabel;
        private PictureBox Giris_Picturebox;
        private ComboBox DilDegistir_Combobox;
        private Label DilDegistir_Label;
        private PictureBox Geridon_Picturebox;
        private PictureBox Gorunur_Picturebox;
        private PictureBox Gorunmez_Picturebox;
        private PictureBox English_Picturebox;
        private PictureBox Turkey_Picturebox;
        private PictureBox pictureBox1;
    }
}
