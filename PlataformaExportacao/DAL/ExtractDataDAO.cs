using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.DAL
{
    public class ExtractDataDAO
    {
        public DataSet ExtractDataWithProcedure(String procedureName)
        {
            DataSet data = new DataSet();
            using (IDbConnection connection = ConnectionFactory.CreateConnection())
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedureName;
                //command.CommandTimeout = 600;
                IDbDataAdapter adapter = new SqlDataAdapter((SqlCommand)command);
                //adapter.SelectCommand = command;
                adapter.Fill(data);
            }
            return data;
        }
    }
}
