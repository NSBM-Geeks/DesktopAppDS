﻿using System;
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
    public partial class AddUsresUC : UserControl
    {
        public AddUsresUC()
        {
            InitializeComponent();
        }

        private void txtBoxFname_Enter(object sender, EventArgs e)
        {
            String fname = txtBoxFname.Text;
            if(fname.ToLower().Trim().Equals("First Name"))
            {
                txtBoxFname.Text = "";
                txtBoxFname.ForeColor = Color.Black;
            }
        }

        private void txtBoxFname_Leave(object sender, EventArgs e)
        {
            String fname = txtBoxFname.Text;
            if (fname.ToLower().Trim().Equals("First Name"))
            {
                txtBoxFname.Text = "First Name";
                txtBoxFname.ForeColor = Color.Gray;
            }
        }

       

        private void txtBoxLname_Enter(object sender, EventArgs e)
        {
            String lname = txtBoxLname.Text;
            if (lname.Equals("Last Name"))
            {
                txtBoxFname.Text = "";
                txtBoxFname.ForeColor = Color.Black;
            }
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
            String password = txtBoxPwd.Text;
            if(password.ToLower().Trim().Equals("password"))
            {
                txtBoxPwd.Text = "";
                txtBoxPwd.UseSystemPasswordChar = true;
                txtBoxPwd.ForeColor = Color.Black;
            }
        }

        private void txtBoxPwd_Leave(object sender, EventArgs e)
        {
            String password = txtBoxPwd.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                txtBoxPwd.Text = "password";
                txtBoxPwd.UseSystemPasswordChar = false;
                txtBoxPwd.ForeColor = Color.Gray;
            }
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {

        }


        private void txtBoxPwdCon_Enter(object sender, EventArgs e)
        {
            String cpassword = txtBoxPwdCon.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                txtBoxPwd.Text = "";
                txtBoxPwd.UseSystemPasswordChar = true;
                txtBoxPwd.ForeColor = Color.Black;
            }
        }

        private void txtBoxPwdCon_Leave(object sender, EventArgs e)
        {
            String cpassword = txtBoxPwdCon.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") || cpassword.Trim().Equals(""))
            {
                txtBoxPwdCon.Text = "confirm password";
                txtBoxPwdCon.UseSystemPasswordChar = false;
                txtBoxPwdCon.ForeColor = Color.Gray;
            }
        }
    }
}
