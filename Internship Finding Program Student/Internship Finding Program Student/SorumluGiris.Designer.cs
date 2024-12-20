namespace Internship_Finding_Program_Student
{
    partial class SorumluGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorumluGiris));
            DilDegistir_Label = new Label();
            DilDegistir_Combobox = new ComboBox();
            Giris_Picturebox = new PictureBox();
            SorunBildir_Linklabel = new LinkLabel();
            Giris_Button = new Button();
            Sifre_Label = new Label();
            ID_Label = new Label();
            Sifre_Textbox = new TextBox();
            ID_Textbox = new TextBox();
            Giris_Label = new Label();
            Gorunmez_Picturebox = new PictureBox();
            Gorunur_Picturebox = new PictureBox();
            English_Picturebox = new PictureBox();
            Turkey_Picturebox = new PictureBox();
            SorunBildir_Picturebox = new PictureBox();
            Geridon_Picturebox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Giris_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SorunBildir_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Geridon_Picturebox).BeginInit();
            SuspendLayout();
            // 
            // DilDegistir_Label
            // 
            DilDegistir_Label.AutoSize = true;
            DilDegistir_Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DilDegistir_Label.Location = new Point(12, 388);
            DilDegistir_Label.Name = "DilDegistir_Label";
            DilDegistir_Label.Size = new Size(122, 23);
            DilDegistir_Label.TabIndex = 22;
            DilDegistir_Label.Text = "DİL DEĞİŞTİR:";
            // 
            // DilDegistir_Combobox
            // 
            DilDegistir_Combobox.FormattingEnabled = true;
            DilDegistir_Combobox.Location = new Point(12, 414);
            DilDegistir_Combobox.Name = "DilDegistir_Combobox";
            DilDegistir_Combobox.Size = new Size(151, 28);
            DilDegistir_Combobox.TabIndex = 21;
            DilDegistir_Combobox.SelectedIndexChanged += DilDegistir_Combobox_SelectedIndexChanged;
            // 
            // Giris_Picturebox
            // 
            Giris_Picturebox.Image = Properties.Resources.database_user;
            Giris_Picturebox.Location = new Point(208, 80);
            Giris_Picturebox.Name = "Giris_Picturebox";
            Giris_Picturebox.Size = new Size(216, 131);
            Giris_Picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            Giris_Picturebox.TabIndex = 20;
            Giris_Picturebox.TabStop = false;
            // 
            // SorunBildir_Linklabel
            // 
            SorunBildir_Linklabel.ActiveLinkColor = Color.Gold;
            SorunBildir_Linklabel.AutoSize = true;
            SorunBildir_Linklabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SorunBildir_Linklabel.LinkColor = Color.Red;
            SorunBildir_Linklabel.Location = new Point(521, 419);
            SorunBildir_Linklabel.Name = "SorunBildir_Linklabel";
            SorunBildir_Linklabel.Size = new Size(95, 17);
            SorunBildir_Linklabel.TabIndex = 19;
            SorunBildir_Linklabel.TabStop = true;
            SorunBildir_Linklabel.Text = "SORUN BİLDİR ";
            SorunBildir_Linklabel.LinkClicked += SorunBildir_Linklabel_LinkClicked;
            // 
            // Giris_Button
            // 
            Giris_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Giris_Button.Image = Properties.Resources.l1ogin;
            Giris_Button.ImageAlign = ContentAlignment.MiddleRight;
            Giris_Button.Location = new Point(243, 372);
            Giris_Button.Name = "Giris_Button";
            Giris_Button.Size = new Size(142, 39);
            Giris_Button.TabIndex = 18;
            Giris_Button.Text = "GİRİŞ";
            Giris_Button.TextAlign = ContentAlignment.MiddleLeft;
            Giris_Button.UseVisualStyleBackColor = true;
            Giris_Button.Click += Giris_Button_Click;
            // 
            // Sifre_Label
            // 
            Sifre_Label.AutoSize = true;
            Sifre_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sifre_Label.Location = new Point(220, 293);
            Sifre_Label.Name = "Sifre_Label";
            Sifre_Label.Size = new Size(63, 28);
            Sifre_Label.TabIndex = 16;
            Sifre_Label.Text = "ŞİFRE";
            // 
            // ID_Label
            // 
            ID_Label.AutoSize = true;
            ID_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID_Label.Location = new Point(220, 214);
            ID_Label.Name = "ID_Label";
            ID_Label.Size = new Size(33, 28);
            ID_Label.TabIndex = 15;
            ID_Label.Text = "ID";
            // 
            // Sifre_Textbox
            // 
            Sifre_Textbox.Location = new Point(220, 324);
            Sifre_Textbox.MaxLength = 15;
            Sifre_Textbox.Name = "Sifre_Textbox";
            Sifre_Textbox.PasswordChar = '*';
            Sifre_Textbox.PlaceholderText = "Şifre Giriniz";
            Sifre_Textbox.Size = new Size(183, 27);
            Sifre_Textbox.TabIndex = 14;
            Sifre_Textbox.Tag = "";
            // 
            // ID_Textbox
            // 
            ID_Textbox.Location = new Point(220, 245);
            ID_Textbox.MaxLength = 10;
            ID_Textbox.Name = "ID_Textbox";
            ID_Textbox.PlaceholderText = "ID Giriniz";
            ID_Textbox.Size = new Size(183, 27);
            ID_Textbox.TabIndex = 13;
            ID_Textbox.Tag = "";
            ID_Textbox.KeyPress += ID_Textbox_KeyPress;
            // 
            // Giris_Label
            // 
            Giris_Label.AutoSize = true;
            Giris_Label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Giris_Label.ForeColor = SystemColors.MenuHighlight;
            Giris_Label.Location = new Point(105, 9);
            Giris_Label.Name = "Giris_Label";
            Giris_Label.Size = new Size(422, 46);
            Giris_Label.TabIndex = 12;
            Giris_Label.Text = "SORUMLU GİRİŞ SİSTEMİ";
            // 
            // Gorunmez_Picturebox
            // 
            Gorunmez_Picturebox.Image = Properties.Resources.hide;
            Gorunmez_Picturebox.Location = new Point(409, 326);
            Gorunmez_Picturebox.Name = "Gorunmez_Picturebox";
            Gorunmez_Picturebox.Size = new Size(30, 25);
            Gorunmez_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunmez_Picturebox.TabIndex = 28;
            Gorunmez_Picturebox.TabStop = false;
            Gorunmez_Picturebox.Visible = false;
            Gorunmez_Picturebox.Click += Gorunmez_Picturebox_Click;
            // 
            // Gorunur_Picturebox
            // 
            Gorunur_Picturebox.Image = Properties.Resources.view;
            Gorunur_Picturebox.Location = new Point(409, 326);
            Gorunur_Picturebox.Name = "Gorunur_Picturebox";
            Gorunur_Picturebox.Size = new Size(30, 25);
            Gorunur_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunur_Picturebox.TabIndex = 27;
            Gorunur_Picturebox.TabStop = false;
            Gorunur_Picturebox.Click += Gorunur_Picturebox_Click;
            // 
            // English_Picturebox
            // 
            English_Picturebox.Image = Properties.Resources.united_kingdom;
            English_Picturebox.Location = new Point(169, 414);
            English_Picturebox.Name = "English_Picturebox";
            English_Picturebox.Size = new Size(35, 28);
            English_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            English_Picturebox.TabIndex = 30;
            English_Picturebox.TabStop = false;
            English_Picturebox.Visible = false;
            // 
            // Turkey_Picturebox
            // 
            Turkey_Picturebox.Image = Properties.Resources.turkey;
            Turkey_Picturebox.Location = new Point(169, 412);
            Turkey_Picturebox.Name = "Turkey_Picturebox";
            Turkey_Picturebox.Size = new Size(35, 30);
            Turkey_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Turkey_Picturebox.TabIndex = 29;
            Turkey_Picturebox.TabStop = false;
            Turkey_Picturebox.Visible = false;
            // 
            // SorunBildir_Picturebox
            // 
            SorunBildir_Picturebox.Image = Properties.Resources.attention;
            SorunBildir_Picturebox.Location = new Point(482, 412);
            SorunBildir_Picturebox.Name = "SorunBildir_Picturebox";
            SorunBildir_Picturebox.Size = new Size(33, 35);
            SorunBildir_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            SorunBildir_Picturebox.TabIndex = 31;
            SorunBildir_Picturebox.TabStop = false;
            // 
            // Geridon_Picturebox
            // 
            Geridon_Picturebox.Image = Properties.Resources.undo;
            Geridon_Picturebox.Location = new Point(12, 13);
            Geridon_Picturebox.Name = "Geridon_Picturebox";
            Geridon_Picturebox.Size = new Size(40, 36);
            Geridon_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Geridon_Picturebox.TabIndex = 32;
            Geridon_Picturebox.TabStop = false;
            Geridon_Picturebox.Click += Geridon_Picturebox_Click;
            // 
            // SorumluGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(640, 452);
            Controls.Add(Geridon_Picturebox);
            Controls.Add(SorunBildir_Picturebox);
            Controls.Add(English_Picturebox);
            Controls.Add(Turkey_Picturebox);
            Controls.Add(Gorunmez_Picturebox);
            Controls.Add(Gorunur_Picturebox);
            Controls.Add(DilDegistir_Label);
            Controls.Add(DilDegistir_Combobox);
            Controls.Add(Giris_Picturebox);
            Controls.Add(SorunBildir_Linklabel);
            Controls.Add(Giris_Button);
            Controls.Add(Sifre_Label);
            Controls.Add(ID_Label);
            Controls.Add(Sifre_Textbox);
            Controls.Add(ID_Textbox);
            Controls.Add(Giris_Label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SorumluGiris";
            Text = "SORUMLU GİRİŞ";
            FormClosing += SorumluGiris_FormClosing;
            Shown += SorumluGiris_Shown;
            ((System.ComponentModel.ISupportInitialize)Giris_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SorunBildir_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Geridon_Picturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DilDegistir_Label;
        private ComboBox DilDegistir_Combobox;
        private PictureBox Giris_Picturebox;
        private LinkLabel SorunBildir_Linklabel;
        private Button Giris_Button;
        private Label Sifre_Label;
        private Label ID_Label;
        private TextBox Sifre_Textbox;
        private TextBox ID_Textbox;
        private Label Giris_Label;
        private PictureBox Gorunmez_Picturebox;
        private PictureBox Gorunur_Picturebox;
        private PictureBox English_Picturebox;
        private PictureBox Turkey_Picturebox;
        private PictureBox SorunBildir_Picturebox;
        private PictureBox Geridon_Picturebox;
    }
}