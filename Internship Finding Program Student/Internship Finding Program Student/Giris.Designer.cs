namespace Internship_Finding_Program_Student
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            Giris_Label = new Label();
            DilDegistir_Combobox = new ComboBox();
            DilDegistir_Label = new Label();
            YoneticiGiris_Button = new Button();
            Ogrenci_Giris_Button = new Button();
            Admin_Button = new Button();
            Giris_Button = new Button();
            Turkey_Picturebox = new PictureBox();
            English_Picturebox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).BeginInit();
            SuspendLayout();
            // 
            // Giris_Label
            // 
            Giris_Label.AutoSize = true;
            Giris_Label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Giris_Label.ForeColor = SystemColors.MenuHighlight;
            Giris_Label.Location = new Point(26, 32);
            Giris_Label.Name = "Giris_Label";
            Giris_Label.Size = new Size(534, 46);
            Giris_Label.TabIndex = 2;
            Giris_Label.Text = "GİRİŞ EKRANINA HOŞ GELDİNİZ";
            // 
            // DilDegistir_Combobox
            // 
            DilDegistir_Combobox.FormattingEnabled = true;
            DilDegistir_Combobox.Location = new Point(12, 389);
            DilDegistir_Combobox.Name = "DilDegistir_Combobox";
            DilDegistir_Combobox.Size = new Size(151, 28);
            DilDegistir_Combobox.TabIndex = 11;
            DilDegistir_Combobox.SelectedIndexChanged += DilDegistir_Combobox_SelectedIndexChanged;
            // 
            // DilDegistir_Label
            // 
            DilDegistir_Label.AutoSize = true;
            DilDegistir_Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DilDegistir_Label.Location = new Point(12, 363);
            DilDegistir_Label.Name = "DilDegistir_Label";
            DilDegistir_Label.Size = new Size(117, 23);
            DilDegistir_Label.TabIndex = 12;
            DilDegistir_Label.Text = "DİL DEĞİŞTİR";
            // 
            // YoneticiGiris_Button
            // 
            YoneticiGiris_Button.BackgroundImageLayout = ImageLayout.Zoom;
            YoneticiGiris_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YoneticiGiris_Button.Image = Properties.Resources.businessman__1_;
            YoneticiGiris_Button.ImageAlign = ContentAlignment.MiddleRight;
            YoneticiGiris_Button.Location = new Point(44, 201);
            YoneticiGiris_Button.Name = "YoneticiGiris_Button";
            YoneticiGiris_Button.Size = new Size(257, 98);
            YoneticiGiris_Button.TabIndex = 14;
            YoneticiGiris_Button.Text = "YÖNETİCİ\r\nGİRİŞ";
            YoneticiGiris_Button.TextAlign = ContentAlignment.MiddleLeft;
            YoneticiGiris_Button.UseVisualStyleBackColor = true;
            YoneticiGiris_Button.Visible = false;
            YoneticiGiris_Button.Click += YoneticiGiris_Button_Click;
            // 
            // Ogrenci_Giris_Button
            // 
            Ogrenci_Giris_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Ogrenci_Giris_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ogrenci_Giris_Button.Image = Properties.Resources.graduated__1_;
            Ogrenci_Giris_Button.ImageAlign = ContentAlignment.MiddleRight;
            Ogrenci_Giris_Button.Location = new Point(44, 107);
            Ogrenci_Giris_Button.Name = "Ogrenci_Giris_Button";
            Ogrenci_Giris_Button.Size = new Size(257, 100);
            Ogrenci_Giris_Button.TabIndex = 13;
            Ogrenci_Giris_Button.Text = "ÖĞRENCİ\r\nGİRİŞ";
            Ogrenci_Giris_Button.TextAlign = ContentAlignment.MiddleLeft;
            Ogrenci_Giris_Button.UseVisualStyleBackColor = true;
            Ogrenci_Giris_Button.Visible = false;
            Ogrenci_Giris_Button.Click += Ogrenci_Giris_Button_Click;
            // 
            // Admin_Button
            // 
            Admin_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Admin_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin_Button.Image = Properties.Resources.database_user__2_;
            Admin_Button.ImageAlign = ContentAlignment.MiddleRight;
            Admin_Button.Location = new Point(297, 107);
            Admin_Button.Name = "Admin_Button";
            Admin_Button.Size = new Size(234, 192);
            Admin_Button.TabIndex = 15;
            Admin_Button.Text = "SORUMLU\r\nGİRİŞ";
            Admin_Button.TextAlign = ContentAlignment.MiddleLeft;
            Admin_Button.UseVisualStyleBackColor = true;
            Admin_Button.Visible = false;
            Admin_Button.Click += Admin_Button_Click;
            // 
            // Giris_Button
            // 
            Giris_Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Giris_Button.Image = Properties.Resources.paper_plane__1_;
            Giris_Button.ImageAlign = ContentAlignment.MiddleRight;
            Giris_Button.Location = new Point(44, 106);
            Giris_Button.Name = "Giris_Button";
            Giris_Button.Size = new Size(487, 193);
            Giris_Button.TabIndex = 17;
            Giris_Button.Text = "GİRİŞ SAĞLA";
            Giris_Button.TextAlign = ContentAlignment.MiddleLeft;
            Giris_Button.UseVisualStyleBackColor = true;
            Giris_Button.MouseEnter += Giris_Button_MouseEnter;
            // 
            // Turkey_Picturebox
            // 
            Turkey_Picturebox.Image = Properties.Resources.turkey;
            Turkey_Picturebox.Location = new Point(169, 387);
            Turkey_Picturebox.Name = "Turkey_Picturebox";
            Turkey_Picturebox.Size = new Size(35, 30);
            Turkey_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Turkey_Picturebox.TabIndex = 18;
            Turkey_Picturebox.TabStop = false;
            Turkey_Picturebox.Visible = false;
            // 
            // English_Picturebox
            // 
            English_Picturebox.Image = Properties.Resources.united_kingdom;
            English_Picturebox.Location = new Point(169, 389);
            English_Picturebox.Name = "English_Picturebox";
            English_Picturebox.Size = new Size(35, 28);
            English_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            English_Picturebox.TabIndex = 19;
            English_Picturebox.TabStop = false;
            English_Picturebox.Visible = false;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(632, 439);
            Controls.Add(English_Picturebox);
            Controls.Add(Turkey_Picturebox);
            Controls.Add(Giris_Button);
            Controls.Add(Admin_Button);
            Controls.Add(YoneticiGiris_Button);
            Controls.Add(Ogrenci_Giris_Button);
            Controls.Add(DilDegistir_Label);
            Controls.Add(DilDegistir_Combobox);
            Controls.Add(Giris_Label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Giris";
            Text = "Giriş";
            FormClosing += Giris_FormClosing;
            Shown += Giris_Shown;
            MouseEnter += Giris_MouseEnter;
            ((System.ComponentModel.ISupportInitialize)Turkey_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)English_Picturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Giris_Label;
        private ComboBox DilDegistir_Combobox;
        private Label DilDegistir_Label;
        private Button YoneticiGiris_Button;
        private Button Ogrenci_Giris_Button;
        private Button Admin_Button;
        private Button Giris_Button;
        private PictureBox Turkey_Picturebox;
        private PictureBox English_Picturebox;
    }
}