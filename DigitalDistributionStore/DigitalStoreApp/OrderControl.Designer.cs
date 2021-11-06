
namespace DigitalStoreApp
{
    partial class OrderControl
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.pnOrderAction = new System.Windows.Forms.Panel();
            this.btDeleteOrder = new System.Windows.Forms.Button();
            this.btCheckOutOrder = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.lbOrderList = new System.Windows.Forms.Label();
            this.lbProductInOrder = new System.Windows.Forms.Label();
            this.btSortByDate = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btSortbyTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnOrderAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(49, 148);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 29;
            this.dgvOrder.Size = new System.Drawing.Size(454, 423);
            this.dgvOrder.TabIndex = 3;
            this.dgvOrder.SelectionChanged += new System.EventHandler(this.dgvOrder_SelectionChanged);
            // 
            // pnOrderAction
            // 
            this.pnOrderAction.Controls.Add(this.btDeleteOrder);
            this.pnOrderAction.Controls.Add(this.btCheckOutOrder);
            this.pnOrderAction.Location = new System.Drawing.Point(525, 475);
            this.pnOrderAction.Name = "pnOrderAction";
            this.pnOrderAction.Size = new System.Drawing.Size(541, 96);
            this.pnOrderAction.TabIndex = 5;
            // 
            // btDeleteOrder
            // 
            this.btDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btDeleteOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btDeleteOrder.Location = new System.Drawing.Point(53, 21);
            this.btDeleteOrder.Name = "btDeleteOrder";
            this.btDeleteOrder.Size = new System.Drawing.Size(196, 55);
            this.btDeleteOrder.TabIndex = 11;
            this.btDeleteOrder.Text = "Delete Order";
            this.btDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // btCheckOutOrder
            // 
            this.btCheckOutOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btCheckOutOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btCheckOutOrder.FlatAppearance.BorderSize = 0;
            this.btCheckOutOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckOutOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckOutOrder.ForeColor = System.Drawing.Color.White;
            this.btCheckOutOrder.Location = new System.Drawing.Point(298, 21);
            this.btCheckOutOrder.Name = "btCheckOutOrder";
            this.btCheckOutOrder.Size = new System.Drawing.Size(196, 55);
            this.btCheckOutOrder.TabIndex = 10;
            this.btCheckOutOrder.Text = "Extract Bill";
            this.btCheckOutOrder.UseVisualStyleBackColor = false;
            this.btCheckOutOrder.Click += new System.EventHandler(this.btCheckOutOrder_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(525, 148);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 29;
            this.dgvOrderDetail.Size = new System.Drawing.Size(538, 329);
            this.dgvOrderDetail.TabIndex = 7;
            // 
            // lbOrderList
            // 
            this.lbOrderList.AutoSize = true;
            this.lbOrderList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderList.ForeColor = System.Drawing.Color.White;
            this.lbOrderList.Location = new System.Drawing.Point(49, 124);
            this.lbOrderList.Name = "lbOrderList";
            this.lbOrderList.Size = new System.Drawing.Size(106, 21);
            this.lbOrderList.TabIndex = 8;
            this.lbOrderList.Text = "Product List";
            // 
            // lbProductInOrder
            // 
            this.lbProductInOrder.AutoSize = true;
            this.lbProductInOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductInOrder.ForeColor = System.Drawing.Color.White;
            this.lbProductInOrder.Location = new System.Drawing.Point(947, 124);
            this.lbProductInOrder.Name = "lbProductInOrder";
            this.lbProductInOrder.Size = new System.Drawing.Size(119, 21);
            this.lbProductInOrder.TabIndex = 9;
            this.lbProductInOrder.Text = "Order Details";
            // 
            // btSortByDate
            // 
            this.btSortByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btSortByDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSortByDate.FlatAppearance.BorderSize = 0;
            this.btSortByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSortByDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSortByDate.ForeColor = System.Drawing.Color.White;
            this.btSortByDate.Location = new System.Drawing.Point(258, 80);
            this.btSortByDate.Name = "btSortByDate";
            this.btSortByDate.Size = new System.Drawing.Size(196, 28);
            this.btSortByDate.TabIndex = 9;
            this.btSortByDate.Text = "Sort by Status";
            this.btSortByDate.UseVisualStyleBackColor = false;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.btSortByDate);
            this.pnTop.Controls.Add(this.btSortbyTime);
            this.pnTop.Location = new System.Drawing.Point(49, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1014, 121);
            this.pnTop.TabIndex = 11;
            // 
            // btSortbyTime
            // 
            this.btSortbyTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btSortbyTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSortbyTime.FlatAppearance.BorderSize = 0;
            this.btSortbyTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSortbyTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSortbyTime.ForeColor = System.Drawing.Color.White;
            this.btSortbyTime.Location = new System.Drawing.Point(0, 80);
            this.btSortbyTime.Name = "btSortbyTime";
            this.btSortbyTime.Size = new System.Drawing.Size(196, 28);
            this.btSortbyTime.TabIndex = 10;
            this.btSortbyTime.Text = "Sort by Latest";
            this.btSortbyTime.UseVisualStyleBackColor = false;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.lbProductInOrder);
            this.Controls.Add(this.lbOrderList);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.pnOrderAction);
            this.Controls.Add(this.dgvOrder);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(1105, 591);
            this.Load += new System.EventHandler(this.OrderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnOrderAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Panel pnOrderAction;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label lbOrderList;
        private System.Windows.Forms.Label lbProductInOrder;
        private System.Windows.Forms.Button btSortByDate;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btSortbyTime;
        private System.Windows.Forms.Button btDeleteOrder;
        private System.Windows.Forms.Button btCheckOutOrder;
    }
}
