
namespace KeyboardShopManagerment_Assignment_PRN211.Forms
{
    partial class ProductForm
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
            this.btSearch = new FontAwesome.Sharp.IconButton();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddProduct = new FontAwesome.Sharp.IconButton();
            this.btEdit = new FontAwesome.Sharp.IconButton();
            this.btDelete = new FontAwesome.Sharp.IconButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.rbStock = new System.Windows.Forms.RadioButton();
            this.rbOutOfStock = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbCategoryAdd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSearch
            // 
            this.btSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btSearch.IconColor = System.Drawing.Color.Black;
            this.btSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSearch.IconSize = 20;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSearch.Location = new System.Drawing.Point(627, 35);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(34, 23);
            this.btSearch.TabIndex = 1;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "ALL"});
            this.cbCategory.Location = new System.Drawing.Point(32, 36);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(140, 23);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(178, 36);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Search";
            this.tbSearch.Size = new System.Drawing.Size(443, 23);
            this.tbSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by product name";
            // 
            // btAddProduct
            // 
            this.btAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAddProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btAddProduct.IconColor = System.Drawing.Color.Black;
            this.btAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAddProduct.IconSize = 25;
            this.btAddProduct.Location = new System.Drawing.Point(677, 418);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(134, 43);
            this.btAddProduct.TabIndex = 6;
            this.btAddProduct.Text = "Add";
            this.btAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddProduct.UseVisualStyleBackColor = false;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btEdit.IconColor = System.Drawing.Color.Black;
            this.btEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEdit.IconSize = 25;
            this.btEdit.Location = new System.Drawing.Point(826, 418);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(134, 43);
            this.btEdit.TabIndex = 7;
            this.btEdit.Text = "Edit";
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btDelete.IconColor = System.Drawing.Color.Black;
            this.btDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDelete.IconSize = 25;
            this.btDelete.Location = new System.Drawing.Point(977, 418);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(134, 43);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Delete";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // id
            // 
            this.id.Name = "id";
            // 
            // productName
            // 
            this.productName.Name = "productName";
            // 
            // price
            // 
            this.price.Name = "price";
            // 
            // status
            // 
            this.status.Name = "status";
            // 
            // category
            // 
            this.category.Name = "category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(677, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Name";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(800, 92);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(222, 23);
            this.tbProductName.TabIndex = 13;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(800, 206);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(222, 23);
            this.tbPrice.TabIndex = 14;
            // 
            // rbStock
            // 
            this.rbStock.AutoSize = true;
            this.rbStock.Location = new System.Drawing.Point(800, 268);
            this.rbStock.Name = "rbStock";
            this.rbStock.Size = new System.Drawing.Size(54, 19);
            this.rbStock.TabIndex = 16;
            this.rbStock.TabStop = true;
            this.rbStock.Text = "Stock";
            this.rbStock.UseVisualStyleBackColor = true;
            // 
            // rbOutOfStock
            // 
            this.rbOutOfStock.AutoSize = true;
            this.rbOutOfStock.Location = new System.Drawing.Point(935, 268);
            this.rbOutOfStock.Name = "rbOutOfStock";
            this.rbOutOfStock.Size = new System.Drawing.Size(87, 19);
            this.rbOutOfStock.TabIndex = 17;
            this.rbOutOfStock.TabStop = true;
            this.rbOutOfStock.Text = "OutOfStock";
            this.rbOutOfStock.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(677, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(677, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(677, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Category";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quantity.Location = new System.Drawing.Point(677, 209);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(43, 20);
            this.Quantity.TabIndex = 21;
            this.Quantity.Text = "Price";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(800, 150);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(222, 23);
            this.tbQuantity.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(32, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(629, 369);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cbCategoryAdd
            // 
            this.cbCategoryAdd.FormattingEnabled = true;
            this.cbCategoryAdd.Items.AddRange(new object[] {
            "ALL"});
            this.cbCategoryAdd.Location = new System.Drawing.Point(800, 339);
            this.cbCategoryAdd.Name = "cbCategoryAdd";
            this.cbCategoryAdd.Size = new System.Drawing.Size(222, 23);
            this.cbCategoryAdd.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Category";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1123, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoryAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbOutOfStock);
            this.Controls.Add(this.rbStock);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btSearch);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btAddProduct;
        private FontAwesome.Sharp.IconButton btEdit;
        private FontAwesome.Sharp.IconButton btDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.RadioButton rbStock;
        private System.Windows.Forms.RadioButton rbOutOfStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbCategoryAdd;
        private System.Windows.Forms.Label label2;
    }
}