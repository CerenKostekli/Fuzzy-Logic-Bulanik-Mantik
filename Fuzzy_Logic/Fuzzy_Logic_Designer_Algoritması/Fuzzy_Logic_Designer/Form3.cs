using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuzzy_Logic_Designer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double giris_2, giris_1; // nem ve sıcaklık değişkemleri.
        double nem_cok_dusuk, nem_dusuk, nem_orta, nem_yuksek, nem_cok_yuksek; //bulanıklaştırma değikenleri.
        double sicaklik_cok_dusuk, sicaklik_dusuk, sicaklik_orta, sicaklik_yuksek, sicaklik_cok_yuksek; //bulanıklaştırma değişkenleri.

        private void giris2_KeyPress(object sender, KeyPressEventArgs e) //nem textbox tuş denetleme
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ','; //harf veya özel karakter yazmayı engeller
        }

        private void giris1_KeyPress(object sender, KeyPressEventArgs e) //sıcaklıkk textbox tuş denetleme
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&& e.KeyChar != ',' && e.KeyChar != '-'; //harf veya özel karakter yazmayı engeller
        }
       
        public void sicaklik_bulaniklastir() //bulanıklaştırma işlemleri
        {
            sicaklik_cok_dusuk = Math.Max(Math.Min((10 - giris_1) / 10, 1), 0);
            sicaklik_dusuk = Math.Max(Math.Min(giris_1 / 7.5, (15 - giris_1) / 7.5), 0);
            sicaklik_orta = Math.Max(Math.Min((giris_1 - 14) / 6, (26 - giris_1) / 6), 0);
            sicaklik_yuksek = Math.Max(Math.Min((giris_1 - 20) / 10, (40 - giris_1) / 10), 0);
            sicaklik_cok_yuksek = Math.Max(Math.Min((giris_1 - 30) / 30, 1), 0);
        }
        public void nem_bulaniklastir() //bulanıklaştırma işlemleri
        {
            nem_cok_dusuk = Math.Max(Math.Min((40 - giris_2) / 20, 1), 0);
            nem_dusuk = Math.Max(Math.Min(giris_2 - 20 / 19.5, (59 - giris_2) / 19.5), 0);
            nem_orta = Math.Max(Math.Min((giris_2 - 50) / 10, (70 - giris_2) / 10), 0);
            nem_yuksek = Math.Max(Math.Min((giris_2 - 60) / 15, (90 - giris_2) / 15), 0);
            nem_cok_yuksek = Math.Max(Math.Min((giris_2 - 80) / 10, 1), 0);
        }


        private void gırıs1_button_Click(object sender, EventArgs e) //Giriş butonu.
        {
            
            if (giris2.Text == string.Empty && giris1.Text == string.Empty) //textbox boşsa hata verir.
            {
                MessageBox.Show("Geçerli bir değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                giris_2 = Convert.ToDouble(giris2.Text); //string değerleri double a çevirir.
                giris_1 = Convert.ToDouble(giris1.Text); //string değrleri double a çevirir.
                if (giris_2 > 100 || giris_2 < 0) //nem aralığının  dışındaysa hata verir.
                {
                    MessageBox.Show("Lütfen 0 ile 100 arasında bir değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (giris_1 > 50 || giris_1 < -10) //sıcaklık aralığının dışındaysa hata verir.
                {
                    MessageBox.Show("Lütfen -10 ile 50 arasında bir değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // girilen değerleri bulanıklaştırır ve grafikte gösterir.
                    sicaklik_bulaniklastir();
                    nem_bulaniklastir();
                    chart_input2.Series[5].Points.AddXY(giris_2, 0);
                    chart_input2.Series[5].Points.AddXY(giris_2, 1);

                    char_input1.Series[5].Points.AddXY(giris_1, 0);
                    char_input1.Series[5].Points.AddXY(giris_1, 1);

                    //bulanıklaştırılan değerleri göster
                    label17.Text = Convert.ToString(Math.Round(nem_cok_yuksek ,2));  
                    label18.Text = Convert.ToString(Math.Round(nem_yuksek, 2));
                    label19.Text = Convert.ToString(Math.Round(nem_orta ,2));
                    label20.Text = Convert.ToString(Math.Round(nem_dusuk,2));
                    label21.Text = Convert.ToString(Math.Round(nem_cok_dusuk,2));

                    label22.Text = Convert.ToString(Math.Round(sicaklik_cok_yuksek,2));
                    label23.Text = Convert.ToString(Math.Round(sicaklik_yuksek,2));
                    label24.Text = Convert.ToString(Math.Round(sicaklik_orta,2));
                    label25.Text = Convert.ToString(Math.Round(sicaklik_dusuk,2));
                    label26.Text = Convert.ToString(Math.Round(sicaklik_cok_dusuk,2));

                    //form1 e değerleri gönderir. form4 e göndermek için.
                    Form1 f1 = new Form1();
                    f1.nem_cok_dusuk1 = nem_cok_dusuk;
                    f1.nem_dusuk1 = nem_dusuk;
                    f1.nem_orta1 = nem_orta;
                    f1.nem_yuksek1 = nem_yuksek;
                    f1.nem_cok_yuksek1 = nem_cok_yuksek;

                    f1.sicaklik_cok_dusuk1 = sicaklik_cok_dusuk;
                    f1.sicaklik_dusuk1 = sicaklik_dusuk;
                    f1.sicaklik_orta1 = sicaklik_orta;
                    f1.sicaklik_yuksek1 = sicaklik_yuksek;
                    f1.sicaklik_cok_yuksek1 = sicaklik_cok_yuksek;

                    f1.Show();
                }
            }
        }



        
        private void Form3_Load(object sender, EventArgs e)
        {
            //Nem grafiği

            chart_input2.Series[4].Points.AddXY(0,0);
            chart_input2.Series[4].Points.AddXY(80, 0);
            chart_input2.Series[4].Points.AddXY(90, 1);
            chart_input2.Series[4].Points.AddXY(100, 1);

            chart_input2.Series[1].Points.AddXY(0, 0);
            chart_input2.Series[1].Points.AddXY(20, 0);
            chart_input2.Series[1].Points.AddXY(39.5, 1);
            chart_input2.Series[1].Points.AddXY(59, 0);
            chart_input2.Series[1].Points.AddXY(100, 0);

            chart_input2.Series[2].Points.AddXY(0, 0);
            chart_input2.Series[2].Points.AddXY(50, 0);
            chart_input2.Series[2].Points.AddXY(60, 1);
            chart_input2.Series[2].Points.AddXY(70, 0);
            chart_input2.Series[2].Points.AddXY(100, 0);

            chart_input2.Series[3].Points.AddXY(0, 0);
            chart_input2.Series[3].Points.AddXY(60, 0);
            chart_input2.Series[3].Points.AddXY(75, 1);
            chart_input2.Series[3].Points.AddXY(90, 0);
            chart_input2.Series[3].Points.AddXY(100, 0);

            chart_input2.Series[0].Points.AddXY(0, 1);
            chart_input2.Series[0].Points.AddXY(20, 1);
            chart_input2.Series[0].Points.AddXY(40, 0);
            chart_input2.Series[0].Points.AddXY(100, 0);


            //Sıcaklık grafiği
            char_input1.Series[0].Points.AddXY(-10, 1);
            char_input1.Series[0].Points.AddXY(0, 1);
            char_input1.Series[0].Points.AddXY(10, 0);
            char_input1.Series[0].Points.AddXY(50, 0);

            char_input1.Series[1].Points.AddXY(-10, 0);
            char_input1.Series[1].Points.AddXY(0, 0);
            char_input1.Series[1].Points.AddXY(7.5, 1);
            char_input1.Series[1].Points.AddXY(15, 0);
            char_input1.Series[1].Points.AddXY(50, 0);

            char_input1.Series[2].Points.AddXY(-10, 0);
            char_input1.Series[2].Points.AddXY(14, 0);
            char_input1.Series[2].Points.AddXY(20, 1);
            char_input1.Series[2].Points.AddXY(26, 0);
            char_input1.Series[2].Points.AddXY(50, 0);

            char_input1.Series[3].Points.AddXY(-10, 0);
            char_input1.Series[3].Points.AddXY(20, 0);
            char_input1.Series[3].Points.AddXY(30, 1);
            char_input1.Series[3].Points.AddXY(40, 0);
            char_input1.Series[3].Points.AddXY(50, 0);

            char_input1.Series[4].Points.AddXY(-10, 0);
            char_input1.Series[4].Points.AddXY(30, 0);
            char_input1.Series[4].Points.AddXY(40, 1);
            char_input1.Series[4].Points.AddXY(50, 1);
        }

    }
}
