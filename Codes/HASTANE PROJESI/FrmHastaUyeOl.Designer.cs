namespace HASTANE_PROJESI
{
    partial class FrmHastaUyeOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaUyeOl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.mskBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.mskBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cinsiyet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "T.C. Kimlik No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Soyad :";
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(226, 63);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(155, 40);
            this.txtBoxAd.TabIndex = 2;
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Location = new System.Drawing.Point(226, 113);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(157, 40);
            this.txtBoxSoyad.TabIndex = 3;
            // 
            // mskBoxTc
            // 
            this.mskBoxTc.Location = new System.Drawing.Point(226, 18);
            this.mskBoxTc.Mask = "00000000000";
            this.mskBoxTc.Name = "mskBoxTc";
            this.mskBoxTc.Size = new System.Drawing.Size(157, 40);
            this.mskBoxTc.TabIndex = 1;
            // 
            // mskBoxTelefon
            // 
            this.mskBoxTelefon.Location = new System.Drawing.Point(226, 163);
            this.mskBoxTelefon.Mask = "(999) 000-0000";
            this.mskBoxTelefon.Name = "mskBoxTelefon";
            this.mskBoxTelefon.Size = new System.Drawing.Size(157, 40);
            this.mskBoxTelefon.TabIndex = 4;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(228, 216);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(155, 40);
            this.txtBoxSifre.TabIndex = 5;
            this.txtBoxSifre.UseSystemPasswordChar = true;
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.Font = new System.Drawing.Font("Corbel", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(226, 262);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(150, 30);
            this.checkBoxSifreGoster.TabIndex = 6;
            this.checkBoxSifreGoster.Text = "Şifreyi Göster";
            this.checkBoxSifreGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(226, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox1.Location = new System.Drawing.Point(226, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 41);
            this.comboBox1.TabIndex = 7;
            // 
            // FrmHastaUyeOl
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(460, 405);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "FrmHastaUyeOl";
            this.Text = "Hasta Üye Olma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.MaskedTextBox mskBoxTc;
        private System.Windows.Forms.MaskedTextBox mskBoxTelefon;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}