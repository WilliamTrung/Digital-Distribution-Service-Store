﻿
namespace DigitalStoreApp
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pnProduct = new System.Windows.Forms.Panel();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btSortByName = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btAddToOrder = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lbProducList = new System.Windows.Forms.Label();
            this.lbProductInOrder = new System.Windows.Forms.Label();
            this.pnOrder = new System.Windows.Forms.Panel();
            this.btResetOrder = new System.Windows.Forms.Button();
            this.btRemoveFromOrder = new System.Windows.Forms.Button();
            this.btSaveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(48, 157);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(513, 416);
            this.dgvProduct.TabIndex = 0;
            // 
            // pnProduct
            // 
            this.pnProduct.Controls.Add(this.lbProductName);
            this.pnProduct.Controls.Add(this.lbCategory);
            this.pnProduct.Controls.Add(this.button2);
            this.pnProduct.Controls.Add(this.btSortByName);
            this.pnProduct.Controls.Add(this.btSearch);
            this.pnProduct.Controls.Add(this.tbProductName);
            this.pnProduct.Controls.Add(this.cbCategory);
            this.pnProduct.Controls.Add(this.btAddToOrder);
            this.pnProduct.Controls.Add(this.btClear);
            this.pnProduct.Location = new System.Drawing.Point(48, 0);
            this.pnProduct.Name = "pnProduct";
            this.pnProduct.Size = new System.Drawing.Size(1011, 118);
            this.pnProduct.TabIndex = 1;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.ForeColor = System.Drawing.Color.White;
            this.lbProductName.Location = new System.Drawing.Point(530, 48);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(91, 21);
            this.lbProductName.TabIndex = 10;
            this.lbProductName.Text = "P. Name :";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategory.ForeColor = System.Drawing.Color.White;
            this.lbCategory.Location = new System.Drawing.Point(530, 5);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(99, 21);
            this.lbCategory.TabIndex = 9;
            this.lbCategory.Text = "Category :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sort By Type";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btSortByName
            // 
            this.btSortByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btSortByName.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSortByName.FlatAppearance.BorderSize = 0;
            this.btSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSortByName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSortByName.ForeColor = System.Drawing.Color.White;
            this.btSortByName.Location = new System.Drawing.Point(0, 43);
            this.btSortByName.Name = "btSortByName";
            this.btSortByName.Size = new System.Drawing.Size(196, 28);
            this.btSortByName.TabIndex = 7;
            this.btSortByName.Text = "Sort by Name";
            this.btSortByName.UseVisualStyleBackColor = false;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(783, 87);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(228, 28);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "SEARCH";
            this.btSearch.UseVisualStyleBackColor = false;
            // 
            // tbProductName
            // 
            this.tbProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.tbProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbProductName.Location = new System.Drawing.Point(651, 47);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(360, 27);
            this.tbProductName.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(651, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(360, 28);
            this.cbCategory.TabIndex = 4;
            // 
            // btAddToOrder
            // 
            this.btAddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btAddToOrder.FlatAppearance.BorderSize = 0;
            this.btAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddToOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btAddToOrder.Location = new System.Drawing.Point(255, 40);
            this.btAddToOrder.Name = "btAddToOrder";
            this.btAddToOrder.Size = new System.Drawing.Size(196, 75);
            this.btAddToOrder.TabIndex = 3;
            this.btAddToOrder.Text = "Add to Order";
            this.btAddToOrder.UseVisualStyleBackColor = false;
            this.btAddToOrder.Click += new System.EventHandler(this.btAddToOrder_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(530, 87);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(231, 28);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = false;
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(578, 157);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 29;
            this.dgvOrder.Size = new System.Drawing.Size(481, 311);
            this.dgvOrder.TabIndex = 2;
            // 
            // lbProducList
            // 
            this.lbProducList.AutoSize = true;
            this.lbProducList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProducList.ForeColor = System.Drawing.Color.White;
            this.lbProducList.Location = new System.Drawing.Point(57, 133);
            this.lbProducList.Name = "lbProducList";
            this.lbProducList.Size = new System.Drawing.Size(106, 21);
            this.lbProducList.TabIndex = 3;
            this.lbProducList.Text = "Product List";
            // 
            // lbProductInOrder
            // 
            this.lbProductInOrder.AutoSize = true;
            this.lbProductInOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductInOrder.ForeColor = System.Drawing.Color.White;
            this.lbProductInOrder.Location = new System.Drawing.Point(1001, 134);
            this.lbProductInOrder.Name = "lbProductInOrder";
            this.lbProductInOrder.Size = new System.Drawing.Size(58, 21);
            this.lbProductInOrder.TabIndex = 4;
            this.lbProductInOrder.Text = "Order";
            // 
            // pnOrder
            // 
            this.pnOrder.Controls.Add(this.btResetOrder);
            this.pnOrder.Controls.Add(this.btRemoveFromOrder);
            this.pnOrder.Controls.Add(this.btSaveOrder);
            this.pnOrder.Location = new System.Drawing.Point(578, 474);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(481, 99);
            this.pnOrder.TabIndex = 7;
            // 
            // btResetOrder
            // 
            this.btResetOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btResetOrder.FlatAppearance.BorderSize = 0;
            this.btResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResetOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btResetOrder.ForeColor = System.Drawing.Color.White;
            this.btResetOrder.Location = new System.Drawing.Point(150, 65);
            this.btResetOrder.Name = "btResetOrder";
            this.btResetOrder.Size = new System.Drawing.Size(196, 34);
            this.btResetOrder.TabIndex = 6;
            this.btResetOrder.Text = "Reset Order";
            this.btResetOrder.UseVisualStyleBackColor = false;
            // 
            // btRemoveFromOrder
            // 
            this.btRemoveFromOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btRemoveFromOrder.FlatAppearance.BorderSize = 0;
            this.btRemoveFromOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveFromOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRemoveFromOrder.ForeColor = System.Drawing.Color.White;
            this.btRemoveFromOrder.Location = new System.Drawing.Point(35, 0);
            this.btRemoveFromOrder.Name = "btRemoveFromOrder";
            this.btRemoveFromOrder.Size = new System.Drawing.Size(196, 49);
            this.btRemoveFromOrder.TabIndex = 5;
            this.btRemoveFromOrder.Text = "Remove from Order";
            this.btRemoveFromOrder.UseVisualStyleBackColor = false;
            // 
            // btSaveOrder
            // 
            this.btSaveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btSaveOrder.FlatAppearance.BorderSize = 0;
            this.btSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSaveOrder.ForeColor = System.Drawing.Color.White;
            this.btSaveOrder.Location = new System.Drawing.Point(253, 0);
            this.btSaveOrder.Name = "btSaveOrder";
            this.btSaveOrder.Size = new System.Drawing.Size(196, 49);
            this.btSaveOrder.TabIndex = 4;
            this.btSaveOrder.Text = "Save Order";
            this.btSaveOrder.UseVisualStyleBackColor = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnOrder);
            this.Controls.Add(this.lbProductInOrder);
            this.Controls.Add(this.lbProducList);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.pnProduct);
            this.Controls.Add(this.dgvProduct);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(1105, 591);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnProduct.ResumeLayout(false);
            this.pnProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel pnProduct;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btAddToOrder;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lbProducList;
        private System.Windows.Forms.Label lbProductInOrder;
        private System.Windows.Forms.Panel pnOrder;
        private System.Windows.Forms.Button btRemoveFromOrder;
        private System.Windows.Forms.Button btSaveOrder;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSortByName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Button btResetOrder;
    }
}
