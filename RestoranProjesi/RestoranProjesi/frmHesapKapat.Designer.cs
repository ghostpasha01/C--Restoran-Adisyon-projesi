namespace RestoranProjesi
{
    partial class frmHesapKapat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapKapat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMasa = new ns1.BunifuCustomLabel();
            this.lblTutar = new ns1.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTutar = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel1.Location = new System.Drawing.Point(180, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 2);
            this.panel1.TabIndex = 15;
            // 
            // lblMasa
            // 
            this.lblMasa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasa.Location = new System.Drawing.Point(180, 60);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(240, 32);
            this.lblMasa.TabIndex = 14;
            this.lblMasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTutar
            // 
            this.lblTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTutar.Location = new System.Drawing.Point(180, 100);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(240, 32);
            this.lblTutar.TabIndex = 16;
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(76, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 17;
            this.button1.Tag = "0";
            this.button1.Text = "Nakit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(76, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 50);
            this.button2.TabIndex = 18;
            this.button2.Tag = "1";
            this.button2.Text = "Kredi Kartı";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(306, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 50);
            this.button3.TabIndex = 19;
            this.button3.Tag = "2";
            this.button3.Text = "İndirimli";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(306, 191);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Tutar";
            // 
            // txtTutar
            // 
            // 
            // 
            // 
            this.txtTutar.CustomButton.Image = null;
            this.txtTutar.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtTutar.CustomButton.Name = "";
            this.txtTutar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTutar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTutar.CustomButton.TabIndex = 1;
            this.txtTutar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTutar.CustomButton.UseSelectable = true;
            this.txtTutar.CustomButton.Visible = false;
            this.txtTutar.Lines = new string[0];
            this.txtTutar.Location = new System.Drawing.Point(306, 213);
            this.txtTutar.MaxLength = 32767;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.PasswordChar = '\0';
            this.txtTutar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTutar.SelectedText = "";
            this.txtTutar.SelectionLength = 0;
            this.txtTutar.SelectionStart = 0;
            this.txtTutar.ShortcutsEnabled = true;
            this.txtTutar.Size = new System.Drawing.Size(170, 23);
            this.txtTutar.TabIndex = 20;
            this.txtTutar.UseSelectable = true;
            this.txtTutar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTutar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmHesapKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHesapKapat";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.frmHesapKapat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel lblMasa;
        private ns1.BunifuCustomLabel lblTutar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTutar;
    }
}