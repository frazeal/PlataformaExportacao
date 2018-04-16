using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExportPlatform.BLL.VO;
using ExportPlatform.DAL;

namespace ExportPlatform.BLL
{
    public class ExtractionFromDataBase : ExtractionBase
    {
        public ExtractionFromDataBase(ProcessingVO processing) : base(processing)
        {
        }

        public override DataSet Extract()
        {
            this.extractedData = this.extracDataDAO.ExtractDataWithProcedure(processing.ProcedureName);
            return extractedData;
        }
    }
}
