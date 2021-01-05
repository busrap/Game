using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class oyun : Form
    {
        public oyun()
        {
            InitializeComponent();
        }
        string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Adana", "Adıyaman",
                    "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Antalya",
                    "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman",
                    "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur",
                    "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli",
                    "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan",
                    "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                    "Hakkari", "Hatay", "Iğdır", "Isparta", "Kahramanmaraş",
                    "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri",
                    "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli",
                    "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin",
                    "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize",
                    "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şırnak",
                    "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
                    "Van", "Yalova", "Yozgat", "Zonguldak"};
        int sayi;
        int tamamiBilindi = 0;
        int kalanHakSayisi = 4;
        private void oyun_Load(object sender, EventArgs e)
        {
            btn_kelime_tahmin.Enabled = false;
            btn_HarfGir.Enabled = false;
            btn_yeni_oyun.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e) // OYUN BAŞLAT
        {
            btn_kelime_tahmin.Enabled = true;
            btn_HarfGir.Enabled = true;
            btn_OyunBaslat.Enabled = false;

            Random rnd = new Random();

            int b = 5;

            sayi = rnd.Next(0, sehirler.Length);
            foreach (char w in sehirler[sayi])
            {

                Label lbl = new Label();
                lbl.Text = w.ToString();
                lbl.Top = 35;
                lbl.Left = b * 20;
                lbl.Width = 40;
                lbl.Height = 30;
                lbl.BackColor = Color.HotPink;
                lbl.ForeColor = Color.HotPink;
                lbl.Font = new Font("Custom", 13, FontStyle.Bold);
                grpBox_control.Controls.Add(lbl);
                b += 3;
            }

        }


        private void button2_Click(object sender, EventArgs e) // HARF GİR
        {




            if (txt_Tahmin.Text.Length != 1)
            {
                MessageBox.Show("UYARI: Lütfen bir harf girişi yapınız!");
                txt_Tahmin.Text = "";
                return;

            }
            else if (lbl_dahaOnceGirilen_harf.Text.Contains(txt_Tahmin.Text))
            {
                MessageBox.Show("UYARI:Aynı harfi daha önce denedin!");
                txt_Tahmin.Text = "";
                txt_Tahmin.Focus();
                kalanHakSayisi--;
                lbl_kalan_hak.Text = kalanHakSayisi.ToString();
                if (kalanHakSayisi <= 0)
                {

                    lbl_kalan_hak.Text = "Hak saysı bitti! Kaybettiniz!";

                    btn_HarfGir.Visible = false;
                    btn_kelime_tahmin.Visible = false;
                    btn_yeni_oyun.Enabled = true;
                }
            }

            lbl_dahaOnceGirilen_harf.Text += txt_Tahmin.Text + " ";


            bool arti = false;
            foreach (Control tool in grpBox_control.Controls)
            {
                if (tool is Label)
                {
                    Label label = tool as Label;
                    if (txt_Tahmin.Text.ToUpper() == label.Text.ToUpper())
                    {
                        label.BackColor = Color.Yellow;
                        label.ForeColor = Color.Black;
                        arti = true;
                        tamamiBilindi++;
                    }
                    if (tamamiBilindi == sehirler[sayi].Length)
                    {
                        MessageBox.Show("Tüm harfleri doğru tahmin ettin ve kazandın!");
                        btn_kelime_tahmin.Enabled = false;
                        btn_HarfGir.Enabled = false;
                        btn_OyunBaslat.Enabled = false;
                        btn_yeni_oyun.Enabled = true;
                        tamamiBilindi = 0;
                    }
                  
                }

            }
            if (arti == false)
            {
                kalanHakSayisi--;
                lbl_kalan_hak.Text = kalanHakSayisi.ToString();
                if (kalanHakSayisi<=0)
                {
                    lbl_kalan_hak.ForeColor = Color.Red;
                    lbl_kalan_hak.Text = "Ha ha ha Kaybettin !";
                    btn_HarfGir.Visible = false;
                    btn_kelime_tahmin.Visible = false;
                    btn_yeni_oyun.Enabled = true;

                }
            }


            txt_Tahmin.Text = "";
        }

        private void btn_yeni_oyun_Click(object sender, EventArgs e)
        {
            grpBox_control.Controls.Clear();
            btn_HarfGir.Visible = true;
            kalanHakSayisi = 4;
            lbl_kalan_hak.Text = "4";
            btn_kelime_tahmin.Visible = true;
            btn_OyunBaslat.Enabled = true;
            txt_Tahmin.Text = "";
            lbl_dahaOnceGirilen_harf.Text = "";
            txt_Tahmin.Focus();
            btn_yeni_oyun.Enabled = false;
            btn_kelime_tahmin.Enabled = false;
            btn_HarfGir.Enabled = false;
            btn_yeni_oyun.Enabled = false;

        }


        private void btn_kelime_tahmin_Click(object sender, EventArgs e)
        {
            if (txt_kelime_tahmin.Text.ToUpper() == sehirler[sayi].ToUpper())
            {
                MessageBox.Show("Tebrikler zınk diye bildin!");
               
                txt_Tahmin.Text = "";
                txt_kelime_tahmin.Text = "";
                btn_kelime_tahmin.Enabled = false;
                btn_HarfGir.Enabled = false;
                btn_OyunBaslat.Enabled = false;
                btn_yeni_oyun.Enabled = true;
                lbl_kalan_hak.Text = "";
                txt_Tahmin.Focus();
                lbl_kalan_hak.Text = "Tebrikler nokta atışı yaptın ve kazandın!";
            }
            else
            {
                MessageBox.Show("Kötü haber, bilemedin ve kaybettin!");
                
                txt_kelime_tahmin.Text = "";
                txt_Tahmin.Text = "";
                lbl_kalan_hak.Text = "";
                btn_kelime_tahmin.Enabled = false;
                btn_HarfGir.Enabled = false;
                btn_OyunBaslat.Enabled = false;
                btn_yeni_oyun.Enabled = true;

            }
        }



    }
}
