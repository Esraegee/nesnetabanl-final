
namespace YemekTarifleriMyspl
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYemekAdi = new System.Windows.Forms.TextBox();
            this.rtxtMalzemeler = new System.Windows.Forms.RichTextBox();
            this.rtxtTarif = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(50, 39);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(64, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Yemek Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Malzemeler :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarif :";
            // 
            // txtYemekAdi
            // 
            this.txtYemekAdi.Location = new System.Drawing.Point(120, 36);
            this.txtYemekAdi.Name = "txtYemekAdi";
            this.txtYemekAdi.Size = new System.Drawing.Size(215, 20);
            this.txtYemekAdi.TabIndex = 1;
            // 
            // rtxtMalzemeler
            // 
            this.rtxtMalzemeler.Location = new System.Drawing.Point(120, 63);
            this.rtxtMalzemeler.Name = "rtxtMalzemeler";
            this.rtxtMalzemeler.Size = new System.Drawing.Size(215, 47);
            this.rtxtMalzemeler.TabIndex = 2;
            this.rtxtMalzemeler.Text = "";
            // 
            // rtxtTarif
            // 
            this.rtxtTarif.Location = new System.Drawing.Point(121, 120);
            this.rtxtTarif.Name = "rtxtTarif";
            this.rtxtTarif.Size = new System.Drawing.Size(214, 130);
            this.rtxtTarif.TabIndex = 3;
            this.rtxtTarif.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(250, 266);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 38);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rtxtTarif);
            this.Controls.Add(this.rtxtMalzemeler);
            this.Controls.Add(this.txtYemekAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Yemek Tarifleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYemekAdi;
        private System.Windows.Forms.RichTextBox rtxtMalzemeler;
        private System.Windows.Forms.RichTextBox rtxtTarif;
        private System.Windows.Forms.Button btnKaydet;
    }
}

