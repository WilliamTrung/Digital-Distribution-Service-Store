
namespace DigitalStoreApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btProfile = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.ctrlProduct = new DigitalStoreApp.ProductControl();
            this.ctrlProfile = new DigitalStoreApp.ProfileControl();
            this.ctrlOrder = new DigitalStoreApp.OrderControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pnSideBar);
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.btProfile);
            this.panel1.Controls.Add(this.btOrder);
            this.panel1.Controls.Add(this.btProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 715);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.pnSideBar.Location = new System.Drawing.Point(0, 187);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(19, 84);
            this.pnSideBar.TabIndex = 1;
            // 
            // btLogout
            // 
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btLogout.Location = new System.Drawing.Point(0, 631);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(251, 84);
            this.btLogout.TabIndex = 3;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            // 
            // btProfile
            // 
            this.btProfile.FlatAppearance.BorderSize = 0;
            this.btProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btProfile.Location = new System.Drawing.Point(12, 367);
            this.btProfile.Name = "btProfile";
            this.btProfile.Size = new System.Drawing.Size(239, 84);
            this.btProfile.TabIndex = 2;
            this.btProfile.Text = "Profile";
            this.btProfile.UseVisualStyleBackColor = true;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // btOrder
            // 
            this.btOrder.FlatAppearance.BorderSize = 0;
            this.btOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btOrder.Location = new System.Drawing.Point(12, 277);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(239, 84);
            this.btOrder.TabIndex = 1;
            this.btOrder.Text = "Orders";
            this.btOrder.UseMnemonic = false;
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btProduct
            // 
            this.btProduct.FlatAppearance.BorderSize = 0;
            this.btProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btProduct.Location = new System.Drawing.Point(12, 187);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(239, 84);
            this.btProduct.TabIndex = 0;
            this.btProduct.Text = "Products";
            this.btProduct.UseVisualStyleBackColor = true;
            this.btProduct.Click += new System.EventHandler(this.btProduct_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 10);
            this.panel2.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(1302, 16);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(42, 41);
            this.btClose.TabIndex = 3;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ctrlProduct
            // 
            this.ctrlProduct.Location = new System.Drawing.Point(251, 97);
            this.ctrlProduct.Name = "ctrlProduct";
            this.ctrlProduct.Size = new System.Drawing.Size(1103, 592);
            this.ctrlProduct.TabIndex = 4;
            // 
            // ctrlProfile
            // 
            this.ctrlProfile.Location = new System.Drawing.Point(251, 80);
            this.ctrlProfile.Name = "ctrlProfile";
            this.ctrlProfile.Size = new System.Drawing.Size(1103, 609);
            this.ctrlProfile.TabIndex = 5;
            // 
            // ctrlOrder
            // 
            this.ctrlOrder.Location = new System.Drawing.Point(251, 110);
            this.ctrlOrder.Name = "ctrlOrder";
            this.ctrlOrder.Size = new System.Drawing.Size(1103, 579);
            this.ctrlOrder.TabIndex = 6;
            this.ctrlOrder.Load += new System.EventHandler(this.orderControl1_Load);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1356, 715);
            this.ControlBox = false;
            this.Controls.Add(this.ctrlOrder);
            this.Controls.Add(this.ctrlProfile);
            this.Controls.Add(this.ctrlProduct);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnSideBar;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btProfile;
        private System.Windows.Forms.Button btProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btClose;
        private ProductControl ctrlProduct;
        private ProfileControl ctrlProfile;
        private System.Windows.Forms.Button btOrder;
        private OrderControl ctrlOrder;
    }
}