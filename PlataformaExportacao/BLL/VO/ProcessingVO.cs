using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.BLL.VO
{
    public class ProcessingVO
    {
        // Job related fields
        public int IdJob { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public short JobOperationMode { get; set; }
        public bool IsJobActiveFlag { get; set; }

        // Helper fields
        public string BackupFolderpath { get; set; }
        public string ProcedureName { get; set; }

        // Input file fields
        public string InputFileFolderPath { get; set; }
        public string InputFileName { get; set; }
        public string InputFileExtension { get; set; }
        public string InputFileSeparatorChar { get; set; }

        // Output file fields
        public string OutputFileFolderPath { get; set; }
        public string OutputFileName { get; set; }
        public string OutputFileExtension { get; set; }
        public string OutputFileSeparatorChar { get; set; }

        // Flag fields
        public bool FileExportDateTimeFlag { get; set; }
        public bool FileProcessingDateTimeFlag { get; set; }
    }
}
