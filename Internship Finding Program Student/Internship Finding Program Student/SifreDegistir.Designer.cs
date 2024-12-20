namespace Internship_Finding_Program_Student
{
    partial class SifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistir));
            Guncelle_Button = new Button();
            YeniSifre_Label = new Label();
            YeniSifre_Textbox = new TextBox();
            MevcutSifre_Textbox = new TextBox();
            Onayla_Button = new Button();
            MevcutSifre_Label = new Label();
            Gorunmez_Picturebox = new PictureBox();
            Gorunur_Picturebox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).BeginInit();
            SuspendLayout();
            // 
            // Guncelle_Button
            // 
            Guncelle_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guncelle_Button.Image = Properties.Resources.reload_1_1_;
            Guncelle_Button.ImageAlign = ContentAlignment.MiddleRight;
            Guncelle_Button.Location = new Point(9, 81);
            Guncelle_Button.Name = "Guncelle_Button";
            Guncelle_Button.Size = new Size(192, 59);
            Guncelle_Button.TabIndex = 0;
            Guncelle_Button.Text = "GÜNCELLE";
            Guncelle_Button.TextAlign = ContentAlignment.MiddleLeft;
            Guncelle_Button.UseVisualStyleBackColor = true;
            Guncelle_Button.Visible = false;
            Guncelle_Button.Click += Guncelle_Button_Click;
            // 
            // YeniSifre_Label
            // 
            YeniSifre_Label.AutoSize = true;
            YeniSifre_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            YeniSifre_Label.ImeMode = ImeMode.NoControl;
            YeniSifre_Label.Location = new Point(9, 16);
            YeniSifre_Label.Name = "YeniSifre_Label";
            YeniSifre_Label.Size = new Size(86, 20);
            YeniSifre_Label.TabIndex = 78;
            YeniSifre_Label.Text = "YENİ ŞİFRE";
            YeniSifre_Label.Visible = false;
            // 
            // YeniSifre_Textbox
            // 
            YeniSifre_Textbox.Location = new Point(9, 39);
            YeniSifre_Textbox.MaxLength = 20;
            YeniSifre_Textbox.Name = "YeniSifre_Textbox";
            YeniSifre_Textbox.PasswordChar = '*';
            YeniSifre_Textbox.PlaceholderText = "Yeni Şifrenizi Giriniz";
            YeniSifre_Textbox.Size = new Size(241, 27);
            YeniSifre_Textbox.TabIndex = 77;
            YeniSifre_Textbox.Visible = false;
            // 
            // MevcutSifre_Textbox
            // 
            MevcutSifre_Textbox.Location = new Point(9, 39);
            MevcutSifre_Textbox.MaxLength = 20;
            MevcutSifre_Textbox.Name = "MevcutSifre_Textbox";
            MevcutSifre_Textbox.PasswordChar = '*';
            MevcutSifre_Textbox.PlaceholderText = "Mevcut Şifrenizi Girin";
            MevcutSifre_Textbox.Size = new Size(241, 27);
            MevcutSifre_Textbox.TabIndex = 80;
            // 
            // Onayla_Button
            // 
            Onayla_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Onayla_Button.Image = Properties.Resources.done1;
            Onayla_Button.ImageAlign = ContentAlignment.MiddleRight;
            Onayla_Button.Location = new Point(9, 81);
            Onayla_Button.Name = "Onayla_Button";
            Onayla_Button.Size = new Size(192, 59);
            Onayla_Button.TabIndex = 79;
            Onayla_Button.Text = "ONAYLA";
            Onayla_Button.TextAlign = ContentAlignment.MiddleLeft;
            Onayla_Button.UseVisualStyleBackColor = true;
            Onayla_Button.Click += Onayla_Button_Click;
            // 
            // MevcutSifre_Label
            // 
            MevcutSifre_Label.AutoSize = true;
            MevcutSifre_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MevcutSifre_Label.ImeMode = ImeMode.NoControl;
            MevcutSifre_Label.Location = new Point(9, 16);
            MevcutSifre_Label.Name = "MevcutSifre_Label";
            MevcutSifre_Label.Size = new Size(113, 20);
            MevcutSifre_Label.TabIndex = 81;
            MevcutSifre_Label.Text = "MEVCUT ŞİFRE";
            // 
            // Gorunmez_Picturebox
            // 
            Gorunmez_Picturebox.Image = Properties.Resources.hide;
            Gorunmez_Picturebox.Location = new Point(267, 41);
            Gorunmez_Picturebox.Name = "Gorunmez_Picturebox";
            Gorunmez_Picturebox.Size = new Size(30, 25);
            Gorunmez_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunmez_Picturebox.TabIndex = 83;
            Gorunmez_Picturebox.TabStop = false;
            Gorunmez_Picturebox.Visible = false;
            Gorunmez_Picturebox.Click += Gorunmez_Picturebox_Click;
            // 
            // Gorunur_Picturebox
            // 
            Gorunur_Picturebox.Image = Properties.Resources.view;
            Gorunur_Picturebox.Location = new Point(267, 41);
            Gorunur_Picturebox.Name = "Gorunur_Picturebox";
            Gorunur_Picturebox.Size = new Size(30, 25);
            Gorunur_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Gorunur_Picturebox.TabIndex = 82;
            Gorunur_Picturebox.TabStop = false;
            Gorunur_Picturebox.Click += Gorunur_Picturebox_Click;
            // 
            // SifreDegistir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(320, 152);
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
            Name = "SifreDegistir";
            Text = "ŞİFRE DEĞİŞTİR";
            FormClosing += SifreDegistir_FormClosing;
            Shown += SifreDegistir_Shown;
            ((System.ComponentModel.ISupportInitialize)Gorunmez_Picturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gorunur_Picturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guncelle_Button;
        private Label YeniSifre_Label;
        private TextBox YeniSifre_Textbox;
        private TextBox MevcutSifre_Textbox;
        private Button Onayla_Button;
        private Label MevcutSifre_Label;
        private PictureBox Gorunmez_Picturebox;
        private PictureBox Gorunur_Picturebox;
    }
}