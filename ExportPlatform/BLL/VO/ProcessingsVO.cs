using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExportPlatform.BLL.VO
{
    [XmlRoot("ProcessingJobs")]
    public class ProcessingsVO
    {
        [XmlElement("ProcessingJob", typeof(ProcessingVO))]
        public List<ProcessingVO> Processings { get; set; }
    }
}
