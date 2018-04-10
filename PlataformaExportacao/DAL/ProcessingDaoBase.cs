using PlataformaExportacao.BLL.VO;
using PlataformaExportacao.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.DAL
{
    public abstract class ProcessingDaoBase : IDao<ProcessingVO>
    {
        public abstract ProcessingVO Get(int id);
    }
}
