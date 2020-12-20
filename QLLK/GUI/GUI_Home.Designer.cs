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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Home));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProducer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrigin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogin = new System.Windows.Forms.ToolStripButton();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProducts = new System.Windows.Forms.ToolStripButton();
            this.btnBill = new System.Windows.Forms.ToolStripButton();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnRevenue = new System.Windows.Forms.ToolStripButton();
            this.btnAccounts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTutorial = new System.Windows.Forms.ToolStripButton();
            this.btnInformation = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(709, 24);
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
            this.btnCategory.Size = new System.Drawing.Size(180, 22);
            this.btnCategory.Text = "Loại";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProducer
            // 
            this.btnProducer.Name = "btnProducer";
            this.btnProducer.Size = new System.Drawing.Size(180, 22);
            this.btnProducer.Text = "Hãng";
            this.btnProducer.Click += new System.EventHandler(this.btnProducer_Click);
            // 
            // btnOrigin
            // 
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(180, 22);
            this.btnOrigin.Text = "Xuất Xứ";
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogin,
            this.btnLogout,
            this.toolStripSeparator1,
            this.btnProducts,
            this.btnBill,
            this.btnCustomer,
            this.btnRevenue,
            this.btnAccounts,
            this.toolStripSeparator2,
            this.btnTutorial,
            this.btnInformation,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 60);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(71, 57);
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(66, 57);
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // btnProducts
            // 
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(64, 57);
            this.btnProducts.Text = "Sản Phẩm";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnBill
            // 
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(58, 57);
            this.btnBill.Text = "Hóa Đơn";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(76, 57);
            this.btnCustomer.Text = "Khách Hàng";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenue.Image")));
            this.btnRevenue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRevenue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(69, 57);
            this.btnRevenue.Text = "Doanh Thu";
            this.btnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Image = ((System.Drawing.Image)(resources.GetObject("btnAccounts.Image")));
            this.btnAccounts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(62, 57);
            this.btnAccounts.Text = "Tài Khoản";
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // btnTutorial
            // 
            this.btnTutorial.Image = ((System.Drawing.Image)(resources.GetObject("btnTutorial.Image")));
            this.btnTutorial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTutorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(72, 57);
            this.btnTutorial.Text = "Hướng Dẫn";
            this.btnTutorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Image = ((System.Drawing.Image)(resources.GetObject("btnInformation.Image")));
            this.btnInformation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(64, 57);
            this.btnInformation.Text = "Thông Tin";
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 57);
            this.btnExit.Text = "Thoát Ngay";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GUI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(709, 489);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI_Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Linh Kiện Máy Tính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_Home_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnCategory;
        private System.Windows.Forms.ToolStripMenuItem btnProducer;
        private System.Windows.Forms.ToolStripMenuItem btnOrigin;
        private System.Windows.Forms.ToolStripButton btnProducts;
        private System.Windows.Forms.ToolStripButton btnLogin;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripButton btnBill;
        private System.Windows.Forms.ToolStripButton btnRevenue;
        private System.Windows.Forms.ToolStripButton btnAccounts;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnTutorial;
        private System.Windows.Forms.ToolStripButton btnInformation;
    }
}