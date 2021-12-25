using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form16 form2 = new Form16();
            form2.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.ShowDialog();

        }

        private void расчетЗарплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form27 form27 = new Form27();
            form27.ShowDialog();

        }
    }
}
