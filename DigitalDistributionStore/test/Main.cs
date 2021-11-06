using BusinessObject;
using DataAccess.Interface;
using System.Linq;
using System.Windows.Forms;

namespace test
{
    public partial class Main : Form
    {
        public Member loginUser;

        public Main(Member loginUser)
        {
            InitializeComponent();
            pnSideBar.Height = btProduct.Height;
            pnSideBar.Top = btProduct.Top;
            //pass loginUser
            //this.loginUser = loginUser;
            //loginUser = new DBContext().Members.Find(4);
            /*
            ctrlOrder.loginUser = loginUser;
            //ctrlProduct.loginUser = loginUser;
            ctrlProfile.loginUser = loginUser;
            */

            /*
            ctrlProfile.Hide();
            ctrlProduct.Visible = true;
            ctrlProduct.Show();
            ctrlProduct.BringToFront();    
            */
        }

        private void btProduct_Click(object sender, System.EventArgs e)
        {
            /*
            pnSideBar.Height = btProduct.Height;
            pnSideBar.Top = btProduct.Top;
            ctrlProfile.Hide();
            ctrlOrder.Hide();
            
            ctrlProduct.Show();
            ctrlProduct.BringToFront();
            */
        }

        private void btOrder_Click(object sender, System.EventArgs e)
        {
            /*
            pnSideBar.Height = btOrder.Height;
            pnSideBar.Top = btOrder.Top;
            //ctrlProduct.Hide();
            ctrlProfile.Hide();
            ctrlOrder.Show();
            ctrlOrder.BringToFront();
            */
        }

        private void btProfile_Click(object sender, System.EventArgs e)
        {
            /*
            pnSideBar.Height = btProfile.Height;
            pnSideBar.Top = btProfile.Top;
            //ctrlProduct.Hide();
            ctrlOrder.Hide();
            ctrlProfile.Show();
            ctrlProfile.BringToFront();
            */
        }

        private void btClose_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {

        }

        private void orderControl1_Load(object sender, System.EventArgs e)
        {

        }

        private void ctrlProfile_Load(object sender, System.EventArgs e)
        {

        }
    }


}
