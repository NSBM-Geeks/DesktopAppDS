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
    public partial class AddUsresUC : UserControl
    {
        public AddUsresUC()
        {
            InitializeComponent();
        }

      

        private void txtBoxFname_Enter(object sender, EventArgs e)
        {
         
        }

        private void txtBoxFname_Leave(object sender, EventArgs e)
        {
           
        }

       

        private void txtBoxLname_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtBoxLname_Leave(object sender, EventArgs e)
        {

        }

        private void txtBoxUname_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxUname_Leave(object sender, EventArgs e)
        {

        }

        private void txtBoxPwd_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtBoxPwd_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {

        }


        private void txtBoxPwdCon_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtBoxPwdCon_Leave(object sender, EventArgs e)
        {
          
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            AddUsersUC std = new AddUsersUC()
            {
                FirstName = txtBoxFname.Text,
                LastName = txtBoxLname.Text,
                UserName = txtBoxUname.Text,
                Email = txtBoxEmail.Text,
                
                Password = txtBoxPwd.Text,
                
            };

            SetResponse set = client.Set("Users/" + txtBoxUname.Text, std);
            
            MessageBox.Show("data inserted successfully");




        }


        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "mE0UoopgWaiJTaJIysrSBRIXu7IDwok2ZAECGT6K",
            BasePath = "https://dsystem-c9b50-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;



        private void AddUsresUC_Load(object sender, EventArgs e)
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

       

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearText();
        }

        public void clearText()
        {
            txtBoxFname.Text = "";
            txtBoxLname.Text = "";
            txtBoxEmail.Text = "";
            txtBoxUname.Text = "";
            txtBoxPwd.Text = "";

            MessageBox.Show("Text Boxes Cleared!");
        }
    }

}
