using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brjs
{
    public partial class Bills : Form
    {
        public int GetMonth(DateTime DT)
        {
            int Month;
            if (DT.Month == 2)
            {
                if (DT.Year % 4 == 0)
                    Month = 29;
                else Month = 28;
            }
            else if (DT.Month <= 7)
            {
                if ((DT.Month % 2 == 0))
                    Month = 30;
                else Month = 31;
            }
            else
            {
                if ((DT.Month % 2 != 0))
                    Month = 30;
                else Month = 31;
            }
            return Month;
        }
        public int GetDayDiff(DateTime fromDT, DateTime toDT)
        {
            int dateNumber = (toDT.Year * 365 + GetMonth(toDT) + toDT.Day) - (fromDT.Year * 365 + GetMonth(fromDT) + fromDT.Day);
            return dateNumber;
        }

        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {

        }

        private void addButn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.addItem.Show();
        }

        private void fromDateTxt_MouseEnter(object sender, EventArgs e)
        {
            if (fromDateTxt.Text == "")
                fromDateTxt.Text = DateTime.Now.AddDays(-5).ToString("MM-dd-yyyy");
        }

        private void toDateTxt_MouseEnter(object sender, EventArgs e)
        {
            if (toDateTxt.Text == "")
                toDateTxt.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.main.Show();
        }

        private void calcButn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fromDateTxt.Text);
            DateTime toDate = Convert.ToDateTime(toDateTxt.Text);
            dataBox.Text = $"Differnt days is {GetDayDiff(fromDate, toDate)} and the amount is {amountTxt.Text}\r\t";



        }

        private void ResetPass_Click(object sender, EventArgs e)
        {

        }
    }
}
