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
    public partial class CashForm : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        public CashForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            getTransaction();
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            getTransaction();
            LoadCash();
        }
        public void getTransaction()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transactionNo FROM Cash WHERE transactionNo LIKE '%" + sdate + "%' ORDER BY id DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lbTransno.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lbTransno.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception)
            {
                cn.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "delete")
            {
                if (MessageBox.Show("Delete this cash ?", "Delete cash", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("DELETE FROM [dbo].[Cash] WHERE id LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Remove successfully");
                }
            }
            else if (colName == "increase")
            {
                int i = CheckQuantityProduct(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (i > int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()))
                {
                    dbcon.executeQuery("UPDATE [dbo].[Cash] SET [quantity] = quantity +" + 1 + "WHERE id LIKE'" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                }
                else
                {
                    MessageBox.Show("Out of stock");
                    return;
                }
               
            }
            else if (colName == "decrease")
            {
                    dbcon.executeQuery("UPDATE [dbo].[Cash] SET [quantity] = quantity -" + 1 + "WHERE id LIKE'" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");      
            }
            LoadCash();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CashProduct c = new CashProduct(this);
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillForm bill = new BillForm(this);
            bill.ShowDialog();
        }

        public void LoadCash()
        {
            dataGridView1.Rows.Clear();
            double total = 0;
            cm = new SqlCommand(@"SELECT c.id,c.productName,c.quantity,c.price,c.total,u.username FROM [dbo].[Cash] as c 
                                LEFT JOIN [User] as u ON c.cashier = u.id WHERE c.transactionNo LIKE '" + lbTransno.Text + "'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                total += double.Parse(dr[4].ToString());
            }
            dr.Close();
            cn.Close();
            lbTotal.Text = total.ToString("#,##0.00");
        }

        public int CheckQuantityProduct(String productName)
        {
            int i = 0;
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT quantity FROM Product WHERE name LIKE '" + productName + "'",cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
            }
            catch(Exception)
            {
                cn.Close();
            }
            return i;
        }
    }
}
