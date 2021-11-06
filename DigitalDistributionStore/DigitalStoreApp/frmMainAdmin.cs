using BusinessObject;
using System;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class frmMainAdmin : Form
    {
        Member loginUser;
        public frmMainAdmin(Member loginUser)
        {
            InitializeComponent();
            pnSideBar.Height = btCategory.Height;
            pnSideBar.Top = btCategory.Top;

            ctrlCategoryManagement.SetControlView(1);
            ctrlMemberManagement.SetControlView(3);
            ctrlProductManagement.SetControlView(2);
            ctrlOrderManagement.SetControlView(4);

            ctrlCategoryManagement.LoadControlView();
            ctrlMemberManagement.LoadControlView();
            ctrlOrderManagement.LoadControlView();
            ctrlProductManagement.LoadControlView();

            ctrlMemberManagement.Hide();
            ctrlProductManagement.Hide();
            ctrlMemberManagement.Hide();
            ctrlCategoryManagement.Show();
            ctrlCategoryManagement.BringToFront();

            this.loginUser = loginUser;
        }

        private void btCategory_Click(object sender, EventArgs e)
        {
            pnSideBar.Height = btCategory.Height;
            pnSideBar.Top = btCategory.Top;
            ctrlMemberManagement.Hide();
            ctrlProductManagement.Hide();
            ctrlOrderManagement.Hide();
            ctrlCategoryManagement.Show();
            ctrlCategoryManagement.BringToFront();
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            pnSideBar.Height = btProduct.Height;
            pnSideBar.Top = btProduct.Top;
            ctrlMemberManagement.Hide();
            ctrlCategoryManagement.Hide();
            ctrlOrderManagement.Hide();
            ctrlProductManagement.Show();
            ctrlProductManagement.BringToFront();
        }

        private void btMember_Click(object sender, EventArgs e)
        {
            pnSideBar.Height = btMember.Height;
            pnSideBar.Top = btMember.Top;
            ctrlProductManagement.Hide();
            ctrlCategoryManagement.Hide();
            ctrlOrderManagement.Hide();
            ctrlMemberManagement.Show();
            ctrlMemberManagement.BringToFront();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            pnSideBar.Height = btOrder.Height;
            pnSideBar.Top = btOrder.Top;
            ctrlMemberManagement.Hide();
            ctrlCategoryManagement.Hide();
            ctrlProductManagement.Hide();
            ctrlOrderManagement.Show();
            ctrlOrderManagement.BringToFront();
        }

        //code for this
        private void btClose_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin frm = new frmLogin();
            frm.Show();

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
        }
    }
}
