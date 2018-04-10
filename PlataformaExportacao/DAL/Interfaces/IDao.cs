using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao.DAL.Interfaces
{
    public interface IDao<T>
    {
        T Get(int id);
        //void Save(T dto);
        //IList<T> List();
        //void Merge(T dto);
        //void Delete(T dto);
    }
}
