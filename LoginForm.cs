using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KeyboardShopManagerment_Assignment_PRN211
{
    public partial class LoginForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand(@"SELECT [username]
                                    FROM[dbo].[User] WHERE username=@name AND password=@password",cn);
                cm.Parameters.AddWithValue("@name", tbUserName.Text);
                cm.Parameters.AddWithValue("@password", tbPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MainForm m = new MainForm();
                    m.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
