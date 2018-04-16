using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExportPlatform.BLL.VO;
using ExportPlatform.Utils;

namespace ExportPlatform.BLL
{
    public class LoadToFile : LoadBase
    {
        public LoadToFile(ProcessingVO processing) : base(processing)
        {
        }

        public override void Load(DataSet dataToLoad)
        {
            WriteToXMLFile(dataToLoad, CreateFile());
            //WriteToFile(dataToLoad, CreateFile());
        }

        public FileStream CreateFile()
        {
            FileStream file = new FileStream(
                Path.Combine(Processing.OutputFileFolderPath, Processing.OutputFileName + processing.OutputFileExtension),
                FileMode.Create);
            return file;
        }

        public void WriteToXMLFile(DataSet data, FileStream file)
        {
            data.WriteXml(file.Name + ".xml");
            //throw new NotImplementedException();
        }

        public void WriteToFile(DataSet data, FileStream file)
        {
            data.WriteCsv(file, Processing.OutputFileSeparatorChar);
        }
    }
}


//StringBuilder str = new StringBuilder();
//foreach (DataRow dr in this.extractedData.Tables[0].Rows)
//{
//    foreach (var field in dr.ItemArray)
//    {
//        str.Append(field.ToString() + ",");
//    }
//    str.Replace(",", Environment.NewLine, str.Length - 1, 1);
//}

//try
//{
//    My.Computer.FileSystem.WriteAllText("C:\\temp\\testcsv.csv", str.ToString, false);
//}
//catch (Exception ex)
//{
//    MessageBox.Show("Write Error");
//}


//int[] maxLengths = new int[extractedData.Tables[0].Columns.Count];

//for (int i = 0; i < extractedData.Tables[0].Columns.Count; i++)
//{
//    maxLengths[i] = extractedData.Tables[0].Columns[i].ColumnName.Length;

//    foreach (DataRow row in extractedData.Tables[0].Rows)
//    {
//        if (!row.IsNull(i))
//        {
//            int length = row[i].ToString().Length;

//            if (length > maxLengths[i])
//            {
//                maxLengths[i] = length;
//            }
//        }
//    }
//}

//using (StreamWriter sw = new StreamWriter(processing.OutputFileFolderPath + "\\" + processing.OutputFileName + processing.OutputFileExtension, false))
//{
//    for (int i = 0; i < extractedData.Tables[0].Columns.Count; i++)
//    {
//        sw.Write(extractedData.Tables[0].Columns[i].ColumnName.PadRight(maxLengths[i] + 2));
//        sw.Write(Convert.ToChar(processing.OutputFileSeparatorChar));
//    }

//    sw.WriteLine();

//    foreach (DataRow row in extractedData.Tables[0].Rows)
//    {
//        for (int i = 0; i < extractedData.Tables[0].Columns.Count; i++)
//        {
//            if (!row.IsNull(i))
//            {
//                sw.Write(row[i].ToString().PadRight(maxLengths[i] + 2));
//            }
//            else
//            {
//                sw.Write(new string(' ', maxLengths[i] + 2));
//            }
//            sw.Write(Convert.ToChar(processing.OutputFileSeparatorChar));
//        }

//        sw.WriteLine();
//    }

//    sw.Close();
