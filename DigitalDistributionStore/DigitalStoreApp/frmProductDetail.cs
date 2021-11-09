using BusinessObject;
using DataAccess.Interface;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class frmProductDetail : Form
    {
        Product product;
        ISystemHandler lib;
        public frmProductDetail(int id)
        {
            InitializeComponent();
            lib = new ISystemHandler();
            LoadCbCategories();
            product = lib.Products().GetProducts().SingleOrDefault(p => p.ProductID == id);
            if(product == null)
            {
                product = new Product()
                {
                    ProductID = id
                };
            }
            else
            {
                txbName.Text = product.ProductName;
                txbAmount.Text = product.UnitsInStock.ToString();
                txbPrice.Text = product.UnitPrice.ToString();
                cbCategory.SelectedIndex = cbCategory.FindStringExact(product.Category.CategoryName);
            }
            txbID.Text = id.ToString();
        }
        private void LoadCbCategories()
        {
            var cateList = lib.Categories().GetCategories();
            cbCategory.DataSource = cateList.ToList();
            cbCategory.ValueMember = "CategoryName";
            cbCategory.DisplayMember = "CategoryName";
        }
        private void btConfirm_Click(object sender, System.EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txbID.Text);
                var name = txbName.Text;
                int inStock = Int32.Parse(txbAmount.Text);
                double price = Double.Parse(txbPrice.Text);
                int categoryId = ((Category) cbCategory.SelectedItem).CategoryID;

                Boolean check = true;
                if (name.Trim().Length == 0)
                {
                    MessageBox.Show("Category name must not be blank!", "Notification");
                    check = false;
                }
                if(inStock <= 10)
                {
                    MessageBox.Show("Quantity added must be greater than 10!", "Notification");
                    check = false;
                }
                if (price < 1000)
                {
                    MessageBox.Show("Price must be equal or greater than 1000!", "Notification");
                    check = false;
                }
                if (check == true)
                {
                    try
                    {
                        var product = new Product()
                        {
                            //ProductID = id,
                            CategoryID = categoryId,
                            ProductName = name,
                            UnitPrice = price,
                            UnitsInStock = inStock                           
                        };
                        lib.Products().Insert(product);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void btCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
