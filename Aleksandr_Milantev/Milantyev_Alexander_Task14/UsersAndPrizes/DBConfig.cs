using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Data
{
    public static class DBConfig
    {
        public static string GetConnectionString()
        {
            string DBName = ConfigurationSettings.AppSettings["DatabaseName"];
            string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = DBName;
            builder.ConnectionString = connectionString;
            return builder.ToString();
        }
    }
}
