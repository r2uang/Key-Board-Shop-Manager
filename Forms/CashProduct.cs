using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardShopManagerment_Assignment_PRN211.Forms
{
    public partial class CashProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        public string username = "";
        SqlDataReader dr;
        CashForm cash;
        public CashProduct(CashForm form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            cash = form;
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT [id],[name],[price],[quantity]FROM[KeyboardShop_PRN_Assignment].[dbo].[Product]", cn);
            cn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btSubmitCash_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvProduct.Rows)
            {
                bool checkbox = Convert.ToBoolean(dr.Cells["select"].Value);
                if (checkbox)
                {
                    try
                    {
                        cm = new SqlCommand(@"INSERT INTO [dbo].[Cash]
                                           ([productName]
                                           ,[quantity]
                                           ,[price]
                                           ,[transactionNo]
                                           ,[cashier])
                                     VALUES
                                           (@productName
                                           ,@quantity
                                           ,@price
                                           ,@transactionNo
                                           ,@cashier)", cn);
                        cm.Parameters.AddWithValue("@productName",dr.Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@quantity", 1);
                        cm.Parameters.AddWithValue("@price", Convert.ToDouble(dr.Cells[3].Value.ToString()));
                        cm.Parameters.AddWithValue("@transactionNo", cash.lbTransno.Text);
                        cm.Parameters.AddWithValue("@cashier","Admin");
                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    catch
                    {
                        cn.Close();
                    }
                }
            }  
            cash.LoadCash();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT [id],[name],[price],[quantity]FROM[KeyboardShop_PRN_Assignment].[dbo].[Product] WHERE name LIKE '%" + textBox1.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
