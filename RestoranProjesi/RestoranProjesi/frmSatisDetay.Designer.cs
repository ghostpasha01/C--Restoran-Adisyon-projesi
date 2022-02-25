namespace RestoranProjesi
{
    partial class frmSatisDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisDetay));
            this.dtTarih = new MetroFramework.Controls.MetroDateTime();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTarih = new ns1.BunifuCustomLabel();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.dgvMenuler = new System.Windows.Forms.DataGridView();
            this.lblSatisSayisi = new ns1.BunifuCustomLabel();
            this.lblHasilat = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(142, 75);
            this.dtTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(332, 29);
            this.dtTarih.TabIndex = 0;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.AllowUserToAddRows = false;
            this.dgvSatislar.AllowUserToDeleteRows = false;
            this.dgvSatislar.AllowUserToResizeColumns = false;
            this.dgvSatislar.AllowUserToResizeRows = false;
            this.dgvSatislar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(50, 110);
            this.dgvSatislar.MultiSelect = false;
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.ReadOnly = true;
            this.dgvSatislar.RowHeadersVisible = false;
            this.dgvSatislar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatislar.Size = new System.Drawing.Size(424, 417);
            this.dgvSatislar.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lblTarih
            // 
            this.lblTarih.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Location = new System.Drawing.Point(84, 72);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(52, 33);
            this.lblTarih.TabIndex = 34;
            this.lblTarih.Text = "Tarih";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.AllowUserToResizeColumns = false;
            this.dgvUrunler.AllowUserToResizeRows = false;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(526, 110);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(413, 182);
            this.dgvUrunler.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(526, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 2);
            this.panel1.TabIndex = 38;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(674, 60);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 32);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "ÜRÜNLER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(526, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 2);
            this.panel2.TabIndex = 41;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(672, 295);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(120, 32);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "MENÜLER";
            // 
            // dgvMenuler
            // 
            this.dgvMenuler.AllowUserToAddRows = false;
            this.dgvMenuler.AllowUserToDeleteRows = false;
            this.dgvMenuler.AllowUserToResizeColumns = false;
            this.dgvMenuler.AllowUserToResizeRows = false;
            this.dgvMenuler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuler.Location = new System.Drawing.Point(526, 345);
            this.dgvMenuler.MultiSelect = false;
            this.dgvMenuler.Name = "dgvMenuler";
            this.dgvMenuler.ReadOnly = true;
            this.dgvMenuler.RowHeadersVisible = false;
            this.dgvMenuler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMenuler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuler.Size = new System.Drawing.Size(413, 182);
            this.dgvMenuler.TabIndex = 39;
            // 
            // lblSatisSayisi
            // 
            this.lblSatisSayisi.AutoSize = true;
            this.lblSatisSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblSatisSayisi.Location = new System.Drawing.Point(47, 530);
            this.lblSatisSayisi.Name = "lblSatisSayisi";
            this.lblSatisSayisi.Size = new System.Drawing.Size(0, 17);
            this.lblSatisSayisi.TabIndex = 42;
            this.lblSatisSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHasilat
            // 
            this.lblHasilat.AutoSize = true;
            this.lblHasilat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHasilat.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHasilat.Location = new System.Drawing.Point(47, 552);
            this.lblHasilat.Name = "lblHasilat";
            this.lblHasilat.Size = new System.Drawing.Size(0, 17);
            this.lblHasilat.TabIndex = 43;
            this.lblHasilat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSatisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 583);
            this.Controls.Add(this.lblHasilat);
            this.Controls.Add(this.lblSatisSayisi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dgvMenuler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.dtTarih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSatisDetay";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.frmSatisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtTarih;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuCustomLabel lblTarih;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridView dgvMenuler;
        private ns1.BunifuCustomLabel lblSatisSayisi;
        private ns1.BunifuCustomLabel lblHasilat;
    }
}