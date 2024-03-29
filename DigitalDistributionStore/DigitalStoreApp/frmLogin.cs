﻿using BusinessObject;
using DataAccess.Interface;
using System;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class frmLogin : Form
    {
        ISystemHandler app;
        Member loginUser;
        public frmLogin()
        {
            InitializeComponent();
            app = new ISystemHandler();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //login info correct
            loginUser = app.Login(txbName.Text, txbPassword.Text);
            //end login
            if(loginUser != null)
            {
                if (loginUser.Status)
                {
                    if (loginUser.IsAdmin)
                    {
                        frmMainAdmin frm = new frmMainAdmin(loginUser);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        frmMain frm = new frmMain(loginUser);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("You are not allowed to log in!", "Warning");
                }
                
            }
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void btHelpSignIn_Click(object sender, EventArgs e)
        {

        }

        private void btNewAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
