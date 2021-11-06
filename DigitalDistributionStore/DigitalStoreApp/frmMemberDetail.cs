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
        private void CheckBoxStatus()
        {
            cbStatus.Enabled = false;
            if (InsertOrUpdate)//update
            {
                cbStatus.Checked = loginUser.Status;
                if (loginUser.Status == true)
                {
                    cbStatus.Text = "Active";
                }
                else
                {
                    cbStatus.Text = "Deactive";
                }
            }
            else //insert
            {
                cbStatus.Checked = true;
                cbStatus.Text = "Active";
            }
                      
        }
        private void frmMemberDetail_Load(object sender, System.EventArgs e)
        {
            txbEmail.Enabled = true;
            txbID.Enabled = true;
            txbMemberName.Enabled = true;
            if (loginUser != null && InsertOrUpdate)//Update
            {
                txbID.Text = loginUser.MemberID.ToString();
                txbEmail.Text = loginUser.Email.ToString();
                txbMemberName.Text = loginUser.MemberName.ToString();
                CheckBoxStatus();
                txbEmail.ReadOnly = true;
            }
            else if(loginUser != null && !InsertOrUpdate)//Insert
            {
                txbID.Text = loginUser.MemberID.ToString();
                CheckBoxStatus();
            }
        }

        private void btCancel_Click(object sender, System.EventArgs e) => Close();
        private Boolean Validate(Member member)
        {
            Boolean check = true;
            if (member.Email.Trim().Length == 0)
            {
                MessageBox.Show("Email must not be blank!", "Notification");
                check = false;
            }
            if (member.MemberName.Trim().Length == 0)
            {
                MessageBox.Show("Name must not be blank!", "Notification");
                check = false;
            }
            return check;
        }
        private void btConfirm_Click(object sender, System.EventArgs e)
        {
            try
            {
                Member member = new Member
                {
                    MemberID = loginUser.MemberID,
                    MemberName=txbMemberName.Text,
                    Email=txbEmail.Text,
                    Status= cbStatus.Checked,
                    Password=loginUser.Password,
                    IsAdmin=loginUser.IsAdmin
                };
                if (member != null)
                {
                    if (Validate(member))
                    {
                        try
                        {
                            if (InsertOrUpdate)
                            {
                                context.Members().Update(member);
                                MessageBox.Show("Update successfully");
                                loginUser = member;
                            }
                            else
                            {
                                member.Password = "123";
                                context.Members().Insert(member);
                                MessageBox.Show("Insert successfully");
                            }
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,"Warning");
                        }
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
