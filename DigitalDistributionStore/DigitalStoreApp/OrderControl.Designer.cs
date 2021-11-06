
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
            this.btCheckOutOrder = new System.Windows.Forms.Button();
            this.lbOrderList = new System.Windows.Forms.Label();
            this.lbProductInOrder = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnOrderAction.SuspendLayout();
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
            this.dgvOrder.Size = new System.Drawing.Size(754, 423);
            this.dgvOrder.TabIndex = 3;
            this.dgvOrder.SelectionChanged += new System.EventHandler(this.dgvOrder_SelectionChanged);
            // 
            // pnOrderAction
            // 
            this.pnOrderAction.Controls.Add(this.btCheckOutOrder);
            this.pnOrderAction.Location = new System.Drawing.Point(857, 475);
            this.pnOrderAction.Name = "pnOrderAction";
            this.pnOrderAction.Size = new System.Drawing.Size(222, 96);
            this.pnOrderAction.TabIndex = 5;
            // 
            // btCheckOutOrder
            // 
            this.btCheckOutOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btCheckOutOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btCheckOutOrder.FlatAppearance.BorderSize = 0;
            this.btCheckOutOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckOutOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckOutOrder.ForeColor = System.Drawing.Color.White;
            this.btCheckOutOrder.Location = new System.Drawing.Point(16, 24);
            this.btCheckOutOrder.Name = "btCheckOutOrder";
            this.btCheckOutOrder.Size = new System.Drawing.Size(190, 55);
            this.btCheckOutOrder.TabIndex = 10;
            this.btCheckOutOrder.Text = "Check Details";
            this.btCheckOutOrder.UseVisualStyleBackColor = false;
            this.btCheckOutOrder.Click += new System.EventHandler(this.btCheckOutOrder_Click);
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
            // pnTop
            // 
            this.pnTop.Location = new System.Drawing.Point(49, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1014, 121);
            this.pnTop.TabIndex = 11;
            // 
            // btReload
            // 
            this.btReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btReload.Cursor = System.Windows.Forms.Cursors.Default;
            this.btReload.FlatAppearance.BorderSize = 0;
            this.btReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReload.ForeColor = System.Drawing.Color.White;
            this.btReload.Location = new System.Drawing.Point(857, 148);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(196, 56);
            this.btReload.TabIndex = 10;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.lbProductInOrder);
            this.Controls.Add(this.lbOrderList);
            this.Controls.Add(this.pnOrderAction);
            this.Controls.Add(this.dgvOrder);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(1105, 591);
            this.Load += new System.EventHandler(this.OrderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnOrderAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Panel pnOrderAction;
        private System.Windows.Forms.Label lbOrderList;
        private System.Windows.Forms.Label lbProductInOrder;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btCheckOutOrder;
    }
}
