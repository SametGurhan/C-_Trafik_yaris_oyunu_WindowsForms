
namespace _145_Araba_Yaris
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yol = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.bizimaraba = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_oyunuBaslat = new System.Windows.Forms.Button();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.lbl_yuksekSkor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.carpma = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.bizimaraba);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.yol);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // yol
            // 
            this.yol.Image = global::_145_Araba_Yaris.Properties.Resources.yol;
            this.yol.Location = new System.Drawing.Point(-7, -1);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(513, 775);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::_145_Araba_Yaris.Properties.Resources.araba4;
            this.araba1.Location = new System.Drawing.Point(78, 87);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(69, 134);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 1;
            this.araba1.TabStop = false;
            // 
            // bizimaraba
            // 
            this.bizimaraba.Image = global::_145_Araba_Yaris.Properties.Resources.araba5;
            this.bizimaraba.Location = new System.Drawing.Point(225, 321);
            this.bizimaraba.Name = "bizimaraba";
            this.bizimaraba.Size = new System.Drawing.Size(69, 134);
            this.bizimaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizimaraba.TabIndex = 1;
            this.bizimaraba.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = global::_145_Araba_Yaris.Properties.Resources.araba8;
            this.araba2.Location = new System.Drawing.Point(348, 137);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(69, 134);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 1;
            this.araba2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(374, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yüksek Skor :";
            // 
            // btn_oyunuBaslat
            // 
            this.btn_oyunuBaslat.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyunuBaslat.Location = new System.Drawing.Point(13, 623);
            this.btn_oyunuBaslat.Name = "btn_oyunuBaslat";
            this.btn_oyunuBaslat.Size = new System.Drawing.Size(507, 50);
            this.btn_oyunuBaslat.TabIndex = 2;
            this.btn_oyunuBaslat.Text = "Oyunu Başlat";
            this.btn_oyunuBaslat.UseVisualStyleBackColor = true;
            this.btn_oyunuBaslat.Click += new System.EventHandler(this.btn_oyunuBaslat_Click);
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.Location = new System.Drawing.Point(450, 565);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(21, 22);
            this.lbl_puan.TabIndex = 1;
            this.lbl_puan.Text = "0";
            // 
            // lbl_yuksekSkor
            // 
            this.lbl_yuksekSkor.AutoSize = true;
            this.lbl_yuksekSkor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yuksekSkor.Location = new System.Drawing.Point(166, 565);
            this.lbl_yuksekSkor.Name = "lbl_yuksekSkor";
            this.lbl_yuksekSkor.Size = new System.Drawing.Size(21, 22);
            this.lbl_yuksekSkor.TabIndex = 1;
            this.lbl_yuksekSkor.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // carpma
            // 
            this.carpma.Image = global::_145_Araba_Yaris.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(266, 298);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(66, 37);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpma.TabIndex = 2;
            this.carpma.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 685);
            this.Controls.Add(this.btn_oyunuBaslat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_yuksekSkor);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı olan kazansın";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox bizimaraba;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_oyunuBaslat;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Label lbl_yuksekSkor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox carpma;
    }
}

