using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat24012020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1 = 0;
        int sayı2 = 0;
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rst = new Random();
            int sayı1 = rst.Next(0, 1000);
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sayı2 = int.Parse(textBox1.Text);

                if (sayı1 < sayı2)
                {
                    label3.Text = "Daha küçük bir sayı giriniz :)";
                    sayac += 1;
                    textBox1.Clear();
                }
                if (sayı1 > sayı2)
                {
                    label3.Text = "Daha Büyük bir sayı giriniz :)";
                    sayac += 1;
                    textBox1.Text = "";
                }
                if (sayı1 == sayı2)
                {
                    label3.Text = "Tebrikler " + sayac.ToString() + ". deneme de Doğru sayıya ulaştınız";
                    textBox1.Text = "";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız lütfen bir sayı giriniz:)");
                textBox1.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "başarılar";
            sayı2 = 0;
            Random rst = new Random();
            sayı1 = rst.Next(0, 1000);
            sayac = 0;
        }
    }
}
