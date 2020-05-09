﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace MidtermExam
{
    class DbUtil
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ShipmentConnectionString"].ConnectionString;
        }

        public SqlConnection GetSqlConnection(string connectionString)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception)
            {
                if (connection != null)
                    connection.Dispose();
            }
            return connection;
        }
    }

}
