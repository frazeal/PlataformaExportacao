using ExportPlatform.BLL.VO;
using ExportPlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.DAL
{
    public abstract class ProcessingDaoBase : IDao<ProcessingVO>
    {
        public abstract ProcessingVO Get(int id);
        public abstract IList<ProcessingVO> List();
    }
}
