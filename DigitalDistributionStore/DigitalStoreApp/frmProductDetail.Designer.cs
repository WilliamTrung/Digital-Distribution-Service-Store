
namespace DigitalStoreApp
{
    partial class frmProductDetail
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbOrderName = new System.Windows.Forms.Label();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(440, 337);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(231, 28);
            this.btCancel.TabIndex = 47;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btConfirm.FlatAppearance.BorderSize = 0;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConfirm.ForeColor = System.Drawing.Color.White;
            this.btConfirm.Location = new System.Drawing.Point(100, 337);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(231, 28);
            this.btConfirm.TabIndex = 46;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(143, 246);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(99, 21);
            this.lbStatus.TabIndex = 44;
            this.lbStatus.Text = "Category :";
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbPrice.Location = new System.Drawing.Point(283, 195);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(360, 27);
            this.txbPrice.TabIndex = 43;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Enabled = false;
            this.lbPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(185, 196);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(60, 21);
            this.lbPrice.TabIndex = 42;
            this.lbPrice.Text = "Price :";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbName.Location = new System.Drawing.Point(283, 95);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(360, 27);
            this.txbName.TabIndex = 41;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbID.Enabled = false;
            this.txbID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbID.Location = new System.Drawing.Point(283, 45);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(360, 27);
            this.txbID.TabIndex = 40;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(133, 46);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(109, 21);
            this.lbID.TabIndex = 39;
            this.lbID.Text = "Product ID :";
            // 
            // lbOrderName
            // 
            this.lbOrderName.AutoSize = true;
            this.lbOrderName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderName.ForeColor = System.Drawing.Color.White;
            this.lbOrderName.Location = new System.Drawing.Point(100, 96);
            this.lbOrderName.Name = "lbOrderName";
            this.lbOrderName.Size = new System.Drawing.Size(142, 21);
            this.lbOrderName.TabIndex = 38;
            this.lbOrderName.Text = "Product Name :";
            // 
            // txbAmount
            // 
            this.txbAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbAmount.Location = new System.Drawing.Point(283, 145);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(360, 27);
            this.txbAmount.TabIndex = 49;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Enabled = false;
            this.lbStock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStock.ForeColor = System.Drawing.Color.White;
            this.lbStock.Location = new System.Drawing.Point(156, 146);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(86, 21);
            this.lbStock.TabIndex = 48;
            this.lbStock.Text = "In Stock :";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(283, 246);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(360, 28);
            this.cbCategory.TabIndex = 50;
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbOrderName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductDetail";
            this.Text = "frmProductDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbOrderName;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}