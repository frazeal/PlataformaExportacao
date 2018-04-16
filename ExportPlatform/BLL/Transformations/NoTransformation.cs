using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExportPlatform.BLL.VO;

namespace ExportPlatform.BLL.Transformations
{
    public class NoTransformation : TransformationBase
    {
        public NoTransformation(ProcessingVO processing) : base(processing)
        {
        }

        public override DataSet Transform(DataSet dataToTransform)
        {
            return dataToTransform;
        }
    }
}
