using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.Utils
{
    public static class DataSetExtensions
    {
        public static void WriteCsv(this DataSet data, FileStream file, string separator)
        {
            DataTable table = data.Tables[0];
            int[] maxLengths = new int[table.Columns.Count];
            for (int i = 0; i < table.Columns.Count; i++)
            {
                maxLengths[i] = table.Columns[i].ColumnName.Length;

                foreach (DataRow row in table.Rows)
                {
                    if (!row.IsNull(i))
                    {
                        int length = row[i].ToString().Length;
                        if (length > maxLengths[i])
                        {
                            maxLengths[i] = length;
                        }
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    sw.Write(table.Columns[i].ColumnName);
                    sw.Write(Convert.ToChar(separator));
                }
                sw.WriteLine();
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        if (!row.IsNull(i))
                        {
                            sw.Write(row[i].ToString());
                        }
                        else
                        {
                            sw.Write(' ');
                        }
                        sw.Write(Convert.ToChar(separator));
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }

        public static void WriteCsvWithTabulation(this DataSet data, FileStream file, string separator)
        {
            DataTable table = data.Tables[0];
            int[] maxLengths = new int[table.Columns.Count];
            for (int i = 0; i < table.Columns.Count; i++)
            {
                maxLengths[i] = table.Columns[i].ColumnName.Length;

                foreach (DataRow row in table.Rows)
                {
                    if (!row.IsNull(i))
                    {
                        int length = row[i].ToString().Length;
                        if (length > maxLengths[i])
                        {
                            maxLengths[i] = length;
                        }
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(file, Encoding.UTF8))
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    sw.Write(table.Columns[i].ColumnName.PadRight(maxLengths[i] + 2));
                    sw.Write(Convert.ToChar(separator));
                }
                sw.WriteLine();
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        if (!row.IsNull(i))
                        {
                            sw.Write(row[i].ToString().PadRight(maxLengths[i] + 2));
                        }
                        else
                        {
                            sw.Write(new string(' ', maxLengths[i] + 2));
                        }
                        sw.Write(Convert.ToChar(separator));
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
    }
}

