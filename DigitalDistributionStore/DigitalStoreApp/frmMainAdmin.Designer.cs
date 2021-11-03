
namespace DigitalStoreApp
{
    partial class frmMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAdmin));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btOrder = new System.Windows.Forms.Button();
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btProduct = new System.Windows.Forms.Button();
            this.btMember = new System.Windows.Forms.Button();
            this.btCategory = new System.Windows.Forms.Button();
            this.pnCategory = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.ctrlOrderManagement = new DigitalStoreApp.AdminManagementControl();
            this.ctrlMemberManagement = new DigitalStoreApp.AdminManagementControl();
            this.ctrlProductManagement = new DigitalStoreApp.AdminManagementControl();
            this.ctrlCategoryManagement = new DigitalStoreApp.AdminManagementControl();
            this.pnMenu.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.pnMenu.Controls.Add(this.btOrder);
            this.pnMenu.Controls.Add(this.pnSideBar);
            this.pnMenu.Controls.Add(this.button4);
            this.pnMenu.Controls.Add(this.btProduct);
            this.pnMenu.Controls.Add(this.btMember);
            this.pnMenu.Controls.Add(this.btCategory);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(245, 715);
            this.pnMenu.TabIndex = 1;
            // 
            // btOrder
            // 
            this.btOrder.FlatAppearance.BorderSize = 0;
            this.btOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btOrder.Location = new System.Drawing.Point(12, 392);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(233, 84);
            this.btOrder.TabIndex = 4;
            this.btOrder.Text = "Orders";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.pnSideBar.Location = new System.Drawing.Point(3, 122);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(16, 84);
            this.pnSideBar.TabIndex = 1;
            this.pnSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.button4.Location = new System.Drawing.Point(3, 631);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(245, 84);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btProduct
            // 
            this.btProduct.FlatAppearance.BorderSize = 0;
            this.btProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btProduct.Location = new System.Drawing.Point(12, 212);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(233, 84);
            this.btProduct.TabIndex = 2;
            this.btProduct.Text = "Products";
            this.btProduct.UseVisualStyleBackColor = true;
            this.btProduct.Click += new System.EventHandler(this.btProduct_Click);
            // 
            // btMember
            // 
            this.btMember.FlatAppearance.BorderSize = 0;
            this.btMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btMember.Location = new System.Drawing.Point(12, 302);
            this.btMember.Name = "btMember";
            this.btMember.Size = new System.Drawing.Size(233, 84);
            this.btMember.TabIndex = 1;
            this.btMember.Text = "Members";
            this.btMember.UseVisualStyleBackColor = true;
            this.btMember.Click += new System.EventHandler(this.btMember_Click);
            // 
            // btCategory
            // 
            this.btCategory.FlatAppearance.BorderSize = 0;
            this.btCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btCategory.Location = new System.Drawing.Point(12, 122);
            this.btCategory.Name = "btCategory";
            this.btCategory.Size = new System.Drawing.Size(233, 84);
            this.btCategory.TabIndex = 0;
            this.btCategory.Text = "Category";
            this.btCategory.UseVisualStyleBackColor = true;
            this.btCategory.Click += new System.EventHandler(this.btCategory_Click);
            // 
            // pnCategory
            // 
            this.pnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.pnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCategory.Location = new System.Drawing.Point(245, 0);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(1111, 10);
            this.pnCategory.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(1053, 6);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(46, 46);
            this.btClose.TabIndex = 4;
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.ctrlOrderManagement);
            this.pnMain.Controls.Add(this.ctrlMemberManagement);
            this.pnMain.Controls.Add(this.ctrlProductManagement);
            this.pnMain.Controls.Add(this.ctrlCategoryManagement);
            this.pnMain.Controls.Add(this.btClose);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMain.Location = new System.Drawing.Point(245, 10);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1111, 705);
            this.pnMain.TabIndex = 5;
            // 
            // ctrlOrderManagement
            // 
            this.ctrlOrderManagement.Location = new System.Drawing.Point(3, 100);
            this.ctrlOrderManagement.Name = "ctrlOrderManagement";
            this.ctrlOrderManagement.Size = new System.Drawing.Size(1108, 605);
            this.ctrlOrderManagement.TabIndex = 8;
            // 
            // ctrlMemberManagement
            // 
            this.ctrlMemberManagement.Location = new System.Drawing.Point(3, 100);
            this.ctrlMemberManagement.Name = "ctrlMemberManagement";
            this.ctrlMemberManagement.Size = new System.Drawing.Size(1108, 605);
            this.ctrlMemberManagement.TabIndex = 7;
            // 
            // ctrlProductManagement
            // 
            this.ctrlProductManagement.Location = new System.Drawing.Point(3, 100);
            this.ctrlProductManagement.Name = "ctrlProductManagement";
            this.ctrlProductManagement.Size = new System.Drawing.Size(1108, 605);
            this.ctrlProductManagement.TabIndex = 6;
            // 
            // ctrlCategoryManagement
            // 
            this.ctrlCategoryManagement.Location = new System.Drawing.Point(3, 100);
            this.ctrlCategoryManagement.Name = "ctrlCategoryManagement";
            this.ctrlCategoryManagement.Size = new System.Drawing.Size(1108, 605);
            this.ctrlCategoryManagement.TabIndex = 5;
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1356, 715);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnCategory);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainAdmin";
            this.Text = "frmMainAdmin";
            this.pnMenu.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnSideBar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btProduct;
        private System.Windows.Forms.Button btMember;
        private System.Windows.Forms.Button btCategory;
        private System.Windows.Forms.Panel pnCategory;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Panel pnMain;
        private AdminManagementControl ctrlOrderManagement;
        private AdminManagementControl ctrlMemberManagement;
        private AdminManagementControl ctrlProductManagement;
        private AdminManagementControl ctrlCategoryManagement;
    }
}