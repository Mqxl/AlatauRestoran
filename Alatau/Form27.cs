using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.timer1.Enabled = true;
            this.timer2.Enabled = true;















        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string povar = "Повар";
            string povar1 = "Менеджер";
            string povar2 = "Кассир";
            string povar3 = "Официант";
            int b = 3000;
            int b1 = 3800;
            int b2 = 2600;
            int b3 = 2400;
            string s = textBox1.Text;
            int n = Convert.ToInt32(s);

            if (comboBox1.Text == povar && progressBar1.Value == 100)
            {
                int a = n * b;
                label3.Text = textBox1.Text;
                string f = Convert.ToString(a);
                label4.Text = f;
                label4.Visible = true;
                label3.Visible = true;
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;



            }
            else if (comboBox1.Text == povar1 && progressBar1.Value == 100)
            {
                int a = n * b1;
                label3.Text = textBox1.Text;
                string f = Convert.ToString(a);
                label4.Text = f;
                label4.Visible = true;
                label3.Visible = true;
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;


            }
            else if (comboBox1.Text == povar2 && progressBar1.Value == 100)
            {
                int a = n * b2;
                label3.Text = textBox1.Text;
                string f = Convert.ToString(a);
                label4.Text = f;
                label4.Visible = true;
                label3.Visible = true;
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;


            }
            else if (comboBox1.Text == povar3 && progressBar1.Value == 100)
            {
                int a = n * b3;
                label3.Text = textBox1.Text;
                string f = Convert.ToString(a);
                label4.Text = f;
                label4.Visible = true;
                label3.Visible = true;
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            this.timer1.Enabled = false;
            this.timer2.Enabled = false;
            label4.Visible = false;
            label3.Visible = false;

        }
    }
}

