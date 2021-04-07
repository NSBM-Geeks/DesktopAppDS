using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace DSystem
{
    public partial class Login : Form
    {
       




        public Login()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "mE0UoopgWaiJTaJIysrSBRIXu7IDwok2ZAECGT6K",
            BasePath = "https://dsystem-c9b50-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;

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
            FirebaseResponse res = client.Get(@"Users/" + txtUname.Text);
            MyUser ResUser = res.ResultAs<MyUser>();// database result

            MyUser CurUser = new MyUser() // USER GIVEN INFO
            {
                UserName = txtUname.Text,
                Password = txtPwd.Text
            };

            if (MyUser.IsEqual(ResUser, CurUser))
            {
                Form1 real = new Form1();
                real.ShowDialog();
            }

            else
            {
                MyUser.ShowError();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("error!");
            }
        }
    }
}
