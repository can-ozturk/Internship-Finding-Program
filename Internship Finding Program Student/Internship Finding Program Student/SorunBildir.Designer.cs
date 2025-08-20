namespace Internship_Finding_Program_Student
{
    partial class SorunBildir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorunBildir));
            Yazı8_Label = new Label();
            Yazı6_Label = new Label();
            Yazı_Linkkabel = new LinkLabel();
            Yazı3_Label = new Label();
            Mailler_Combobox = new ComboBox();
            Yazı2_Label = new Label();
            Yazı4_Label = new Label();
            SuspendLayout();
            // 
            // Yazı8_Label
            // 
            Yazı8_Label.AutoSize = true;
            Yazı8_Label.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Yazı8_Label.Location = new Point(12, 313);
            Yazı8_Label.Name = "Yazı8_Label";
            Yazı8_Label.Size = new Size(148, 17);
            Yazı8_Label.TabIndex = 29;
            Yazı8_Label.Text = "Bizim için değerlisiniz...";
            // 
            // Yazı6_Label
            // 
            Yazı6_Label.AutoSize = true;
            Yazı6_Label.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            Yazı6_Label.Location = new Point(269, 164);
            Yazı6_Label.Name = "Yazı6_Label";
            Yazı6_Label.Size = new Size(241, 17);
            Yazı6_Label.TabIndex = 27;
            Yazı6_Label.Text = "Intership Finding Program Forum için";
            // 
            // Yazı_Linkkabel
            // 
            Yazı_Linkkabel.AutoSize = true;
            Yazı_Linkkabel.BackColor = SystemColors.MenuHighlight;
            Yazı_Linkkabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            Yazı_Linkkabel.LinkColor = Color.White;
            Yazı_Linkkabel.Location = new Point(446, 181);
            Yazı_Linkkabel.Name = "Yazı_Linkkabel";
            Yazı_Linkkabel.Size = new Size(64, 17);
            Yazı_Linkkabel.TabIndex = 26;
            Yazı_Linkkabel.TabStop = true;
            Yazı_Linkkabel.Text = "tıklayınız";
            Yazı_Linkkabel.LinkClicked += Yazı_Linkkabel_LinkClicked;
            // 
            // Yazı3_Label
            // 
            Yazı3_Label.AutoSize = true;
            Yazı3_Label.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Yazı3_Label.Location = new Point(9, 61);
            Yazı3_Label.Name = "Yazı3_Label";
            Yazı3_Label.Size = new Size(173, 17);
            Yazı3_Label.TabIndex = 24;
            Yazı3_Label.Text = "İlginiz için teşekkür ederiz.";
            // 
            // Mailler_Combobox
            // 
            Mailler_Combobox.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            Mailler_Combobox.FormattingEnabled = true;
            Mailler_Combobox.Location = new Point(12, 161);
            Mailler_Combobox.Margin = new Padding(3, 4, 3, 4);
            Mailler_Combobox.Name = "Mailler_Combobox";
            Mailler_Combobox.Size = new Size(173, 25);
            Mailler_Combobox.TabIndex = 21;
            // 
            // Yazı2_Label
            // 
            Yazı2_Label.AutoSize = true;
            Yazı2_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Yazı2_Label.Location = new Point(9, 9);
            Yazı2_Label.Name = "Yazı2_Label";
            Yazı2_Label.Size = new Size(645, 40);
            Yazı2_Label.TabIndex = 20;
            Yazı2_Label.Text = "SORUN OLDUĞUNU DÜŞÜNÜYORSANIZ LÜTFEN AŞAĞIDAKİ MAİLLERDEN BİR TANESİNE\r\nSORUNUN EKRAN GÖRÜNTÜSÜNÜ GÖNDEREREK KISACA İZAH EDİNİZ.";
            // 
            // Yazı4_Label
            // 
            Yazı4_Label.AutoSize = true;
            Yazı4_Label.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            Yazı4_Label.Location = new Point(211, 164);
            Yazı4_Label.Name = "Yazı4_Label";
            Yazı4_Label.Size = new Size(36, 17);
            Yazı4_Label.TabIndex = 28;
            Yazı4_Label.Text = "veya";
            // 
            // SorunBildir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(669, 342);
            Controls.Add(Yazı8_Label);
            Controls.Add(Yazı4_Label);
            Controls.Add(Yazı6_Label);
            Controls.Add(Yazı_Linkkabel);
            Controls.Add(Yazı3_Label);
            Controls.Add(Mailler_Combobox);
            Controls.Add(Yazı2_Label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SorunBildir";
            Text = "SORUN BİLDİR";
            FormClosing += SorunBildir_FormClosing;
            Shown += SorunBildir_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Yazı8_Label;
        private Label Yazı6_Label;
        private LinkLabel Yazı_Linkkabel;
        private Label Yazı3_Label;
        private ComboBox Mailler_Combobox;
        private Label Yazı2_Label;
        private Label Yazı4_Label;
    }
}