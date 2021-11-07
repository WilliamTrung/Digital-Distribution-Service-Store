using BusinessObject;
using DataAccess.Interface;
using System.Linq;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class frmMain : Form
    {
        Member loginUser;
        public frmMain(Member loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
            pnSideBar.Height = btProduct.Height;
            pnSideBar.Top = btProduct.Top;
            ctrlProfile.Hide();
            ctrlProduct.Show();
            ctrlProduct.BringToFront();


            ctrlOrder.loginUser = loginUser;
            ctrlProduct.loginUser = loginUser;
            ctrlProfile.loginUser = loginUser;
        }

        private void btProduct_Click(object sender, System.EventArgs e)
        {
            pnSideBar.Height = btProduct.Height;
            pnSideBar.Top = btProduct.Top;
            ctrlProfile.Hide();
            ctrlOrder.Hide();
            ctrlProduct.Show();
            ctrlProduct.BringToFront();
        }

        private void btOrder_Click(object sender, System.EventArgs e)
        {
            pnSideBar.Height = btOrder.Height;
            pnSideBar.Top = btOrder.Top;
            ctrlProduct.Hide();
            ctrlProfile.Hide();
            ctrlOrder.Show();
            ctrlOrder.BringToFront();
        }

        private void btProfile_Click(object sender, System.EventArgs e)
        {
            pnSideBar.Height = btProfile.Height;
            pnSideBar.Top = btProfile.Top;
            ctrlProduct.Hide();
            ctrlOrder.Hide();
            ctrlProfile.Show();
            ctrlProfile.BringToFront();
        }

        private void btClose_Click(object sender, System.EventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void ctrlOrder_Load(object sender, System.EventArgs e)
        {

        }

        private void btLogout_Click(object sender, System.EventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
