using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;

namespace Alatau
{
    public partial class Заказ : Form
    {
        public Заказ()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet9.HotFood". При необходимости она может быть перемещена или удалена.
            this.hotFoodTableAdapter.Fill(this.restoranDataSet9.HotFood);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet9.Napitki". При необходимости она может быть перемещена или удалена.
            this.napitkiTableAdapter.Fill(this.restoranDataSet9.Napitki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet9.Pervoe". При необходимости она может быть перемещена или удалена.
            this.pervoeTableAdapter.Fill(this.restoranDataSet9.Pervoe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet9.Desert". При необходимости она может быть перемещена или удалена.
            this.desertTableAdapter.Fill(this.restoranDataSet9.Desert);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet9.Zakuski". При необходимости она может быть перемещена или удалена.
            this.zakuskiTableAdapter.Fill(this.restoranDataSet9.Zakuski);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Desert". При необходимости она может быть перемещена или удалена.
            this.desertTableAdapter.Fill(this.restoranDataSet9.Desert);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Pervoe". При необходимости она может быть перемещена или удалена.
            this.pervoeTableAdapter.Fill(this.restoranDataSet9.Pervoe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Zakuski". При необходимости она может быть перемещена или удалена.
            this.zakuskiTableAdapter.Fill(this.restoranDataSet9.Zakuski);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Napitki". При необходимости она может быть перемещена или удалена.
            this.napitkiTableAdapter.Fill(this.restoranDataSet9.Napitki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.HotFood". При необходимости она может быть перемещена или удалена.
            this.hotFoodTableAdapter.Fill(this.restoranDataSet9.HotFood);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.DataBindings.Clear();
                comboBox3.DataSource = hotFoodBindingSource1;
                comboBox3.DisplayMember = "Dish Name";
                textBox3.DataBindings.Add("Text", hotFoodBindingSource1, "Price", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox3.DataBindings.Clear();
                comboBox3.DataSource = pervoeBindingSource1;
                comboBox3.DisplayMember = "Название блюда";
                textBox3.DataBindings.Add("Text", pervoeBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {

            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox3.DataBindings.Clear();
                comboBox3.DataSource = desertBindingSource1;
                comboBox3.DisplayMember = "Название блюда";
                textBox3.DataBindings.Add("Text", desertBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox3.DataBindings.Clear();
                comboBox3.DataSource = zakuskiBindingSource1;
                comboBox3.DisplayMember = "Название";
                textBox3.DataBindings.Add("Text", zakuskiBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox3.DataBindings.Clear();
                comboBox3.DataSource = napitkiBindingSource2;
                comboBox3.DisplayMember = "Название";
                textBox3.DataBindings.Add("Text", napitkiBindingSource2, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                textBox2.DataBindings.Clear();
                comboBox2.DataSource = hotFoodBindingSource1;
                comboBox2.DisplayMember = "Dish Name";
                textBox2.DataBindings.Add("Text", hotFoodBindingSource1, "Price", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                textBox2.DataBindings.Clear();
                comboBox2.DataSource = pervoeBindingSource1;
                comboBox2.DisplayMember = "Название блюда";
                textBox2.DataBindings.Add("Text", pervoeBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {

            }

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                textBox2.DataBindings.Clear();
                comboBox2.DataSource = desertBindingSource1;
                comboBox2.DisplayMember = "Название блюда";
                textBox2.DataBindings.Add("Text", desertBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                textBox2.DataBindings.Clear();
                comboBox2.DataSource = zakuskiBindingSource1;
                comboBox2.DisplayMember = "Название";
                textBox2.DataBindings.Add("Text", zakuskiBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                textBox2.DataBindings.Clear();
                comboBox2.DataSource = napitkiBindingSource1;
                comboBox2.DisplayMember = "Название";
                textBox2.DataBindings.Add("Text", napitkiBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                textBox1.DataBindings.Clear();
                comboBox1.DataSource = hotFoodBindingSource1;
                comboBox1.DisplayMember = "Dish Name";
                textBox1.DataBindings.Add("Text", hotFoodBindingSource1, "Price", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                textBox1.DataBindings.Clear();
                comboBox1.DataSource = pervoeBindingSource1;
                comboBox1.DisplayMember = "Название блюда";
                textBox1.DataBindings.Add("Text", pervoeBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {

            }

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                textBox1.DataBindings.Clear();
                comboBox1.DataSource = desertBindingSource1;
                comboBox1.DisplayMember = "Название блюда";
                textBox1.DataBindings.Add("Text", desertBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                textBox1.DataBindings.Clear();
                comboBox1.DataSource = zakuskiBindingSource1;
                comboBox1.DisplayMember = "Название";
                textBox1.DataBindings.Add("Text", zakuskiBindingSource1, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                textBox1.DataBindings.Clear();
                comboBox1.DataSource = napitkiBindingSource2;
                comboBox1.DisplayMember = "Название";
                textBox1.DataBindings.Add("Text", napitkiBindingSource2, "Цена", false, DataSourceUpdateMode.OnPropertyChanged);
            }
            else
            {


            }

        }

        private string result = "";
        private void button2_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = "Строка 1\n\n";

            result += "Строка 2\nСтрока 3";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox3.Text;
            label3.Text = comboBox2.Text;
            label4.Text = comboBox1.Text;

            label5.Text = textBox3.Text;
            label6.Text = textBox2.Text;
            label7.Text = textBox1.Text;

            string s = textBox3.Text;
            int n = Convert.ToInt32(s);

            string d = textBox2.Text;
            int z = Convert.ToInt32(d);

            string b = textBox1.Text;
            int x = Convert.ToInt32(b);

            int h = n += z += x;

            string g = Convert.ToString(h);

            label9.Text = g;
            label10.Text = dateTimePicker1.Text;

            panel1.Visible = true;
            panel2.Visible = true;

            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            


        }
    }
}
