namespace Internship_Finding_Program_Student
{
    partial class YoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGiris));
            DilDegistir_Label = new Label();
            DilDegistir_Combobox = new ComboBox();
            Giris_Picturebox = new PictureBox();
            YoneticiSifre_Label = new Label();
            ID_Label = new Label();
            YoneticiSifre_Textbox = new TextBox();
            ID_Textbox = new TextBox();
            Giris_Label = new Label();
            SorunBildir_Linklabel = new LinkLabel();
            Giris_Button = new Button();
            Geridon_Picturebox = new PictureBox();
            Gorunmez_Picturebox = new PictureBox();
            Gorunur_Picturebox = new PictureBox();
            English_Picturebox = new PictureBox();
            Turkey_Picturebox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Giris_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Geridon_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DilDegistir_Label
            // 
            DilDegistir_Label.AutoSize = true;
            DilDegistir_Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DilDegistir_Label.Location = new Point(12, 425);
            DilDegistir_Label.Name = "DilDegistir_Label";
            DilDegistir_Label.Size = new Size(117, 23);
            DilDegistir_Label.TabIndex = 14;
            DilDegistir_Label.Text = "DİL DEĞİŞTİR";
            // 
            // DilDegistir_Combobox
            // 
            DilDegistir_Combobox.FormattingEnabled = true;
            DilDegistir_Combobox.Location = new Point(12, 451);
            DilDegistir_Combobox.Name = "DilDegistir_Combobox";
            DilDegistir_Combobox.Size = new Size(151, 28);
            DilDegistir_Combobox.TabIndex = 13;
            DilDegistir_Combobox.SelectedIndexChanged += DilDegistir_Combobox_SelectedIndexChanged;
            // 
            // Giris_Picturebox
            // 
            Giris_Picturebox.Image = Properties.Resources.businessman;
            Giris_Picturebox.Location = new Point(250, 81);
            Giris_Picturebox.Name = "Giris_Picturebox";
            Giris_Picturebox.Size = new Size(243, 157);
            Giris_Picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            Giris_Picturebox.TabIndex = 21;
            Giris_Picturebox.TabStop = false;
            // 
            // YoneticiSifre_Label
            // 
            YoneticiSifre_Label.AutoSize = true;
            YoneticiSifre_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YoneticiSifre_Label.Location = new Point(274, 320);
            YoneticiSifre_Label.Name = "YoneticiSifre_Label";
            YoneticiSifre_Label.Size = new Size(63, 28);
            YoneticiSifre_Label.TabIndex = 19;
            YoneticiSifre_Label.Text = "ŞİFRE";
            // 
            // ID_Label
            // 
            ID_Label.AutoSize = true;
            ID_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID_Label.Location = new Point(274, 241);
            ID_Label.Name = "ID_Label";
            ID_Label.Size = new Size(33, 28);
            ID_Label.TabIndex = 18;
            ID_Label.Text = "ID";
            // 
            // YoneticiSifre_Textbox
            // 
            YoneticiSifre_Textbox.Location = new Point(274, 351);
            YoneticiSifre_Textbox.MaxLength = 15;
            YoneticiSifre_Textbox.Name = "YoneticiSifre_Textbox";
            YoneticiSifre_Textbox.PasswordChar = '*';
            YoneticiSifre_Textbox.PlaceholderText = "Şifre";
            YoneticiSifre_Textbox.Size = new Size(183, 27);
            YoneticiSifre_Textbox.TabIndex = 17;
            YoneticiSifre_Textbox.Tag = "";
            // 
            // ID_Textbox
            // 
            ID_Textbox.Location = new Point(274, 272);
            ID_Textbox.MaxLength = 10;
            ID_Textbox.Name = "ID_Textbox";
            ID_Textbox.PlaceholderText = "ID";
            ID_Textbox.Size = new Size(183, 27);
            ID_Textbox.TabIndex = 16;
            ID_Textbox.Tag = "";
            ID_Textbox.KeyPress += ID_Textbox_KeyPress;
            // 
            // Giris_Label
            // 
            Giris_Label.AutoSize = true;
            Giris_Label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Giris_Label.ForeColor = SystemColors.MenuHighlight;
            Giris_Label.Location = new Point(76, 12);
            Giris_Label.Name = "Giris_Label";
            Giris_Label.Size = new Size(496, 46);
            Giris_Label.TabIndex = 15;
            Giris_Label.Text = "YÖNETİCİ STAJ SİSTEMİ GİRİŞ";
            // 
            // SorunBildir_Linklabel
            // 
            SorunBildir_Linklabel.ActiveLinkColor = Color.Gold;
            SorunBildir_Linklabel.AutoSize = true;
            SorunBildir_Linklabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SorunBildir_Linklabel.LinkColor = Color.Red;
            SorunBildir_Linklabel.Location = new Point(612, 456);
            SorunBildir_Linklabel.Name = "SorunBildir_Linklabel";
            SorunBildir_Linklabel.Size = new Size(95, 17);
            SorunBildir_Linklabel.TabIndex = 22;
            SorunBildir_Linklabel.TabStop = true;
            SorunBildir_Linklabel.Text = "SORUN BİLDİR ";
            SorunBildir_Linklabel.LinkClicked += SorunBildir_Linklabel_LinkClicked;
            // 
            // Giris_Button
            // 
            Giris_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Giris_Button.Image = Properties.Resources.l1ogin;
            Giris_Button.ImageAlign = ContentAlignment.MiddleRight;
            Giris_Button.Location = new Point(305, 408);
            Giris_Button.Name = "Giris_Button";
            Giris_Button.Size = new Size(130, 40);
            Giris_Button.TabIndex = 23;
            Giris_Button.Text = "GİRİŞ";
            Giris_Button.TextAlign = ContentAlignment.MiddleLeft;
            Giris_Button.UseVisualStyleBackColor = true;
            Giris_Button.Click += Giris_Button_Click;
            // 
            // Geridon_Picturebox
            // 
            Geridon_Picturebox.Image = Properties.Resources.undo;
            Geridon_Picturebox.Location = new Point(12, 17);
            Geridon_Picturebox.Name = "Geridon_Picturebox";
            Geridon_Picturebox.Size = new Size(40, 36);
            Geridon_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Geridon_Picturebox.TabIndex = 24;
            Geridon_Picturebox.TabStop = false;
            Geridon_Picturebox.Click += Geridon_Picturebox_Click;
            // 
            // Gorunmez_Picturebox
            // 
            Gorunmez_Picturebox.Image = Properties.Resources.hide;
            Gorunmez_Picturebox.Location = new Point(463, 353);
            Gorunmez_Picturebox.Name = "Gorunmez_Picturebox";
            Gorunmez_Picturebox.Size = new Size(30, 25);
            Gorunmez_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunmez_Picturebox.TabIndex = 26;
            Gorunmez_Picturebox.TabStop = false;
            Gorunmez_Picturebox.Visible = false;
            Gorunmez_Picturebox.Click += Gorunmez_Picturebox_Click;
            // 
            // Gorunur_Picturebox
            // 
            Gorunur_Picturebox.Image = Properties.Resources.view;
            Gorunur_Picturebox.Location = new Point(463, 353);
            Gorunur_Picturebox.Name = "Gorunur_Picturebox";
            Gorunur_Picturebox.Size = new Size(30, 25);
            Gorunur_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunur_Picturebox.TabIndex = 25;
            Gorunur_Picturebox.TabStop = false;
            Gorunur_Picturebox.Click += Gorunur_Picturebox_Click;
            // 
            // English_Picturebox
            // 
            English_Picturebox.Image = Properties.Resources.united_kingdom;
            English_Picturebox.Location = new Point(169, 449);
            English_Picturebox.Name = "English_Picturebox";
            English_Picturebox.Size = new Size(35, 30);
            English_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            English_Picturebox.TabIndex = 28;
            English_Picturebox.TabStop = false;
            English_Picturebox.Visible = false;
            // 
            // Turkey_Picturebox
            // 
            Turkey_Picturebox.Image = Properties.Resources.turkey;
            Turkey_Picturebox.Location = new Point(169, 449);
            Turkey_Picturebox.Name = "Turkey_Picturebox";
            Turkey_Picturebox.Size = new Size(35, 30);
            Turkey_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Turkey_Picturebox.TabIndex = 27;
            Turkey_Picturebox.TabStop = false;
            Turkey_Picturebox.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.attention;
            pictureBox1.Location = new Point(573, 449);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // YoneticiGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(719, 484);
            Controls.Add(pictureBox1);
            Controls.Add(English_Picturebox);
            Controls.Add(Turkey_Picturebox);
            Controls.Add(Gorunmez_Picturebox);
            Controls.Add(Gorunur_Picturebox);
            Controls.Add(Geridon_Picturebox);
            Controls.Add(Giris_Button);
            Controls.Add(SorunBildir_Linklabel);
            Controls.Add(Giris_Picturebox);
            Controls.Add(YoneticiSifre_Label);
            Controls.Add(ID_Label);
            Controls.Add(YoneticiSifre_Textbox);
            Controls.Add(ID_Textbox);
            Controls.Add(Giris_Label);
            Controls.Add(DilDegistir_Label);
            Controls.Add(DilDegistir_Combobox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "YoneticiGiris";
            Text = "Yönetici Giriş";
            FormClosing += YoneticiGiris_FormClosing;
            Shown += YoneticiGiris_Shown;
            ((System.ComponentModel.ISupportInitialize)Giris_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Geridon_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DilDegistir_Label;
        private ComboBox DilDegistir_Combobox;
        private PictureBox Giris_Picturebox;
        private Label YoneticiSifre_Label;
        private Label ID_Label;
        private TextBox YoneticiSifre_Textbox;
        private TextBox ID_Textbox;
        private Label Giris_Label;
        private LinkLabel SorunBildir_Linklabel;
        private Button Giris_Button;
        private PictureBox Geridon_Picturebox;
        private PictureBox Gorunmez_Picturebox;
        private PictureBox Gorunur_Picturebox;
        private PictureBox English_Picturebox;
        private PictureBox Turkey_Picturebox;
        private PictureBox pictureBox1;
    }
}