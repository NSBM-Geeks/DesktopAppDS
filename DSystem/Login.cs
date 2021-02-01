using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSystem
{
    public partial class Login : Form
    {

        

        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database= coopdb");




        public Login()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Red;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            String username = txtUname.Text;
            String password = txtPwd.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @user and `Password` = @pass", db.GetConnection());

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if(table.Rows.Count>0)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }

        }
    }
}
