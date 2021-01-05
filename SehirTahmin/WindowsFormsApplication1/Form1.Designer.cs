namespace WindowsFormsApplication1
{
    partial class oyun
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
            this.btn_OyunBaslat = new System.Windows.Forms.Button();
            this.txt_Tahmin = new System.Windows.Forms.TextBox();
            this.btn_HarfGir = new System.Windows.Forms.Button();
            this.grpBox_control = new System.Windows.Forms.GroupBox();
            this.btn_yeni_oyun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dahaOnceGirilen_harf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kelime_tahmin = new System.Windows.Forms.Button();
            this.txt_kelime_tahmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_kalan_hak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OyunBaslat
            // 
            this.btn_OyunBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OyunBaslat.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_OyunBaslat.Location = new System.Drawing.Point(264, 344);
            this.btn_OyunBaslat.Name = "btn_OyunBaslat";
            this.btn_OyunBaslat.Size = new System.Drawing.Size(175, 38);
            this.btn_OyunBaslat.TabIndex = 0;
            this.btn_OyunBaslat.Text = "OYUN BAŞLASIN !";
            this.btn_OyunBaslat.UseVisualStyleBackColor = true;
            this.btn_OyunBaslat.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Tahmin
            // 
            this.txt_Tahmin.Location = new System.Drawing.Point(214, 39);
            this.txt_Tahmin.Multiline = true;
            this.txt_Tahmin.Name = "txt_Tahmin";
            this.txt_Tahmin.Size = new System.Drawing.Size(203, 23);
            this.txt_Tahmin.TabIndex = 2;
            // 
            // btn_HarfGir
            // 
            this.btn_HarfGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HarfGir.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_HarfGir.Location = new System.Drawing.Point(214, 65);
            this.btn_HarfGir.Name = "btn_HarfGir";
            this.btn_HarfGir.Size = new System.Drawing.Size(203, 38);
            this.btn_HarfGir.TabIndex = 3;
            this.btn_HarfGir.Text = "Harf gir";
            this.btn_HarfGir.UseVisualStyleBackColor = true;
            this.btn_HarfGir.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpBox_control
            // 
            this.grpBox_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBox_control.Location = new System.Drawing.Point(53, 182);
            this.grpBox_control.Name = "grpBox_control";
            this.grpBox_control.Size = new System.Drawing.Size(1253, 140);
            this.grpBox_control.TabIndex = 4;
            this.grpBox_control.TabStop = false;
            this.grpBox_control.Text = "GİZLENEN ŞEHRİ TAHMİN EDİNİZ";
            // 
            // btn_yeni_oyun
            // 
            this.btn_yeni_oyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni_oyun.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_yeni_oyun.Location = new System.Drawing.Point(53, 344);
            this.btn_yeni_oyun.Name = "btn_yeni_oyun";
            this.btn_yeni_oyun.Size = new System.Drawing.Size(188, 38);
            this.btn_yeni_oyun.TabIndex = 5;
            this.btn_yeni_oyun.Text = "YENİ OYUN";
            this.btn_yeni_oyun.UseVisualStyleBackColor = true;
            this.btn_yeni_oyun.Click += new System.EventHandler(this.btn_yeni_oyun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(713, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Daha önce kullanılan harfler =>\r\n";
            // 
            // lbl_dahaOnceGirilen_harf
            // 
            this.lbl_dahaOnceGirilen_harf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dahaOnceGirilen_harf.Location = new System.Drawing.Point(969, 31);
            this.lbl_dahaOnceGirilen_harf.Name = "lbl_dahaOnceGirilen_harf";
            this.lbl_dahaOnceGirilen_harf.Size = new System.Drawing.Size(210, 148);
            this.lbl_dahaOnceGirilen_harf.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(84, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bir harf giriniz :";
            // 
            // btn_kelime_tahmin
            // 
            this.btn_kelime_tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kelime_tahmin.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_kelime_tahmin.Location = new System.Drawing.Point(437, 65);
            this.btn_kelime_tahmin.Name = "btn_kelime_tahmin";
            this.btn_kelime_tahmin.Size = new System.Drawing.Size(199, 38);
            this.btn_kelime_tahmin.TabIndex = 9;
            this.btn_kelime_tahmin.Text = "Kelimeyi tahmin et";
            this.btn_kelime_tahmin.UseVisualStyleBackColor = true;
            this.btn_kelime_tahmin.Click += new System.EventHandler(this.btn_kelime_tahmin_Click);
            // 
            // txt_kelime_tahmin
            // 
            this.txt_kelime_tahmin.Location = new System.Drawing.Point(437, 39);
            this.txt_kelime_tahmin.Multiline = true;
            this.txt_kelime_tahmin.Name = "txt_kelime_tahmin";
            this.txt_kelime_tahmin.Size = new System.Drawing.Size(199, 23);
            this.txt_kelime_tahmin.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(260, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "KALAN HAK SAYISI :";
            // 
            // lbl_kalan_hak
            // 
            this.lbl_kalan_hak.AutoSize = true;
            this.lbl_kalan_hak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kalan_hak.Location = new System.Drawing.Point(487, 122);
            this.lbl_kalan_hak.Name = "lbl_kalan_hak";
            this.lbl_kalan_hak.Size = new System.Drawing.Size(30, 31);
            this.lbl_kalan_hak.TabIndex = 12;
            this.lbl_kalan_hak.Text = "4";
            // 
            // oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1341, 396);
            this.Controls.Add(this.lbl_kalan_hak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kelime_tahmin);
            this.Controls.Add(this.btn_kelime_tahmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_dahaOnceGirilen_harf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_yeni_oyun);
            this.Controls.Add(this.grpBox_control);
            this.Controls.Add(this.btn_HarfGir);
            this.Controls.Add(this.txt_Tahmin);
            this.Controls.Add(this.btn_OyunBaslat);
            this.Name = "oyun";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.oyun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OyunBaslat;
        private System.Windows.Forms.TextBox txt_Tahmin;
        private System.Windows.Forms.Button btn_HarfGir;
        private System.Windows.Forms.GroupBox grpBox_control;
        private System.Windows.Forms.Button btn_yeni_oyun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dahaOnceGirilen_harf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kelime_tahmin;
        private System.Windows.Forms.TextBox txt_kelime_tahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_kalan_hak;
    }
}

