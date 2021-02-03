
namespace DSystem
{
    partial class AddUsresUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxFname = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxUname = new System.Windows.Forms.TextBox();
            this.txtBoxPwd = new System.Windows.Forms.TextBox();
            this.txtBoxPwdCon = new System.Windows.Forms.TextBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.txtBoxLname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(240)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.btnCreateAcc);
            this.panel1.Controls.Add(this.txtBoxPwdCon);
            this.panel1.Controls.Add(this.txtBoxPwd);
            this.panel1.Controls.Add(this.txtBoxUname);
            this.panel1.Controls.Add(this.txtBoxEmail);
            this.panel1.Controls.Add(this.txtBoxFname);
            this.panel1.Controls.Add(this.txtBoxLname);
            this.panel1.Location = new System.Drawing.Point(123, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 447);
            this.panel1.TabIndex = 0;
            // 
            // txtBoxFname
            // 
            this.txtBoxFname.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.txtBoxFname.Location = new System.Drawing.Point(50, 37);
            this.txtBoxFname.Name = "txtBoxFname";
            this.txtBoxFname.Size = new System.Drawing.Size(222, 37);
            this.txtBoxFname.TabIndex = 1;
            this.txtBoxFname.Text = "First Name";
            this.txtBoxFname.Enter += new System.EventHandler(this.txtBoxFname_Enter);
            this.txtBoxFname.Leave += new System.EventHandler(this.txtBoxFname_Leave);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.txtBoxEmail.Location = new System.Drawing.Point(50, 91);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(450, 37);
            this.txtBoxEmail.TabIndex = 2;
            this.txtBoxEmail.Text = "Email Address";
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // txtBoxUname
            // 
            this.txtBoxUname.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.txtBoxUname.Location = new System.Drawing.Point(50, 149);
            this.txtBoxUname.Name = "txtBoxUname";
            this.txtBoxUname.Size = new System.Drawing.Size(450, 37);
            this.txtBoxUname.TabIndex = 3;
            this.txtBoxUname.Text = "Username";
            this.txtBoxUname.Enter += new System.EventHandler(this.txtBoxUname_Enter);
            this.txtBoxUname.Leave += new System.EventHandler(this.txtBoxUname_Leave);
            // 
            // txtBoxPwd
            // 
            this.txtBoxPwd.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.txtBoxPwd.Location = new System.Drawing.Point(50, 206);
            this.txtBoxPwd.Name = "txtBoxPwd";
            this.txtBoxPwd.Size = new System.Drawing.Size(450, 37);
            this.txtBoxPwd.TabIndex = 4;
            this.txtBoxPwd.Text = "Password";
            this.txtBoxPwd.Enter += new System.EventHandler(this.txtBoxPwd_Enter);
            this.txtBoxPwd.Leave += new System.EventHandler(this.txtBoxPwd_Leave);
            // 
            // txtBoxPwdCon
            // 
            this.txtBoxPwdCon.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPwdCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.txtBoxPwdCon.Location = new System.Drawing.Point(50, 265);
            this.txtBoxPwdCon.Name = "txtBoxPwdCon";
            this.txtBoxPwdCon.Size = new System.Drawing.Size(450, 37);
            this.txtBoxPwdCon.TabIndex = 5;
            this.txtBoxPwdCon.Text = "Confirm Password";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.btnCreateAcc.FlatAppearance.BorderSize = 0;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(240)))), ((int)(((byte)(221)))));
            this.btnCreateAcc.Location = new System.Drawing.Point(50, 349);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(450, 55);
            this.btnCreateAcc.TabIndex = 6;
            this.btnCreateAcc.Text = "CREATE ACCOUNT";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            // 
            // txtBoxLname
            // 
            this.txtBoxLname.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.txtBoxLname.Location = new System.Drawing.Point(278, 37);
            this.txtBoxLname.Name = "txtBoxLname";
            this.txtBoxLname.Size = new System.Drawing.Size(222, 37);
            this.txtBoxLname.TabIndex = 1;
            this.txtBoxLname.Text = "Last Name";
            this.txtBoxLname.Enter += new System.EventHandler(this.txtBoxLname_Enter);
            this.txtBoxLname.Leave += new System.EventHandler(this.txtBoxLname_Leave);
            // 
            // AddUsresUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddUsresUC";
            this.Size = new System.Drawing.Size(803, 487);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxFname;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.TextBox txtBoxPwdCon;
        private System.Windows.Forms.TextBox txtBoxPwd;
        private System.Windows.Forms.TextBox txtBoxUname;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxLname;
    }
}
