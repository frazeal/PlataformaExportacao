using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlataformaExportacao.BLL.VO;
using PlataformaExportacao.DAL;

namespace PlataformaExportacao.BLL
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
