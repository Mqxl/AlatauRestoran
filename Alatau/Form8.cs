using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RestoranDataSet3.Povar". При необходимости она может быть перемещена или удалена.
            this.PovarTableAdapter.Fill(this.RestoranDataSet3.Povar);

            this.reportViewer1.RefreshReport();
        }
    }
}
