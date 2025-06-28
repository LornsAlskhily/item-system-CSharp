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

namespace brjs
{

    public partial class ShowOrder : Form
    {
        static String sql = "Data Source=DESKTOP-7QUBAIH;Initial Catalog=CNCDB;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=True;User ID = '' ; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        public DataTable GetTable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [CNCDB].[dbo].[order]";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public ShowOrder()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetTable();
        }

        private void ShowOrder_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT TOP 1 * FROM [CNCDB].[dbo].[order] ORDER  BY ID DESC";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();
            AddItem.DTGF1.DataSource = dt;
            this.Close();

        } 
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
                editTxt.Text = dataGridView1.CurrentCell.Value.ToString();
            else
                editTxt.Text = "";
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentCell != null)
            {
                int orderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                string columnName = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name;
                string newValue = editTxt.Text;
                string query = $"UPDATE [CNCDB].[dbo].[order] SET [{columnName}] = @NewValue WHERE ID = @ID";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.Parameters.AddWithValue("@ID", orderId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    con.Close();
                    dataGridView1.DataSource = GetTable();
                }
            }
            else
            {
                MessageBox.Show("Please select a cell to edit.");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delet this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                searchTxt.ForeColor = Color.Gray;
                searchTxt.Text = "Search";
                con.Open();
                string query = "DELETE FROM  [CNCDB].[dbo].[order] WHERE ID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteReader();
                con.Close();
                dataGridView1.DataSource = GetTable();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [CNCDB].[dbo].[order] WHERE " +
                           "Type LIKE @searchText OR " +
                           "[Phone Number] LIKE @searchText OR " +
                           "Date LIKE @searchText OR " +
                           "Price LIKE @searchText OR " +
                           "Location LIKE @searchText OR " +
                           "[Group] LIKE @searchText OR " +
                           "Other LIKE @searchText";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchTxt.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void searchTxt_Enter(object sender, EventArgs e)
        {
            if (searchTxt.Text == "Search")
            {
                searchTxt.Text = string.Empty;
                searchTxt.ForeColor = Color.Black;
            }
        }

        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (searchTxt.Text == string.Empty)
            {
                searchTxt.ForeColor = Color.Gray;
                searchTxt.Text = "Search";
            }
        }

        private void editTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                saveBtn_Click(sender, e);
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            searchBtn_Click(sender, e);
        }
    }
}
