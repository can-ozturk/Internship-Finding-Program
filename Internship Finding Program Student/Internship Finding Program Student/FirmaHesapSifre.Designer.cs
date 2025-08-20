namespace Internship_Finding_Program_Student
{
    partial class FirmaHesapSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaHesapSifre));
            MevcutSifre_Label = new Label();
            MevcutSifre_Textbox = new TextBox();
            Onayla_Button = new Button();
            YeniSifre_Label = new Label();
            YeniSifre_Textbox = new TextBox();
            Guncelle_Button = new Button();
            Gorunmez_Picturebox = new PictureBox();
            Gorunur_Picturebox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).BeginInit();
            SuspendLayout();
            // 
            // MevcutSifre_Label
            // 
            MevcutSifre_Label.AutoSize = true;
            MevcutSifre_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MevcutSifre_Label.ImeMode = ImeMode.NoControl;
            MevcutSifre_Label.Location = new Point(12, 9);
            MevcutSifre_Label.Name = "MevcutSifre_Label";
            MevcutSifre_Label.Size = new Size(113, 20);
            MevcutSifre_Label.TabIndex = 87;
            MevcutSifre_Label.Text = "MEVCUT ŞİFRE";
            // 
            // MevcutSifre_Textbox
            // 
            MevcutSifre_Textbox.Location = new Point(12, 32);
            MevcutSifre_Textbox.MaxLength = 20;
            MevcutSifre_Textbox.Name = "MevcutSifre_Textbox";
            MevcutSifre_Textbox.PasswordChar = '*';
            MevcutSifre_Textbox.PlaceholderText = "Mevcut Şifrenizi Girin";
            MevcutSifre_Textbox.Size = new Size(241, 27);
            MevcutSifre_Textbox.TabIndex = 86;
            // 
            // Onayla_Button
            // 
            Onayla_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Onayla_Button.Image = Properties.Resources.done1;
            Onayla_Button.ImageAlign = ContentAlignment.MiddleRight;
            Onayla_Button.Location = new Point(12, 75);
            Onayla_Button.Name = "Onayla_Button";
            Onayla_Button.Size = new Size(187, 59);
            Onayla_Button.TabIndex = 85;
            Onayla_Button.Text = "ONAYLA";
            Onayla_Button.TextAlign = ContentAlignment.MiddleLeft;
            Onayla_Button.UseVisualStyleBackColor = true;
            Onayla_Button.Click += Onayla_Button_Click;
            // 
            // YeniSifre_Label
            // 
            YeniSifre_Label.AutoSize = true;
            YeniSifre_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            YeniSifre_Label.ImeMode = ImeMode.NoControl;
            YeniSifre_Label.Location = new Point(12, 9);
            YeniSifre_Label.Name = "YeniSifre_Label";
            YeniSifre_Label.Size = new Size(86, 20);
            YeniSifre_Label.TabIndex = 84;
            YeniSifre_Label.Text = "YENİ ŞİFRE";
            YeniSifre_Label.Visible = false;
            // 
            // YeniSifre_Textbox
            // 
            YeniSifre_Textbox.Location = new Point(12, 32);
            YeniSifre_Textbox.MaxLength = 20;
            YeniSifre_Textbox.Name = "YeniSifre_Textbox";
            YeniSifre_Textbox.PasswordChar = '*';
            YeniSifre_Textbox.PlaceholderText = "Yeni Şifrenizi Giriniz";
            YeniSifre_Textbox.Size = new Size(241, 27);
            YeniSifre_Textbox.TabIndex = 83;
            YeniSifre_Textbox.Visible = false;
            // 
            // Guncelle_Button
            // 
            Guncelle_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guncelle_Button.Image = Properties.Resources.reload_1_1_;
            Guncelle_Button.ImageAlign = ContentAlignment.MiddleRight;
            Guncelle_Button.Location = new Point(12, 75);
            Guncelle_Button.Name = "Guncelle_Button";
            Guncelle_Button.Size = new Size(187, 59);
            Guncelle_Button.TabIndex = 82;
            Guncelle_Button.Text = "GÜNCELLE";
            Guncelle_Button.TextAlign = ContentAlignment.MiddleLeft;
            Guncelle_Button.UseVisualStyleBackColor = true;
            Guncelle_Button.Visible = false;
            Guncelle_Button.Click += Guncelle_Button_Click;
            // 
            // Gorunmez_Picturebox
            // 
            Gorunmez_Picturebox.Image = Properties.Resources.hide;
            Gorunmez_Picturebox.Location = new Point(259, 32);
            Gorunmez_Picturebox.Name = "Gorunmez_Picturebox";
            Gorunmez_Picturebox.Size = new Size(30, 25);
            Gorunmez_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunmez_Picturebox.TabIndex = 89;
            Gorunmez_Picturebox.TabStop = false;
            Gorunmez_Picturebox.Visible = false;
            Gorunmez_Picturebox.Click += Gorunmez_Picturebox_Click;
            // 
            // Gorunur_Picturebox
            // 
            Gorunur_Picturebox.Image = Properties.Resources.view;
            Gorunur_Picturebox.Location = new Point(259, 32);
            Gorunur_Picturebox.Name = "Gorunur_Picturebox";
            Gorunur_Picturebox.Size = new Size(30, 25);
            Gorunur_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunur_Picturebox.TabIndex = 88;
            Gorunur_Picturebox.TabStop = false;
            Gorunur_Picturebox.Click += Gorunur_Picturebox_Click;
            // 
            // FirmaHesapSifre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(323, 167);
            Controls.Add(Gorunmez_Picturebox);
            Controls.Add(Gorunur_Picturebox);
            Controls.Add(MevcutSifre_Label);
            Controls.Add(MevcutSifre_Textbox);
            Controls.Add(Onayla_Button);
            Controls.Add(YeniSifre_Label);
            Controls.Add(YeniSifre_Textbox);
            Controls.Add(Guncelle_Button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FirmaHesapSifre";
            Text = "ŞİFRE DEĞİŞTİR";
            FormClosing += YoneticiHesapSifre_FormClosing;
            Shown += YoneticiHesapSifre_Shown;
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MevcutSifre_Label;
        private TextBox MevcutSifre_Textbox;
        private Button Onayla_Button;
        private Label YeniSifre_Label;
        private TextBox YeniSifre_Textbox;
        private Button Guncelle_Button;
        private PictureBox Gorunmez_Picturebox;
        private PictureBox Gorunur_Picturebox;
    }
}