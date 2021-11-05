using BusinessObject;
using DataAccess.Interface;
using System;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class frmMemberDetail : Form
    {
        ISystemHandler context;
        public Member loginUser { get; set; }

        public bool InsertOrUpdate { get; set; }//Insert:false Update:true
        public frmMemberDetail()
        {
            InitializeComponent();
            context = new ISystemHandler();
        }

        private void frmMemberDetail_Load(object sender, System.EventArgs e)
        {
            txbEmail.Enabled = true;
            txbID.Enabled = true;
            txbMemberName.Enabled = true;
            if (loginUser != null && InsertOrUpdate)
            {
                txbID.Text = loginUser.MemberID.ToString();
                txbEmail.Text = loginUser.Email.ToString();
                txbMemberName.Text = loginUser.MemberName.ToString();
                txbStatus.Text = loginUser.Status.ToString();
                txbStatus.Enabled = false;
                if (loginUser.IsAdmin)
                {
                    txbStatus.Enabled = true;
                }
            }
        }

        private void btCancel_Click(object sender, System.EventArgs e) => Close();

        private void btConfirm_Click(object sender, System.EventArgs e)
        {
            try
            {
                Member member= new Member
                {
                    MemberName=txbMemberName.Text,
                    Email=txbEmail.Text,
                    Status=bool.Parse(txbStatus.Text),
                    Password=loginUser.Password,
                    IsAdmin=loginUser.IsAdmin
                };
                if (member != null)
                {
                    if (InsertOrUpdate)
                    {
                        context.Members().Update(member);
                        MessageBox.Show("Update successfully");
                    }
                    else
                    {
                        context.Members().Insert(member);
                        MessageBox.Show("Insert successfully");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate ? "Update failed" : "Insert Failed");
            }
        }
    }
}
