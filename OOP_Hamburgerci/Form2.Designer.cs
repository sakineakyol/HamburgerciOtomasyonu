
namespace OOP_Hamburgerci
{
    partial class Form2
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
            this.grpMenuBilgileri = new System.Windows.Forms.GroupBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuBilgileri
            // 
            this.grpMenuBilgileri.Controls.Add(this.btnMenuEkle);
            this.grpMenuBilgileri.Controls.Add(this.nmrMenuFiyati);
            this.grpMenuBilgileri.Controls.Add(this.txtMenu);
            this.grpMenuBilgileri.Controls.Add(this.label2);
            this.grpMenuBilgileri.Controls.Add(this.label1);
            this.grpMenuBilgileri.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMenuBilgileri.Location = new System.Drawing.Point(12, 22);
            this.grpMenuBilgileri.Name = "grpMenuBilgileri";
            this.grpMenuBilgileri.Size = new System.Drawing.Size(340, 182);
            this.grpMenuBilgileri.TabIndex = 0;
            this.grpMenuBilgileri.TabStop = false;
            this.grpMenuBilgileri.Text = "Menü Bilgileri";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMenuEkle.Location = new System.Drawing.Point(136, 127);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(163, 31);
            this.btnMenuEkle.TabIndex = 4;
            this.btnMenuEkle.Text = "Menü Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = false;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.Location = new System.Drawing.Point(136, 87);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(163, 25);
            this.nmrMenuFiyati.TabIndex = 3;
            this.nmrMenuFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrMenuFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(136, 43);
            this.txtMenu.Multiline = true;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(163, 20);
            this.txtMenu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(364, 228);
            this.Controls.Add(this.grpMenuBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.grpMenuBilgileri.ResumeLayout(false);
            this.grpMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuBilgileri;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.NumericUpDown nmrMenuFiyati;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}