using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace brjs
{
    public partial class AddItem : Form
    {
        static string sql = "Data Source=DESKTOP-7QUBAIH;Initial Catalog=CNCDB;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=True;User ID = '' ; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        DateTime dateTi;
        public static DataGridView DTGF1 = null;
        public AddItem()
        {
            InitializeComponent();
            DTGF1 = dataGridView1;
        }
      
      
        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.main.Show();
        }

        private void ResetPass_Click(object sender, EventArgs e)
        {
            resetPassword re = new resetPassword();
            re.Show();

        }
        public DataTable GetTable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT TOP 1 * FROM [CNCDB].[dbo].[order] ORDER  BY ID DESC";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        /* public DataTable Add(string query)
         {
             string query2 = "INSERT INTO [CNCDB].[dbo].[order] (Type,[Phone Number],Date,Price,Location,Gruop,Other) VALUES (@Type,@[Phone Number],@Date,@Price,@Location,@Gruop,@Other)" + query;
             DataTable dt = new DataTable();
             con.Open();
             SqlCommand cmd = new SqlCommand(query,con);
             cmd.Parameters.AddWithValue()
             con.Close();
             return dt;
         }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetTable();
        }

        private void addButn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [CNCDB].[dbo].[order] (Type,[Phone Number],Date,Price,Location,[Group],Other) VALUES (@Type,@Phone,@Date,@Price,@Location,@Group,@Other)";
            DataTable dt = new DataTable();
            if (typeTxt.Text == "")
            {
                MessageBox.Show("Invalid Type format. Please enter a valid Type.");
                return;
            }
            int NumberTest;
            if (!int.TryParse(phoneNumTxt.Text, out NumberTest))
            {
                MessageBox.Show("Invalid Phone Number format. Please enter a valid Phone Number.");
                return;
            }
            if (!DateTime.TryParse(dateTxt.Text, out dateTi))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.");
                return;
            }
            if (!int.TryParse(priceTxt.Text, out NumberTest))
            {
                MessageBox.Show("Invalid Price format. Please enter a valid Price.");
                return;
            }
            if (locationTxt.Text == "")
            {
                MessageBox.Show("Invalid Location format. Please enter a valid Location.");
                return;
            }
            if (groupTxt.Text == "")
            {
                MessageBox.Show("Invalid Group format. Please enter a valid Group.");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Type", typeTxt.Text);
            cmd.Parameters.AddWithValue("@Phone", Convert.ToInt64(phoneNumTxt.Text));
            cmd.Parameters.AddWithValue("@Date", dateTi);
            cmd.Parameters.AddWithValue("@Price", Convert.ToInt64(priceTxt.Text));
            cmd.Parameters.AddWithValue("@Location", locationTxt.Text);
            cmd.Parameters.AddWithValue("@Group", groupTxt.Text);
            cmd.Parameters.AddWithValue("@Other", otherTxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("order added!!");
            con.Close();
            typeTxt.Text = "";
            phoneNumTxt.Text = "";
            priceTxt.Text = "";
            locationTxt.Text = "";
            groupTxt.Text = "";
            otherTxt.Text = "";
            dataGridView1.DataSource = GetTable();
        }

        private void dateTxt_MouseEnter(object sender, EventArgs e)
        {
            if (dateTxt.Text == "")
                dateTxt.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ShowOrder showOrder = new ShowOrder();
            showOrder.Show();

        }
         private void billsFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.bills.Show();
        }


    }
}
