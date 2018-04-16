using ExportPlatform.BLL.VO;
using ExportPlatform.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.BLL
{
    public abstract class ExtractionBase
    {
        protected ProcessingVO processing;
        protected ExtractDataDao extracDataDAO;
        protected DataSet extractedData;

        public ExtractionBase(ProcessingVO processing)
        {
            this.processing = processing;
            this.extracDataDAO = new ExtractDataDao();
            this.extractedData = new DataSet();
        }

        public abstract DataSet Extract();
    }
}
