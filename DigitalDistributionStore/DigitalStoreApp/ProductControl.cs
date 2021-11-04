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
    public partial class ProductControl : UserControl
    {
        Member loginUser;
        ISystemHandler context;
        public ProductControl(Member loginUser)
        {
            InitializeComponent();
            this.loginUser = loginUser;
        }
        private void LoadProducts(string search)
        {
            var list_products = context.Products().GetProducts();
            dgvProduct.DataSource = list_products;
        }
        private void btAddToOrder_Click(object sender, EventArgs e)
        {

        }

        private void btSaveOrder_Click(object sender, EventArgs e)
        {

        }

        private void ProductControl_Load(object sender, EventArgs e)
        {

        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSortByName_Click(object sender, EventArgs e)
        {

        }
    }
}
