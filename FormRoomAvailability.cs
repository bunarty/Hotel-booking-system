using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using Bay_View_Hotel.Tables;
using System.Collections.Generic;
using System.Linq;

namespace Bay_View_Hotel
{
    public partial class FormRoomAvailability : Form
    {
        // Declare Database variables
        SQLiteConnection dbCon;
        SQLiteCommand sql_cmd;

        List<AvailableRooms> availableRooms = new List<AvailableRooms>();

        public FormRoomAvailability()
        {
            InitializeComponent();
        }

        //Back to Home button
        private void tsBack_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            FormHome frmHome = new FormHome();
            frmHome.FormClosed += (s, args) => this.Close();
            frmHome.Show();
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            try
            {
                availableRooms = new List<AvailableRooms>();
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    string sql = @"SELECT * FROM (
	                                SELECT 
		                                b.RoomNo,
		                                Lag(EndDate, 1) OVER ( ORDER BY StartDate) AS AvailableFrom,
		                                StartDate AS AvailableTo,
                                        r.RoomType
	                                FROM
		                                Booking b
	                                JOIN
		                                room r on r.roomno = b.roomno
	                                WHERE
		                                r.RoomType = $roomtype AND
		                                $isaccessible IN (IsAccessible, 0)
                                )
                                WHERE (AvailableFrom >= $startdate and AvailableFrom <= $enddate) or (AvailableTo >= $startdate and AvailableTo <= $enddate)
                                UNION
                                SELECT
	                                RoomNo,
	                                $startdate AS AvailableFrom,
	                                $enddate AS AvailableTo,
                                    RoomType
                                FROM
	                                Room
                                WHERE
	                                RoomNo NOT IN (select roomno from booking where (startdate >= $startdate and startdate <= $enddate) or (enddate >= $startdate and enddate <= $enddate)) AND RoomType = $roomtype AND $isaccessible IN (IsAccessible, 0)";
                    sql_cmd = dbCon.CreateCommand();
                    sql_cmd.CommandText = sql;
                    sql_cmd.Parameters.AddWithValue("$roomtype", cbRoomType.Text);
                    sql_cmd.Parameters.AddWithValue("$isaccessible", cbSearchAccessible.Checked ? 1 : 0);
                    sql_cmd.Parameters.AddWithValue("$startdate", dtSearchStartDate.Value.ToString("yyyy-MM-dd"));
                    sql_cmd.Parameters.AddWithValue("$enddate", dtSearchEndDate.Value.ToString("yyyy-MM-dd"));

                    using (var reader = sql_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            availableRooms.Add(new AvailableRooms
                            {
                                RoomNo = Convert.ToInt32(reader["RoomNo"]),
                                AvailableFrom = Convert.ToDateTime(reader["AvailableFrom"]),
                                AvailableTo = Convert.ToDateTime(reader["AvailableTo"]),
                                RoomType = (string)reader["RoomType"]
                            });
                        }
                    }
                }

                lstAvailableRooms.Items.Clear();
                for (var i = 0; i < availableRooms.Count(); i++)
                {
                    lstAvailableRooms.Items.Add("Room " + availableRooms[i].RoomNo + " Available between " + availableRooms[i].AvailableFrom.ToString("dd/MM/yyyy") + " and " + availableRooms[i].AvailableTo.ToString("dd/MM/yyyy"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }
    }

}

    

