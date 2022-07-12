
namespace OOP_Hamburgerci
{
    partial class Form3
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
            this.btnEkstraMalzemeEkle = new System.Windows.Forms.Button();
            this.grpMalzemeBilgileri = new System.Windows.Forms.GroupBox();
            this.nmrEMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtExtraMalzemeBil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkstraMalzemeEkle
            // 
            this.btnEkstraMalzemeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEkstraMalzemeEkle.Location = new System.Drawing.Point(136, 127);
            this.btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            this.btnEkstraMalzemeEkle.Size = new System.Drawing.Size(163, 31);
            this.btnEkstraMalzemeEkle.TabIndex = 4;
            this.btnEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.btnEkstraMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnEkstraMalzemeEkle.Click += new System.EventHandler(this.btnEkstraMalzemeEkle_Click);
            // 
            // grpMalzemeBilgileri
            // 
            this.grpMalzemeBilgileri.Controls.Add(this.btnEkstraMalzemeEkle);
            this.grpMalzemeBilgileri.Controls.Add(this.nmrEMenuFiyati);
            this.grpMalzemeBilgileri.Controls.Add(this.txtExtraMalzemeBil);
            this.grpMalzemeBilgileri.Controls.Add(this.label2);
            this.grpMalzemeBilgileri.Controls.Add(this.label1);
            this.grpMalzemeBilgileri.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMalzemeBilgileri.Location = new System.Drawing.Point(12, 24);
            this.grpMalzemeBilgileri.Name = "grpMalzemeBilgileri";
            this.grpMalzemeBilgileri.Size = new System.Drawing.Size(340, 182);
            this.grpMalzemeBilgileri.TabIndex = 1;
            this.grpMalzemeBilgileri.TabStop = false;
            this.grpMalzemeBilgileri.Text = "Malzeme Bilgileri";
            // 
            // nmrEMenuFiyati
            // 
            this.nmrEMenuFiyati.Location = new System.Drawing.Point(136, 87);
            this.nmrEMenuFiyati.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrEMenuFiyati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrEMenuFiyati.Name = "nmrEMenuFiyati";
            this.nmrEMenuFiyati.Size = new System.Drawing.Size(163, 25);
            this.nmrEMenuFiyati.TabIndex = 3;
            this.nmrEMenuFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrEMenuFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtExtraMalzemeBil
            // 
            this.txtExtraMalzemeBil.Location = new System.Drawing.Point(136, 43);
            this.txtExtraMalzemeBil.Multiline = true;
            this.txtExtraMalzemeBil.Name = "txtExtraMalzemeBil";
            this.txtExtraMalzemeBil.Size = new System.Drawing.Size(163, 20);
            this.txtExtraMalzemeBil.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(372, 227);
            this.Controls.Add(this.grpMalzemeBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpMalzemeBilgileri.ResumeLayout(false);
            this.grpMalzemeBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkstraMalzemeEkle;
        private System.Windows.Forms.GroupBox grpMalzemeBilgileri;
        private System.Windows.Forms.NumericUpDown nmrEMenuFiyati;
        private System.Windows.Forms.TextBox txtExtraMalzemeBil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}