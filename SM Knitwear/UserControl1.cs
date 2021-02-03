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

namespace SM_Knitwear
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=WASEQ-WINDOWS;Initial Catalog = SMKnitwearDB; User ID = sa; Password=Retail123#");
        

        public UserControl1()
        {
            InitializeComponent();
        }

        //ADD
        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Machine_info values('" + textBox_machineID.Text + "', '" + textBox_name.Text + "', '" + textBox_location.Text + "', '" + textBox_ip.Text + "', '" + textBox_port.Text + "', '" + Convert.ToBoolean(checkBox1.Checked) + "') ";
            cmd.ExecuteNonQuery();

            sqlcon.Close();

            disp_data();

            MessageBox.Show("Added");             

                    
                               
        }


        //GRID
        public void disp_data()
        {
            sqlcon.Open();           


            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Machine_info", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dataGridView1.DataSource = dtbl;

            sqlcon.Close();


        }

        
        //UPDATE
        
        
        private void button2_Click(object sender, EventArgs e)
        {

           


        }
        

        //DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Machine_info where name=('" + textBox_machineID.Text + "', '" + textBox_name.Text + "', '" + textBox_location.Text + "', '" + textBox_ip.Text + "', '" + textBox_port.Text + "', '" + Convert.ToBoolean(checkBox1.Checked) + "') ";
            cmd.ExecuteNonQuery();

            sqlcon.Close();

            disp_data();

            MessageBox.Show("Deleted");

            

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
