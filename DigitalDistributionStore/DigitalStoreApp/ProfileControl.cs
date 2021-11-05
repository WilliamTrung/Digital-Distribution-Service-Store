using BusinessObject;
using DataAccess.Interface;
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
    public partial class ProfileControl : UserControl
    {
        Member loginUser;
        ISystemHandler context;
        public ProfileControl(Member loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;
            context = new ISystemHandler();
        }

        private void btEditProfile_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail {
                loginUser = loginUser,
                InsertOrUpdate = true
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                this.loginUser = frmMemberDetail.loginUser;
                LoadUserDetails();
            }
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            if (loginUser != null)
            {
                lbID.Text = loginUser.MemberID.ToString();
                lbEmail.Text = loginUser.Email.ToString();
                lbMemberName.Text = loginUser.MemberName.ToString();
            }
        }
    }
}
