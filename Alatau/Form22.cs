using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alatau
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Заказ form23 = new Заказ();
            form23.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form24 form24 = new Form24();
            form24.ShowDialog();
        }
    }
}
