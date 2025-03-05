namespace Universite_Projesi
{
    partial class FrmSinavNotlar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgreciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.cmbDersAd = new System.Windows.Forms.ComboBox();
            this.txtProje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblKontrol);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 154);
            this.panel1.TabIndex = 0;
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Location = new System.Drawing.Point(69, 44);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(68, 37);
            this.lblKontrol.TabIndex = 2;
            this.lblKontrol.Text = "Null";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 18);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 61.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(849, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Kontrol Paneli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 53);
            this.label3.TabIndex = 3;
            this.label3.Text = "Öğrenci Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label4.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 53);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ders Ad:";
            // 
            // txtOgreciAd
            // 
            this.txtOgreciAd.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgreciAd.Location = new System.Drawing.Point(237, 207);
            this.txtOgreciAd.Name = "txtOgreciAd";
            this.txtOgreciAd.Size = new System.Drawing.Size(196, 53);
            this.txtOgreciAd.TabIndex = 5;
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Enabled = false;
            this.txtOgrenciId.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrenciId.Location = new System.Drawing.Point(237, 276);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(196, 53);
            this.txtOgrenciId.TabIndex = 6;
            // 
            // cmbDersAd
            // 
            this.cmbDersAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersAd.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDersAd.FormattingEnabled = true;
            this.cmbDersAd.Location = new System.Drawing.Point(237, 342);
            this.cmbDersAd.Name = "cmbDersAd";
            this.cmbDersAd.Size = new System.Drawing.Size(196, 53);
            this.cmbDersAd.TabIndex = 7;
            // 
            // txtProje
            // 
            this.txtProje.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProje.Location = new System.Drawing.Point(664, 342);
            this.txtProje.Name = "txtProje";
            this.txtProje.Size = new System.Drawing.Size(97, 53);
            this.txtProje.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label5.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 53);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proje:";
            // 
            // txtDurum
            // 
            this.txtDurum.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDurum.Location = new System.Drawing.Point(237, 410);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(196, 53);
            this.txtDurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label6.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 53);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum:";
            // 
            // txtSinav1
            // 
            this.txtSinav1.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinav1.Location = new System.Drawing.Point(664, 204);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(97, 53);
            this.txtSinav1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label7.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 53);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sınav 1:";
            // 
            // txtSinav2
            // 
            this.txtSinav2.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinav2.Location = new System.Drawing.Point(664, 273);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(97, 53);
            this.txtSinav2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label8.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 53);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sınav 2:";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrtalama.Location = new System.Drawing.Point(664, 410);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(97, 53);
            this.txtOrtalama.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label9.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 53);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ortalama:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.btnHesapla.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(831, 207);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(176, 66);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(831, 292);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(176, 66);
            this.btnGuncelle.TabIndex = 19;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.button3.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(831, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 66);
            this.button3.TabIndex = 20;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(69, 87);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 37);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // FrmSinavNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1061, 727);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSinav2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSinav1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDersAd);
            this.Controls.Add(this.txtOgrenciId);
            this.Controls.Add(this.txtOgreciAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "FrmSinavNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Kontrol Paneli";
            this.Load += new System.EventHandler(this.FrmSinavNotlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgreciAd;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.ComboBox cmbDersAd;
        private System.Windows.Forms.TextBox txtProje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblKontrol;
        private System.Windows.Forms.Label lblId;
    }
}