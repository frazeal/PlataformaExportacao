using PlataformaExportacao.BLL.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.BLL
{
    public abstract class ProcessingFacadeBase : IProcessable
    {
        protected ExtractionBase extraction;
        protected TransformationBase transformation;
        protected LoadBase load;
        protected DataSet extractedData;
        protected DataSet dataToLoad;
        private ProcessingVO processing;

        public ProcessingFacadeBase(ProcessingVO processing)
        {
            this.processing = processing;
            extraction = null;
            transformation = null;
            load = null;
        }

        public virtual void Process()
        {
            this.extractedData = extraction?.Extract();
            this.dataToLoad = transformation?.Transform(extractedData);
            load?.Load(dataToLoad);
        }
    }
}
