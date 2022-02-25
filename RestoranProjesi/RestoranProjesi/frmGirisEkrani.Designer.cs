namespace RestoranProjesi
{
    partial class frmGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisEkrani));
            this.txtSifre = new ns1.BunifuMaterialTextbox();
            this.btnGirisYap = new ns1.BunifuThinButton2();
            this.txtKAdi = new ns1.BunifuMaterialTextbox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.HintForeColor = System.Drawing.Color.Empty;
            this.txtSifre.HintText = "";
            this.txtSifre.isPassword = true;
            this.txtSifre.LineFocusedColor = System.Drawing.Color.Brown;
            this.txtSifre.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtSifre.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.txtSifre.LineThickness = 3;
            this.txtSifre.Location = new System.Drawing.Point(64, 202);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(303, 44);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ActiveBorderThickness = 1;
            this.btnGirisYap.ActiveCornerRadius = 20;
            this.btnGirisYap.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGirisYap.ActiveForecolor = System.Drawing.Color.White;
            this.btnGirisYap.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.BackgroundImage")));
            this.btnGirisYap.ButtonText = "Giriş Yap";
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGirisYap.IdleBorderThickness = 1;
            this.btnGirisYap.IdleCornerRadius = 20;
            this.btnGirisYap.IdleFillColor = System.Drawing.Color.White;
            this.btnGirisYap.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGirisYap.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGirisYap.Location = new System.Drawing.Point(125, 255);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(5);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(181, 41);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtKAdi
            // 
            this.txtKAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKAdi.HintForeColor = System.Drawing.Color.Empty;
            this.txtKAdi.HintText = "Kullanıcı Adı";
            this.txtKAdi.isPassword = false;
            this.txtKAdi.LineFocusedColor = System.Drawing.Color.Brown;
            this.txtKAdi.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtKAdi.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.txtKAdi.LineThickness = 3;
            this.txtKAdi.Location = new System.Drawing.Point(64, 150);
            this.txtKAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKAdi.Name = "txtKAdi";
            this.txtKAdi.Size = new System.Drawing.Size(303, 44);
            this.txtKAdi.TabIndex = 1;
            this.txtKAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(147, 333);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(137, 23);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.Text = "Yeni Kullanıcı Oluştur";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.txtKAdi);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGirisEkrani";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.frmGirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuMaterialTextbox txtSifre;
        private ns1.BunifuThinButton2 btnGirisYap;
        private ns1.BunifuMaterialTextbox txtKAdi;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

