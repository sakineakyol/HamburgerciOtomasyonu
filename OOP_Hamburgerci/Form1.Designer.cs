
namespace OOP_Hamburgerci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.rdKucuk = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdBuyuk = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flwEkstraMalzeme = new System.Windows.Forms.FlowLayoutPanel();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisTmm = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(14, 212);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(273, 21);
            this.cmbMenuler.TabIndex = 1;
            // 
            // rdKucuk
            // 
            this.rdKucuk.AutoSize = true;
            this.rdKucuk.Location = new System.Drawing.Point(6, 30);
            this.rdKucuk.Name = "rdKucuk";
            this.rdKucuk.Size = new System.Drawing.Size(96, 23);
            this.rdKucuk.TabIndex = 2;
            this.rdKucuk.TabStop = true;
            this.rdKucuk.Text = "Küçük Boy";
            this.rdKucuk.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(156, 30);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(86, 23);
            this.rdOrta.TabIndex = 3;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Orta Boy";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdBuyuk
            // 
            this.rdBuyuk.AutoSize = true;
            this.rdBuyuk.Location = new System.Drawing.Point(82, 51);
            this.rdBuyuk.Name = "rdBuyuk";
            this.rdBuyuk.Size = new System.Drawing.Size(96, 23);
            this.rdBuyuk.TabIndex = 4;
            this.rdBuyuk.TabStop = true;
            this.rdBuyuk.Text = "Büyük Boy";
            this.rdBuyuk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdKucuk);
            this.groupBox1.Controls.Add(this.rdBuyuk);
            this.groupBox1.Controls.Add(this.rdOrta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Malzeme Seçiniz";
            // 
            // flwEkstraMalzeme
            // 
            this.flwEkstraMalzeme.Location = new System.Drawing.Point(16, 344);
            this.flwEkstraMalzeme.Name = "flwEkstraMalzeme";
            this.flwEkstraMalzeme.Size = new System.Drawing.Size(271, 126);
            this.flwEkstraMalzeme.TabIndex = 8;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(84, 476);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 20);
            this.nmrAdet.TabIndex = 9;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adet";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.Location = new System.Drawing.Point(15, 519);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(271, 31);
            this.btnSiparisEkle.TabIndex = 11;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Menü Seçiniz";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(329, 28);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(384, 407);
            this.lstSiparisler.TabIndex = 13;
            // 
            // btnSiparisTmm
            // 
            this.btnSiparisTmm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSiparisTmm.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisTmm.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisTmm.Location = new System.Drawing.Point(512, 478);
            this.btnSiparisTmm.Name = "btnSiparisTmm";
            this.btnSiparisTmm.Size = new System.Drawing.Size(201, 51);
            this.btnSiparisTmm.TabIndex = 14;
            this.btnSiparisTmm.Text = "Siparişi Tamamla";
            this.btnSiparisTmm.UseVisualStyleBackColor = false;
            this.btnSiparisTmm.Click += new System.EventHandler(this.btnSiparisTmm_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(326, 462);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(99, 19);
            this.label.TabIndex = 15;
            this.label.Text = "Toplam Tutar";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(355, 497);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(17, 19);
            this.lblToplamTutar.TabIndex = 16;
            this.lblToplamTutar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(735, 556);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSiparisTmm);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.flwEkstraMalzeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.RadioButton rdKucuk;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.RadioButton rdBuyuk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flwEkstraMalzeme;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnSiparisTmm;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}