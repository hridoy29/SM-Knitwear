using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMkneetware
{
    public partial class Setup : Form
    {
        private int ID = 0;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=103.125.254.20,9433;Initial Catalog = qt_infinigentdb; User ID = demo2; Password=BaalSaal420$");
        public Setup()
        {
            InitializeComponent();
            disp_data();
            Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO TRN_SMkneet_t VALUES('" + txtBoxId.Text + "', '" + textBoxIpAddress.Text + "', '" + textBoxPort.Text + "','" + textBoxLocation.Text + "','" + Convert.ToBoolean(checkBoxIsActive.Checked) + "') ";
            cmd.ExecuteNonQuery();

            sqlcon.Close();

            disp_data();
            Clear();

            MessageBox.Show("Sucessfully added...");
        }
        //GRID
        public void disp_data()
        {
            sqlcon.Open();


            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM TRN_SMkneet_t", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridViewSetup.DataSource = dtbl;
            sqlcon.Close();

        }
        //CLEAR
        public void Clear()
        {
            txtBoxId.Clear();
            textBoxIpAddress.Clear();
            textBoxPort.Clear();
            textBoxLocation.Clear();
            checkBoxIsActive.Checked = false;
        }

        private void dataGridViewSetup_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridViewSetup.Rows[e.RowIndex];
            ID= (int)row.Cells[0].Value;
            txtBoxId.Text= row.Cells[1].Value.ToString();
            textBoxIpAddress.Text = row.Cells[2].Value.ToString();
            textBoxPort.Text = row.Cells[3].Value.ToString();
            textBoxLocation.Text = row.Cells[4].Value.ToString();
            checkBoxIsActive.Checked = (bool)row.Cells[5].Value;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            String UpdateStatement = "UPDATE  TRN_SMkneet_t SET MachineId='" + txtBoxId.Text + "',IpAddress= '" + textBoxIpAddress.Text + "',port= '" + textBoxPort.Text + "',Address='" + textBoxLocation.Text + "',IsActive='" + Convert.ToBoolean(checkBoxIsActive.Checked) + "' WHERE Id=" + ID;
            cmd.CommandText = UpdateStatement;
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            disp_data();
            Clear();
        }
    }
}
