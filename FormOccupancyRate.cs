 using Bay_View_Hotel.Tables;
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
    public partial class FormOccupancyRate : Form
    {
        SQLiteConnection dbCon;
        SQLiteCommand sql_cmd;
        SQLiteDataAdapter dataAdapter;
        DataTable dt;

        List<OccupancyRate> occupancyRates;

        public FormOccupancyRate()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                occupancyRates = new List<OccupancyRate>();
                if (cbType.Text == "Any")
                {
                    using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                    {
                        dbCon.Open();
                        //grabs how many nights are booked for all rooms by month for a given year
                        string sql = @"SELECT MonthNo,
                                    MonthName,
                                    CASE WHEN MonthNo <> '01' THEN BookingLength + FromStart + FromEnd - LAG(FromEnd, 1) OVER ( ORDER BY MonthNo )
                                    ELSE BookingLength + FromStart + FromEnd
                                    END AS TotalNightsForMonth,
                                    NumberNightsAvailable,
                                    CASE WHEN MonthNo <> '01' THEN Round((BookingLength + FromStart + FromEnd - LAG(FromEnd, 1) OVER ( ORDER BY MonthNo )) / NumberNightsAvailable * 100, 2)
                                    ELSE Round((BookingLength + FromStart + FromEnd) / NumberNightsAvailable * 100, 2)
                                    END AS OccupancyRate
                                    FROM
                                    (SELECT MonthNo, MonthName,
                                    NumberDays * 27 AS NumberNightsAvailable,
                                    SUM(BookingLength) AS BookingLength,
                                    SUM(FromStart) AS FromStart,
                                    SUM(FromEnd) AS FromEnd
                                    FROM
                                    (SELECT strftime('%m', StartDate) AS MonthNo,
                                    CASE
	                                    WHEN strftime('%m', StartDate) = '01' THEN 'JANUARY'
	                                    WHEN strftime('%m', StartDate) = '02' THEN 'FEBRUARY'
	                                    WHEN strftime('%m', StartDate) = '03' THEN 'MARCH'
	                                    WHEN strftime('%m', StartDate) = '04' THEN 'APRIL'
	                                    WHEN strftime('%m', StartDate) = '05' THEN 'MAY'
	                                    WHEN strftime('%m', StartDate) = '06' THEN 'JUNE'
	                                    WHEN strftime('%m', StartDate) = '07' THEN 'JULY'
	                                    WHEN strftime('%m', StartDate) = '08' THEN 'AUGUST'
	                                    WHEN strftime('%m', StartDate) = '09' THEN 'SEPTEMBER'
	                                    WHEN strftime('%m', StartDate) = '10' THEN 'OCTOBER'
	                                    WHEN strftime('%m', StartDate) = '11' THEN 'NOVEMBER'
	                                    WHEN strftime('%m', StartDate) = '12' THEN 'DECEMBER'
	                                    ELSE 'NULL'
                                    END AS MonthName,
                                    CASE
	                                    WHEN strftime('%m', StartDate) = '01' THEN 31
	                                    WHEN strftime('%m', StartDate) = '02' THEN CASE WHEN (strftime('%Y', StartDate) % 4 = 0 AND strftime('%Y', StartDate) % 100 <> 0) OR strftime('%m', StartDate) % 400 = 0 THEN 29 ELSE 28 END
	                                    WHEN strftime('%m', StartDate) = '03' THEN 31
	                                    WHEN strftime('%m', StartDate) = '04' THEN 30
	                                    WHEN strftime('%m', StartDate) = '05' THEN 31
	                                    WHEN strftime('%m', StartDate) = '06' THEN 30
	                                    WHEN strftime('%m', StartDate) = '07' THEN 31
	                                    WHEN strftime('%m', StartDate) = '08' THEN 31
	                                    WHEN strftime('%m', StartDate) = '09' THEN 30
	                                    WHEN strftime('%m', StartDate) = '10' THEN 31
	                                    WHEN strftime('%m', StartDate) = '11' THEN 30
	                                    WHEN strftime('%m', StartDate) = '12' THEN 31
	                                    ELSE 'NULL'
                                    END AS NumberDays,
                                    CASE
	                                    WHEN(julianday(StartDate) - julianday(StartDate, 'start of month')) < 0
	                                    THEN julianday(StartDate) - julianday(StartDate, 'start of month')
	                                    ELSE 0
                                    END AS FromStart,
                                    CASE
	                                    WHEN julianday(StartDate, 'start of month', '+1 month', '-1 day') - julianday(EndDate) < 0
	                                    THEN julianday(StartDate, 'start of month', '+1 month', '-1 day') - julianday(EndDate)
	                                    ELSE 0
                                    END AS FromEnd,
                                    julianday(EndDate) - julianday(StartDate) as BookingLength
                                    FROM Booking
                                    JOIN Room on Room.RoomNo = Booking.RoomNo
                                    WHERE strftime('%Y', StartDate) = $year
                                    AND BookingNo Not in (SELECT bookingno from BookingCancellation))
                                    GROUP BY MonthName, NumberDays)";
                        sql_cmd = dbCon.CreateCommand();
                        sql_cmd.CommandText = sql;
                        sql_cmd.Parameters.AddWithValue("$year", dtYear.Value.ToString("yyyy"));

                        using (var reader = sql_cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                occupancyRates.Add(new OccupancyRate
                                {
                                    MonthNo = Convert.ToInt32(reader["MonthNo"]),
                                    MonthName = (string)reader["MonthName"],
                                    TotalNightsForMonth = Convert.ToInt32(reader["TotalNightsForMonth"]),
                                    NumberNightsAvailable = Convert.ToInt32(reader["NumberNightsAvailable"]),
                                    OccupancyRateValue = Convert.ToDecimal(reader["OccupancyRate"])
                                });
                            }
                        }
                    }
                }
                else
                {
                    int roomCount = 0;
                    using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                    {
                        dbCon.Open();
                        string sql = @"SELECT COUNT(*) AS RoomCount FROM Room WHERE RoomType = $roomtype";
                        sql_cmd = dbCon.CreateCommand();
                        sql_cmd.CommandText = sql;
                        sql_cmd.Parameters.AddWithValue("$roomtype", cbType.Text);

                        using (var reader = sql_cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                roomCount = Convert.ToInt32(reader["RoomCount"]);
                            }
                        }
                    }
                    using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                    {
                        dbCon.Open();
                        //grabs how many nights are booked for a certain room type by month for a given year
                        string sql = @"SELECT MonthNo,
                                    MonthName,
                                    CASE WHEN MonthNo <> '01' THEN BookingLength + FromStart + FromEnd - LAG(FromEnd, 1) OVER ( ORDER BY MonthNo )
                                    ELSE BookingLength + FromStart + FromEnd
                                    END AS TotalNightsForMonth,
                                    NumberNightsAvailable,
                                    CASE WHEN MonthNo <> '01' THEN Round((BookingLength + FromStart + FromEnd - LAG(FromEnd, 1) OVER ( ORDER BY MonthNo )) / NumberNightsAvailable * 100, 2)
                                    ELSE Round((BookingLength + FromStart + FromEnd) / NumberNightsAvailable * 100, 2)
                                    END AS OccupancyRate
                                    FROM
                                    (SELECT MonthNo, MonthName,
                                    NumberDays * $roomcount AS NumberNightsAvailable,
                                    SUM(BookingLength) AS BookingLength,
                                    SUM(FromStart) AS FromStart,
                                    SUM(FromEnd) AS FromEnd
                                    FROM
                                    (SELECT strftime('%m', StartDate) AS MonthNo,
                                    CASE
	                                    WHEN strftime('%m', StartDate) = '01' THEN 'JANUARY'
	                                    WHEN strftime('%m', StartDate) = '02' THEN 'FEBRUARY'
	                                    WHEN strftime('%m', StartDate) = '03' THEN 'MARCH'
	                                    WHEN strftime('%m', StartDate) = '04' THEN 'APRIL'
	                                    WHEN strftime('%m', StartDate) = '05' THEN 'MAY'
	                                    WHEN strftime('%m', StartDate) = '06' THEN 'JUNE'
	                                    WHEN strftime('%m', StartDate) = '07' THEN 'JULY'
	                                    WHEN strftime('%m', StartDate) = '08' THEN 'AUGUST'
	                                    WHEN strftime('%m', StartDate) = '09' THEN 'SEPTEMBER'
	                                    WHEN strftime('%m', StartDate) = '10' THEN 'OCTOBER'
	                                    WHEN strftime('%m', StartDate) = '11' THEN 'NOVEMBER'
	                                    WHEN strftime('%m', StartDate) = '12' THEN 'DECEMBER'
	                                    ELSE 'NULL'
                                    END AS MonthName,
                                    CASE
	                                    WHEN strftime('%m', StartDate) = '01' THEN 31
	                                    WHEN strftime('%m', StartDate) = '02' THEN CASE WHEN (strftime('%Y', StartDate) % 4 = 0 AND strftime('%Y', StartDate) % 100 <> 0) OR strftime('%m', StartDate) % 400 = 0 THEN 29 ELSE 28 END
	                                    WHEN strftime('%m', StartDate) = '03' THEN 31
	                                    WHEN strftime('%m', StartDate) = '04' THEN 30
	                                    WHEN strftime('%m', StartDate) = '05' THEN 31
	                                    WHEN strftime('%m', StartDate) = '06' THEN 30
	                                    WHEN strftime('%m', StartDate) = '07' THEN 31
	                                    WHEN strftime('%m', StartDate) = '08' THEN 31
	                                    WHEN strftime('%m', StartDate) = '09' THEN 30
	                                    WHEN strftime('%m', StartDate) = '10' THEN 31
	                                    WHEN strftime('%m', StartDate) = '11' THEN 30
	                                    WHEN strftime('%m', StartDate) = '12' THEN 31
	                                    ELSE 'NULL'
                                    END AS NumberDays,
                                    CASE
	                                    WHEN(julianday(StartDate) - julianday(StartDate, 'start of month')) < 0
	                                    THEN julianday(StartDate) - julianday(StartDate, 'start of month')
	                                    ELSE 0
                                    END AS FromStart,
                                    CASE
	                                    WHEN julianday(StartDate, 'start of month', '+1 month', '-1 day') - julianday(EndDate) < 0
	                                    THEN julianday(StartDate, 'start of month', '+1 month', '-1 day') - julianday(EndDate)
	                                    ELSE 0
                                    END AS FromEnd,
                                    julianday(EndDate) - julianday(StartDate) as BookingLength
                                    FROM Booking
                                    JOIN Room on Room.RoomNo = Booking.RoomNo
                                    WHERE strftime('%Y', StartDate) = $year
                                    AND BookingNo Not in (SELECT bookingno from BookingCancellation)
                                    AND RoomType = $roomtype)
                                    GROUP BY MonthName, NumberDays)";
                        sql_cmd = dbCon.CreateCommand();
                        sql_cmd.CommandText = sql;
                        sql_cmd.Parameters.AddWithValue("$year", dtYear.Value.ToString("yyyy"));
                        sql_cmd.Parameters.AddWithValue("$roomtype", cbType.Text);
                        sql_cmd.Parameters.AddWithValue("$roomcount", roomCount);

                        using (var reader = sql_cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                occupancyRates.Add(new OccupancyRate
                                {
                                    MonthNo = Convert.ToInt32(reader["MonthNo"]),
                                    MonthName = (string)reader["MonthName"],
                                    TotalNightsForMonth = Convert.ToInt32(reader["TotalNightsForMonth"]),
                                    NumberNightsAvailable = Convert.ToInt32(reader["NumberNightsAvailable"]),
                                    OccupancyRateValue = Convert.ToDecimal(reader["OccupancyRate"])
                                });
                            }
                        }
                    }
                }
                var list = new BindingList<OccupancyRate>(occupancyRates);
                dgOccupancy.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        private void tsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome frmHome = new FormHome();
            frmHome.FormClosed += (s, args) => this.Close();
            frmHome.Show();
        }
    }
}
