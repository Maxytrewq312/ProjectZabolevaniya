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
    public partial class EMPLOYEE : Form
    {
        public EMPLOYEE()
        {
            InitializeComponent();
            ShowPos();
            ShowEmp();
        }
        void ShowPos()
        {
            CBPOSITION.Items.Clear();
            foreach (Position pos in Program.Zab.Position)
            {
                string[] item = { pos.IdPos.ToString() + '.', pos.NamePos };
                CBPOSITION.Items.Add(string.Join(" ", item));
            }
        }

        private void BBACK_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        void ShowEmp()
        {
            listView1.Items.Clear();
            foreach (Employees emp in Program.Zab.Employees)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    emp.IdEmp.ToString(), emp.Surname, emp.Name,
                    emp.Patronymic, emp.Birth.ToString(), emp.Gender, emp.Position.ToString()
                });
                item.Tag = emp;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void BADD_Click(object sender, EventArgs e)
        {
            if (CBPOSITION.SelectedItem != null && TSURNAME.Text != null && TNAME.Text != "" && TPATRO.Text != null && TDATEBIRTH.Text != "" && TGENDER.Text != null && TPLACE.Text != "")
            {
                Employees em = new Employees();
                em.Surname = Convert.ToString(TSURNAME.Text);
                em.Name = Convert.ToString(TNAME.Text);
                em.Patronymic = Convert.ToString(TPATRO.Text);
                em.Birth = Convert.ToDateTime(TDATEBIRTH.Text);
                em.Gender = Convert.ToString(TGENDER.Text);
                em.Place = Convert.ToString(TPLACE.Text);
                em.IdPos = Convert.ToInt32(CBPOSITION.SelectedItem.ToString().Split('.')[0]);
                Program.Zab.Employees.Add(em);
                Program.Zab.SaveChanges();
                ShowEmp();
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
                Employees em = new Employees();
                em.Surname = Convert.ToString(TSURNAME.Text);
                em.Name = Convert.ToString(TNAME.Text);
                em.Patronymic = Convert.ToString(TPATRO.Text);
                em.Birth = Convert.ToDateTime(TDATEBIRTH.Text);
                em.Gender = Convert.ToString(TGENDER.Text);
                em.Place = Convert.ToString(TPLACE.Text);
                em.IdPos = Convert.ToInt32(CBPOSITION.SelectedItem.ToString().Split('.')[0]);
                Program.Zab.SaveChanges();
                ShowEmp();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Employees emp = listView1.SelectedItems[0].Tag as Employees;
                TSURNAME.Text = emp.Surname;
                TNAME.Text = emp.Name;
                TPATRO.Text = emp.Patronymic;
                TDATEBIRTH.Text = emp.Birth.ToString();
                TGENDER.Text = emp.Gender;
                TPLACE.Text = emp.Place;
                CBPOSITION.SelectedIndex = CBPOSITION.FindString(emp.IdEmp.ToString());
            }
            else
            {
                TSURNAME.Text = "";
                TNAME.Text = "";
                TPATRO.Text = "";
                TDATEBIRTH.Text = "";
                TGENDER.Text = "";
                TPLACE.Text = "";
                CBPOSITION.SelectedItem = null;
            }
        }

        private void BREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Employees emp = listView1.SelectedItems[0].Tag as Employees;
                    Program.Zab.Employees.Remove(emp);
                    Program.Zab.SaveChanges();
                    ShowEmp();
                }
                TSURNAME.Text = "";
                TNAME.Text = "";
                TPATRO.Text = "";
                TDATEBIRTH.Text = "";
                TGENDER.Text = "";
                TPLACE.Text = "";
                CBPOSITION.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
