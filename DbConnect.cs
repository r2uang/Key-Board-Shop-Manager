using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KeyboardShopManagerment_Assignment_PRN211
{
    class DbConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;

        public string connection()
        {
            con = @"server=localhost; database=KeyboardShop_PRN_Assignment;uid=se1514;password=se1514";
            return con;
        }
        public void executeQuery(string sql)
        {
            try
            {
                cn.ConnectionString = connection();
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception )
            {
                cn.Close();
            }
        }
    }
}
