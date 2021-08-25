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

namespace Database
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-UFMBHAH; Initial Catalog=dbTest;Integrated Security=True;");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Vaccine values('" + txtID.Text + "' , '" + txtName.Text + "' , '" + txtSurname.Text + "')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved in database");
            con.Close();

            txtID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
