using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace İleri_seviye_hesap_makinesi
{
    public partial class Form1 : Form
    {
        private string _islem;
        private double _ilksayi;
        private double _ikinciSayi;
        private double radyan;
        private bool _ekrantemizle;
        public double _ozet;
        double _sonuc = 0;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void b4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "4";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "1";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "0";

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "3";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) { t1.Text = ""; _ekrantemizle = false; }
            if (t1.Text == "0") { t1.Text = ""; }
            t1.Text += "9";
        }

        private void bartı_Click(object sender, EventArgs e)
        {
            _islem ="+";
            _ekrantemizle = true;
            _ilksayi=Convert.ToDouble(t1.Text);
            ekranOzet.Text = _ilksayi + "+";
        }

        private void beksi_Click(object sender, EventArgs e)
        {
            _islem = "-";

            _ilksayi= Convert.ToDouble(t1.Text);
            ekranOzet.Text = _ilksayi + "-";
            t1.Text = "0";
        }

        private void bcarpma_Click(object sender, EventArgs e)
        {
            _islem ="x";
            _ekrantemizle = true;
            _ilksayi = Convert.ToDouble(t1.Text);
            ekranOzet.Text = _ilksayi + "x";
        }

        private void bbolme_Click(object sender, EventArgs e)
        {
            _islem= "÷";
            _ekrantemizle = true;
            _ilksayi = Convert.ToDouble(t1.Text);
            ekranOzet.Text = _ilksayi + "÷";
        }

        private void besit_Click(object sender, EventArgs e)
        {
           
            double _sonuc=0;
            if (_islem=="+")  
            {
                _ikinciSayi = Convert.ToDouble(t1.Text);
                t1.Text += _ikinciSayi;
                _sonuc = (_ilksayi + _ikinciSayi);

                t1.Text = _sonuc.ToString();
                ekranOzet.Text = _ilksayi + "+" + _ikinciSayi + "="+_sonuc;

            }
            if (_islem == "-")  //-6 dedikten sonra = basınca ekranda gözüküyor hocam
            {
                _ikinciSayi = Convert.ToDouble(t1.Text);
                t1.Text += _ikinciSayi;
                _sonuc = (_ilksayi - _ikinciSayi);

                t1.Text = _sonuc.ToString();
                ekranOzet.Text = _ilksayi + "-" + _ikinciSayi + "=" + _sonuc;


            }
            if (_islem == "x")
            {
                _ikinciSayi = Convert.ToDouble(t1.Text);
                t1.Text += _ikinciSayi;
                _sonuc = (_ilksayi * _ikinciSayi);

                t1.Text = _sonuc.ToString();
                ekranOzet.Text = _ilksayi + "x" + _ikinciSayi + "=" + _sonuc;
            }
            if (_islem == "÷")
            {
                _ikinciSayi = Convert.ToDouble(t1.Text);
                t1.Text += _ikinciSayi;
                _sonuc = (_ilksayi / _ikinciSayi);

                t1.Text = _sonuc.ToString();
                ekranOzet.Text = _ilksayi + "÷" + _ikinciSayi + "=" + _sonuc;

            }

            

            if (_islem=="sin")  
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                 radyan = _ilksayi * Math.PI / 180;
                _sonuc = Math.Sin(radyan);
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = " sin"+_ilksayi +"=" + _sonuc;

            }
            if (_islem == "cos")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                radyan = _ilksayi * Math.PI / 180;
                _sonuc = Math.Cos(radyan);
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = " cos" + _ilksayi + "=" + _sonuc;
            }
            if (_islem == "tan")
            {
                
                _ilksayi = Convert.ToDouble(t1.Text);
                radyan = _ilksayi * Math.PI / 180;
                _sonuc = Math.Tan(radyan);
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = " tan" + _ilksayi + "=" + _sonuc;
            }
            if (_islem == "arctan")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                _sonuc = Math.Atan(_ilksayi) * 180 / Math.PI;

                t1.Text = _sonuc.ToString();
                ekranOzet.Text = " arctan" + _ilksayi + "=" + _sonuc;
            }
                if (_islem == "arccos")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                _sonuc = Math.Acos(_ilksayi) * 180 / Math.PI;
               
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = " arccos" + _ilksayi + "=" + _sonuc;
            }
            if (_islem == "arcsin")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                _sonuc = Math.Asin(_ilksayi)*180/Math.PI;

                t1.Text = _sonuc.ToString();
                ekranOzet.Text = " arcsin" + _ilksayi + "=" + _sonuc;
            }
                if (_islem == "ln")
            {
                _ilksayi = Convert.ToDouble(t1.Text);

                _sonuc = Math.Log(_ilksayi);
                 t1.Text = _sonuc.ToString();
                ekranOzet.Text += + _ilksayi + "=" + _sonuc;
            }
            if(_islem == "log10(x)")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                _sonuc = Math.Log10(_ilksayi);
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = " log" + (_ilksayi) + "=" + _sonuc;
            }
            if (_islem == "x²")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                _sonuc = _ilksayi*_ilksayi;
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = (_ilksayi) + "²"+ " = " + _sonuc;
            }
            if (_islem == "√x")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                _sonuc = Math.Sqrt(_ilksayi);
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = "√"+(_ilksayi) +" = " + _sonuc;
            }
            if (_islem == " x³")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                _sonuc = _ilksayi * _ilksayi*_ilksayi;
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = (_ilksayi) + "³" + " = " + _sonuc;
            }
            if (_islem == "x^")
            {
                _ikinciSayi = Convert.ToDouble(t1.Text);
                _sonuc = Math.Pow(_ilksayi,_ikinciSayi);
                t1.Text = _sonuc.ToString();    
                ekranOzet.Text += _ikinciSayi + "=" + _sonuc;
            }
            if (_islem == "1/x")
            {
                _ilksayi = Convert.ToDouble(t1.Text);
                _sonuc = 1 /_ilksayi;
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = "1/"+(_ilksayi) + " = " + _sonuc;
            }
            if (_islem == " |x|")
            {
                
                if (t1.Text != "")
                {
                    
                    _sonuc = Math.Abs(_ilksayi);
                    t1.Text = _sonuc.ToString();
                }
                else
                {
                    MessageBox.Show("Sayı girişi yaptıktan sonra işlem seçin", "İşlem Hatası");
                }
                ekranOzet.Text = "|" + (_ilksayi) + "|" + " = " + _sonuc;
            }
           
            
            if (_islem == "%")
            {
                
                _ikinciSayi = Convert.ToDouble(t1.Text);
                _sonuc = _ilksayi % _ikinciSayi;
                t1.Text = _sonuc.ToString();
                ekranOzet.Text = (_ilksayi) +"%"+(_ikinciSayi)+ " = " + _sonuc;
            }
              t1.Text=Convert.ToString(_sonuc);
            listBox1.Items.Add(ekranOzet.Text);
        }
        private void btemiz_Click(object sender, EventArgs e)
        {
            t1.Text = "0";
            ekranOzet.Text = "0";
        }
        private void bsilme_Click(object sender, EventArgs e)
        {
            int uzunluk = t1.Text.Length;
            if (uzunluk > 0)
            {
                t1.Text = t1.Text.Substring(0, uzunluk - 1);
            }
            t1.Focus();
            t1.SelectionStart = t1.Text.Length;
            t1.SelectionLength = 0;
        }
        private void bozet_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Yapılan işlem >>"+ekranOzet.Text);
        }
        private void bnokta_Click(object sender, EventArgs e)
        {
            if ((t1.Text == "") | (t1.Text.EndsWith(",")))
            {
                t1.Text += "";
            }
            else
            {
                t1.Text += ",";
            }     
        }
        private void bsin_Click(object sender, EventArgs e)
        {
            _islem ="sin";
        }
        private void btan_Click(object sender, EventArgs e)
        {
            _islem = "tan";
        }
        private void bcos_Click(object sender, EventArgs e)
        {
            _islem = "cos";
        }
        private void barccos_Click(object sender, EventArgs e)
        {
            _islem = "arccos";
        }
        private void barcsin_Click(object sender, EventArgs e)
        {
            _islem = "arcsin";
        }
        private void barctan_Click(object sender, EventArgs e)
        {
            _islem = "arctan";
        }
        private void bln_Click(object sender, EventArgs e)
        {
           _islem = "ln";
            ekranOzet.Text = "ln";
            t1.Text = "0";
        }
        private void blog10_Click(object sender, EventArgs e)
        {
            _islem = "log10(x)";
        }
        private void t1_TextChanged(object sender, EventArgs e)
        { }
        private void ekranOzet_TextChanged(object sender, EventArgs e)
        {
            t1.Text = ekranOzet.Text;
        }
        private void bxkare_Click(object sender, EventArgs e)
        {
            _islem = "x²";
        }
        private void büssü_Click(object sender, EventArgs e)
        {
          
                _ilksayi = Convert.ToDouble(t1.Text);
                _islem = "x^";
            ekranOzet.Text= t1.Text+"^";

            t1.Text = "0";

         
        }
        private void bussueksi_Click(object sender, EventArgs e)
        {
            _islem = "1/x";
        }

        private void bxkup_Click(object sender, EventArgs e)
        {
            _islem = " x³";
        }

        private void bkökx_Click(object sender, EventArgs e)
        {
            _islem = "√x";
        }

      
        private void button40_Click(object sender, EventArgs e) //OFF düğmesi ama sonradan değiştiremedim bir türlü
        {
            if (t1.Enabled == true)
            {
                t1.Text = "";
                t1.Enabled = false;
                b0.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                besit.Enabled = false;
                bnokta.Enabled = false;
                MessageBox.Show("Hesap Makinesi kapatılıyor ........", "Hesap Makinesi Bilgilendirme");
            }
            
        }

        private void bmod_Click(object sender, EventArgs e)
        {
            _ilksayi = Convert.ToDouble(t1.Text);
            _islem = "%";
            t1.Text = "0";

        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Yapılan işlemleri göstermek için
        {
            listBox1.Items.Add(ekranOzet.Text);
            Convert.ToInt16(t1.Text);
            t1.Clear();
        }

        private void bON_Click_1(object sender, EventArgs e)
        {
            if (t1.Enabled ==false)
            {
                t1.Text = "";
                t1.Enabled = true;
                b0.Enabled = true;
                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true;
                b5.Enabled = true;
                b6.Enabled = true;
                b7.Enabled = true;
                b8.Enabled = true;
                b9.Enabled = true;
                besit.Enabled = true;
                bnokta.Enabled = true;
                MessageBox.Show("Hesap Makinesi Açıldı.........", "Hesap Makinesi Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Hesap Makinesi işlem yapmaya hazır.........", "Hesap Makinesi Bilgilendirme");
            }
        }
    }
}
