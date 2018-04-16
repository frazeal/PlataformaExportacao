using ExportPlatform.BLL.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.BLL
{
    public class ExtractionFromFile : ExtractionBase
    {
        public ExtractionFromFile(ProcessingVO processing) : base(processing)
        {
        }

        public override DataSet Extract()
        {
            throw new NotImplementedException();
        }
    }
}
