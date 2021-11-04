
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbOrderName = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.lbOrderIDInfo = new System.Windows.Forms.Label();
            this.lbEmployeeIDInfo = new System.Windows.Forms.Label();
            this.lbDateInfo = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.lbUSD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDateInfo);
            this.panel1.Controls.Add(this.lbEmployeeIDInfo);
            this.panel1.Controls.Add(this.lbOrderIDInfo);
            this.panel1.Controls.Add(this.lbLogo);
            this.panel1.Controls.Add(this.ptbLogo);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbOrderID);
            this.panel1.Controls.Add(this.lbOrderName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 188);
            this.panel1.TabIndex = 28;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Enabled = false;
            this.lbDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(62, 122);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(53, 20);
            this.lbDate.TabIndex = 26;
            this.lbDate.Text = "Date :";
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
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Enabled = false;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb3.ForeColor = System.Drawing.Color.White;
            this.lb3.Location = new System.Drawing.Point(32, 552);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(49, 18);
            this.lb3.TabIndex = 27;
            this.lb3.Text = "Total :";
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
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Enabled = false;
            this.lb4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb4.ForeColor = System.Drawing.Color.White;
            this.lb4.Location = new System.Drawing.Point(226, 611);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(154, 21);
            this.lb4.TabIndex = 29;
            this.lb4.Text = "Thanks for buying!";
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
            // lbUSD
            // 
            this.lbUSD.AutoSize = true;
            this.lbUSD.Enabled = false;
            this.lbUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUSD.ForeColor = System.Drawing.Color.White;
            this.lbUSD.Location = new System.Drawing.Point(165, 552);
            this.lbUSD.Name = "lbUSD";
            this.lbUSD.Size = new System.Drawing.Size(43, 18);
            this.lbUSD.TabIndex = 31;
            this.lbUSD.Text = "USD";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(584, 642);
            this.Controls.Add(this.lbUSD);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.dgvDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.Text = "frmBill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbOrderName;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbDateInfo;
        private System.Windows.Forms.Label lbEmployeeIDInfo;
        private System.Windows.Forms.Label lbOrderIDInfo;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label lbUSD;
    }
}