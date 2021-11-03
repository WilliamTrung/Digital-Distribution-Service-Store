using BusinessObject;
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
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //login info correct
            loginUser = app.Login(txbName.Text, txbPassword.Text);
            //end login
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Show();
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
