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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public double nem_cok_dusuk4, nem_dusuk4, nem_orta4, nem_yuksek4, nem_cok_yuksek4, sicaklik_cok_dusuk4, sicaklik_dusuk4, sicaklik_orta4, sicaklik_yuksek4, sicaklik_cok_yuksek4;
        public bool And_Degisken, Or_Degisken, agirlikliortalama_4, maksimum_4; //form1 deki radio butonlerının değişkenleri.
        public byte sicaklik_Indis_satir1 = 5, sicaklik_Indis_satir2 = 5; //Maksimum iki tane sıcaklık değeri elde edilir. Bunların tablodaki konumunu belirlemek için atanmıştır.
        public byte nem_Indis_sutun1 = 5, nem_Indis_sutun2 = 5; //Maksimum iki tane nem değeri elde edilir. Bunların tablodaki konumunu belirlemek için atanmıştır.
        double[] sicaklik_Dizi = new double[6];
        double[] nem_Dizi = new double[6];
        string[,] Isitici_Satir_Sutun = new string[5, 5]; //Isıtıcı tablosu için oluşturulmuştur.
        public string Isitici_Karsiligi1 = "null", Isitici_Karsiligi2 = "null", Isitici_Karsiligi3 = "null", Isitici_Karsiligi4 = "null";
        public string combo4;
        public double Kiyas1, Kiyas2, Kiyas3, Kiyas4;
        public double Kiyas_Sonuc1, Kiyas_Sonuc2, Kiyas_Sonuc3, Kiyas_Sonuc4;
        public double cevap;

        public void dizilere_deger_atama()
        {
            nem_Dizi[0] = nem_cok_dusuk4;
            nem_Dizi[1] = nem_dusuk4;
            nem_Dizi[2] = nem_orta4;
            nem_Dizi[3] = nem_yuksek4;
            nem_Dizi[4] = nem_cok_yuksek4;
            nem_Dizi[5] = 0;

            sicaklik_Dizi[0] = sicaklik_cok_dusuk4;
            sicaklik_Dizi[1] = sicaklik_dusuk4;
            sicaklik_Dizi[2] = sicaklik_orta4;
            sicaklik_Dizi[3] = sicaklik_yuksek4;
            sicaklik_Dizi[4] = sicaklik_cok_yuksek4;
            sicaklik_Dizi[5] = 0;
        }
        public void sifirları_yok_etme(){
            byte i; //sıcaklık için
            byte j; //nem için

            for (i=0; i<5; i++)
            {
                if (sicaklik_Dizi[i] != 0 && sicaklik_Indis_satir1 == 5) // Eğer sıcaklık indis satırına bir değişken girilmediyse kutu içine değer atanır. Bu değer bulanıklaştırılan değerin konumunu belirler.
                {
                    sicaklik_Indis_satir1 = i;
                }
                else if (sicaklik_Dizi[i] != 0 && sicaklik_Indis_satir2 == 5) 
                {
                    sicaklik_Indis_satir2 = i;
                }
            }

            for (j = 0; j < 5; j++)
            {
                if (nem_Dizi[j] != 0 && nem_Indis_sutun1 == 5) 
                {
                    nem_Indis_sutun1 = j;
                }
                else if (nem_Dizi[j] != 0 && nem_Indis_sutun2 == 5)
                {
                    nem_Indis_sutun2 = j;
                }
            }
        }
        public void kural_tablosu(){

            //1.satır
            Isitici_Satir_Sutun[0, 0] = "Çok Yüksek";
            Isitici_Satir_Sutun[0, 1] = "Yüksek";
            Isitici_Satir_Sutun[0, 2] = "Orta";
            Isitici_Satir_Sutun[0, 3] = "Düşük";
            Isitici_Satir_Sutun[0, 4] = "Çok Düşük";
            //2.satır
            Isitici_Satir_Sutun[1, 0] = "Çok Yüksek";
            Isitici_Satir_Sutun[1, 1] = "Yüksek";
            Isitici_Satir_Sutun[1, 2] = "Orta";
            Isitici_Satir_Sutun[1, 3] = "Düşük";
            Isitici_Satir_Sutun[1, 4] = "Çok Düşük";
            //3.satır
            Isitici_Satir_Sutun[2, 0] = "Yüksek";
            Isitici_Satir_Sutun[2, 1] = "Yüksek";
            Isitici_Satir_Sutun[2, 2] = "Orta";
            Isitici_Satir_Sutun[2, 3] = "Düşük";
            Isitici_Satir_Sutun[2, 4] = "Çok Düşük";
            //4.satır
            Isitici_Satir_Sutun[3, 0] = "Yüksek";
            Isitici_Satir_Sutun[3, 1] = "Orta";
            Isitici_Satir_Sutun[3, 2] = "Orta";
            Isitici_Satir_Sutun[3, 3] = "Düşük";
            Isitici_Satir_Sutun[3, 4] = "Çok Düşük";
            //5.satır
            Isitici_Satir_Sutun[4, 0] = "Yüksek";
            Isitici_Satir_Sutun[4, 1] = "Orta";
            Isitici_Satir_Sutun[4, 2] = "Düşük";
            Isitici_Satir_Sutun[4, 3] = "Düşük";
            Isitici_Satir_Sutun[4, 4] = "Çok Düşük"; 

            if (sicaklik_Indis_satir1<=4 && nem_Indis_sutun1<=4) //Değişmişse.
            {
                Isitici_Karsiligi1 = Isitici_Satir_Sutun[nem_Indis_sutun1,sicaklik_Indis_satir1];
            }
            if (sicaklik_Indis_satir1 <= 4 && nem_Indis_sutun2 <= 4)
            {
                Isitici_Karsiligi2 = Isitici_Satir_Sutun[nem_Indis_sutun2, sicaklik_Indis_satir1];
            }
            if (sicaklik_Indis_satir2 <= 4 && nem_Indis_sutun1 <= 4)
            {
                Isitici_Karsiligi3 = Isitici_Satir_Sutun[nem_Indis_sutun1, sicaklik_Indis_satir2];
            }
            if (sicaklik_Indis_satir2 <= 4 && nem_Indis_sutun2 <= 4)
            {
                Isitici_Karsiligi4 = Isitici_Satir_Sutun[nem_Indis_sutun2, sicaklik_Indis_satir2];
            }
        }
        public void AND() {
            dizilere_deger_atama();
            sifirları_yok_etme();
            //Kıyas için bütün olasılıklar yazılır.
            Kiyas1 = Math.Min(nem_Dizi[nem_Indis_sutun1], sicaklik_Dizi[sicaklik_Indis_satir1]);
            Kiyas2 = Math.Min(nem_Dizi[nem_Indis_sutun1], sicaklik_Dizi[sicaklik_Indis_satir2]);
            Kiyas3 = Math.Min(nem_Dizi[nem_Indis_sutun2], sicaklik_Dizi[sicaklik_Indis_satir1]);
            Kiyas4 = Math.Min(nem_Dizi[nem_Indis_sutun2], sicaklik_Dizi[sicaklik_Indis_satir2]);
        }
        public void OR() {
            dizilere_deger_atama();
            sifirları_yok_etme();
            Kiyas1 = Math.Max(nem_Dizi[nem_Indis_sutun1], sicaklik_Dizi[sicaklik_Indis_satir1]);
            Kiyas2 = Math.Max(nem_Dizi[nem_Indis_sutun1], sicaklik_Dizi[sicaklik_Indis_satir2]);
            Kiyas3 = Math.Max(nem_Dizi[nem_Indis_sutun2], sicaklik_Dizi[sicaklik_Indis_satir1]);
            Kiyas4 = Math.Max(nem_Dizi[nem_Indis_sutun2], sicaklik_Dizi[sicaklik_Indis_satir2]);
        }
        public void yakınlasma() //form1 de seçilen maksimum ve ağırlıklı ortalama seçimini değerlendirir.
        {
            if (maksimum_4 == true)
            {
                maksimum_yontemi();
            }
            else if(agirlikliortalama_4 == true)
            {
                Agırlikli_Ortalama_Hesabı();
            }
        }
        public void Yontem() {
            if (And_Degisken == true)
            {
                AND();

            }
            else if (Or_Degisken == true) {

                OR();

            }
        
        }
        public void maksimum_yontemi()
        {
            dizilere_deger_atama();
            sifirları_yok_etme();
            kural_tablosu();
            if (Isitici_Karsiligi1 == "Çok Düşük")
            {
                if (combo4 == "som")
                {
                    cevap = 0;
                }
                else if(combo4 == "mom")
                {
                    cevap = 0.25;
                }
                else if (combo4 == "lom")
                {
                    cevap = 0.5;
                }
            }
            else if (Isitici_Karsiligi1 == "Düşük")
            {
                cevap = 1.5;
            }
            else if (Isitici_Karsiligi1 == "Orta")
            {
                cevap = 3;
            }
            else if (Isitici_Karsiligi1 == "Yüksek")
            {
                cevap = 4.25;
            }
            else if(Isitici_Karsiligi1 == "Çok Yüksek")
            {
                if (combo4 == "som")
                {
                    cevap = 5.25;
                }
                else if (combo4 == "mom")
                {
                    cevap = 5.625;
                }
                else if (combo4 == "lom")
                {
                    cevap = 6;
                }
            }

            if (Isitici_Karsiligi2 == "Çok Düşük")
            {
                if (combo4 == "som")
                {
                    cevap = 0;
                }
                else if (combo4 == "mom")
                {
                    cevap = 0.25;
                }
                else if (combo4 == "lom")
                {
                    cevap = 0.5;
                }
            }
            else if (Isitici_Karsiligi2 == "Düşük")
            {
                cevap = 1.5;
            }
            else if (Isitici_Karsiligi2 == "Orta")
            {
                cevap = 3;
            }
            else if (Isitici_Karsiligi2 == "Yüksek")
            {
                cevap = 4.25;
            }
            else if (Isitici_Karsiligi2 == "Çok Yüksek")
            {
                if (combo4 == "som")
                {
                    cevap = 5.25;
                }
                else if (combo4 == "mom")
                {
                    cevap = 5.625;
                }
                else if (combo4 == "lom")
                {
                    cevap = 6;
                }
            }

            if (Isitici_Karsiligi3 == "Çok Düşük")
            {
                if (combo4 == "som")
                {
                    cevap = 0;
                }
                else if (combo4 == "mom")
                {
                    cevap = 0.25;
                }
                else if (combo4 == "lom")
                {
                    cevap = 0.5;
                }
            }
            else if (Isitici_Karsiligi3 == "Düşük")
            {
                cevap = 1.5;
            }
            else if (Isitici_Karsiligi3 == "Orta")
            {
                cevap = 3;
            }
            else if (Isitici_Karsiligi3 == "Yüksek")
            {
                cevap = 4.25;
            }
            else if (Isitici_Karsiligi3 == "Çok Yüksek")
            {
                if (combo4 == "som")
                {
                    cevap = 5.25;
                }
                else if (combo4 == "mom")
                {
                    cevap = 5.625;
                }
                else if (combo4 == "lom")
                {
                    cevap = 6;
                }
            }

            if (Isitici_Karsiligi4 == "Çok Düşük")
            {
                if (combo4 == "som")
                {
                    cevap = 0;
                }
                else if (combo4 == "mom")
                {
                    cevap = 0.25;
                }
                else if (combo4 == "lom")
                {
                    cevap = 0.5;
                }
            }
            else if (Isitici_Karsiligi4 == "Düşük")
            {
                cevap = 1.5;
            }
            else if (Isitici_Karsiligi4 == "Orta")
            {
                cevap = 3;
            }
            else if (Isitici_Karsiligi4 == "Yüksek")
            {
                cevap = 4.25;
            }
            else if (Isitici_Karsiligi4 == "Çok Yüksek")
            {
                if (combo4 == "som")
                {
                    cevap = 5.25;
                }
                else if (combo4 == "mom")
                {
                    cevap = 5.625;
                }
                else if (combo4 == "lom")
                {
                    cevap = 6;
                }
            }
        }
        public void Agırlikli_Ortalama_Hesabı()
        {
            Yontem();
            kural_tablosu();

            if (Isitici_Karsiligi1=="Çok Düşük")
            {
                Kiyas_Sonuc1 = Convert.ToDouble(Kiyas1 * 0.5); //çapım değerlerini yuvarlamasın diye conver.todouble yapılmıştır.
            }
            else if (Isitici_Karsiligi1 == "Düşük")
            {
                Kiyas_Sonuc1 = Convert.ToDouble(Kiyas1 * 1.5);
            }
            else if (Isitici_Karsiligi1 == "Orta")
            {
                Kiyas_Sonuc1 = Convert.ToDouble(Kiyas1 * 3);
            }
            else if (Isitici_Karsiligi1 == "Yüksek")
            {
                Kiyas_Sonuc1 = Convert.ToDouble(Kiyas1 * 4.25);
            }
            else if (Isitici_Karsiligi1 == "Çok Yüksek")
            {
                Kiyas_Sonuc1 = Convert.ToDouble(Kiyas1 * 5.25);
            }

            if (Isitici_Karsiligi2 == "Çok Düşük")
            {
                Kiyas_Sonuc2 = Convert.ToDouble(Kiyas1 * 0.5);
            }
            else if (Isitici_Karsiligi2 == "Düşük")
            {
                Kiyas_Sonuc2 = Convert.ToDouble(Kiyas1 * 1.5);
            }
            else if (Isitici_Karsiligi2 == "Orta")
            {
                Kiyas_Sonuc2 = Convert.ToDouble(Kiyas1 * 3);
            }
            else if (Isitici_Karsiligi2 == "Yüksek")
            {
                Kiyas_Sonuc2 = Convert.ToDouble(Kiyas1 * 4.25);
            }
            else if (Isitici_Karsiligi2 == "Çok Yüksek")
            {
                Kiyas_Sonuc2 = Convert.ToDouble(Kiyas1 * 5.25);
            }

            if (Isitici_Karsiligi3 == "Çok Düşük")
            {
                Kiyas_Sonuc3 = Convert.ToDouble(Kiyas1 * 0.5);
            }
            else if (Isitici_Karsiligi3 == "Düşük")
            {
                Kiyas_Sonuc3 = Convert.ToDouble(Kiyas1 * 1.5);
            }
            else if (Isitici_Karsiligi3 == "Orta")
            {
                Kiyas_Sonuc3 = Convert.ToDouble(Kiyas1 * 3);
            }
            else if (Isitici_Karsiligi3 == "Yüksek")
            {
                Kiyas_Sonuc3 = Convert.ToDouble(Kiyas1 * 4.25);
            }
            else if (Isitici_Karsiligi3 == "Çok Yüksek")
            {
                Kiyas_Sonuc3 = Convert.ToDouble(Kiyas1 * 5.25);
            }

            if (Isitici_Karsiligi4 == "Çok Düşük")
            {
                Kiyas_Sonuc4 = Convert.ToDouble(Kiyas1 * 0.5);
            }
            else if (Isitici_Karsiligi4 == "Düşük")
            {
                Kiyas_Sonuc4 = Convert.ToDouble(Kiyas1 * 1.5);
            }
            else if (Isitici_Karsiligi4 == "Orta")
            {
                Kiyas_Sonuc4 = Convert.ToDouble(Kiyas1 * 3);
            }
            else if (Isitici_Karsiligi4 == "Yüksek")
            {
                Kiyas_Sonuc4 = Convert.ToDouble(Kiyas1 * 4.25);
            }
            else if (Isitici_Karsiligi4 == "Çok Yüksek")
            {
                Kiyas_Sonuc4 = Convert.ToDouble(Kiyas1 * 5.25);

            }

            cevap = Convert.ToDouble((Kiyas_Sonuc1 + Kiyas_Sonuc2 + Kiyas_Sonuc3 + Kiyas_Sonuc4) / (Kiyas1 + Kiyas2 + Kiyas3 + Kiyas4));
        }
        public void Cevap(){
            
            char_input1.Series[5].Points.AddXY(cevap, 0);
            char_input1.Series[5].Points.AddXY(cevap, 1);
            Cevap_label.Text=cevap.ToString();  
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            yakınlasma();
            Cevap();
            char_input1.Series[0].Points.AddXY(0,1);
            char_input1.Series[0].Points.AddXY(0.5, 1);
            char_input1.Series[0].Points.AddXY(1, 0);

            char_input1.Series[1].Points.AddXY(0, 0);
            char_input1.Series[1].Points.AddXY(1.5, 1);
            char_input1.Series[1].Points.AddXY(3, 0);
            char_input1.Series[1].Points.AddXY(6, 0);

            char_input1.Series[2].Points.AddXY(0, 0);
            char_input1.Series[2].Points.AddXY(2, 0);
            char_input1.Series[2].Points.AddXY(3, 1);
            char_input1.Series[2].Points.AddXY(4, 0);
            char_input1.Series[2].Points.AddXY(6, 0);

            char_input1.Series[3].Points.AddXY(0, 0);
            char_input1.Series[3].Points.AddXY(3.5, 0);
            char_input1.Series[3].Points.AddXY(4.25, 1);
            char_input1.Series[3].Points.AddXY(5, 0);
            char_input1.Series[3].Points.AddXY(6, 0);

            char_input1.Series[4].Points.AddXY(4.5, 0);
            char_input1.Series[4].Points.AddXY(5.25, 1);
            char_input1.Series[4].Points.AddXY(6, 1);
        }
    }
}
