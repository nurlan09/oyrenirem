using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBox1.Text);
            int end = Convert.ToInt32(textBox2.Text);
            int tekcem = 0;
            int teksay = 0;
            int cutcem = 0;
            int cutsay = 0;
            for (int i = start; i < end; i++)
            {
                if (i%2==0)
                {
                    cutcem += i;
                    cutsay++;

                }
                else
                {
                    tekcem += i;
                    teksay++;
                }
                label1.Text = tekcem.ToString();
                label2.Text = teksay.ToString();
                label3.Text = cutcem.ToString();
                label4.Text = cutsay.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBox1.Text);
            int end = Convert.ToInt32(textBox2.Text);
            int bolunencem = 0;
            int bolunensay = 0;
            for (int i = start; i <=end; i++)
            {
                if (i % 4==0 || i % 6==0) 
                {
                    bolunencem += i;
                    bolunensay++;
                }
                label1.Text = bolunencem.ToString();
                label4.Text = bolunensay.ToString();
            }
            {

            }
        }
    }
}
