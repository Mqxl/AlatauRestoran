using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet4.Desert". При необходимости она может быть перемещена или удалена.
            this.desertTableAdapter.Fill(this.restoranDataSet4.Desert);

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].Width = 1500;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[1].Width = 1500;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[2].Width = 1500;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
