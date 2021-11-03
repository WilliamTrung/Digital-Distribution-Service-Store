using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
            pnSideBar.Height = btCategory.Height;
            pnSideBar.Top = btCategory.Top;
            ctrlMemberManagement.Hide();
            ctrlProductManagement.Hide();
            ctrlMemberManagement.Hide();
            ctrlCategoryManagement.Show();
            ctrlCategoryManagement.BringToFront();
        }

        //don't touch this
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
