
namespace DigitalDistributionStoreWinApp
{
    partial class frmCategoryInsert
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
            this.lbCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.AutoSize = true;
            this.lbCategoryName.Location = new System.Drawing.Point(113, 18);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Size = new System.Drawing.Size(113, 20);
            this.lbCategoryName.TabIndex = 1;
            this.lbCategoryName.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(13, 53);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(320, 27);
            this.txtCategoryName.TabIndex = 3;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 100);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(239, 100);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmCategoryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 152);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lbCategoryName);
            this.Name = "frmCategoryInsert";
            this.Text = "Category Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
    }
}