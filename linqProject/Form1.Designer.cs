namespace linqProject
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
            this.btnTumSayilar = new System.Windows.Forms.Button();
            this.lstbxResult = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNagatifler = new System.Windows.Forms.Button();
            this.btnPozitifSayilar = new System.Windows.Forms.Button();
            this.btnCift = new System.Windows.Forms.Button();
            this.btnTek = new System.Windows.Forms.Button();
            this.btnEnBuyuk = new System.Windows.Forms.Button();
            this.btnEnkucuk = new System.Windows.Forms.Button();
            this.btnKacTane = new System.Windows.Forms.Button();
            this.btnAdlar = new System.Windows.Forms.Button();
            this.btnTersAlfabe = new System.Windows.Forms.Button();
            this.btnAdUzunluk = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnTarih = new System.Windows.Forms.Button();
            this.btnTop5 = new System.Windows.Forms.Button();
            this.btnYang = new System.Windows.Forms.Button();
            this.btnSiparisSayisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTumSayilar
            // 
            this.btnTumSayilar.Location = new System.Drawing.Point(21, 12);
            this.btnTumSayilar.Name = "btnTumSayilar";
            this.btnTumSayilar.Size = new System.Drawing.Size(90, 49);
            this.btnTumSayilar.TabIndex = 0;
            this.btnTumSayilar.Text = "Tüm Sayılar";
            this.btnTumSayilar.UseVisualStyleBackColor = true;
            this.btnTumSayilar.Click += new System.EventHandler(this.btnTumSayilar_Click);
            // 
            // lstbxResult
            // 
            this.lstbxResult.FormattingEnabled = true;
            this.lstbxResult.ItemHeight = 16;
            this.lstbxResult.Location = new System.Drawing.Point(21, 244);
            this.lstbxResult.Name = "lstbxResult";
            this.lstbxResult.Size = new System.Drawing.Size(139, 180);
            this.lstbxResult.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 180);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnNagatifler
            // 
            this.btnNagatifler.Location = new System.Drawing.Point(138, 12);
            this.btnNagatifler.Name = "btnNagatifler";
            this.btnNagatifler.Size = new System.Drawing.Size(90, 49);
            this.btnNagatifler.TabIndex = 3;
            this.btnNagatifler.Text = "Negatif Sayilar";
            this.btnNagatifler.UseVisualStyleBackColor = true;
            this.btnNagatifler.Click += new System.EventHandler(this.btnNagatifler_Click);
            // 
            // btnPozitifSayilar
            // 
            this.btnPozitifSayilar.Location = new System.Drawing.Point(252, 12);
            this.btnPozitifSayilar.Name = "btnPozitifSayilar";
            this.btnPozitifSayilar.Size = new System.Drawing.Size(90, 49);
            this.btnPozitifSayilar.TabIndex = 4;
            this.btnPozitifSayilar.Text = "Pozitif Sayilar";
            this.btnPozitifSayilar.UseVisualStyleBackColor = true;
            this.btnPozitifSayilar.Click += new System.EventHandler(this.btnPozitifSayilar_Click);
            // 
            // btnCift
            // 
            this.btnCift.Location = new System.Drawing.Point(362, 12);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(90, 49);
            this.btnCift.TabIndex = 5;
            this.btnCift.Text = "Çift Sayılar";
            this.btnCift.UseVisualStyleBackColor = true;
            this.btnCift.Click += new System.EventHandler(this.btnCift_Click);
            // 
            // btnTek
            // 
            this.btnTek.Location = new System.Drawing.Point(476, 12);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(90, 49);
            this.btnTek.TabIndex = 6;
            this.btnTek.Text = "Tek Sayılar";
            this.btnTek.UseVisualStyleBackColor = true;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // btnEnBuyuk
            // 
            this.btnEnBuyuk.Location = new System.Drawing.Point(589, 12);
            this.btnEnBuyuk.Name = "btnEnBuyuk";
            this.btnEnBuyuk.Size = new System.Drawing.Size(90, 49);
            this.btnEnBuyuk.TabIndex = 7;
            this.btnEnBuyuk.Text = "En Büyük Sayı";
            this.btnEnBuyuk.UseVisualStyleBackColor = true;
            this.btnEnBuyuk.Click += new System.EventHandler(this.btnEnBuyuk_Click);
            // 
            // btnEnkucuk
            // 
            this.btnEnkucuk.Location = new System.Drawing.Point(698, 12);
            this.btnEnkucuk.Name = "btnEnkucuk";
            this.btnEnkucuk.Size = new System.Drawing.Size(90, 49);
            this.btnEnkucuk.TabIndex = 8;
            this.btnEnkucuk.Text = "En Küçük Sayı";
            this.btnEnkucuk.UseVisualStyleBackColor = true;
            this.btnEnkucuk.Click += new System.EventHandler(this.btnEnkucuk_Click);
            // 
            // btnKacTane
            // 
            this.btnKacTane.Location = new System.Drawing.Point(809, 12);
            this.btnKacTane.Name = "btnKacTane";
            this.btnKacTane.Size = new System.Drawing.Size(90, 49);
            this.btnKacTane.TabIndex = 9;
            this.btnKacTane.Text = "Kaç Tane";
            this.btnKacTane.UseVisualStyleBackColor = true;
            this.btnKacTane.Click += new System.EventHandler(this.btnKacTane_Click);
            // 
            // btnAdlar
            // 
            this.btnAdlar.Location = new System.Drawing.Point(21, 82);
            this.btnAdlar.Name = "btnAdlar";
            this.btnAdlar.Size = new System.Drawing.Size(90, 49);
            this.btnAdlar.TabIndex = 10;
            this.btnAdlar.Text = "İsimler Alfabetik";
            this.btnAdlar.UseVisualStyleBackColor = true;
            this.btnAdlar.Click += new System.EventHandler(this.btnAdlar_Click);
            // 
            // btnTersAlfabe
            // 
            this.btnTersAlfabe.Location = new System.Drawing.Point(138, 82);
            this.btnTersAlfabe.Name = "btnTersAlfabe";
            this.btnTersAlfabe.Size = new System.Drawing.Size(90, 49);
            this.btnTersAlfabe.TabIndex = 11;
            this.btnTersAlfabe.Text = "İsimler Ters Alfabetik";
            this.btnTersAlfabe.UseVisualStyleBackColor = true;
            this.btnTersAlfabe.Click += new System.EventHandler(this.btnTersAlfabe_Click);
            // 
            // btnAdUzunluk
            // 
            this.btnAdUzunluk.Location = new System.Drawing.Point(252, 82);
            this.btnAdUzunluk.Name = "btnAdUzunluk";
            this.btnAdUzunluk.Size = new System.Drawing.Size(90, 49);
            this.btnAdUzunluk.TabIndex = 12;
            this.btnAdUzunluk.Text = "İsimlerin Uzunlukları";
            this.btnAdUzunluk.UseVisualStyleBackColor = true;
            this.btnAdUzunluk.Click += new System.EventHandler(this.btnAdUzunluk_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(362, 82);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(90, 49);
            this.btnN.TabIndex = 13;
            this.btnN.Text = "N barındıran";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(476, 82);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(90, 49);
            this.btnE.TabIndex = 14;
            this.btnE.Text = "E ile Başlayan";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(21, 159);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(90, 49);
            this.btnSiparis.TabIndex = 15;
            this.btnSiparis.Text = "Tüm Siparişleri Getir";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnTarih
            // 
            this.btnTarih.Location = new System.Drawing.Point(129, 154);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(99, 58);
            this.btnTarih.TabIndex = 16;
            this.btnTarih.Text = "Siparişlerin Tarihlerini Getir";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // btnTop5
            // 
            this.btnTop5.Location = new System.Drawing.Point(252, 159);
            this.btnTop5.Name = "btnTop5";
            this.btnTop5.Size = new System.Drawing.Size(90, 49);
            this.btnTop5.TabIndex = 17;
            this.btnTop5.Text = "5 tane Sipariş Getir";
            this.btnTop5.UseVisualStyleBackColor = true;
            this.btnTop5.Click += new System.EventHandler(this.btnTop5_Click);
            // 
            // btnYang
            // 
            this.btnYang.Location = new System.Drawing.Point(362, 159);
            this.btnYang.Name = "btnYang";
            this.btnYang.Size = new System.Drawing.Size(90, 49);
            this.btnYang.TabIndex = 18;
            this.btnYang.Text = "Yang Wang";
            this.btnYang.UseVisualStyleBackColor = true;
            this.btnYang.Click += new System.EventHandler(this.btnYang_Click);
            // 
            // btnSiparisSayisi
            // 
            this.btnSiparisSayisi.Location = new System.Drawing.Point(476, 159);
            this.btnSiparisSayisi.Name = "btnSiparisSayisi";
            this.btnSiparisSayisi.Size = new System.Drawing.Size(90, 49);
            this.btnSiparisSayisi.TabIndex = 19;
            this.btnSiparisSayisi.Text = "Sipariş Sayısı";
            this.btnSiparisSayisi.UseVisualStyleBackColor = true;
            this.btnSiparisSayisi.Click += new System.EventHandler(this.btnSiparisSayisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.btnSiparisSayisi);
            this.Controls.Add(this.btnYang);
            this.Controls.Add(this.btnTop5);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnAdUzunluk);
            this.Controls.Add(this.btnTersAlfabe);
            this.Controls.Add(this.btnAdlar);
            this.Controls.Add(this.btnKacTane);
            this.Controls.Add(this.btnEnkucuk);
            this.Controls.Add(this.btnEnBuyuk);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnPozitifSayilar);
            this.Controls.Add(this.btnNagatifler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstbxResult);
            this.Controls.Add(this.btnTumSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTumSayilar;
        private System.Windows.Forms.ListBox lstbxResult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNagatifler;
        private System.Windows.Forms.Button btnPozitifSayilar;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.Button btnEnBuyuk;
        private System.Windows.Forms.Button btnEnkucuk;
        private System.Windows.Forms.Button btnKacTane;
        private System.Windows.Forms.Button btnAdlar;
        private System.Windows.Forms.Button btnTersAlfabe;
        private System.Windows.Forms.Button btnAdUzunluk;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Button btnTop5;
        private System.Windows.Forms.Button btnYang;
        private System.Windows.Forms.Button btnSiparisSayisi;
    }
}

