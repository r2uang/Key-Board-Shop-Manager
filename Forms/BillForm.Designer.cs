
namespace KeyboardShopManagerment_Assignment_PRN211.Forms
{
    partial class BillForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCashierName = new System.Windows.Forms.Label();
            this.btAddToBill = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbBillName = new System.Windows.Forms.Label();
            this.lbBillNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intomoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Cashier:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(104, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "Payment receipt";
            // 
            // lbCashierName
            // 
            this.lbCashierName.AutoSize = true;
            this.lbCashierName.Location = new System.Drawing.Point(84, 71);
            this.lbCashierName.Name = "lbCashierName";
            this.lbCashierName.Size = new System.Drawing.Size(76, 15);
            this.lbCashierName.TabIndex = 66;
            this.lbCashierName.Text = "cashierName";
            // 
            // btAddToBill
            // 
            this.btAddToBill.BackColor = System.Drawing.Color.Yellow;
            this.btAddToBill.Location = new System.Drawing.Point(104, 441);
            this.btAddToBill.Name = "btAddToBill";
            this.btAddToBill.Size = new System.Drawing.Size(104, 23);
            this.btAddToBill.TabIndex = 68;
            this.btAddToBill.Text = "Print Bill";
            this.btAddToBill.UseVisualStyleBackColor = false;
            this.btAddToBill.Click += new System.EventHandler(this.btAddToBill_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(262, 394);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(28, 15);
            this.lbTotal.TabIndex = 71;
            this.lbTotal.Text = "0.00";
            // 
            // lbBillName
            // 
            this.lbBillName.AutoSize = true;
            this.lbBillName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBillName.Location = new System.Drawing.Point(12, 107);
            this.lbBillName.Name = "lbBillName";
            this.lbBillName.Size = new System.Drawing.Size(83, 17);
            this.lbBillName.TabIndex = 72;
            this.lbBillName.Text = "Bill Number:";
            // 
            // lbBillNumber
            // 
            this.lbBillNumber.AutoSize = true;
            this.lbBillNumber.Location = new System.Drawing.Point(104, 109);
            this.lbBillNumber.Name = "lbBillNumber";
            this.lbBillNumber.Size = new System.Drawing.Size(37, 15);
            this.lbBillNumber.TabIndex = 73;
            this.lbBillNumber.Text = "00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(216, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "Total:";
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.productName,
            this.quantity,
            this.intomoney});
            this.dgvBill.Location = new System.Drawing.Point(12, 137);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowTemplate.Height = 25;
            this.dgvBill.Size = new System.Drawing.Size(304, 228);
            this.dgvBill.TabIndex = 75;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // intomoney
            // 
            this.intomoney.HeaderText = "Into Money";
            this.intomoney.Name = "intomoney";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 512);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbBillNumber);
            this.Controls.Add(this.lbBillName);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btAddToBill);
            this.Controls.Add(this.lbCashierName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashCustomercs";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCashierName;
        private System.Windows.Forms.Button btAddToBill;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbBillName;
        private System.Windows.Forms.Label lbBillNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn intomoney;
    }
}