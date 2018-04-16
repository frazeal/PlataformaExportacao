using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExportPlatform.BLL.VO;

namespace ExportPlatform.BLL
{
    public class LoadToDataBase : LoadBase
    {
        public LoadToDataBase(ProcessingVO processing) : base(processing)
        {
        }

        public override void Load(DataSet dataToLoad)
        {
            throw new NotImplementedException();
        }
    }
}
