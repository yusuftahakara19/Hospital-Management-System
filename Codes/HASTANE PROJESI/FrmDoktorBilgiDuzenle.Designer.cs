namespace HASTANE_PROJESI
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.mskBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(116, 306);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(256, 45);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.Font = new System.Drawing.Font("Corbel", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(217, 270);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(150, 30);
            this.checkBoxSifreGoster.TabIndex = 5;
            this.checkBoxSifreGoster.Text = "Şifreyi Göster";
            this.checkBoxSifreGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreGoster_CheckedChanged);
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(217, 224);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(157, 40);
            this.txtBoxSifre.TabIndex = 4;
            this.txtBoxSifre.UseSystemPasswordChar = true;
            // 
            // mskBoxTc
            // 
            this.mskBoxTc.Enabled = false;
            this.mskBoxTc.Location = new System.Drawing.Point(217, 29);
            this.mskBoxTc.Mask = "00000000000";
            this.mskBoxTc.Name = "mskBoxTc";
            this.mskBoxTc.Size = new System.Drawing.Size(157, 40);
            this.mskBoxTc.TabIndex = 27;
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Location = new System.Drawing.Point(217, 121);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(157, 40);
            this.txtBoxSoyad.TabIndex = 2;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(217, 72);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(157, 40);
            this.txtBoxAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 35);
            this.label6.TabIndex = 35;
            this.label6.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 35);
            this.label5.TabIndex = 33;
            this.label5.Text = "T.C. Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 35);
            this.label4.TabIndex = 32;
            this.label4.Text = "Branş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ad :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(217, 171);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(157, 41);
            this.cmbBrans.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(116, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 45);
            this.button1.TabIndex = 36;
            this.button1.Text = "Sayfaya Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(410, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.checkBoxSifreGoster);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.mskBoxTc);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "FrmDoktorBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.MaskedTextBox mskBoxTc;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button button1;
    }
}