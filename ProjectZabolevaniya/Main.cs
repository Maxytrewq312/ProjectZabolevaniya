using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectZabolevaniya
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BEMP_Click(object sender, EventArgs e)
        {
            EMPLOYEE emp = new EMPLOYEE();
            emp.Show();
            this.Hide();
        }

        private void BSTAT_Click(object sender, EventArgs e)
        {
            STATUSS st = new STATUSS();
            st.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BMON_Click(object sender, EventArgs e)
        {
            MONITORINGG mon = new MONITORINGG();
            mon.Show();
            this.Hide();
        }
    }
}
