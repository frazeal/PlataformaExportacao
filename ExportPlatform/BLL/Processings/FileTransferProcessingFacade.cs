using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExportPlatform.BLL.VO;

namespace ExportPlatform.BLL
{
    public class FileTransferProcessingFacade : ProcessingFacadeBase
    {
        public FileTransferProcessingFacade(ProcessingVO processing) 
            : base(processing)
        {
            this.transformation = new FileTransferTransformation(processing);
        }
    }
}
