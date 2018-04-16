using ExportPlatform.BLL.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.BLL
{
    public abstract class TransformationBase
    {
        protected ProcessingVO processing;
        protected DataSet transformedData;

        public TransformationBase(ProcessingVO processing)
        {
            this.processing = processing;
            this.transformedData = new DataSet();
        }

        public abstract DataSet Transform(DataSet dataToTransform);
        public virtual void Transform()
        {
            return;
        }
    }
}
