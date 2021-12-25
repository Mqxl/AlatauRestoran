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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            
            


            SqlConnection conn1 = new SqlConnection("Data Source=DESKTOP-78G7HDS;Initial Catalog=Restoran;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn1;
            conn1.Open();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "INSERT INTO dbo.stol (Столик,Имя,Дата)" +
                "VALUES (@stol,@name,@data)";
            cmd1.Parameters.AddWithValue("@stol", comboBox1.Text);
            cmd1.Parameters.AddWithValue("@name", textBox1.Text);
            cmd1.Parameters.AddWithValue("@data", dateTimePicker1.Value);
            cmd1.ExecuteNonQuery();
            conn1.Close();
        }
    }
}
