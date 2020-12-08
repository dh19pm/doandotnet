namespace QLLK.GUI
{
    partial class GUI_Home
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProducer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrigin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.gpbOption = new System.Windows.Forms.GroupBox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.gpbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Enabled = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(431, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCategory,
            this.btnProducer,
            this.btnOrigin});
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(49, 20);
            this.btnThem.Text = "Thêm";
            // 
            // btnCategory
            // 
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(115, 22);
            this.btnCategory.Text = "Loại";
            // 
            // btnProducer
            // 
            this.btnProducer.Name = "btnProducer";
            this.btnProducer.Size = new System.Drawing.Size(115, 22);
            this.btnProducer.Text = "Hãng";
            // 
            // btnOrigin
            // 
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(115, 22);
            this.btnOrigin.Text = "Xuất Xứ";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(67, 85);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnLogout);
            this.groupBox.Controls.Add(this.txtCreateDate);
            this.groupBox.Controls.Add(this.btnLogin);
            this.groupBox.Controls.Add(this.lbCreateDate);
            this.groupBox.Controls.Add(this.txtPosition);
            this.groupBox.Controls.Add(this.txtUsername);
            this.groupBox.Controls.Add(this.lbUsername);
            this.groupBox.Controls.Add(this.lbPosition);
            this.groupBox.Location = new System.Drawing.Point(12, 37);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(206, 184);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Thông tin tài khoản";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(67, 141);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Location = new System.Drawing.Point(67, 100);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(117, 20);
            this.txtCreateDate.TabIndex = 7;
            this.txtCreateDate.Visible = false;
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(17, 103);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(49, 13);
            this.lbCreateDate.TabIndex = 6;
            this.lbCreateDate.Text = "Khỏi tạo:";
            this.lbCreateDate.Visible = false;
            // 
            // txtPosition
            // 
            this.txtPosition.Enabled = false;
            this.txtPosition.Location = new System.Drawing.Point(67, 67);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(117, 20);
            this.txtPosition.TabIndex = 5;
            this.txtPosition.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(67, 33);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(117, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Visible = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(8, 36);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(58, 13);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Tài khoản:";
            this.lbUsername.Visible = false;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(15, 69);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(50, 13);
            this.lbPosition.TabIndex = 2;
            this.lbPosition.Text = "Chức vụ:";
            this.lbPosition.Visible = false;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(45, 31);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(111, 23);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Sản Phẩm";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(45, 64);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(112, 23);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Hóa Đơn";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(45, 99);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(111, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Nhập Kho";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // gpbOption
            // 
            this.gpbOption.Controls.Add(this.btnAccount);
            this.gpbOption.Controls.Add(this.btnProduct);
            this.gpbOption.Controls.Add(this.btnImport);
            this.gpbOption.Controls.Add(this.btnBill);
            this.gpbOption.Enabled = false;
            this.gpbOption.Location = new System.Drawing.Point(224, 37);
            this.gpbOption.Name = "gpbOption";
            this.gpbOption.Size = new System.Drawing.Size(194, 184);
            this.gpbOption.TabIndex = 5;
            this.gpbOption.TabStop = false;
            this.gpbOption.Text = "Tính năng quản lý";
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(45, 134);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(111, 23);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // GUI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 232);
            this.Controls.Add(this.gpbOption);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI_Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.gpbOption.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox gpbOption;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.ToolStripMenuItem btnCategory;
        private System.Windows.Forms.ToolStripMenuItem btnProducer;
        private System.Windows.Forms.ToolStripMenuItem btnOrigin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPosition;
    }
}