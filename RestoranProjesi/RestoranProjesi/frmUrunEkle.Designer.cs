namespace RestoranProjesi
{
    partial class frmUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunEkle));
            this.txtUrunAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFiyati = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtGorselYolu = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSKullanilan = new System.Windows.Forms.CheckBox();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAdi
            // 
            // 
            // 
            // 
            this.txtUrunAdi.CustomButton.Image = null;
            this.txtUrunAdi.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txtUrunAdi.CustomButton.Name = "";
            this.txtUrunAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUrunAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrunAdi.CustomButton.TabIndex = 1;
            this.txtUrunAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrunAdi.CustomButton.UseSelectable = true;
            this.txtUrunAdi.CustomButton.Visible = false;
            this.txtUrunAdi.Lines = new string[0];
            this.txtUrunAdi.Location = new System.Drawing.Point(98, 160);
            this.txtUrunAdi.MaxLength = 32767;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PasswordChar = '\0';
            this.txtUrunAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrunAdi.SelectedText = "";
            this.txtUrunAdi.SelectionLength = 0;
            this.txtUrunAdi.SelectionStart = 0;
            this.txtUrunAdi.ShortcutsEnabled = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(176, 23);
            this.txtUrunAdi.TabIndex = 0;
            this.txtUrunAdi.UseSelectable = true;
            this.txtUrunAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrunAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(98, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Ürün Adı";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Items.AddRange(new object[] {
            "Çorbalar",
            "Et Yemekleri",
            "İçecekler",
            "Ana Yemekler",
            "Sebze ve Meyve",
            "Salatalar",
            "Tatlılar"});
            this.cmbKategori.Location = new System.Drawing.Point(98, 218);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(332, 29);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(298, 138);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Ürün Fiyatı";
            // 
            // txtFiyati
            // 
            // 
            // 
            // 
            this.txtFiyati.CustomButton.Image = null;
            this.txtFiyati.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtFiyati.CustomButton.Name = "";
            this.txtFiyati.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiyati.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiyati.CustomButton.TabIndex = 1;
            this.txtFiyati.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiyati.CustomButton.UseSelectable = true;
            this.txtFiyati.CustomButton.Visible = false;
            this.txtFiyati.Lines = new string[0];
            this.txtFiyati.Location = new System.Drawing.Point(298, 160);
            this.txtFiyati.MaxLength = 32767;
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.PasswordChar = '\0';
            this.txtFiyati.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiyati.SelectedText = "";
            this.txtFiyati.SelectionLength = 0;
            this.txtFiyati.SelectionStart = 0;
            this.txtFiyati.ShortcutsEnabled = true;
            this.txtFiyati.Size = new System.Drawing.Size(104, 23);
            this.txtFiyati.TabIndex = 1;
            this.txtFiyati.UseSelectable = true;
            this.txtFiyati.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiyati.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(98, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Ürün Kategorisi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(280, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(98, 260);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Ürün Görseli";
            // 
            // txtGorselYolu
            // 
            // 
            // 
            // 
            this.txtGorselYolu.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtGorselYolu.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txtGorselYolu.CustomButton.Name = "";
            this.txtGorselYolu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGorselYolu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGorselYolu.CustomButton.TabIndex = 1;
            this.txtGorselYolu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGorselYolu.CustomButton.UseSelectable = true;
            this.txtGorselYolu.Lines = new string[0];
            this.txtGorselYolu.Location = new System.Drawing.Point(98, 282);
            this.txtGorselYolu.MaxLength = 32767;
            this.txtGorselYolu.Name = "txtGorselYolu";
            this.txtGorselYolu.PasswordChar = '\0';
            this.txtGorselYolu.ReadOnly = true;
            this.txtGorselYolu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGorselYolu.SelectedText = "";
            this.txtGorselYolu.SelectionLength = 0;
            this.txtGorselYolu.SelectionStart = 0;
            this.txtGorselYolu.ShortcutsEnabled = true;
            this.txtGorselYolu.ShowButton = true;
            this.txtGorselYolu.Size = new System.Drawing.Size(176, 23);
            this.txtGorselYolu.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtGorselYolu.TabIndex = 3;
            this.txtGorselYolu.UseSelectable = true;
            this.txtGorselYolu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGorselYolu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGorselYolu.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtGorselYolu_ButtonClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(197, 60);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(135, 32);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "ÜRÜN EKLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel1.Location = new System.Drawing.Point(144, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 2);
            this.panel1.TabIndex = 13;
            // 
            // cbSKullanilan
            // 
            this.cbSKullanilan.AutoSize = true;
            this.cbSKullanilan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbSKullanilan.Location = new System.Drawing.Point(98, 328);
            this.cbSKullanilan.Name = "cbSKullanilan";
            this.cbSKullanilan.Size = new System.Drawing.Size(116, 24);
            this.cbSKullanilan.TabIndex = 4;
            this.cbSKullanilan.Text = "Sık Kullanılan";
            this.cbSKullanilan.UseVisualStyleBackColor = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Ekle";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(98, 452);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(332, 41);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 530);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.cbSKullanilan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtGorselYolu);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiyati);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUrunAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUrunEkle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUrunAdi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFiyati;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtGorselYolu;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbSKullanilan;
        private ns1.BunifuThinButton2 bunifuThinButton21;
    }
}