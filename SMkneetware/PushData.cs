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
    public partial class PushData : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=103.125.254.20,9433;Initial Catalog = qt_infinigentdb; User ID = demo2; Password=BaalSaal420$");

        public PushData()
        {
            InitializeComponent();
            disp_data();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {

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
    }
}
