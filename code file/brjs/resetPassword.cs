using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brjs
{
    public partial class resetPassword : Form
    {
        static string sql = "Data Source=DESKTOP-7QUBAIH;Initial Catalog=CNCDB;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=True;User ID = '' ; Password = ''";
        SqlConnection con = new SqlConnection(sql);

        public resetPassword()
        {
            InitializeComponent();
        }

        private void resetPassword_Load(object sender, EventArgs e)
        {


        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE [CNCDB].[dbo].[account] SET password = @NewValue";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.GetValue(0).ToString() == lastPassword.Text)
            {
                if (confirmPassword.Text == newPassword.Text)
                {
                    string pass = newPassword.Text;
                    cmd.Parameters.AddWithValue("@NewValue", pass);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("updated successfully!");
                    this.Close();
                }
                else MessageBox.Show("password not same");
            }
            else MessageBox.Show("error in last password");
        }
        

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
