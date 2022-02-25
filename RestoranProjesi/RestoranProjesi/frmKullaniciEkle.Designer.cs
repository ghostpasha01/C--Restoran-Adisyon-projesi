namespace RestoranProjesi
{
    partial class frmKullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciEkle));
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new ns1.BunifuTextbox();
            this.txtKAdi = new ns1.BunifuTextbox();
            this.btnOlustur = new ns1.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyad = new ns1.BunifuTextbox();
            this.txtSifre = new ns1.BunifuTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(135, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAd.BackgroundImage")));
            this.txtAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAd.ForeColor = System.Drawing.Color.Brown;
            this.txtAd.Icon = ((System.Drawing.Image)(resources.GetObject("txtAd.Icon")));
            this.txtAd.Location = new System.Drawing.Point(124, 104);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(223, 32);
            this.txtAd.TabIndex = 1;
            this.txtAd.text = "";
            // 
            // txtKAdi
            // 
            this.txtKAdi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtKAdi.BackgroundImage")));
            this.txtKAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtKAdi.ForeColor = System.Drawing.Color.Brown;
            this.txtKAdi.Icon = ((System.Drawing.Image)(resources.GetObject("txtKAdi.Icon")));
            this.txtKAdi.Location = new System.Drawing.Point(124, 232);
            this.txtKAdi.Name = "txtKAdi";
            this.txtKAdi.Size = new System.Drawing.Size(223, 32);
            this.txtKAdi.TabIndex = 3;
            this.txtKAdi.text = "";
            // 
            // btnOlustur
            // 
            this.btnOlustur.ActiveBorderThickness = 1;
            this.btnOlustur.ActiveCornerRadius = 20;
            this.btnOlustur.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.ActiveForecolor = System.Drawing.Color.White;
            this.btnOlustur.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOlustur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOlustur.BackgroundImage")));
            this.btnOlustur.ButtonText = "Kullanıcı Oluştur";
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlustur.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.IdleBorderThickness = 1;
            this.btnOlustur.IdleCornerRadius = 20;
            this.btnOlustur.IdleFillColor = System.Drawing.SystemColors.Window;
            this.btnOlustur.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOlustur.Location = new System.Drawing.Point(143, 359);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(5);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(185, 41);
            this.btnOlustur.TabIndex = 5;
            this.btnOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(135, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(135, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSoyad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSoyad.BackgroundImage")));
            this.txtSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSoyad.ForeColor = System.Drawing.Color.Brown;
            this.txtSoyad.Icon = ((System.Drawing.Image)(resources.GetObject("txtSoyad.Icon")));
            this.txtSoyad.Location = new System.Drawing.Point(124, 168);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(223, 32);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.text = "";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSifre.BackgroundImage")));
            this.txtSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSifre.ForeColor = System.Drawing.Color.Brown;
            this.txtSifre.Icon = ((System.Drawing.Image)(resources.GetObject("txtSifre.Icon")));
            this.txtSifre.Location = new System.Drawing.Point(124, 296);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(223, 32);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(135, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Şifre";
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtKAdi);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKullaniciEkle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Kullanıcı Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private ns1.BunifuTextbox txtAd;
        private ns1.BunifuTextbox txtKAdi;
        private ns1.BunifuThinButton2 btnOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuTextbox txtSoyad;
        private ns1.BunifuTextbox txtSifre;
        private System.Windows.Forms.Label label4;
    }
}