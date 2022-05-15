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
    public partial class MONITORINGG : Form
    {
        public MONITORINGG()
        {
            InitializeComponent();
            ShowStat();
            ShowEmp();
            ShowMon();
        }

        void ShowStat()
        {
            CBSTATUS.Items.Clear();
            foreach (Status st in Program.Zab.Status)
            {
                string[] item = { st.IdStatus.ToString() + '.', st.Stepen };
                CBSTATUS.Items.Add(string.Join(" ", item));
            }
        }
        void ShowEmp()
        {
            CBEMPM.Items.Clear();
            foreach (Employees em in Program.Zab.Employees)
            {
                string[] item = { em.IdEmp.ToString() + '.', em.Name, em.Surname };
                CBEMPM.Items.Add(string.Join(" ", item));
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        void ShowMon()
        {
            listView1.Items.Clear();
            foreach (Monitoring mon in Program.Zab.Monitoring)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    mon.IdMon.ToString(), mon.DateBegin.ToString(), mon.DateExit.ToString(),
                    mon.Status.ToString(), mon.Employees.ToString() });
                item.Tag = mon;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void BADD_Click(object sender, EventArgs e)
        {
            if (TBEGIN.Text != "" && TEXIT.Text != null && CBSTATUS.SelectedItem != null && CBEMPM.SelectedItem != null)
            {
                Monitoring mon = new Monitoring();
                mon.DateBegin = Convert.ToDateTime(TBEGIN.Text);
                mon.DateExit = Convert.ToDateTime(TEXIT.Text);
                mon.IdStatus = Convert.ToInt32(CBSTATUS.SelectedItem.ToString().Split('.')[0]);
                mon.IdEmp = Convert.ToInt32(CBEMPM.SelectedItem.ToString().Split('.')[0]);
                Program.Zab.Monitoring.Add(mon);
                Program.Zab.SaveChanges();
                ShowMon();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BEDIT_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Monitoring mon = new Monitoring();
                mon.DateBegin = Convert.ToDateTime(TBEGIN.Text);
                mon.DateExit = Convert.ToDateTime(TEXIT.Text);
                mon.IdStatus = Convert.ToInt32(CBSTATUS.SelectedItem.ToString().Split('.')[0]);
                mon.IdEmp = Convert.ToInt32(CBEMPM.SelectedItem.ToString().Split('.')[0]);
                Program.Zab.SaveChanges();
                ShowMon();
            }
        }

        private void BREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Monitoring mon = listView1.SelectedItems[0].Tag as Monitoring;
                    Program.Zab.Monitoring.Remove(mon);
                    Program.Zab.SaveChanges();
                    ShowMon();
                }
                TBEGIN.Text = "";
                TEXIT.Text = "";
                CBSTATUS.SelectedItem = null;
                CBEMPM.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Monitoring mon = listView1.SelectedItems[0].Tag as Monitoring;
                TBEGIN.Text = mon.DateBegin.ToString();
                TEXIT.Text = mon.DateExit.ToString();
                CBSTATUS.SelectedIndex = CBSTATUS.FindString(mon.IdStatus.ToString());
                CBEMPM.SelectedIndex = CBEMPM.FindString(mon.IdEmp.ToString());
            }
            else
            {
                TBEGIN.Text = "";
                TEXIT.Text = "";
                CBSTATUS.SelectedItem = null;
                CBEMPM.SelectedItem = null;
            }
        }
    }
}
