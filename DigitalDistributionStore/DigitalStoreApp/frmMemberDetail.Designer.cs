
namespace DigitalStoreApp
{
    partial class frmMemberDetail
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
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbMemberName = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbOrderName = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbStatus.Location = new System.Drawing.Point(285, 222);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(360, 27);
            this.txbStatus.TabIndex = 35;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(107, 223);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(142, 21);
            this.lbStatus.TabIndex = 34;
            this.lbStatus.Text = "Member Status:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Enabled = false;
            this.txbEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbEmail.Location = new System.Drawing.Point(285, 168);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(360, 27);
            this.txbEmail.TabIndex = 33;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Enabled = false;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(187, 169);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 21);
            this.lbEmail.TabIndex = 32;
            this.lbEmail.Text = "Email :";
            // 
            // txbMemberName
            // 
            this.txbMemberName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMemberName.Enabled = false;
            this.txbMemberName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbMemberName.Location = new System.Drawing.Point(285, 114);
            this.txbMemberName.Name = "txbMemberName";
            this.txbMemberName.Size = new System.Drawing.Size(360, 27);
            this.txbMemberName.TabIndex = 31;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbID.Enabled = false;
            this.txbID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbID.Location = new System.Drawing.Point(285, 60);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(360, 27);
            this.txbID.TabIndex = 30;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderID.ForeColor = System.Drawing.Color.White;
            this.lbOrderID.Location = new System.Drawing.Point(135, 61);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(114, 21);
            this.lbOrderID.TabIndex = 29;
            this.lbOrderID.Text = "Member ID :";
            // 
            // lbOrderName
            // 
            this.lbOrderName.AutoSize = true;
            this.lbOrderName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderName.ForeColor = System.Drawing.Color.White;
            this.lbOrderName.Location = new System.Drawing.Point(102, 115);
            this.lbOrderName.Name = "lbOrderName";
            this.lbOrderName.Size = new System.Drawing.Size(147, 21);
            this.lbOrderName.TabIndex = 28;
            this.lbOrderName.Text = "Member Name :";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(442, 312);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(231, 28);
            this.btCancel.TabIndex = 37;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btConfirm.FlatAppearance.BorderSize = 0;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConfirm.ForeColor = System.Drawing.Color.White;
            this.btConfirm.Location = new System.Drawing.Point(102, 312);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(231, 28);
            this.btConfirm.TabIndex = 36;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // frmMemberDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txbMemberName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.lbOrderName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemberDetail";
            this.Text = "frmMemberDetail";
            this.Load += new System.EventHandler(this.frmMemberDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbMemberName;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbOrderName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
    }
}