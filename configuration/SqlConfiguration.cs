using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EducationCentre.configuration
{
    /**
     * @brief: This class is responsible for configuration
     * @details: The configuration includes loading the SQL Server settings from the XML file
     */
    public class SqlConfiguration
    {
        private static SqlConnectionStringBuilder connectionStringBuilder;
        public static string LoadSqlServerSettings()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = "127.0.0.1",
                InitialCatalog = "EducationCentre",
                UserID = "sa",
                Password = "dotanphat",
                TrustServerCertificate = true,
            };
            return connectionStringBuilder.ToString();
        }
    }
}
