using BusinessObject;
using DataAccess.Interface;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class frmCategoryDetail : Form
    {
        Category category;
        ISystemHandler lib;
        public frmCategoryDetail(int id)
        {
            InitializeComponent();
            lib = new ISystemHandler();
            category = lib.Categories().GetCategories().SingleOrDefault(c => c.CategoryID == id);
            if (category == null)
            {
                category = new Category()
                {
                    CategoryID = id
                };
            }
            else
            {
                txbName.Text = category.CategoryName;
            }
            tbProductName.Text = category.CategoryID.ToString();
        }

        private void btConfirm_Click(object sender, System.EventArgs e)
        {
            var name = txbName.Text;
            if(name.Trim().Length == 0)
            {
                MessageBox.Show("Category name must not be blank!", "Notification");
            }
            else
            {
                try
                {
                    var new_category = new Category()
                    {
                        CategoryID = Int32.Parse(tbProductName.Text.ToString()),
                        CategoryName = name
                    };
                    lib.Categories().Insert(new_category);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
        }

        private void btCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
