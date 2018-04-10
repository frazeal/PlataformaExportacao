using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PlataformaExportacao.DAL
{
    public class ConnectionFactory
    {
        public static IDbConnection CreateConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CV4DB"];
            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString.ConnectionString;
            connection.Open();
            return connection;
        }

        public static XmlReader CreateXmlReader()
        {
            string xmlFile = ConfigurationManager.AppSettings["ProcessingJobsXml"];
            XmlReader reader = XmlReader.Create(xmlFile);
            return reader;
        }
    }
}
