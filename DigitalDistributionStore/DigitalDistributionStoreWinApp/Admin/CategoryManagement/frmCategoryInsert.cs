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
    public partial class frmCategoryInsert : Form
    {
        ICategoryDAO cDao = new CategoryDAO();

        public frmCategoryInsert()
        {
            InitializeComponent();
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCategoryName.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtCategoryName.Text;
                if(name.Trim().Length == 0)
                {
                    throw new Exception("Category name must not be blank!");
                }
                var category = new Category
                {
                    categoryName = txtCategoryName.Text
                };                               
                cDao.InsertCategory(category);
            }                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            } 
            finally
            {
                Close();
            }
}
    }
}
