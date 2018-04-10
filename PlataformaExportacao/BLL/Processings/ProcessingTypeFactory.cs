using PlataformaExportacao.BLL.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.BLL
{
    public static class ProcessingTypeFactory
    {
        private static Dictionary<ProcessingTypes, ProcessingFacadeBase> processingTypes = new Dictionary<ProcessingTypes, ProcessingFacadeBase>();

        public enum ProcessingTypes
        {
            FileCopy,
            FileTransfer,
            FileConversion,
            ExtractionFromDataBaseToFile,
            ExtractionFromFile
        }

        //static ProcessingTypeFactory()
        //{
            
        //}

        public static void Initialize(ProcessingVO processing)
        {
            processingTypes.Add(ProcessingTypes.FileCopy, new FileCopyProcessingFacade(processing));
            processingTypes.Add(ProcessingTypes.FileTransfer, new FileTransferProcessingFacade(processing));
            processingTypes.Add(ProcessingTypes.ExtractionFromDataBaseToFile, new ExtractionFromDataBaseToFileProcessingFacade(processing));
            //processingTypes.Add(ProcessingTypes.ExtractionFromDataBase, new ExtractionFromFileProcessingFacade());
        }

        public static ProcessingFacadeBase GetProcessing(ProcessingTypes processingType)
        {
            if (processingTypes.TryGetValue(processingType, out ProcessingFacadeBase processing))
            {
                return processing;
            }
            return null;
        }

        public static ProcessingFacadeBase GetProcessing(ProcessingVO processingVO)
        {
            if (processingTypes.TryGetValue((ProcessingTypeFactory.ProcessingTypes) processingVO.JobOperationMode, out ProcessingFacadeBase processing))
            {
                return processing;
            }
            return null;
        }
    }
}
