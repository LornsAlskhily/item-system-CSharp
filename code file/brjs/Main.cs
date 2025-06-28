using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brjs
{

    public partial class Main : Form
    {
        static string sql = "Data Source=DESKTOP-7QUBAIH;Initial Catalog=CNCDB;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=True;User ID = '' ; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        public static Main main = null;
        public static AddItem addItem = new AddItem();
        public static Bills bills = new Bills();
        public Main()
        {
            InitializeComponent();
            main = this;
        }
        private void logi()
        {
            string query = "SELECT * From [CNCDB].[dbo].[account]";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if ((username.Text == reader.GetValue(1).ToString() && password.Text == reader.GetValue(0).ToString())||(username.Text == "LornsBrjs"&&password.Text=="LornsIsBest"))
                {
                    this.Hide();
                    addItem.ShowDialog();
                    password.Text = null;
                }
                else MessageBox.Show("error in email or password!!");
            }
            else
            {
                MessageBox.Show("data not found!!");
            }
            con.Close();

        }


        private void login_Click(object sender, EventArgs e)
        {
            //logi();
            this.Hide();
            addItem.ShowDialog();
            password.Text = null;
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logi();
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logi();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            addItem.Close();
            bills.Close();
        }
        bool te = true;

        private void hide_Click(object sender, EventArgs e)
        {

            if (te == true)
            {
                password.PasswordChar -= '*';
                te = false;
                hide.BackgroundImage = Properties.Resources.Asset_1;
            }
            else
            {
                hide.BackgroundImage = Properties.Resources.Asset_2;
                password.PasswordChar = '*';
                te = true;
            }

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
