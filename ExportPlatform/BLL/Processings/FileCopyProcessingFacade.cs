using ExportPlatform.BLL.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.BLL
{
    public class FileCopyProcessingFacade : ProcessingFacadeBase
    {
        public FileCopyProcessingFacade(ProcessingVO processing) 
            : base(processing)
        {
            this.transformation = new FileCopyTransformation(processing);
        }
    }
}
