
namespace DigitalStoreApp
{
    partial class frmOrderDetail
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
            this.txbMemberName = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbOrderName = new System.Windows.Forms.Label();
            this.txbDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
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
            this.btCancel.Location = new System.Drawing.Point(455, 560);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(231, 28);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btConfirm.FlatAppearance.BorderSize = 0;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConfirm.ForeColor = System.Drawing.Color.White;
            this.btConfirm.Location = new System.Drawing.Point(115, 560);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(231, 28);
            this.btConfirm.TabIndex = 21;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = false;
            // 
            // txbMemberName
            // 
            this.txbMemberName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMemberName.Enabled = false;
            this.txbMemberName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbMemberName.Location = new System.Drawing.Point(285, 71);
            this.txbMemberName.Name = "txbMemberName";
            this.txbMemberName.Size = new System.Drawing.Size(360, 27);
            this.txbMemberName.TabIndex = 20;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbID.Enabled = false;
            this.txbID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbID.Location = new System.Drawing.Point(285, 17);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(360, 27);
            this.txbID.TabIndex = 19;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderID.ForeColor = System.Drawing.Color.White;
            this.lbOrderID.Location = new System.Drawing.Point(158, 18);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(91, 21);
            this.lbOrderID.TabIndex = 18;
            this.lbOrderID.Text = "Order ID :";
            // 
            // lbOrderName
            // 
            this.lbOrderName.AutoSize = true;
            this.lbOrderName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderName.ForeColor = System.Drawing.Color.White;
            this.lbOrderName.Location = new System.Drawing.Point(136, 72);
            this.lbOrderName.Name = "lbOrderName";
            this.lbOrderName.Size = new System.Drawing.Size(117, 21);
            this.lbOrderName.TabIndex = 17;
            this.lbOrderName.Text = "Created by :";
            // 
            // txbDate
            // 
            this.txbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbDate.Location = new System.Drawing.Point(285, 125);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(360, 27);
            this.txbDate.TabIndex = 24;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Enabled = false;
            this.lbDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(115, 126);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(134, 21);
            this.lbDate.TabIndex = 23;
            this.lbDate.Text = "Created date:";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Enabled = false;
            this.dgvDetail.Location = new System.Drawing.Point(-2, 257);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 29;
            this.dgvDetail.Size = new System.Drawing.Size(803, 283);
            this.dgvDetail.TabIndex = 25;
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbStatus.Location = new System.Drawing.Point(285, 179);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(360, 27);
            this.txbStatus.TabIndex = 27;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(130, 180);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(119, 21);
            this.lbStatus.TabIndex = 26;
            this.lbStatus.Text = "Order Status:";
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDetail.ForeColor = System.Drawing.Color.White;
            this.lbDetail.Location = new System.Drawing.Point(12, 233);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(149, 21);
            this.lbDetail.TabIndex = 28;
            this.lbDetail.Text = "Product In Order";
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.lbDetail);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.txbDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.txbMemberName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.lbOrderName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderDetail";
            this.Text = "frmOrderDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox txbMemberName;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbOrderName;
        private System.Windows.Forms.TextBox txbDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbDetail;
    }
}