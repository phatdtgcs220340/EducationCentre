using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace EducationCentre.configuration
{
    public class Configuration
    {
        private static SqlConnectionStringBuilder connectionStringBuilder;
        public static string loadSqlServerSettings()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("SqlServerSettings.xml");

                XmlElement root = doc.DocumentElement;
                connectionStringBuilder = new SqlConnectionStringBuilder()
                {
                    DataSource = root.SelectSingleNode("setting[@key='ServerName']").Attributes["value"].Value,
                    InitialCatalog = root.SelectSingleNode("setting[@key='DatabaseName']").Attributes["value"].Value,
                    UserID = root.SelectSingleNode("setting[@key='Username']").Attributes["value"].Value,
                    Password = root.SelectSingleNode("setting[@key='Password']").Attributes["value"].Value
                };
                return connectionStringBuilder.ToString();
            }
            catch (Exception ex)
            {
                return string.Format(loadSqlServerSettings(), ex.Message);
            }
        }
    }
}
