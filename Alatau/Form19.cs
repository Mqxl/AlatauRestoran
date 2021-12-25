using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet4.Napitki". При необходимости она может быть перемещена или удалена.
            this.napitkiTableAdapter.Fill(this.restoranDataSet4.Napitki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet4.Zakuski". При необходимости она может быть перемещена или удалена.
            this.zakuskiTableAdapter.Fill(this.restoranDataSet4.Zakuski);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].FormattedValue.ToString().Contains(textBox2.Text))
                {

                    dataGridView1.Rows[i].Selected = true;
                }

                else if (dataGridView1.Rows[i].Cells[1].FormattedValue.ToString().Contains(textBox2.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                }
                else if (dataGridView1.Rows[i].Cells[2].FormattedValue.ToString().Contains(textBox2.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                }

                else if (dataGridView1.Rows[i].Cells[3].FormattedValue.ToString().Contains(textBox2.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                }
                else
                {
                    dataGridView1.Rows[i].Selected = false;



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int b = 0; b <= dataGridView2.Rows.Count - 1; b++)
            {
                if (dataGridView2.Rows[b].Cells[0].FormattedValue.ToString().Contains(textBox1.Text))
                {

                    dataGridView2.Rows[b].Selected = true;
                }

                else if (dataGridView2.Rows[b].Cells[1].FormattedValue.ToString().Contains(textBox1.Text))
                {
                    dataGridView2.Rows[b].Selected = true;
                }
                else if (dataGridView2.Rows[b].Cells[2].FormattedValue.ToString().Contains(textBox1.Text))
                {
                    dataGridView2.Rows[b].Selected = true;
                }



                else
                {
                    dataGridView2.Rows[b].Selected = false;



                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int b = 0; b <= dataGridView2.Rows.Count - 1; b++)
            {
                dataGridView2.Rows[b].Selected = false;
            }

        }
    }
}
