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

    public partial class Form1 : Form
    {
        bool OR_Degisken, AND_Degisken, agirlikli_ortalama_1, maksimum_ortalama1;
        public double nem_cok_dusuk1, nem_dusuk1, nem_orta1, nem_yuksek1, nem_cok_yuksek1, sicaklik_cok_dusuk1, sicaklik_dusuk1, sicaklik_orta1, sicaklik_yuksek1, sicaklik_cok_yuksek1; //form 4 e atmak için.
        string combo; //combo box için.
        private void Form1_Load(object sender, EventArgs e)
        {
            //combo box ın içeriğini belirlenir.
            comboBox1.Items.Add("lom");
            comboBox1.Items.Add("mom");
            comboBox1.Items.Add("som");
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void input2_Click(object sender, EventArgs e) //Giriş butonu
        {
                Form3 f3 = new Form3();
                f3.Show(); //form 3 ü aç.
                this.Hide(); //form 1 gizle. 
        }
        private void output1_Click(object sender, EventArgs e)
        {
            //Radio butonlar okunur.
            AND_Degisken = AND.Checked; 
            OR_Degisken = OR.Checked;
            maksimum_ortalama1 = maksimumortalama_1.Checked;
            agirlikli_ortalama_1=agirlikliortalama_1.Checked;
            //Combo box ın içeriği okunur.
            combo = comboBox1.Text;
            if (OR_Degisken==false && AND_Degisken==false && agirlikli_ortalama_1 == true)
            {
                MessageBox.Show("AND ya da OR seçimi yapılmadı. Lütfen seçiminizi yapınız.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Değişkenleri form4 e gönderir.
                Form4 f4 = new Form4();               
                f4.nem_cok_dusuk4 = nem_cok_dusuk1;
                f4.nem_dusuk4 = nem_dusuk1;
                f4.nem_orta4 = nem_orta1;
                f4.nem_yuksek4 = nem_yuksek1;
                f4.nem_cok_yuksek4 = nem_cok_yuksek1;
                
                f4.sicaklik_cok_dusuk4 = sicaklik_cok_dusuk1;
                f4.sicaklik_dusuk4 = sicaklik_dusuk1;
                f4.sicaklik_orta4 = sicaklik_orta1;
                f4.sicaklik_yuksek4 = sicaklik_yuksek1;
                f4.sicaklik_cok_yuksek4 = sicaklik_cok_yuksek1;

                f4.And_Degisken = AND_Degisken;
                f4.Or_Degisken = OR_Degisken;
                f4.maksimum_4 = maksimum_ortalama1;
                f4.agirlikliortalama_4 = agirlikli_ortalama_1;
                f4.combo4 = combo;
                f4.Show();
                
            }

        }
    }
}
