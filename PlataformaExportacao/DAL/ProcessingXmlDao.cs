using PlataformaExportacao.BLL.VO;
using PlataformaExportacao.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PlataformaExportacao.DAL
{
    public class ProcessingXmlDao : ProcessingDaoBase
    {
        public override ProcessingVO Get(int IdJob)
        {
            using (XmlReader reader = ConnectionFactory.CreateXmlReader())
            {
                ProcessingsVO ps = Serializer.Deserialize<ProcessingsVO>(reader);
                // Lists are zero-based.
                return ps.Processings[IdJob - 1];
            }
        }
    }
}
