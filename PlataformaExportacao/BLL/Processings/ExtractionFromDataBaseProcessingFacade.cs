using PlataformaExportacao.BLL.Transformations;
using PlataformaExportacao.BLL.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.BLL
{
    public class ExtractionFromDataBaseToFileProcessingFacade : ProcessingFacadeBase
    {
        public ExtractionFromDataBaseToFileProcessingFacade(ProcessingVO processing) 
            : base(processing)
        {
            this.extraction = new ExtractionFromDataBase(processing);
            this.transformation = new NoTransformation(processing);
            this.load = new LoadToFile(processing);
        }
    }
}