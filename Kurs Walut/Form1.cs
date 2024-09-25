using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Kurs_Walut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string value1 = textBox1.Text;
            textBox1.Text = value1;
            float number = float.Parse(value1);
            if (FUSD.Checked)
            {
                if (value1 != string.Empty && TEUR.Checked)
                {
                    textBox2.Text = (number * 0.89f).ToString();
                }
                else if (value1 != string.Empty && TUAH.Checked)
                {
                    textBox2.Text = (number * 41.42f).ToString();
                }
                else if (value1 != string.Empty && TTHB.Checked)
                {
                    textBox2.Text = (number * 32.67f).ToString();
                }
                else if (value1 != string.Empty && TPLN.Checked)
                {
                    textBox2.Text = (number * 3.81f).ToString();
                } 
                else
                {
                    textBox2.Text = number.ToString();
                }
            }
            if (FEUR.Checked)
            {
                if (value1 != string.Empty && TUSD.Checked)
                {
                    textBox2.Text = (number * 1.12f).ToString();
                }
                else if (value1 != string.Empty && TUAH.Checked)
                {
                    textBox2.Text = (number * 46.22f).ToString();
                }
                else if (value1 != string.Empty && TTHB.Checked)
                {
                    textBox2.Text = (number * 36.60f).ToString();
                }
                else if (value1 != string.Empty && TPLN.Checked)
                {
                    textBox2.Text = (number * 4.26f).ToString();
                }
                else
                {
                    textBox2.Text = (number).ToString();
                }
            }
            if (FUAH.Checked)
            {
                if (value1 != string.Empty && TEUR.Checked)
                {
                    textBox2.Text = (number * 0.022f).ToString();
                }
                else if (value1 != string.Empty && TUSD.Checked)
                {
                    textBox2.Text = (number * 0.024).ToString();
                }
                else if (value1 != string.Empty && TTHB.Checked)
                {
                    textBox2.Text = (number * 0.79).ToString();
                }
                else if (value1 != string.Empty && TPLN.Checked)
                {
                    textBox2.Text = (number * 0.092).ToString();
                }
                else
                {
                    textBox2.Text = (number).ToString();
                }
            }
            if (FTHB.Checked)
            {
                if (value1 != string.Empty && TEUR.Checked)
                {
                    textBox2.Text = (number * 0.027f).ToString();
                }
                else if (value1 != string.Empty && TUAH.Checked)
                {
                    textBox2.Text = (number * 1.26).ToString();
                }
                else if (value1 != string.Empty && TUSD.Checked)
                {
                    textBox2.Text = (number * 0.031).ToString();
                }
                else if (value1 != string.Empty && TPLN.Checked)
                {
                    textBox2.Text = (number * 0.12).ToString();
                }
                else
                {
                    textBox2.Text = (number).ToString();
                }
            }
            if (FPLN.Checked)
            {
                if (value1 != string.Empty && TEUR.Checked)
                {
                    textBox2.Text = (number * 0.23f).ToString();
                }
                else if (value1 != string.Empty && TUAH.Checked)
                {
                    textBox2.Text = (number * 10.85).ToString();
                }
                else if (value1 != string.Empty && TTHB.Checked)
                {
                    textBox2.Text = (number * 8.59).ToString();
                }
                else if (value1 != string.Empty && TUSD.Checked)
                {
                    textBox2.Text = (number * 0.26).ToString();
                }
                else
                {
                    textBox2.Text = (number).ToString();
                }
            }
            void textBoxReset()
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
        }
    }
}
