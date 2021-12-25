using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RestoranDataSet3.Cassir". При необходимости она может быть перемещена или удалена.
            this.CassirTableAdapter.Fill(this.RestoranDataSet3.Cassir);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
