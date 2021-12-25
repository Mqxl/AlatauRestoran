using System;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RestoranDataSet8.skld". При необходимости она может быть перемещена или удалена.
            this.skldTableAdapter.Fill(this.RestoranDataSet8.skld);

            this.reportViewer1.RefreshReport();
        }
    }
}
