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
    public partial class frmCategoryManagement : Form
    {
        public frmCategoryManagement()
        {
            InitializeComponent();
        }
        private void LoadCategories()
        {
            var categories = new List<Category>();
            try
            {
                categories = CategoryDAO.Instance.GetCatagories();
                //clear bindings
                txtCategoryId.DataBindings.Clear();
                txtCategoryName.DataBindings.Clear();
                //create binding
                txtCategoryId.DataBindings.Add("Text", categories, "categoryId");
                txtCategoryName.DataBindings.Add("Text", categories, "categoryName");
                //Binding to DGV
                dgvCategories.DataSource = categories;
            }
            catch (Exception ex)
            {
                dgvCategories.DataSource = categories;
                MessageBox.Show(ex.Message, "Error");
            }           
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                frmCategoryInsert fI = new frmCategoryInsert();
                fI.ShowDialog();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }            
        }

        private void frmCatagoryManagement_Load(object sender, EventArgs e) => LoadCategories();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtCategoryId.Text);
                frmCategoryUpdate fU = new frmCategoryUpdate(id, txtCategoryName.Text);
                fU.ShowDialog();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtCategoryId.Text);
                var category = new Product.Category(id, txtCategoryName.Text);
                CategoryDAO.Instance.RemoveCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnReload_Click(object sender, EventArgs e) => LoadCategories();
    }
}
