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
    public partial class OrderForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        public OrderForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadBillData();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadBillData();
        }

        public void LoadBillData()
        {
            dataGridView1.Rows.Clear();
            cm = new SqlCommand(@"SELECT b.id
                                  ,p.name
                                  ,[total_quantity]
                                  ,[total_price]
                                  ,[billnumber]
                                  ,[createdby_user]
                              FROM [KeyboardShop_PRN_Assignment].[dbo].[Bill] b JOIN Product p ON b.product_id = p.id
                              WHERE b.billnumber LIKE '%" + textBox1.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "delete")
            {
                if (MessageBox.Show("Delete this order ?", "Delete order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("DELETE FROM [dbo].[Bill] WHERE id  LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Remove successfully");
                    LoadBillData();
                }
            }
        }
    }
}
