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

namespace sql_CURD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address = textBox2.Text;
            string age = textBox3.Text;
            string ConnectionString = "Data Source=FATEMEHYEGANEH\\SQLEXPRESS;Initial Catalog=EF-MVC-DB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "INSERT INTO Teachers (teacherName,TeacherAddress,TeacherAge) " +
                "VALUES('"+name+"','"+address+"','"+age+"')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data has been saved!");
        }
    }
}
