using PlataformaExportacao.BLL.VO;
using PlataformaExportacao.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.BLL
{
    public abstract class ExtractionBase
    {
        protected ProcessingVO processing;
        protected ExtractDataDAO extracDataDAO;
        protected DataSet extractedData;

        public ExtractionBase(ProcessingVO processing)
        {
            this.processing = processing;
            this.extracDataDAO = new ExtractDataDAO();
            this.extractedData = new DataSet();
        }

        public abstract DataSet Extract();
    }
}
