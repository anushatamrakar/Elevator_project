using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem.Storage
{
    internal class DBContext
    {
         


        string connectionString = @"Server = DESKTOP-1FI8RBI;Database = Elevator; Trusted_Connection = True;";

        public void InsertLogsIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"Insert into lift (Date,Time,Event) values (@Date,@Time, @Event)";

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime, 0, "Date");
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "Time");
                        adapter.InsertCommand.Parameters.Add("@Event", SqlDbType.NVarChar, 255, "Event");

                        conn.Open();

                        adapter.Update(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB: " + ex.Message);
            }
        }

        public void loadLogsFromDB(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"Select Date,Time, Event from lift  order by Time ;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();

                        adapter.Fill(dt);

                        dataGridViewLogs.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            string currentDate= Convert.ToDateTime(row["Date"]).ToString("hh:mm:ss");
                            string currentTime = Convert.ToDateTime(row["Time"]).ToString("hh:mm:ss");

                            string events = row["Event"].ToString();

                            dataGridViewLogs.Rows.Add(currentDate,currentTime, events);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs from DB: " + ex.Message);
            }

        }
        public void clearLogs(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"Truncate table lift;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        loadLogsFromDB(dt, dataGridViewLogs);
                        dt.Rows.Clear();

                        adapter.Fill(dt);

                        dataGridViewLogs.Rows.Clear();
                        MessageBox.Show("Table cleared successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs from DB: " + ex.Message);
            }

        }

    }
}
