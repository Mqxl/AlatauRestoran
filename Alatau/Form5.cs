using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet3.Officiant". При необходимости она может быть перемещена или удалена.
            this.officiantTableAdapter1.Fill(this.restoranDataSet3.Officiant);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet123.Officiant". При необходимости она может быть перемещена или удалена.
            this.officiantTableAdapter.Fill(this.restoranDataSet123.Officiant);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet1.HotFood". При необходимости она может быть перемещена или удалена.
            this.hotFoodTableAdapter.Fill(this.restoranDataSet1.HotFood);

        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
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
    }
}
