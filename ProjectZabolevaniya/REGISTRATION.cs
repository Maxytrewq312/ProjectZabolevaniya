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
    public partial class REGISTRATION : Form
    {
        public REGISTRATION()
        {
            InitializeComponent();
        }

        private void BREG_Click(object sender, EventArgs e)
        {
            REGA reg = new REGA();
            reg.Name = TNAMER.Text;
            reg.Surname = TSURNAMER.Text;
            reg.Login = TLOGR.Text;
            reg.Password = TPASSR.Text;
            AUTH aut = new AUTH();
            aut.Login = TLOGR.Text;
            aut.Password = TPASSR.Text;
            Program.Zab.REGA.Add(reg);
            Program.Zab.AUTH.Add(aut);
            Program.Zab.SaveChanges();
            Main m = new Main();
            m.Show();
            this.Hide();
        }
    }
}
