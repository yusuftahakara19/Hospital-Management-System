namespace HASTANE_PROJESI
{
    partial class FrmHastaBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiDuzenle));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.mskBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(217, 360);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(163, 45);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.Font = new System.Drawing.Font("Corbel", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(217, 265);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(150, 30);
            this.checkBoxSifreGoster.TabIndex = 5;
            this.checkBoxSifreGoster.Text = "Şifreyi Göster";
            this.checkBoxSifreGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreGoster_CheckedChanged);
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(219, 219);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(163, 40);
            this.txtBoxSifre.TabIndex = 4;
            this.txtBoxSifre.UseSystemPasswordChar = true;
            // 
            // mskBoxTelefon
            // 
            this.mskBoxTelefon.Location = new System.Drawing.Point(217, 166);
            this.mskBoxTelefon.Mask = "(999) 000-0000";
            this.mskBoxTelefon.Name = "mskBoxTelefon";
            this.mskBoxTelefon.Size = new System.Drawing.Size(165, 40);
            this.mskBoxTelefon.TabIndex = 3;
            // 
            // mskBoxTc
            // 
            this.mskBoxTc.Enabled = false;
            this.mskBoxTc.Location = new System.Drawing.Point(217, 21);
            this.mskBoxTc.Mask = "00000000000";
            this.mskBoxTc.Name = "mskBoxTc";
            this.mskBoxTc.Size = new System.Drawing.Size(165, 40);
            this.mskBoxTc.TabIndex = 12;
            this.mskBoxTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskBoxTc_MaskInputRejected);
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Location = new System.Drawing.Point(217, 116);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(165, 40);
            this.txtBoxSoyad.TabIndex = 2;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(217, 66);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(165, 40);
            this.txtBoxAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 35);
            this.label6.TabIndex = 20;
            this.label6.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "T.C. Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cinsiyet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox1.Location = new System.Drawing.Point(217, 303);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 41);
            this.comboBox1.TabIndex = 6;
            // 
            // FrmHastaBilgiDuzenle
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(460, 431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.checkBoxSifreGoster);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.mskBoxTelefon);
            this.Controls.Add(this.mskBoxTc);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBilgiDuzenle";
            this.Text = "FrmHastaBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmHastaBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.MaskedTextBox mskBoxTelefon;
        private System.Windows.Forms.MaskedTextBox mskBoxTc;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}