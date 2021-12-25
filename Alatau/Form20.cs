using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
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


                else
                {
                    dataGridView1.Rows[i].Selected = false;



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = 0;
            if (dataGridView1.Rows[b].Cells[0].FormattedValue.ToString().Contains(textBox2.Text))
            {

                dataGridView1.Rows[b].Selected = false;
            }

        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet7.skld". При необходимости она может быть перемещена или удалена.
            this.skldTableAdapter.Fill(this.restoranDataSet7.skld);
            dataGridView1.AutoGenerateColumns = true;





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void отчеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form21 form21 = new Form21();
            form21.ShowDialog();
        }
    }
}
