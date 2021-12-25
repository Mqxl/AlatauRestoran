using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RestoranDataSet.HotFood". При необходимости она может быть перемещена или удалена.
            this.HotFoodTableAdapter.Fill(this.RestoranDataSet.HotFood);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RestoranDataSet123.Officiant". При необходимости она может быть перемещена или удалена.
            this.OfficiantTableAdapter.Fill(this.RestoranDataSet123.Officiant);



            this.reportViewer1.LocalReport.EnableExternalImages = true;


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
