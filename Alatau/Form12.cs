using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RestoranDataSet3.Manager". При необходимости она может быть перемещена или удалена.
            this.ManagerTableAdapter.Fill(this.RestoranDataSet3.Manager);

            this.reportViewer1.RefreshReport();
        }
    }
}
