using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double mocnina = 0;
        long faktorial = 1;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mocnina = 1;
            if (checkBox1.Checked && textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    double a = Convert.ToInt32(textBox1.Text);
                    double n = Convert.ToInt32(textBox2.Text);
                    if (n == 0) label4.Text = "Mocnina A na N je 1";
                    if (n > 0)
                    {
                        for (int i = 0; n > i; i++)
                        {
                            mocnina *= a;
                        }
                    }
                    else
                    {
                        for (int i = 0; n < i; i--)
                        {
                            mocnina *= a;
                        }
                        mocnina = 1 / mocnina;
                    }
                    label4.Text = "A na N je " + Convert.ToString(mocnina);
                }
                catch
                {
                    MessageBox.Show("Nějaký problém", "ERROR", MessageBoxButtons.OK);
                }
            }
            else label4.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            faktorial = 1;
            if (textBox2.Text != "" && checkBox2.Checked)
            {
                try
                {
                    int n = Convert.ToInt32(textBox2.Text);
                    if (n >= 21)
                    {
                        label6.Text = "Bohužel číslo je moc velké, přesáhlo by to rozsah";
                    }
                    else
                    {
                        if (n >= 0)
                        {
                            for (int i = n; i > 0; i--)
                            {
                                faktorial *= i;
                            }
                            label6.Text = "Faktoriál N! je " + Convert.ToString(faktorial);
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Nějaký problém", "ERROR", MessageBoxButtons.OK);
                }
            }
            else label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pokud ti nefunguje faktoriál, zkontroluj zda jsi zadal u čísla N pouze číslo větší nebo rovne 0, jinak se ti faktoriál nevypočítá. U mocniny tento problém není.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
