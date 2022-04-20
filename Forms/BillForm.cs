using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardShopManagerment_Assignment_PRN211.Forms
{
    public partial class BillForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        CashForm cash;
        public BillForm(CashForm form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            cash = form;
            LoadCash();
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
            LoadCash();
        }
        public void LoadCash()
        {
            Random rnd = new Random();
            int num = rnd.Next(99999);
            dgvBill.Rows.Clear();
            cm = new SqlCommand(@"SELECT p.id,c.productName,c.quantity,c.total FROM [dbo].[Cash] as c 
                                LEFT JOIN [Product] as p ON c.productName = p.name WHERE c.transactionNo LIKE '" + cash.lbTransno.Text + "'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvBill.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
            lbBillNumber.Text = num.ToString();
            lbTotal.Text = cash.lbTotal.Text;
        }

        private void btAddToBill_Click(object sender, EventArgs e)
        {
            DateTime insertDate = DateTime.Now;
            foreach (DataGridViewRow dr in dgvBill.Rows)
            {
                try
                {
                    cm = new SqlCommand(@"INSERT INTO [dbo].[Bill]
                                       ([createdby_user]
                                       ,[create_date]
                                       ,[product_id]
                                       ,[total_price]
                                       ,[total_quantity]
                                       ,[billnumber])
                                 VALUES
                                       (@createdby_user
                                       ,@create_date
                                       ,@product_id
                                       ,@total_price
                                       ,@total_quantity
                                       ,@billnumber)", cn);
                    cm.Parameters.AddWithValue("@createdby_user", "Admin");
                    cm.Parameters.AddWithValue("@create_date", insertDate);
                    cm.Parameters.AddWithValue("@product_id", Convert.ToInt32(dr.Cells[0].Value.ToString()));
                    cm.Parameters.AddWithValue("@total_price", Convert.ToDouble(dr.Cells[3].Value.ToString()));
                    cm.Parameters.AddWithValue("@total_quantity", Convert.ToInt32(dr.Cells[2].Value.ToString()));
                    cm.Parameters.AddWithValue("@billnumber", lbBillNumber.Text);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                }
                catch
                {
                    cn.Close();
                }
                this.Close();
            }
        }
    }
}

