using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bay_View_Hotel
{
    public partial class FormIncomeGenerated : Form
    {
        SQLiteConnection dbCon;
        SQLiteCommand sql_cmd;
        SQLiteDataAdapter dataAdapter;
        DataTable dt;

        int selectedIncome;
        int totalIncome;

        public FormIncomeGenerated()
        {
            InitializeComponent();
        }

        private void FormIncomeGenerated_Load(object sender, EventArgs e)
        {
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            totalIncome = 0;
            //grab all bookings between given dates
            using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
            {
                dbCon.Open();
                string sql = @"SELECT * FROM Booking WHERE StartDate BETWEEN $from AND $to";
                sql_cmd = dbCon.CreateCommand();
                sql_cmd.CommandText = sql;
                sql_cmd.Parameters.AddWithValue("$from", dtFrom.Value.ToString("yyyy-MM-dd"));
                sql_cmd.Parameters.AddWithValue("$to", dtTo.Value.ToString("yyyy-MM-dd"));

                dataAdapter = new SQLiteDataAdapter(sql_cmd);
                dt = new DataTable();
                dataAdapter.Fill(dt);
                dgIncome.DataSource = dt;
            }

            //calculate total for all bookings displayed
            foreach (DataRow row in dt.Rows)
            {
                totalIncome += Convert.ToInt32(row["BookingCost"]);
            }

            //display total on screen
            txtTotalIncome.Text = "£" + totalIncome.ToString();
        }

        private void tsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome frmHome = new FormHome();
            frmHome.FormClosed += (s, args) => this.Close();
            frmHome.Show();
        }

        private void dgIncome_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //logic so user can grab the total cost from only the selected rows
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            selectedIncome = 0;
            foreach (DataGridViewRow row in dgIncome.SelectedRows)
            {
                selectedIncome += Convert.ToInt32(row.Cells[9].Value);
            }

            txtSelectedAmount.Text = "£" + selectedIncome.ToString();
        }
    }
}
