namespace Internship_Finding_Program_Student
{
    partial class EpostaDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EpostaDegistir));
            Guncelle_Button = new Button();
            YeniEposta_Label = new Label();
            EpostayıGuncelle_Textbox = new TextBox();
            Ogr_Eposta_Label = new Label();
            Ogr_Eposta_Textbox = new TextBox();
            SuspendLayout();
            // 
            // Guncelle_Button
            // 
            Guncelle_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guncelle_Button.Image = Properties.Resources.reload_1_1_1;
            Guncelle_Button.ImageAlign = ContentAlignment.MiddleRight;
            Guncelle_Button.ImeMode = ImeMode.NoControl;
            Guncelle_Button.Location = new Point(43, 170);
            Guncelle_Button.Name = "Guncelle_Button";
            Guncelle_Button.Size = new Size(217, 59);
            Guncelle_Button.TabIndex = 77;
            Guncelle_Button.Text = "GÜNCELLE";
            Guncelle_Button.TextAlign = ContentAlignment.MiddleLeft;
            Guncelle_Button.UseVisualStyleBackColor = true;
            Guncelle_Button.Click += Guncelle_Button_Click;
            // 
            // YeniEposta_Label
            // 
            YeniEposta_Label.AutoSize = true;
            YeniEposta_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            YeniEposta_Label.ImeMode = ImeMode.NoControl;
            YeniEposta_Label.Location = new Point(32, 100);
            YeniEposta_Label.Name = "YeniEposta_Label";
            YeniEposta_Label.Size = new Size(165, 20);
            YeniEposta_Label.TabIndex = 76;
            YeniEposta_Label.Text = "YENİ E-POSTA ADRESİ";
            // 
            // EpostayıGuncelle_Textbox
            // 
            EpostayıGuncelle_Textbox.Location = new Point(32, 123);
            EpostayıGuncelle_Textbox.MaxLength = 30;
            EpostayıGuncelle_Textbox.Name = "EpostayıGuncelle_Textbox";
            EpostayıGuncelle_Textbox.PlaceholderText = "Yeni E-Posta Adresi";
            EpostayıGuncelle_Textbox.Size = new Size(241, 27);
            EpostayıGuncelle_Textbox.TabIndex = 75;
            // 
            // Ogr_Eposta_Label
            // 
            Ogr_Eposta_Label.AutoSize = true;
            Ogr_Eposta_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Ogr_Eposta_Label.ImeMode = ImeMode.NoControl;
            Ogr_Eposta_Label.Location = new Point(32, 18);
            Ogr_Eposta_Label.Name = "Ogr_Eposta_Label";
            Ogr_Eposta_Label.Size = new Size(192, 20);
            Ogr_Eposta_Label.TabIndex = 79;
            Ogr_Eposta_Label.Text = "MEVCUT E-POSTA ADRESİ";
            // 
            // Ogr_Eposta_Textbox
            // 
            Ogr_Eposta_Textbox.Enabled = false;
            Ogr_Eposta_Textbox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Ogr_Eposta_Textbox.Location = new Point(32, 41);
            Ogr_Eposta_Textbox.Name = "Ogr_Eposta_Textbox";
            Ogr_Eposta_Textbox.Size = new Size(241, 27);
            Ogr_Eposta_Textbox.TabIndex = 78;
            // 
            // EpostaDegistir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(304, 273);
            Controls.Add(Ogr_Eposta_Label);
            Controls.Add(Ogr_Eposta_Textbox);
            Controls.Add(Guncelle_Button);
            Controls.Add(YeniEposta_Label);
            Controls.Add(EpostayıGuncelle_Textbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EpostaDegistir";
            Text = "E-POSTA DEĞİŞTİR";
            FormClosing += EpostaDegistir_FormClosing;
            Shown += EpostaDegistir_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guncelle_Button;
        private Label YeniEposta_Label;
        private TextBox EpostayıGuncelle_Textbox;
        private Label Ogr_Eposta_Label;
        private TextBox Ogr_Eposta_Textbox;
    }
}