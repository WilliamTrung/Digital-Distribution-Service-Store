using BusinessObject;
using DataAccess.Interface;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class frmMain : Form
    {
        Member loginUser;
        ISystemHandler context;
        public frmMain(Member loginUser)
        {
            InitializeComponent();
            pnSideBar.Height = btProduct.Height;
            pnSideBar.Top = btProduct.Top;
            ctrlProfile.Hide();
            ctrlProduct.Show();
            ctrlProduct.BringToFront();
            this.loginUser = loginUser;
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

        private void orderControl1_Load(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

   
}
