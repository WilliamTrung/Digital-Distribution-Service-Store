using DataObjects.Repository;
using DigitalDistributionStoreLibrary.DataAccess;
using Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDistributionStoreWinApp
{
    public partial class frmCategoryUpdate : Form
    {
        ICategoryDAO cDao = new CategoryDAO();
        public frmCategoryUpdate(int categoryId, string categoryName)
        {
            InitializeComponent();
            txtCategoryId.Text = categoryId.ToString();
            txtCategoryName.Text = categoryName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                categoryName = txtCategoryName.Text,
                categoryId = Int32.Parse(txtCategoryId.Text)               
            };
            try
            {
                cDao.UpdateCategory(category);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCategoryId.Clear();
            txtCategoryName.Clear();
        }
    }
}
