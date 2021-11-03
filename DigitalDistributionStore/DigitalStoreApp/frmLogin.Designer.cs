
namespace DigitalStoreApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.lbStoreName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNewAccount = new System.Windows.Forms.Label();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.btNewAccount = new System.Windows.Forms.Button();
            this.btHelpSignIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.lbStoreName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 37);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(106, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 64);
            this.panel4.TabIndex = 6;
            // 
            // btClose
            // 
            this.btClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(607, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(48, 37);
            this.btClose.TabIndex = 5;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbStoreName
            // 
            this.lbStoreName.AutoSize = true;
            this.lbStoreName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStoreName.ForeColor = System.Drawing.Color.White;
            this.lbStoreName.Location = new System.Drawing.Point(12, 9);
            this.lbStoreName.Name = "lbStoreName";
            this.lbStoreName.Size = new System.Drawing.Size(89, 20);
            this.lbStoreName.TabIndex = 4;
            this.lbStoreName.Text = "Store Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.lbLogo);
            this.panel2.Controls.Add(this.ptbLogo);
            this.panel2.Controls.Add(this.btCancel);
            this.panel2.Controls.Add(this.btLogin);
            this.panel2.Controls.Add(this.lbPassword);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.txbPassword);
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Location = new System.Drawing.Point(38, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 231);
            this.panel2.TabIndex = 0;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLogo.Location = new System.Drawing.Point(128, 18);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(109, 37);
            this.lbLogo.TabIndex = 1;
            this.lbLogo.Text = "eStore";
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(71, 6);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(65, 67);
            this.ptbLogo.TabIndex = 7;
            this.ptbLogo.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(172)))), ((int)(((byte)(190)))));
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancel.Location = new System.Drawing.Point(361, 190);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(214, 29);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "CANCEL";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(172)))), ((int)(((byte)(190)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLogin.Location = new System.Drawing.Point(128, 190);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(214, 29);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "LOGIN";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(43, 134);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(79, 20);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(3, 92);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(119, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Account name";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txbPassword.Location = new System.Drawing.Point(128, 132);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(447, 27);
            this.txbPassword.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.AllowDrop = true;
            this.txbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.ForeColor = System.Drawing.SystemColors.Window;
            this.txbName.Location = new System.Drawing.Point(128, 90);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(447, 27);
            this.txbName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbNewAccount);
            this.panel3.Controls.Add(this.lbSignIn);
            this.panel3.Controls.Add(this.btNewAccount);
            this.panel3.Controls.Add(this.btHelpSignIn);
            this.panel3.Location = new System.Drawing.Point(38, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 109);
            this.panel3.TabIndex = 0;
            // 
            // lbNewAccount
            // 
            this.lbNewAccount.AutoSize = true;
            this.lbNewAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNewAccount.ForeColor = System.Drawing.Color.White;
            this.lbNewAccount.Location = new System.Drawing.Point(32, 67);
            this.lbNewAccount.Name = "lbNewAccount";
            this.lbNewAccount.Size = new System.Drawing.Size(221, 20);
            this.lbNewAccount.TabIndex = 8;
            this.lbNewAccount.Text = "Don\'t have a Store account?";
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSignIn.ForeColor = System.Drawing.Color.White;
            this.lbSignIn.Location = new System.Drawing.Point(88, 23);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(165, 20);
            this.lbSignIn.TabIndex = 7;
            this.lbSignIn.Text = "Need help signing in?";
            // 
            // btNewAccount
            // 
            this.btNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(172)))), ((int)(((byte)(190)))));
            this.btNewAccount.FlatAppearance.BorderSize = 0;
            this.btNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNewAccount.Location = new System.Drawing.Point(259, 63);
            this.btNewAccount.Name = "btNewAccount";
            this.btNewAccount.Size = new System.Drawing.Size(316, 29);
            this.btNewAccount.TabIndex = 6;
            this.btNewAccount.Text = "CREATE A NEW ACCOUNT...";
            this.btNewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNewAccount.UseVisualStyleBackColor = false;
            this.btNewAccount.Click += new System.EventHandler(this.btNewAccount_Click);
            // 
            // btHelpSignIn
            // 
            this.btHelpSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(172)))), ((int)(((byte)(190)))));
            this.btHelpSignIn.FlatAppearance.BorderSize = 0;
            this.btHelpSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelpSignIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btHelpSignIn.Location = new System.Drawing.Point(259, 19);
            this.btHelpSignIn.Name = "btHelpSignIn";
            this.btHelpSignIn.Size = new System.Drawing.Size(316, 29);
            this.btHelpSignIn.TabIndex = 5;
            this.btHelpSignIn.Text = "I CAN\'T SIGN IN... ";
            this.btHelpSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHelpSignIn.UseVisualStyleBackColor = false;
            this.btHelpSignIn.Click += new System.EventHandler(this.btHelpSignIn_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(655, 409);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbStoreName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbNewAccount;
        private System.Windows.Forms.Label lbSignIn;
        private System.Windows.Forms.Button btNewAccount;
        private System.Windows.Forms.Button btHelpSignIn;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.PictureBox ptbLogo;
    }
}