﻿
namespace DigitalStoreApp
{
    partial class AdminManagementControl
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
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.pnR = new System.Windows.Forms.Panel();
            this.pnSearchName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btSortByName = new System.Windows.Forms.Button();
            this.pnSearchDateForOrder = new System.Windows.Forms.Panel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.btLoadAll = new System.Windows.Forms.Button();
            this.pnCategoryForProduct = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.pnCUD = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.pnR.SuspendLayout();
            this.pnSearchName.SuspendLayout();
            this.pnSearchDateForOrder.SuspendLayout();
            this.pnCategoryForProduct.SuspendLayout();
            this.pnCUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDisplay.Location = new System.Drawing.Point(16, 132);
            this.dgvDisplay.MultiSelect = false;
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.RowTemplate.Height = 29;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(852, 443);
            this.dgvDisplay.TabIndex = 4;
            this.dgvDisplay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellDoubleClick);
            this.dgvDisplay.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellValueChanged);
            // 
            // pnR
            // 
            this.pnR.Controls.Add(this.pnSearchName);
            this.pnR.Controls.Add(this.pnSearchDateForOrder);
            this.pnR.Controls.Add(this.btLoadAll);
            this.pnR.Controls.Add(this.pnCategoryForProduct);
            this.pnR.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnR.Location = new System.Drawing.Point(0, 0);
            this.pnR.Name = "pnR";
            this.pnR.Size = new System.Drawing.Size(1105, 132);
            this.pnR.TabIndex = 5;
            // 
            // pnSearchName
            // 
            this.pnSearchName.Controls.Add(this.lbName);
            this.pnSearchName.Controls.Add(this.tbSearchName);
            this.pnSearchName.Controls.Add(this.btSortByName);
            this.pnSearchName.Location = new System.Drawing.Point(16, 85);
            this.pnSearchName.Name = "pnSearchName";
            this.pnSearchName.Size = new System.Drawing.Size(853, 34);
            this.pnSearchName.TabIndex = 18;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(0, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(133, 21);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Search Name :";
            // 
            // tbSearchName
            // 
            this.tbSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.tbSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSearchName.Location = new System.Drawing.Point(139, 3);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(451, 27);
            this.tbSearchName.TabIndex = 11;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // btSortByName
            // 
            this.btSortByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btSortByName.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSortByName.FlatAppearance.BorderSize = 0;
            this.btSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSortByName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSortByName.ForeColor = System.Drawing.Color.White;
            this.btSortByName.Location = new System.Drawing.Point(656, 3);
            this.btSortByName.Name = "btSortByName";
            this.btSortByName.Size = new System.Drawing.Size(196, 30);
            this.btSortByName.TabIndex = 13;
            this.btSortByName.Text = "Sort by Name";
            this.btSortByName.UseVisualStyleBackColor = false;
            this.btSortByName.Click += new System.EventHandler(this.btSortByName_Click);
            // 
            // pnSearchDateForOrder
            // 
            this.pnSearchDateForOrder.Controls.Add(this.dtpEnd);
            this.pnSearchDateForOrder.Controls.Add(this.dtpStart);
            this.pnSearchDateForOrder.Controls.Add(this.lbTo);
            this.pnSearchDateForOrder.Controls.Add(this.lbFrom);
            this.pnSearchDateForOrder.Controls.Add(this.lbDate);
            this.pnSearchDateForOrder.Location = new System.Drawing.Point(16, 14);
            this.pnSearchDateForOrder.Name = "pnSearchDateForOrder";
            this.pnSearchDateForOrder.Size = new System.Drawing.Size(590, 71);
            this.pnSearchDateForOrder.TabIndex = 17;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(340, 35);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(250, 27);
            this.dtpEnd.TabIndex = 19;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(56, 35);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(250, 27);
            this.dtpStart.TabIndex = 18;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTo.ForeColor = System.Drawing.Color.White;
            this.lbTo.Location = new System.Drawing.Point(312, 40);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(24, 20);
            this.lbTo.TabIndex = 16;
            this.lbTo.Text = "To";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFrom.ForeColor = System.Drawing.Color.White;
            this.lbFrom.Location = new System.Drawing.Point(0, 40);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(44, 20);
            this.lbFrom.TabIndex = 14;
            this.lbFrom.Text = "From";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(0, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(125, 21);
            this.lbDate.TabIndex = 13;
            this.lbDate.Text = "Search Date :";
            // 
            // btLoadAll
            // 
            this.btLoadAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btLoadAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btLoadAll.FlatAppearance.BorderSize = 0;
            this.btLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLoadAll.ForeColor = System.Drawing.Color.White;
            this.btLoadAll.Location = new System.Drawing.Point(672, 15);
            this.btLoadAll.Name = "btLoadAll";
            this.btLoadAll.Size = new System.Drawing.Size(196, 59);
            this.btLoadAll.TabIndex = 12;
            this.btLoadAll.Text = "Load All";
            this.btLoadAll.UseVisualStyleBackColor = false;
            this.btLoadAll.Click += new System.EventHandler(this.btLoadAll_Click);
            // 
            // pnCategoryForProduct
            // 
            this.pnCategoryForProduct.Controls.Add(this.cbCategory);
            this.pnCategoryForProduct.Controls.Add(this.lbCategory);
            this.pnCategoryForProduct.Location = new System.Drawing.Point(16, 38);
            this.pnCategoryForProduct.Name = "pnCategoryForProduct";
            this.pnCategoryForProduct.Size = new System.Drawing.Size(603, 27);
            this.pnCategoryForProduct.TabIndex = 16;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(174, -1);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(416, 28);
            this.cbCategory.TabIndex = 14;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategory.ForeColor = System.Drawing.Color.White;
            this.lbCategory.Location = new System.Drawing.Point(0, 1);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(168, 21);
            this.lbCategory.TabIndex = 15;
            this.lbCategory.Text = "Choose Category :";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(21, 76);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(196, 44);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btCreate.FlatAppearance.BorderSize = 0;
            this.btCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCreate.ForeColor = System.Drawing.Color.White;
            this.btCreate.Location = new System.Drawing.Point(21, 6);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(196, 44);
            this.btCreate.TabIndex = 9;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(21, 150);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(196, 44);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // pnCUD
            // 
            this.pnCUD.Controls.Add(this.btUpdate);
            this.pnCUD.Controls.Add(this.btDelete);
            this.pnCUD.Controls.Add(this.btCreate);
            this.pnCUD.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCUD.Location = new System.Drawing.Point(866, 132);
            this.pnCUD.Name = "pnCUD";
            this.pnCUD.Size = new System.Drawing.Size(239, 459);
            this.pnCUD.TabIndex = 12;
            // 
            // AdminManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnCUD);
            this.Controls.Add(this.pnR);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "AdminManagementControl";
            this.Size = new System.Drawing.Size(1105, 591);
            this.Load += new System.EventHandler(this.AdminManagementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.pnR.ResumeLayout(false);
            this.pnSearchName.ResumeLayout(false);
            this.pnSearchName.PerformLayout();
            this.pnSearchDateForOrder.ResumeLayout(false);
            this.pnSearchDateForOrder.PerformLayout();
            this.pnCategoryForProduct.ResumeLayout(false);
            this.pnCategoryForProduct.PerformLayout();
            this.pnCUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Panel pnR;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel pnCUD;
        private System.Windows.Forms.Button btSortByName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btLoadAll;
        private System.Windows.Forms.Panel pnCategoryForProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Panel pnSearchDateForOrder;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel pnSearchName;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}
