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
    public struct User
    {
        public string Login;
        public string Password;
    }
    public partial class Form1 : Form
    {
        public static User autoriz = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BNOAC_Click(object sender, EventArgs e)
        {
            REGISTRATION reg = new REGISTRATION();
            reg.Show();
            this.Hide();
        }

        private void BAUTH_Click(object sender, EventArgs e)
        {
            if (TLOG.Text == "" && TPASS.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool k = false;
                foreach (AUTH user in Program.Zab.AUTH)
                {
                    if (TLOG.Text == user.Login && TPASS.Text == user.Password)
                    {
                        k = true;
                        autoriz.Login = user.Login;
                        autoriz.Password = user.Password;
                    }
                }
                if (!k)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TLOG.Text = "";
                    TPASS.Text = "";
                }
                else
                {
                    Main menu = new Main();
                    menu.Show();
                    this.Hide();
                }
            }
        }
    }
}
