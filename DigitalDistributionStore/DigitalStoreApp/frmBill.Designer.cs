
namespace DigitalStoreApp
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.pnBill = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDateInfo = new System.Windows.Forms.Label();
            this.lbEmployeeIDInfo = new System.Windows.Forms.Label();
            this.lbOrderIDInfo = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbOrderName = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.pnBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetail
            // 
            this.dgvDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Enabled = false;
            this.dgvDetail.Location = new System.Drawing.Point(-1, 185);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 29;
            this.dgvDetail.Size = new System.Drawing.Size(586, 364);
            this.dgvDetail.TabIndex = 26;
            // 
            // pnBill
            // 
            this.pnBill.BackColor = System.Drawing.Color.Transparent;
            this.pnBill.Controls.Add(this.label1);
            this.pnBill.Controls.Add(this.lbDateInfo);
            this.pnBill.Controls.Add(this.lbEmployeeIDInfo);
            this.pnBill.Controls.Add(this.lbOrderIDInfo);
            this.pnBill.Controls.Add(this.lbLogo);
            this.pnBill.Controls.Add(this.ptbLogo);
            this.pnBill.Controls.Add(this.lb1);
            this.pnBill.Controls.Add(this.lb2);
            this.pnBill.Controls.Add(this.lbOrderID);
            this.pnBill.Controls.Add(this.lbOrderName);
            this.pnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBill.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnBill.Location = new System.Drawing.Point(0, 0);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(584, 188);
            this.pnBill.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Date :";
            // 
            // lbDateInfo
            // 
            this.lbDateInfo.AutoSize = true;
            this.lbDateInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDateInfo.ForeColor = System.Drawing.Color.White;
            this.lbDateInfo.Location = new System.Drawing.Point(121, 122);
            this.lbDateInfo.Name = "lbDateInfo";
            this.lbDateInfo.Size = new System.Drawing.Size(87, 20);
            this.lbDateInfo.TabIndex = 34;
            this.lbDateInfo.Text = "00/00/0000";
            // 
            // lbEmployeeIDInfo
            // 
            this.lbEmployeeIDInfo.AutoSize = true;
            this.lbEmployeeIDInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmployeeIDInfo.ForeColor = System.Drawing.Color.White;
            this.lbEmployeeIDInfo.Location = new System.Drawing.Point(177, 87);
            this.lbEmployeeIDInfo.Name = "lbEmployeeIDInfo";
            this.lbEmployeeIDInfo.Size = new System.Drawing.Size(44, 20);
            this.lbEmployeeIDInfo.TabIndex = 33;
            this.lbEmployeeIDInfo.Text = "xxxxx";
            // 
            // lbOrderIDInfo
            // 
            this.lbOrderIDInfo.AutoSize = true;
            this.lbOrderIDInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderIDInfo.ForeColor = System.Drawing.Color.White;
            this.lbOrderIDInfo.Location = new System.Drawing.Point(148, 52);
            this.lbOrderIDInfo.Name = "lbOrderIDInfo";
            this.lbOrderIDInfo.Size = new System.Drawing.Size(37, 20);
            this.lbOrderIDInfo.TabIndex = 32;
            this.lbOrderIDInfo.Text = "xxxx";
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.Color.Transparent;
            this.lbLogo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLogo.Location = new System.Drawing.Point(449, 9);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(109, 37);
            this.lbLogo.TabIndex = 30;
            this.lbLogo.Text = "eStore";
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(483, 45);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(65, 67);
            this.ptbLogo.TabIndex = 31;
            this.ptbLogo.TabStop = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb1.ForeColor = System.Drawing.Color.White;
            this.lb1.Location = new System.Drawing.Point(32, 155);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(182, 22);
            this.lb1.TabIndex = 29;
            this.lb1.Text = "Item(s) purchased :";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb2.ForeColor = System.Drawing.Color.White;
            this.lb2.Location = new System.Drawing.Point(32, 22);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(166, 22);
            this.lb2.TabIndex = 28;
            this.lb2.Text = "Order Information";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderID.ForeColor = System.Drawing.Color.White;
            this.lbOrderID.Location = new System.Drawing.Point(62, 52);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(80, 20);
            this.lbOrderID.TabIndex = 25;
            this.lbOrderID.Text = "Order ID :";
            // 
            // lbOrderName
            // 
            this.lbOrderName.AutoSize = true;
            this.lbOrderName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderName.ForeColor = System.Drawing.Color.White;
            this.lbOrderName.Location = new System.Drawing.Point(62, 87);
            this.lbOrderName.Name = "lbOrderName";
            this.lbOrderName.Size = new System.Drawing.Size(109, 20);
            this.lbOrderName.TabIndex = 24;
            this.lbOrderName.Text = "Employee ID :";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalMoney.ForeColor = System.Drawing.Color.White;
            this.lbTotalMoney.Location = new System.Drawing.Point(102, 552);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(40, 18);
            this.lbTotalMoney.TabIndex = 30;
            this.lbTotalMoney.Text = "0.00";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(172)))), ((int)(((byte)(190)))));
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancel.Location = new System.Drawing.Point(241, 621);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(108, 29);
            this.btCancel.TabIndex = 32;
            this.btCancel.Text = "Confirm";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Total :";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(584, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.pnBill);
            this.Controls.Add(this.dgvDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.pnBill.ResumeLayout(false);
            this.pnBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbOrderName;
        private System.Windows.Forms.Label lbDateInfo;
        private System.Windows.Forms.Label lbEmployeeIDInfo;
        private System.Windows.Forms.Label lbOrderIDInfo;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}