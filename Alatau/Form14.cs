using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = "Selim";
            string pas = "12345";
            if (textBox1.Text == log && textBox2.Text == pas)
            {
                MessageBox.Show("Добро пожаловать!!");
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form13 form13 = new Form13();
            form13.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
