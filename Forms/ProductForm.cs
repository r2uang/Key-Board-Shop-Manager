
using KeyboardShopManagerment_Assignment_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardShopManagerment_Assignment_PRN211.Forms
{
    public partial class ProductForm : Form
    {
        KeyboardShop_PRN_AssignmentContext context = new KeyboardShop_PRN_AssignmentContext();
        Product currentProduct;
        public ProductForm()
        {
            InitializeComponent();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            loadCategory();
            //DesignDGV();
            LoadProductData();
        }
        private void DesignDGV()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns["id"].DataPropertyName = "Id";
            dataGridView1.Columns.Add("productName", "Product Name");
            dataGridView1.Columns["productName"].DataPropertyName = "productName";
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns["price"].DataPropertyName = "Price";
            dataGridView1.Columns.Add("quantity", "Quantity");
            dataGridView1.Columns["quantity"].DataPropertyName = "Quantity";
            dataGridView1.Columns.Add("status", "Status");
            dataGridView1.Columns["status"].DataPropertyName = "Status";
            dataGridView1.Columns.Add("category", "Category");
            dataGridView1.Columns["category"].DataPropertyName = "Category";
        }
        private void loadCategory()
        {
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = context.Categories.ToList();
            cbCategoryAdd.DisplayMember = "Name";
            cbCategoryAdd.ValueMember = "Id";
            cbCategoryAdd.DataSource = context.Categories.ToList();
        }
        private void LoadProductData()
        {
            dataGridView1.DataSource = context.Products.ToList();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
            dataGridView1.DataSource = context.Products.Where(x => x.CatagoryId == categoryId).ToList();
        }
        private void LoadDataBySearchByProductName()
        {
            string text = tbSearch.Text;
            dataGridView1.DataSource = context.Products.Where(x => x.Name.Contains(text)).ToList();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            LoadDataBySearchByProductName();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = tbProductName.Text;
            double price = double.Parse(tbPrice.Text);
            product.Price = price;
            if (rbStock.Checked == true)
            {
                product.Status = true;
            }
            else
            {
                product.Status = false;
            }
            product.Quantity = Convert.ToInt32(tbQuantity.Text);
            product.CatagoryId = Convert.ToInt32(cbCategoryAdd.SelectedValue);
            context.Products.Add(product);
            int count = context.SaveChanges();
            if (count != 0)
            {
                MessageBox.Show("Add new product successfully");
                ClearData();
            }
            else
            {
                MessageBox.Show("Add new product fail");
                ClearData();
            }
            LoadProductData();

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            
            currentProduct.Name = tbProductName.Text;
            double price = double.Parse(tbPrice.Text);
            currentProduct.Price = price;
            if (rbStock.Checked == true)
            {
                currentProduct.Status = true;
            }
            else
            {
                currentProduct.Status = false;
            }
            currentProduct.Quantity = Convert.ToInt32(tbQuantity.Text);
            currentProduct.CatagoryId = Convert.ToInt32(cbCategoryAdd.SelectedValue);
            context.Products.Update(currentProduct);
            int count = context.SaveChanges();
            if (count != 0)
            {
                MessageBox.Show("Update product successfully");
                ClearData();
            }
            else
            {
                MessageBox.Show("Add product fail");
                ClearData();
            }
            LoadProductData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                Product product = context.Products.First(x => x.Id == currentProduct.Id);
                context.Products.Remove(product); 
                int count = context.SaveChanges(); 
                if(count != 0)
                {
                    MessageBox.Show("Delete successfully");
                    LoadProductData();
                }
                else
                {
                    MessageBox.Show("Delete fail");
                    LoadProductData();
                }
                
            }
        }

        private void ClearData()
        {
            tbProductName.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbQuantity.Text = string.Empty;
            rbStock.Checked = false;
            rbOutOfStock.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            List<Product> products = (List<Product>)dataGridView1.DataSource;
            currentProduct = products[e.RowIndex];
            tbProductName.Text = currentProduct.Name;
            tbPrice.Text = Convert.ToString(currentProduct.Price);
            tbQuantity.Text = Convert.ToString(currentProduct.Quantity);
            if(currentProduct.Status == true)
            {
                rbStock.Checked = true;
            }
            else
            {
                rbOutOfStock.Checked = true;
            }
            cbCategoryAdd.SelectedValue = currentProduct.CatagoryId;
        }

        
    }
}
