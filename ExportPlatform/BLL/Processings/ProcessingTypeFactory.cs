using ExportPlatform.BLL.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.BLL
{
    public static class ProcessingTypeFactory
    {
        private static Dictionary<ProcessingTypes, IProcessable> processingTypes = null;

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

        public static void LoadProcessingTypes(ProcessingVO processing)
        {
            processingTypes = new Dictionary<ProcessingTypes, IProcessable>
            {
                { ProcessingTypes.FileCopy, new FileCopyProcessingFacade(processing) },
                { ProcessingTypes.FileTransfer, new FileTransferProcessingFacade(processing) },
                { ProcessingTypes.ExtractionFromDataBaseToFile, new ExtractionFromDataBaseToFileProcessingFacade(processing) }
            };
            //processingTypes.Add(ProcessingTypes.ExtractionFromDataBase, new ExtractionFromFileProcessingFacade());
        }

        //public static IProcessable GetProcessing(ProcessingTypes processingType)
        //{
        //    if (processingTypes.TryGetValue(processingType, out IProcessable processing))
        //    {
        //        return processing;
        //    }
        //    return null;
        //}

        public static IProcessable CreateProcessing(ProcessingVO processingVO)
        {
            if (processingTypes == null)
            {
                LoadProcessingTypes(processingVO);
            }

            if (processingTypes.TryGetValue((ProcessingTypeFactory.ProcessingTypes) processingVO.JobProcessingType, out IProcessable processing))
            {
                return processing;
            }
            return null;
        }
    }
}
