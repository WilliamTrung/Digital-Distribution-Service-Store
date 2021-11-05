using System.Windows.Forms;

namespace DigitalStoreApp
{
    public partial class AdminManagementControl : UserControl
    {
        int control;

        public AdminManagementControl()
        {
            InitializeComponent();
        }

        public void SetControlView(int view)
        {
            control = view;
        }

        public void LoadControlView()
        {
            switch (control)
            {
                //Category = 1
                case 1:
                    pnCategoryForProduct.Hide();
                    pnSearchDateForOrder.Hide();
                    break;
                //Product = 2
                case 2:
                    pnSearchDateForOrder.Hide();
                    pnCategoryForProduct.Show();
                    break;
                //Member = 3
                case 3:
                    pnCategoryForProduct.Hide();
                    pnSearchDateForOrder.Hide();
                    break;
                //Order = 4
                case 4:
                    pnSearchDateForOrder.Show();
                    pnCategoryForProduct.Hide();
                    pnSearchName.Hide();
                    pnCUD.Enabled = false;
                    break;
            }
        }

    }
}
