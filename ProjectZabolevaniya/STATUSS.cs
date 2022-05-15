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
    public partial class STATUSS : Form
    {
        public STATUSS()
        {
            InitializeComponent();
            ShowEmp();
            ShowSt();
        }

        void ShowEmp()
        {
            CBEMPS.Items.Clear();
            foreach (Employees em in Program.Zab.Employees)
            {
                string[] item = { em.IdEmp.ToString() + '.', em.Name, em.Surname };
                CBEMPS.Items.Add(string.Join(" ", item));
            }
        }

        void ShowSt()
        {
            listView1.Items.Clear();
            foreach (Status st in Program.Zab.Status)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    st.IdStatus.ToString(), st.Simptoms, st.Stepen,
                    st.DatePrim.ToString(), st.Employees.ToString() });
                item.Tag = st;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void BADD_Click(object sender, EventArgs e)
        {
            if (TSIMP.Text != "" && TSTEP.Text != null && TDATEPRIM.Text != null && CBEMPS.SelectedItem != null)
            {
                Status st = new Status();
                st.Simptoms = Convert.ToString(TSIMP.Text);
                st.Stepen = Convert.ToString(TSTEP.Text);
                st.DatePrim = Convert.ToDateTime(TDATEPRIM.Text);
                st.IdEmp = Convert.ToInt32(CBEMPS.SelectedItem.ToString().Split('.')[0]);
                Program.Zab.Status.Add(st);
                Program.Zab.SaveChanges();
                ShowSt();
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
                Status st = new Status();
                st.Simptoms = Convert.ToString(TSIMP.Text);
                st.Stepen = Convert.ToString(TSTEP.Text);
                st.DatePrim = Convert.ToDateTime(TDATEPRIM.Text);
                st.IdEmp = Convert.ToInt32(CBEMPS.SelectedItem.ToString().Split('.')[0]);
                Program.Zab.SaveChanges();
                ShowSt();
            }
        }

        private void BREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Status st = listView1.SelectedItems[0].Tag as Status;
                    Program.Zab.Status.Remove(st);
                    Program.Zab.SaveChanges();
                    ShowSt();
                }
                TSIMP.Text = "";
                TSTEP.Text = "";
                TDATEPRIM.Text = "";
                CBEMPS.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Status st = listView1.SelectedItems[0].Tag as Status;
                TSIMP.Text = st.Simptoms;
                TSTEP.Text = st.Stepen;
                TDATEPRIM.Text = st.DatePrim.ToString();
                CBEMPS.SelectedIndex = CBEMPS.FindString(st.IdEmp.ToString());
            }
            else
            {
                TSIMP.Text = "";
                TSTEP.Text = "";
                TDATEPRIM.Text = "";
                CBEMPS.SelectedItem = null;
            }
        }
    }
}
