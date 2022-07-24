namespace Cafe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_stm = new System.Windows.Forms.Button();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_espsseksi = new System.Windows.Forms.Button();
            this.btn_espssarti = new System.Windows.Forms.Button();
            this.lbl_latte = new System.Windows.Forms.Label();
            this.lbl_esprss = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_latteeksi = new System.Windows.Forms.Button();
            this.btn_amceksi = new System.Windows.Forms.Button();
            this.btn_lattearti = new System.Windows.Forms.Button();
            this.btn_amcarti = new System.Windows.Forms.Button();
            this.lbl_amrcn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_stm);
            this.groupBox1.Controls.Add(this.lbl_fiyat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_espsseksi);
            this.groupBox1.Controls.Add(this.btn_espssarti);
            this.groupBox1.Controls.Add(this.lbl_latte);
            this.groupBox1.Controls.Add(this.lbl_esprss);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_latteeksi);
            this.groupBox1.Controls.Add(this.btn_amceksi);
            this.groupBox1.Controls.Add(this.btn_lattearti);
            this.groupBox1.Controls.Add(this.btn_amcarti);
            this.groupBox1.Controls.Add(this.lbl_amrcn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(163, 130);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(72, 39);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "Çıkış";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(6, 130);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(72, 39);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Sıfırla";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_stm
            // 
            this.btn_stm.Location = new System.Drawing.Point(85, 130);
            this.btn_stm.Name = "btn_stm";
            this.btn_stm.Size = new System.Drawing.Size(72, 39);
            this.btn_stm.TabIndex = 14;
            this.btn_stm.Text = "Siparişi Tamamla";
            this.btn_stm.UseVisualStyleBackColor = true;
            this.btn_stm.Click += new System.EventHandler(this.btn_stm_Click);
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Location = new System.Drawing.Point(299, 130);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(13, 13);
            this.lbl_fiyat.TabIndex = 13;
            this.lbl_fiyat.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fiyat :";
            // 
            // btn_espsseksi
            // 
            this.btn_espsseksi.Location = new System.Drawing.Point(172, 90);
            this.btn_espsseksi.Name = "btn_espsseksi";
            this.btn_espsseksi.Size = new System.Drawing.Size(28, 23);
            this.btn_espsseksi.TabIndex = 11;
            this.btn_espsseksi.Text = "-";
            this.btn_espsseksi.UseVisualStyleBackColor = true;
            this.btn_espsseksi.Click += new System.EventHandler(this.btn_espsseksi_Click);
            // 
            // btn_espssarti
            // 
            this.btn_espssarti.Location = new System.Drawing.Point(128, 90);
            this.btn_espssarti.Name = "btn_espssarti";
            this.btn_espssarti.Size = new System.Drawing.Size(28, 23);
            this.btn_espssarti.TabIndex = 10;
            this.btn_espssarti.Text = "+";
            this.btn_espssarti.UseVisualStyleBackColor = true;
            this.btn_espssarti.Click += new System.EventHandler(this.btn_espssarti_Click);
            // 
            // lbl_latte
            // 
            this.lbl_latte.AutoSize = true;
            this.lbl_latte.Location = new System.Drawing.Point(93, 63);
            this.lbl_latte.Name = "lbl_latte";
            this.lbl_latte.Size = new System.Drawing.Size(13, 13);
            this.lbl_latte.TabIndex = 9;
            this.lbl_latte.Text = "0";
            // 
            // lbl_esprss
            // 
            this.lbl_esprss.AutoSize = true;
            this.lbl_esprss.Location = new System.Drawing.Point(93, 100);
            this.lbl_esprss.Name = "lbl_esprss";
            this.lbl_esprss.Size = new System.Drawing.Size(13, 13);
            this.lbl_esprss.TabIndex = 8;
            this.lbl_esprss.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Espersso 20₺";
            // 
            // btn_latteeksi
            // 
            this.btn_latteeksi.Location = new System.Drawing.Point(172, 53);
            this.btn_latteeksi.Name = "btn_latteeksi";
            this.btn_latteeksi.Size = new System.Drawing.Size(28, 23);
            this.btn_latteeksi.TabIndex = 6;
            this.btn_latteeksi.Text = "-";
            this.btn_latteeksi.UseVisualStyleBackColor = true;
            this.btn_latteeksi.Click += new System.EventHandler(this.btn_latteeksi_Click);
            // 
            // btn_amceksi
            // 
            this.btn_amceksi.Location = new System.Drawing.Point(172, 21);
            this.btn_amceksi.Name = "btn_amceksi";
            this.btn_amceksi.Size = new System.Drawing.Size(28, 23);
            this.btn_amceksi.TabIndex = 5;
            this.btn_amceksi.Text = "-";
            this.btn_amceksi.UseVisualStyleBackColor = true;
            this.btn_amceksi.Click += new System.EventHandler(this.btn_amceksi_Click);
            // 
            // btn_lattearti
            // 
            this.btn_lattearti.Location = new System.Drawing.Point(128, 53);
            this.btn_lattearti.Name = "btn_lattearti";
            this.btn_lattearti.Size = new System.Drawing.Size(28, 23);
            this.btn_lattearti.TabIndex = 4;
            this.btn_lattearti.Text = "+";
            this.btn_lattearti.UseVisualStyleBackColor = true;
            this.btn_lattearti.Click += new System.EventHandler(this.btn_lattearti_Click);
            // 
            // btn_amcarti
            // 
            this.btn_amcarti.Location = new System.Drawing.Point(128, 21);
            this.btn_amcarti.Name = "btn_amcarti";
            this.btn_amcarti.Size = new System.Drawing.Size(28, 23);
            this.btn_amcarti.TabIndex = 3;
            this.btn_amcarti.Text = "+";
            this.btn_amcarti.UseVisualStyleBackColor = true;
            this.btn_amcarti.Click += new System.EventHandler(this.btn_amcarti_Click);
            // 
            // lbl_amrcn
            // 
            this.lbl_amrcn.AutoSize = true;
            this.lbl_amrcn.Location = new System.Drawing.Point(93, 31);
            this.lbl_amrcn.Name = "lbl_amrcn";
            this.lbl_amrcn.Size = new System.Drawing.Size(13, 13);
            this.lbl_amrcn.TabIndex = 2;
            this.lbl_amrcn.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latte 24₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Americano 28 ₺";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 265);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_stm;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_espsseksi;
        private System.Windows.Forms.Button btn_espssarti;
        private System.Windows.Forms.Label lbl_latte;
        private System.Windows.Forms.Label lbl_esprss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_latteeksi;
        private System.Windows.Forms.Button btn_amceksi;
        private System.Windows.Forms.Button btn_lattearti;
        private System.Windows.Forms.Button btn_amcarti;
        private System.Windows.Forms.Label lbl_amrcn;
        private System.Windows.Forms.Label label2;
    }
}

