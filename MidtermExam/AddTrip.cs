using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MidtermExam
{
    public partial class AddTrip : Form
    {
        DbUtil dbUtil = new DbUtil();

        public AddTrip()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string shipname = shipsComboBox.SelectedItem.ToString();
            string portname = portListBox.SelectedItem.ToString();
            int shipcode = shipsComboBox.SelectedIndex + 1;
            int portcode = portListBox.SelectedIndex + 1;
            int count=0;
            using (SqlConnection c = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select Count(*) from Trip where Date >= @TodayPlusWeek and ShipCode=@shipcode", c))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@TodayPlusWeek", DateTime.Today.AddDays(7).ToString("MM-dd-yyyy")));
                    sqlCommand.Parameters.Add(new SqlParameter("@shipcode", shipcode));
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        count = Convert.ToInt32(sqlReader.GetValue(0));
                    }
                }
            }
            if (count == 0)
            {
                using (SqlConnection c = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Trip (ShipCode, PortCode, Date) VALUES (@shipcode, @portcode,@date) ", c))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@shipcode", shipcode));
                        sqlCommand.Parameters.Add(new SqlParameter("@portcode", portcode));
                        sqlCommand.Parameters.Add(new SqlParameter("@date", tripDateTimePicker.Value.Date));
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            else MessageBox.Show("The Ship has a scheduled trip");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTrip_Load(object sender, EventArgs e)
        {
            tripDateTimePicker.MinDate = DateTime.Today.AddDays(7);

            using (SqlConnection c = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {
                using (SqlCommand sqlCommand = new SqlCommand("Select * from Ship", c))
                {
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        shipsComboBox.Items.Add(sqlReader.GetValue(1).ToString());
                    }
                }
            }

            using (SqlConnection c = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {
                using (SqlCommand sqlCommand = new SqlCommand("Select * from Port", c))
                {
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        portListBox.Items.Add(sqlReader.GetValue(1).ToString());
                    }
                }
            }
        }
    }
}
