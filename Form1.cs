using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : Form
    {
        List<String> dersler = new List<string>() {"Proje Yönetimi",
            "Veri Tabanı Yönetim Sistemleri 1",
            "Grafik Animasyon 1",
            "Görsel Programlama 1 ",
            "Bilgisayar Donanımı",
            "İnternet Programlama 2",
            "Mobil Programlama",
            "Bilgisayarlı Veri Toplama Ve Kontrol",
            "Topluma Hizmet Uygulamaları",
            "Bitirme Projesi" };
        public Form1()
        {
            InitializeComponent();
            combo_doldur();


        }

        private void combo_doldur()
        {
            this.comboBox2.Items.AddRange(dersler.ToArray());
            this.comboBox1.Items.AddRange(dersler.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = Int32.Parse(this.textBox3.Text);
            int final = Int32.Parse(this.textBox4.Text);
            double ortalama = vize * 0.2 + final * 0.8;
            string durum = null;
            Color durumRenk = Color.Red;
            if (ortalama >=35)
            {
                durum = "Geçti";
                durumRenk = Color.Green;
            }
            else
            {
                durum = "Kaldı";
                durumRenk = Color.Red;
            }
      
            int satir_sayisi=this.dataGridView1.Rows.Add(this.textBox1.Text, this.textBox2.Text,
                this.comboBox2.SelectedItem.ToString(),this.textBox3.Text, this.textBox4.Text,ortalama,durum);
            this.dataGridView1.Rows[satir_sayisi].Cells[6].Style.BackColor = durumRenk;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<double> ortalamalar;
            if (this.comboBox1.SelectedItem != null)
            {
                int secili_ders_sayac=0;
                double secili_ders_toplam_ort = 0;
                double secili_ders_ort = 0;
                for(int i=0; i< this.dataGridView1.RowCount-1; i++)
                {
                    if(this.comboBox1.SelectedItem.ToString() == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac++;
                        string ort = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                        secili_ders_toplam_ort += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                    }
                }

                if (secili_ders_sayac > 0) 
                {
                    secili_ders_ort = secili_ders_toplam_ort / secili_ders_sayac;
                    this.dataGridView2.Rows.Add(comboBox1.SelectedItem.ToString(), secili_ders_ort);
                    
                }
                else
                {
                    // error seçili dersten 
                } 
            }
            else
            {
                int secili_ders_sayac1 = 0;
                int secili_ders_sayac2 = 0;
                int secili_ders_sayac3 = 0;
                int secili_ders_sayac4 = 0;
                int secili_ders_sayac5 = 0;
                int secili_ders_sayac6 = 0;
                int secili_ders_sayac7= 0;
                int secili_ders_sayac8 = 0;
                int secili_ders_sayac9 = 0;
                int secili_ders_sayac10 = 0;
                double secili_ders_toplam_ort1 = 0;
                double secili_ders_toplam_ort2 = 0;
                double secili_ders_toplam_ort3 = 0;
                double secili_ders_toplam_ort4 = 0;
                double secili_ders_toplam_ort5 = 0;
                double secili_ders_toplam_ort6 = 0;
                double secili_ders_toplam_ort7 = 0;
                double secili_ders_toplam_ort8 = 0;
                double secili_ders_toplam_ort9 = 0;
                double secili_ders_toplam_ort10 = 0;
                double secili_ders_ort1 = 0;
                double secili_ders_ort2 = 0;
                double secili_ders_ort3 = 0;
                double secili_ders_ort4 = 0;
                double secili_ders_ort5 = 0;
                double secili_ders_ort6= 0;
                double secili_ders_ort7 = 0;
                double secili_ders_ort8 = 0;
                double secili_ders_ort9 = 0;
                double secili_ders_ort10 = 0;
                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (dersler[0] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac1++;
                        
                         secili_ders_toplam_ort1 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[1] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac2++;
                         secili_ders_toplam_ort2 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[2] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac3++;
                         secili_ders_toplam_ort3 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[3] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac4++;
                         secili_ders_toplam_ort4 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[4] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac5++;
                         secili_ders_toplam_ort5 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[5] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac6++;
                         secili_ders_toplam_ort6 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[6] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac7++;
                         secili_ders_toplam_ort7 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[7] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac8++;
                         secili_ders_toplam_ort8 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[8] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac9++;
                         secili_ders_toplam_ort9 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                    if (dersler[9] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac10++;
                         secili_ders_toplam_ort10 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        
                    }
                }
                if (secili_ders_sayac1 > 0)
                {
                    secili_ders_ort1 = secili_ders_toplam_ort1 / secili_ders_sayac1;
                    this.dataGridView2.Rows.Add(dersler[0], secili_ders_ort1);
                }
                if (secili_ders_sayac2 > 0)
                {
                    secili_ders_ort2 = secili_ders_toplam_ort2 / secili_ders_sayac2;
                    this.dataGridView2.Rows.Add(dersler[1], secili_ders_ort2);
                }
                if (secili_ders_sayac3 > 0)
                {
                    secili_ders_ort3 = secili_ders_toplam_ort3 / secili_ders_sayac3;
                    this.dataGridView2.Rows.Add(dersler[2], secili_ders_ort3);
                }
                if (secili_ders_sayac4 > 0)
                {
                    secili_ders_ort4 = secili_ders_toplam_ort4 / secili_ders_sayac4;
                    this.dataGridView2.Rows.Add(dersler[3], secili_ders_ort4);
                }
                if (secili_ders_sayac5 > 0)
                {
                    secili_ders_ort5 = secili_ders_toplam_ort5 / secili_ders_sayac5;
                    this.dataGridView2.Rows.Add(dersler[4], secili_ders_ort5);
                }
                if (secili_ders_sayac6 > 0)
                {
                    secili_ders_ort6 = secili_ders_toplam_ort6 / secili_ders_sayac6;
                    this.dataGridView2.Rows.Add(dersler[5], secili_ders_ort6);
                }
                if (secili_ders_sayac7 > 0)
                {
                    secili_ders_ort7 = secili_ders_toplam_ort7 / secili_ders_sayac7;
                    this.dataGridView2.Rows.Add(dersler[6], secili_ders_ort7);
                }
                if (secili_ders_sayac8 > 0)
                {
                    secili_ders_ort8 = secili_ders_toplam_ort8 / secili_ders_sayac8;
                    this.dataGridView2.Rows.Add(dersler[7], secili_ders_ort8);
                }
                if (secili_ders_sayac9 > 0)
                {
                    secili_ders_ort9 = secili_ders_toplam_ort9 / secili_ders_sayac9;
                    this.dataGridView2.Rows.Add(dersler[8], secili_ders_ort9);
                }
                if (secili_ders_sayac10 > 0)
                {
                    secili_ders_ort10 = secili_ders_toplam_ort10 / secili_ders_sayac10;
                    this.dataGridView2.Rows.Add(dersler[9], secili_ders_ort10);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem != null)
            {
                
                double secili_en_buyuk_ort = -1;
                double secili_en_kucuk_ort = 101;
                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (this.comboBox1.SelectedItem.ToString() == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                       
                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort)
                        {
                            secili_en_buyuk_ort = ort;

                        }
                        if (ort < secili_en_kucuk_ort)
                        {
                            secili_en_kucuk_ort = ort;
                        }
                    }
                }

                if (secili_en_kucuk_ort < 101 && secili_en_buyuk_ort>-1)
                {
                    
                    this.dataGridView3.Rows.Add(comboBox1.SelectedItem.ToString(), secili_en_buyuk_ort,secili_en_kucuk_ort);

                }
                else
                {
                    // error seçili dersten 
                }
            }
            else
            {

                double secili_en_buyuk_ort1 = -1;
                double secili_en_buyuk_ort2 = -1;
                double secili_en_buyuk_ort3 = -1;
                double secili_en_buyuk_ort4 = -1;
                double secili_en_buyuk_ort5 = -1;
                double secili_en_buyuk_ort6 = -1;
                double secili_en_buyuk_ort7 = -1;
                double secili_en_buyuk_ort8 = -1;
                double secili_en_buyuk_ort9 = -1;
                double secili_en_buyuk_ort10 = -1;
                double secili_en_kucuk_ort1 = 101;
                double secili_en_kucuk_ort2 = 101;
                double secili_en_kucuk_ort3 = 101;
                double secili_en_kucuk_ort4 = 101;
                double secili_en_kucuk_ort5 = 101;
                double secili_en_kucuk_ort6 = 101;
                double secili_en_kucuk_ort7 = 101;
                double secili_en_kucuk_ort8 = 101;
                double secili_en_kucuk_ort9 = 101;
                double secili_en_kucuk_ort10 = 101;

                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (dersler[0] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort1)
                        {
                            secili_en_buyuk_ort1 = ort;

                        }
                        if (ort < secili_en_kucuk_ort1)
                        {
                            secili_en_kucuk_ort1 = ort;
                        }

                    }
                    if (dersler[1] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort2)
                        {
                            secili_en_buyuk_ort2 = ort;

                        }
                        if (ort < secili_en_kucuk_ort2)
                        {
                            secili_en_kucuk_ort2 = ort;
                        }

                    }
                    if (dersler[2] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort3)
                        {
                            secili_en_buyuk_ort3 = ort;

                        }
                        if (ort < secili_en_kucuk_ort3)
                        {
                            secili_en_kucuk_ort3 = ort;
                        }
                    }
                    if (dersler[3] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort4)
                        {
                            secili_en_buyuk_ort4 = ort;

                        }
                        if (ort < secili_en_kucuk_ort4)
                        {
                            secili_en_kucuk_ort4 = ort;
                        }
                    }
                    if (dersler[4] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort5)
                        {
                            secili_en_buyuk_ort5 = ort;

                        }
                        if (ort < secili_en_kucuk_ort5)
                        {
                            secili_en_kucuk_ort5 = ort;
                        }
                    }
                    if (dersler[5] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort6)
                        {
                            secili_en_buyuk_ort6 = ort;

                        }
                        if (ort < secili_en_kucuk_ort6)
                        {
                            secili_en_kucuk_ort6 = ort;
                        }

                    }
                    if (dersler[6] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort7)
                        {
                            secili_en_buyuk_ort7 = ort;

                        }
                        if (ort < secili_en_kucuk_ort7)
                        {
                            secili_en_kucuk_ort7 = ort;
                        }
                    }
                    if (dersler[7] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort8)
                        {
                            secili_en_buyuk_ort8 = ort;

                        }
                        if (ort < secili_en_kucuk_ort8)
                        {
                            secili_en_kucuk_ort8 = ort;
                        }
                    }
                    if (dersler[8] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort9)
                        {
                            secili_en_buyuk_ort9 = ort;

                        }
                        if (ort < secili_en_kucuk_ort9)
                        {
                            secili_en_kucuk_ort9 = ort;
                        }
                    }
                    if (dersler[9] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                        if (ort > secili_en_buyuk_ort10)
                        {
                            secili_en_buyuk_ort10 = ort;

                        }
                        if (ort < secili_en_kucuk_ort10)
                        {
                            secili_en_kucuk_ort10 = ort;
                        }
                    }
                }

                if (secili_en_kucuk_ort1 < 101 && secili_en_buyuk_ort1 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[0], secili_en_buyuk_ort1, secili_en_kucuk_ort1);

                }
                if (secili_en_kucuk_ort2 < 101 && secili_en_buyuk_ort2 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[1], secili_en_buyuk_ort2, secili_en_kucuk_ort2);

                }
                if (secili_en_kucuk_ort3 < 101 && secili_en_buyuk_ort3 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[2], secili_en_buyuk_ort3, secili_en_kucuk_ort3);

                }
                if (secili_en_kucuk_ort4 < 101 && secili_en_buyuk_ort4 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[3], secili_en_buyuk_ort4, secili_en_kucuk_ort4);

                }
                if (secili_en_kucuk_ort5 < 101 && secili_en_buyuk_ort5 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[4], secili_en_buyuk_ort5, secili_en_kucuk_ort5);

                }
                if (secili_en_kucuk_ort6 < 101 && secili_en_buyuk_ort6 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[5], secili_en_buyuk_ort6, secili_en_kucuk_ort6);

                }
                if (secili_en_kucuk_ort7 < 101 && secili_en_buyuk_ort7 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[6], secili_en_buyuk_ort7, secili_en_kucuk_ort7);

                }
                if (secili_en_kucuk_ort8 < 101 && secili_en_buyuk_ort8 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[7], secili_en_buyuk_ort8, secili_en_kucuk_ort8);

                }
                if (secili_en_kucuk_ort9 < 101 && secili_en_buyuk_ort9 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[8], secili_en_buyuk_ort9, secili_en_kucuk_ort9);

                }
                if (secili_en_kucuk_ort10 < 101 && secili_en_buyuk_ort10 > -1)
                {

                    this.dataGridView3.Rows.Add(dersler[9], secili_en_buyuk_ort10, secili_en_kucuk_ort10);

                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (this.comboBox1.SelectedItem != null)
            {

                int gecen_kisi_sayisi = 0;
                
                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (this.comboBox1.SelectedItem.ToString() == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti"==durum)
                        {
                            gecen_kisi_sayisi++;

                        }
                        
                    }
                }

                if (gecen_kisi_sayisi>0)
                {

                    this.dataGridView4.Rows.Add(comboBox1.SelectedItem.ToString(), gecen_kisi_sayisi);

                }
                else
                {
                    // error seçili dersten 
                }
            }
            else
            {

                int gecen_kisi_sayisi1 = 0;
                int gecen_kisi_sayisi2 = 0;
                int gecen_kisi_sayisi3 = 0;
                int gecen_kisi_sayisi4 = 0;
                int gecen_kisi_sayisi5 = 0;
                int gecen_kisi_sayisi6 = 0;
                int gecen_kisi_sayisi7 = 0;
                int gecen_kisi_sayisi8 = 0;
                int gecen_kisi_sayisi9 = 0;
                int gecen_kisi_sayisi10 = 0;
                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (dersler[0] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi1++;

                        }
                    }
                    if (dersler[1] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi2++;

                        }
                    }
                    if (dersler[2] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi3++;

                        }
                    }
                    if (dersler[3] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi4++;

                        }
                    }
                    if (dersler[4] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi5++;

                        }
                    }
                    if (dersler[5] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi6++;

                        }

                    }
                    if (dersler[6] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi7++;

                        }
                    }
                    if (dersler[7] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi8++;

                        }
                    }
                    if (dersler[8] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi9++;

                        }
                    }
                    if (dersler[9] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        string durum = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                        if ("Geçti" == durum)
                        {
                            gecen_kisi_sayisi10++;

                        }
                    }
                }

                if (gecen_kisi_sayisi1 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[0], gecen_kisi_sayisi1);

                }
                if (gecen_kisi_sayisi2 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[1], gecen_kisi_sayisi2);

                }
                if (gecen_kisi_sayisi3 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[2], gecen_kisi_sayisi3);

                }
                if (gecen_kisi_sayisi4 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[3], gecen_kisi_sayisi4);

                }
                if (gecen_kisi_sayisi5 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[4], gecen_kisi_sayisi5);

                }
                if (gecen_kisi_sayisi6 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[5], gecen_kisi_sayisi6);

                }
                if (gecen_kisi_sayisi7 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[6], gecen_kisi_sayisi7);

                }
                if (gecen_kisi_sayisi8 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[7], gecen_kisi_sayisi8);

                }
                if (gecen_kisi_sayisi9 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[8], gecen_kisi_sayisi9);

                }
                if (gecen_kisi_sayisi10 > 0)
                {

                    this.dataGridView4.Rows.Add(dersler[9], gecen_kisi_sayisi10);

                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (this.comboBox1.SelectedItem != null)
            {

                int secili_en_buyuk_yas = -1;
                string secili_en_buyuk_ad = null;
                int secili_en_kucuk_yas = 101;
                string secili_en_kucuk_ad = null;
                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (this.comboBox1.SelectedItem.ToString() == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas)
                        {
                            secili_en_buyuk_yas = yas;
                            secili_en_buyuk_ad = ad;

                        }
                        if (yas < secili_en_kucuk_yas)
                        {
                            secili_en_kucuk_yas = yas;
                            secili_en_kucuk_ad = ad;
                        }
                    }
                }

                if (secili_en_kucuk_yas < 101 && secili_en_buyuk_yas > -1)
                {

                    this.dataGridView7.Rows.Add(comboBox1.SelectedItem.ToString(), secili_en_buyuk_ad, secili_en_buyuk_yas);
                    this.dataGridView7.Rows.Add(comboBox1.SelectedItem.ToString(), secili_en_kucuk_ad, secili_en_kucuk_yas);

                }
                else
                {
                    // error seçili dersten 
                }
            }
            else
            {

                int secili_en_buyuk_yas1 = -1;
                int secili_en_buyuk_yas2 = -1;
                int secili_en_buyuk_yas3 = -1;
                int secili_en_buyuk_yas4 = -1;
                int secili_en_buyuk_yas5 = -1;
                int secili_en_buyuk_yas6 = -1;
                int secili_en_buyuk_yas7 = -1;
                int secili_en_buyuk_yas8 = -1;
                int secili_en_buyuk_yas9 = -1;
                int secili_en_buyuk_yas10 = -1;
                int secili_en_kucuk_yas1 = 101;
                int secili_en_kucuk_yas2 = 101;
                int secili_en_kucuk_yas3 = 101;
                int secili_en_kucuk_yas4 = 101;
                int secili_en_kucuk_yas5 = 101;
                int secili_en_kucuk_yas6 = 101;
                int secili_en_kucuk_yas7 = 101;
                int secili_en_kucuk_yas8 = 101;
                int secili_en_kucuk_yas9 = 101;
                int secili_en_kucuk_yas10 = 101;
                string secili_en_buyuk_ad1 = null;
                string secili_en_buyuk_ad2 = null;
                string secili_en_buyuk_ad3 = null;
                string secili_en_buyuk_ad4 = null;
                string secili_en_buyuk_ad5 = null;
                string secili_en_buyuk_ad6 = null;
                string secili_en_buyuk_ad7 = null;
                string secili_en_buyuk_ad8 = null;
                string secili_en_buyuk_ad9 = null;
                string secili_en_buyuk_ad10 = null;
                string secili_en_kucuk_ad1 = null;
                string secili_en_kucuk_ad2 = null;
                string secili_en_kucuk_ad3 = null;
                string secili_en_kucuk_ad4 = null;
                string secili_en_kucuk_ad5 = null;
                string secili_en_kucuk_ad6 = null;
                string secili_en_kucuk_ad7 = null;
                string secili_en_kucuk_ad8 = null;
                string secili_en_kucuk_ad9 = null;
                string secili_en_kucuk_ad10 = null;




                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (dersler[0] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas1)
                        {
                            secili_en_buyuk_yas1 = yas;
                            secili_en_buyuk_ad1 = ad;

                        }
                        if (yas < secili_en_kucuk_yas1)
                        {
                            secili_en_kucuk_yas1 = yas;
                            secili_en_kucuk_ad1 = ad;
                        }

                    }
                    if (dersler[1] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas2)
                        {
                            secili_en_buyuk_yas2 = yas;
                            secili_en_buyuk_ad2 = ad;

                        }
                        if (yas < secili_en_kucuk_yas2)
                        {
                            secili_en_kucuk_yas2 = yas;
                            secili_en_kucuk_ad2 = ad;
                        }

                    }
                    if (dersler[2] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas3)
                        {
                            secili_en_buyuk_yas3 = yas;
                            secili_en_buyuk_ad3 = ad;

                        }
                        if (yas < secili_en_kucuk_yas3)
                        {
                            secili_en_kucuk_yas3 = yas;
                            secili_en_kucuk_ad3 = ad;
                        }
                    }
                    if (dersler[3] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas4)
                        {
                            secili_en_buyuk_yas4 = yas;
                            secili_en_buyuk_ad4 = ad;

                        }
                        if (yas < secili_en_kucuk_yas4)
                        {
                            secili_en_kucuk_yas4 = yas;
                            secili_en_kucuk_ad4 = ad;
                        }
                    }
                    if (dersler[4] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas5)
                        {
                            secili_en_buyuk_yas5 = yas;
                            secili_en_buyuk_ad5 = ad;

                        }
                        if (yas < secili_en_kucuk_yas5)
                        {
                            secili_en_kucuk_yas5 = yas;
                            secili_en_kucuk_ad5 = ad;
                        }
                    }
                    if (dersler[5] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas6)
                        {
                            secili_en_buyuk_yas6 = yas;
                            secili_en_buyuk_ad6 = ad;

                        }
                        if (yas < secili_en_kucuk_yas6)
                        {
                            secili_en_kucuk_yas6 = yas;
                            secili_en_kucuk_ad6 = ad;
                        }

                    }
                    if (dersler[6] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas7)
                        {
                            secili_en_buyuk_yas7 = yas;
                            secili_en_buyuk_ad7 = ad;

                        }
                        if (yas < secili_en_kucuk_yas7)
                        {
                            secili_en_kucuk_yas7 = yas;
                            secili_en_kucuk_ad7 = ad;
                        }
                    }
                    if (dersler[7] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas8)
                        {
                            secili_en_buyuk_yas8 = yas;
                            secili_en_buyuk_ad8 = ad;

                        }
                        if (yas < secili_en_kucuk_yas8)
                        {
                            secili_en_kucuk_yas8 = yas;
                            secili_en_kucuk_ad8 = ad;
                        }
                    }
                    if (dersler[8] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas9)
                        {
                            secili_en_buyuk_yas9 = yas;
                            secili_en_buyuk_ad9 = ad;

                        }
                        if (yas < secili_en_kucuk_yas9)
                        {
                            secili_en_kucuk_yas9 = yas;
                            secili_en_kucuk_ad9 = ad;
                        }
                    }
                    if (dersler[9] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {

                        int yas = Convert.ToInt16(this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                        string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (yas > secili_en_buyuk_yas10)
                        {
                            secili_en_buyuk_yas10 = yas;
                            secili_en_buyuk_ad10 = ad;

                        }
                        if (yas < secili_en_kucuk_yas10)
                        {
                            secili_en_kucuk_yas10 = yas;
                            secili_en_kucuk_ad10 = ad;
                        }
                    }
                }

                if (secili_en_kucuk_yas1 < 101 && secili_en_buyuk_yas1 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[0], secili_en_buyuk_ad1, secili_en_buyuk_yas1);
                    this.dataGridView7.Rows.Add(dersler[0], secili_en_kucuk_ad1, secili_en_kucuk_yas1);

                }

                if (secili_en_kucuk_yas2 < 101 && secili_en_buyuk_yas2 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[1], secili_en_buyuk_ad2, secili_en_buyuk_yas2);
                    this.dataGridView7.Rows.Add(dersler[1], secili_en_kucuk_ad2, secili_en_kucuk_yas2);

                }

                if (secili_en_kucuk_yas3 < 101 && secili_en_buyuk_yas3 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[2], secili_en_buyuk_ad3, secili_en_buyuk_yas3);
                    this.dataGridView7.Rows.Add(dersler[2], secili_en_kucuk_ad3, secili_en_kucuk_yas3);

                }

                if (secili_en_kucuk_yas4 < 101 && secili_en_buyuk_yas4 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[3], secili_en_buyuk_ad4, secili_en_buyuk_yas4);
                    this.dataGridView7.Rows.Add(dersler[3], secili_en_kucuk_ad4, secili_en_kucuk_yas4);

                }

                if (secili_en_kucuk_yas5 < 101 && secili_en_buyuk_yas5 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[4], secili_en_buyuk_ad5, secili_en_buyuk_yas5);
                    this.dataGridView7.Rows.Add(dersler[4], secili_en_kucuk_ad5, secili_en_kucuk_yas5);

                }

                if (secili_en_kucuk_yas6 < 101 && secili_en_buyuk_yas6 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[5], secili_en_buyuk_ad6, secili_en_buyuk_yas6);
                    this.dataGridView7.Rows.Add(dersler[5], secili_en_kucuk_ad6, secili_en_kucuk_yas6);

                }

                if (secili_en_kucuk_yas7 < 101 && secili_en_buyuk_yas7 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[6], secili_en_buyuk_ad7, secili_en_buyuk_yas7);
                    this.dataGridView7.Rows.Add(dersler[6], secili_en_kucuk_ad7, secili_en_kucuk_yas7);

                }

                if (secili_en_kucuk_yas8 < 101 && secili_en_buyuk_yas8 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[7], secili_en_buyuk_ad8, secili_en_buyuk_yas8);
                    this.dataGridView7.Rows.Add(dersler[7], secili_en_kucuk_ad8, secili_en_kucuk_yas8);

                }

                if (secili_en_kucuk_yas9 < 101 && secili_en_buyuk_yas9 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[8], secili_en_buyuk_ad9, secili_en_buyuk_yas9);
                    this.dataGridView7.Rows.Add(dersler[8], secili_en_kucuk_ad9, secili_en_kucuk_yas9);

                }

                if (secili_en_kucuk_yas10 < 101 && secili_en_buyuk_yas10 > -1)
                {

                    this.dataGridView7.Rows.Add(dersler[9], secili_en_buyuk_ad10, secili_en_buyuk_yas10);
                    this.dataGridView7.Rows.Add(dersler[9], secili_en_kucuk_ad10, secili_en_kucuk_yas10);

                }


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

                double secili_en_buyuk_ort1 = -1;
                double secili_en_buyuk_ort2 = -1;
                double secili_en_buyuk_ort3 = -1;
                double secili_en_buyuk_ort4 = -1;
                double secili_en_buyuk_ort5 = -1;
                double secili_en_buyuk_ort6 = -1;
                double secili_en_buyuk_ort7 = -1;
                double secili_en_buyuk_ort8 = -1;
                double secili_en_buyuk_ort9 = -1;
                double secili_en_buyuk_ort10 = -1;
                string en_buyuk_ad1 = null;
                string en_buyuk_ad2 = null;
                string en_buyuk_ad3 = null;
                string en_buyuk_ad4 = null;
                string en_buyuk_ad5 = null;
                string en_buyuk_ad6 = null;
                string en_buyuk_ad7 = null;
                string en_buyuk_ad8 = null;
                string en_buyuk_ad9 = null;
                string en_buyuk_ad10 = null;


            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (dersler[0] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort1)
                    {
                        secili_en_buyuk_ort1 = ort;
                        en_buyuk_ad1 = ad;

                    }

                }
                if (dersler[1] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {

                    if (ort > secili_en_buyuk_ort2)
                    {
                        secili_en_buyuk_ort2 = ort;
                        en_buyuk_ad2 = ad;

                    }


                }
                if (dersler[2] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort3)
                    {
                        secili_en_buyuk_ort3 = ort;
                        en_buyuk_ad3 = ad;

                    }
                }
                if (dersler[3] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort4)
                    {
                        secili_en_buyuk_ort4 = ort;
                        en_buyuk_ad4 = ad;

                    }
                }
                if (dersler[4] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort5)
                    {
                        secili_en_buyuk_ort5 = ort;
                        en_buyuk_ad5 = ad;

                    }
                }
                if (dersler[5] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort6)
                    {
                        secili_en_buyuk_ort6 = ort;
                        en_buyuk_ad6 = ad;

                    }
                }
                if (dersler[6] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort7)
                    {
                        secili_en_buyuk_ort7 = ort;
                        en_buyuk_ad7 = ad;

                    }
                }
                if (dersler[7] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort8)
                    {
                        secili_en_buyuk_ort8 = ort;
                        en_buyuk_ad8 = ad;

                    }
                }
                if (dersler[8] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort9)
                    {
                        secili_en_buyuk_ort9 = ort;
                        en_buyuk_ad9 = ad;

                    }
                }
                if (dersler[9] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_en_buyuk_ort10)
                    {
                        secili_en_buyuk_ort10 = ort;
                        en_buyuk_ad10 = ad;

                    }
                }
            }

                if (secili_en_buyuk_ort1 > -1)
                {

                    this.dataGridView5.Rows.Add(dersler[0], en_buyuk_ad1, secili_en_buyuk_ort1);

                }
                if (secili_en_buyuk_ort2 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[1], en_buyuk_ad2, secili_en_buyuk_ort2);
                }
                if (secili_en_buyuk_ort3 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[2], en_buyuk_ad3, secili_en_buyuk_ort3);
                }
                if (secili_en_buyuk_ort4 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[3], en_buyuk_ad4, secili_en_buyuk_ort4);
                }
                if (secili_en_buyuk_ort5 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[4], en_buyuk_ad5, secili_en_buyuk_ort5);
                }
                if (secili_en_buyuk_ort6 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[5], en_buyuk_ad6, secili_en_buyuk_ort6);
                }
                if (secili_en_buyuk_ort7 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[6], en_buyuk_ad7, secili_en_buyuk_ort7);
                }
                if (secili_en_buyuk_ort8 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[7], en_buyuk_ad8, secili_en_buyuk_ort8);
                }
                if (secili_en_buyuk_ort9 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[8], en_buyuk_ad9, secili_en_buyuk_ort9);
                }
                if (secili_en_buyuk_ort10 > -1)
                {

                this.dataGridView5.Rows.Add(dersler[9], en_buyuk_ad10, secili_en_buyuk_ort10);
                }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                double ort = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                string ad = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                string ders = this.dataGridView1.Rows[i].Cells[2].Value.ToString();

                if (ort == 35)
                {
                    this.dataGridView9.Rows.Add(ders, ad, ort);
                    this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Blue;
                    this.dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Blue;
                    this.dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Blue;
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
             
            
                int secili_ders_sayac1 = 0;
                int secili_ders_sayac2 = 0;
                int secili_ders_sayac3 = 0;
                int secili_ders_sayac4 = 0;
                int secili_ders_sayac5 = 0;
                int secili_ders_sayac6 = 0;
                int secili_ders_sayac7 = 0;
                int secili_ders_sayac8 = 0;
                int secili_ders_sayac9 = 0;
                int secili_ders_sayac10 = 0;
                double secili_ders_toplam_ort1 = 0;
                double secili_ders_toplam_ort2 = 0;
                double secili_ders_toplam_ort3 = 0;
                double secili_ders_toplam_ort4 = 0;
                double secili_ders_toplam_ort5 = 0;
                double secili_ders_toplam_ort6 = 0;
                double secili_ders_toplam_ort7 = 0;
                double secili_ders_toplam_ort8 = 0;
                double secili_ders_toplam_ort9 = 0;
                double secili_ders_toplam_ort10 = 0;
                double secili_ders_ort1 = 0;
                double secili_ders_ort2 = 0;
                double secili_ders_ort3 = 0;
                double secili_ders_ort4 = 0;
                double secili_ders_ort5 = 0;
                double secili_ders_ort6 = 0;
                double secili_ders_ort7 = 0;
                double secili_ders_ort8 = 0;
                double secili_ders_ort9 = 0;
                double secili_ders_ort10 = 0;

                for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                {
                    if (dersler[0] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac1++;

                        secili_ders_toplam_ort1 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[1] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac2++;
                        secili_ders_toplam_ort2 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[2] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac3++;
                        secili_ders_toplam_ort3 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[3] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac4++;
                        secili_ders_toplam_ort4 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[4] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac5++;
                        secili_ders_toplam_ort5 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[5] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac6++;
                        secili_ders_toplam_ort6 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[6] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac7++;
                        secili_ders_toplam_ort7 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[7] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac8++;
                        secili_ders_toplam_ort8 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[8] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac9++;
                        secili_ders_toplam_ort9 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                    if (dersler[9] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        secili_ders_sayac10++;
                        secili_ders_toplam_ort10 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value.ToString());

                    }
                }
                if (secili_ders_sayac1 > 0)
                {
                    secili_ders_ort1 = secili_ders_toplam_ort1 / secili_ders_sayac1;
                    
                }
                if (secili_ders_sayac2 > 0)
                {
                    secili_ders_ort2 = secili_ders_toplam_ort2 / secili_ders_sayac2;
                    
                }
                if (secili_ders_sayac3 > 0)
                {
                    secili_ders_ort3 = secili_ders_toplam_ort3 / secili_ders_sayac3;
                }
                if (secili_ders_sayac4 > 0)
                {
                    secili_ders_ort4 = secili_ders_toplam_ort4 / secili_ders_sayac4;
                }
                if (secili_ders_sayac5 > 0)
                {
                    secili_ders_ort5 = secili_ders_toplam_ort5 / secili_ders_sayac5;
                }
                if (secili_ders_sayac6 > 0)
                {
                    secili_ders_ort6 = secili_ders_toplam_ort6 / secili_ders_sayac6;
                }
                if (secili_ders_sayac7 > 0)
                {
                    secili_ders_ort7 = secili_ders_toplam_ort7 / secili_ders_sayac7;
                }
                if (secili_ders_sayac8 > 0)
                {
                    secili_ders_ort8 = secili_ders_toplam_ort8 / secili_ders_sayac8;
                }
                if (secili_ders_sayac9 > 0)
                {
                    secili_ders_ort9 = secili_ders_toplam_ort9 / secili_ders_sayac9;
                }
                if (secili_ders_sayac10 > 0)
                {
                    secili_ders_ort10 = secili_ders_toplam_ort10 / secili_ders_sayac10;
                }
            double en_buyuk = 0;
            string en_buyuk_ad = null;
            double[] vizeler = { secili_ders_ort1, secili_ders_ort2,secili_ders_ort3,secili_ders_ort4,secili_ders_ort5,secili_ders_ort6,secili_ders_ort7,secili_ders_ort8,secili_ders_ort9,secili_ders_ort10 };
            for(int i=0; i <= 10;i++ )
            {
                if (vizeler[i] > en_buyuk)
                {
                    en_buyuk = vizeler[i];
                    en_buyuk_ad = dersler[i];

                }

            }
            this.dataGridView8.Rows.Add(en_buyuk_ad, en_buyuk);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int secili_ders_sayac1 = 0;
            int secili_ders_sayac2 = 0;
            int secili_ders_sayac3 = 0;
            int secili_ders_sayac4 = 0;
            int secili_ders_sayac5 = 0;
            int secili_ders_sayac6 = 0;
            int secili_ders_sayac7 = 0;
            int secili_ders_sayac8 = 0;
            int secili_ders_sayac9 = 0;
            int secili_ders_sayac10 = 0;
            double secili_ders_toplam_ort1 = 0;
            double secili_ders_toplam_ort2 = 0;
            double secili_ders_toplam_ort3 = 0;
            double secili_ders_toplam_ort4 = 0;
            double secili_ders_toplam_ort5 = 0;
            double secili_ders_toplam_ort6 = 0;
            double secili_ders_toplam_ort7 = 0;
            double secili_ders_toplam_ort8 = 0;
            double secili_ders_toplam_ort9 = 0;
            double secili_ders_toplam_ort10 = 0;
            double secili_ders_ort1 = 0;
            double secili_ders_ort2 = 0;
            double secili_ders_ort3 = 0;
            double secili_ders_ort4 = 0;
            double secili_ders_ort5 = 0;
            double secili_ders_ort6 = 0;
            double secili_ders_ort7 = 0;
            double secili_ders_ort8 = 0;
            double secili_ders_ort9 = 0;
            double secili_ders_ort10 = 0;

            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                if (dersler[0] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac1++;

                    secili_ders_toplam_ort1 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[1] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac2++;
                    secili_ders_toplam_ort2 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[2] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac3++;
                    secili_ders_toplam_ort3 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[3] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac4++;
                    secili_ders_toplam_ort4 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[4] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac5++;
                    secili_ders_toplam_ort5 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[5] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac6++;
                    secili_ders_toplam_ort6 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[6] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac7++;
                    secili_ders_toplam_ort7 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[7] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac8++;
                    secili_ders_toplam_ort8 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[8] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac9++;
                    secili_ders_toplam_ort9 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
                if (dersler[9] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    secili_ders_sayac10++;
                    secili_ders_toplam_ort10 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());

                }
            }
            if (secili_ders_sayac1 > 0)
            {
                secili_ders_ort1 = secili_ders_toplam_ort1 / secili_ders_sayac1;

            }
            if (secili_ders_sayac2 > 0)
            {
                secili_ders_ort2 = secili_ders_toplam_ort2 / secili_ders_sayac2;

            }
            if (secili_ders_sayac3 > 0)
            {
                secili_ders_ort3 = secili_ders_toplam_ort3 / secili_ders_sayac3;
            }
            if (secili_ders_sayac4 > 0)
            {
                secili_ders_ort4 = secili_ders_toplam_ort4 / secili_ders_sayac4;
            }
            if (secili_ders_sayac5 > 0)
            {
                secili_ders_ort5 = secili_ders_toplam_ort5 / secili_ders_sayac5;
            }
            if (secili_ders_sayac6 > 0)
            {
                secili_ders_ort6 = secili_ders_toplam_ort6 / secili_ders_sayac6;
            }
            if (secili_ders_sayac7 > 0)
            {
                secili_ders_ort7 = secili_ders_toplam_ort7 / secili_ders_sayac7;
            }
            if (secili_ders_sayac8 > 0)
            {
                secili_ders_ort8 = secili_ders_toplam_ort8 / secili_ders_sayac8;
            }
            if (secili_ders_sayac9 > 0)
            {
                secili_ders_ort9 = secili_ders_toplam_ort9 / secili_ders_sayac9;
            }
            if (secili_ders_sayac10 > 0)
            {
                secili_ders_ort10 = secili_ders_toplam_ort10 / secili_ders_sayac10;
            }
            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                double ort= Convert.ToDouble(this.dataGridView1.Rows[i].Cells[5].Value.ToString());
                if (dersler[0] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort1)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor= Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
                if (dersler[1] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort2)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }

                }
                if (dersler[2] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort3)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
                if (dersler[3] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort4)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
                if (dersler[4] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort5)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
                if (dersler[5] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort6)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
                if (dersler[6] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort7)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
                if (dersler[7] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort8)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
                if (dersler[8] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort9)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
                if (dersler[9] == this.dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    if (ort > secili_ders_ort10)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        this.dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    }
                }
            }

        }
    }
}
