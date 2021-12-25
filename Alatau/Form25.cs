using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Alatau
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet10.stol". При необходимости она может быть перемещена или удалена.
            this.stolTableAdapter.Fill(this.restoranDataSet10.stol);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-78G7HDS;Initial Catalog=Restoran;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn1;
            conn1.Open();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "DELETE FROM dbo.stol;";

            cmd1.ExecuteNonQuery();
            conn1.Close();
            
            MessageBox.Show("Бронь снята");
            this.Controls.Clear();
            this.InitializeComponent();



        }

        
    }
}
