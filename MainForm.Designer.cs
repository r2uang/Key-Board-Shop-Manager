
namespace KeyboardShopManagerment_Assignment_PRN211
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.icbtCart = new FontAwesome.Sharp.IconButton();
            this.icbtOrder = new FontAwesome.Sharp.IconButton();
            this.icbCustomer = new FontAwesome.Sharp.IconButton();
            this.icbtProduct = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.btMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btExit = new FontAwesome.Sharp.IconPictureBox();
            this.labelCurrentChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).BeginInit();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.icbtCart);
            this.panelMenu.Controls.Add(this.icbtOrder);
            this.panelMenu.Controls.Add(this.icbCustomer);
            this.panelMenu.Controls.Add(this.icbtProduct);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 637);
            this.panelMenu.TabIndex = 0;
            // 
            // icbtCart
            // 
            this.icbtCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtCart.FlatAppearance.BorderSize = 0;
            this.icbtCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.icbtCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.icbtCart.IconColor = System.Drawing.Color.Gainsboro;
            this.icbtCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtCart.IconSize = 32;
            this.icbtCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtCart.Location = new System.Drawing.Point(0, 320);
            this.icbtCart.Name = "icbtCart";
            this.icbtCart.Size = new System.Drawing.Size(220, 60);
            this.icbtCart.TabIndex = 6;
            this.icbtCart.Text = "Cart";
            this.icbtCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtCart.UseVisualStyleBackColor = true;
            this.icbtCart.Click += new System.EventHandler(this.icbtCart_Click);
            // 
            // icbtOrder
            // 
            this.icbtOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtOrder.FlatAppearance.BorderSize = 0;
            this.icbtOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.icbtOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.icbtOrder.IconColor = System.Drawing.Color.Gainsboro;
            this.icbtOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtOrder.IconSize = 32;
            this.icbtOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtOrder.Location = new System.Drawing.Point(0, 260);
            this.icbtOrder.Name = "icbtOrder";
            this.icbtOrder.Size = new System.Drawing.Size(220, 60);
            this.icbtOrder.TabIndex = 5;
            this.icbtOrder.Text = "Orders";
            this.icbtOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtOrder.UseVisualStyleBackColor = true;
            this.icbtOrder.Click += new System.EventHandler(this.icbtOrder_Click);
            // 
            // icbCustomer
            // 
            this.icbCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbCustomer.FlatAppearance.BorderSize = 0;
            this.icbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.icbCustomer.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.icbCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.icbCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbCustomer.IconSize = 32;
            this.icbCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbCustomer.Location = new System.Drawing.Point(0, 200);
            this.icbCustomer.Name = "icbCustomer";
            this.icbCustomer.Size = new System.Drawing.Size(220, 60);
            this.icbCustomer.TabIndex = 3;
            this.icbCustomer.Text = "User";
            this.icbCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbCustomer.UseVisualStyleBackColor = true;
            this.icbCustomer.Click += new System.EventHandler(this.icbCustomer_Click);
            // 
            // icbtProduct
            // 
            this.icbtProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbtProduct.FlatAppearance.BorderSize = 0;
            this.icbtProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.icbtProduct.IconChar = FontAwesome.Sharp.IconChar.Keyboard;
            this.icbtProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.icbtProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtProduct.IconSize = 32;
            this.icbtProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtProduct.Location = new System.Drawing.Point(0, 140);
            this.icbtProduct.Name = "icbtProduct";
            this.icbtProduct.Size = new System.Drawing.Size(220, 60);
            this.icbtProduct.TabIndex = 2;
            this.icbtProduct.Text = "Product";
            this.icbtProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtProduct.UseVisualStyleBackColor = true;
            this.icbtProduct.Click += new System.EventHandler(this.icbtProduct_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btHome);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // btHome
            // 
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(220, 96);
            this.btHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btHome.TabIndex = 0;
            this.btHome.TabStop = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(37, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "2uang Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.titleBar.Controls.Add(this.btMinimize);
            this.titleBar.Controls.Add(this.btMaximize);
            this.titleBar.Controls.Add(this.btExit);
            this.titleBar.Controls.Add(this.labelCurrentChildForm);
            this.titleBar.Controls.Add(this.iconCurrentChildFormIcon);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(220, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1139, 75);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMinimize.IconSize = 19;
            this.btMinimize.Location = new System.Drawing.Point(1031, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(32, 19);
            this.btMinimize.TabIndex = 4;
            this.btMinimize.TabStop = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btMaximize
            // 
            this.btMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMaximize.IconSize = 19;
            this.btMaximize.Location = new System.Drawing.Point(1069, 0);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(32, 19);
            this.btMaximize.TabIndex = 3;
            this.btMaximize.TabStop = false;
            this.btMaximize.Click += new System.EventHandler(this.btMaximize_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btExit.IconSize = 19;
            this.btExit.Location = new System.Drawing.Point(1107, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(32, 19);
            this.btExit.TabIndex = 2;
            this.btExit.TabStop = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // labelCurrentChildForm
            // 
            this.labelCurrentChildForm.AutoSize = true;
            this.labelCurrentChildForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentChildForm.Location = new System.Drawing.Point(62, 24);
            this.labelCurrentChildForm.Name = "labelCurrentChildForm";
            this.labelCurrentChildForm.Size = new System.Drawing.Size(43, 17);
            this.labelCurrentChildForm.TabIndex = 1;
            this.labelCurrentChildForm.Text = "Home";
            // 
            // iconCurrentChildFormIcon
            // 
            this.iconCurrentChildFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildFormIcon.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildFormIcon.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildFormIcon.Location = new System.Drawing.Point(24, 24);
            this.iconCurrentChildFormIcon.Name = "iconCurrentChildFormIcon";
            this.iconCurrentChildFormIcon.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildFormIcon.TabIndex = 0;
            this.iconCurrentChildFormIcon.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1139, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1139, 553);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 637);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btHome)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton icbtOrder;
        private FontAwesome.Sharp.IconButton icbCustomer;
        private FontAwesome.Sharp.IconButton icbtProduct;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton icbtCart;
        private System.Windows.Forms.PictureBox btHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label labelCurrentChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFormIcon;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox btMinimize;
        private FontAwesome.Sharp.IconPictureBox btMaximize;
    }
}