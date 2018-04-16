using ExportPlatform.BLL.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.BLL
{
    public abstract class LoadBase
    {
        protected ProcessingVO processing;
        protected ProcessingVO Processing
        {
            get { return this.processing; }
            private set { this.processing = value;  }
        }

        public LoadBase(ProcessingVO processing)
        {
            this.processing = processing;
        }

        public abstract void Load(DataSet dataToLoad);
    }
}
