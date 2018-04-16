using ExportPlatform.BLL.VO;
using ExportPlatform.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ExportPlatform.DAL
{
    public class ProcessingXmlDao : ProcessingDaoBase
    {
        public override ProcessingVO Get(int IdJob)
        {
            using (XmlReader reader = ConnectionFactory.CreateXmlReader())
            {
                ProcessingsVO ps = Serializer.Deserialize<ProcessingsVO>(reader);
                // Lists are zero-based.
                //reader.Read();
                return ps.Processings[IdJob - 1];
            }
        }

        public override IList<ProcessingVO> List()
        {
            using (XmlReader reader = ConnectionFactory.CreateXmlReader())
            {
                ProcessingsVO ps = Serializer.Deserialize<ProcessingsVO>(reader);
                // Lists are zero-based.
                //reader.Read();
                return ps.Processings;
            }
        }
    }
}
