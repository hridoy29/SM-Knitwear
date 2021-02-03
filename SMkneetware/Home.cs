using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMkneetware
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SETUP_Click(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            setup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PushData pushData = new PushData();
            pushData.Show();
        }
    }
}
