using PlataformaExportacao.BLL;
using PlataformaExportacao.BLL.VO;
using PlataformaExportacao.DAL;
using PlataformaExportacao.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaExportacao
{
    class Program
    {
        private static IProcessable processingBO;
        private static ProcessingDAO processingDAO = new ProcessingDAO();
        private static ProcessingXmlDao processingXmlDao = new ProcessingXmlDao();

        static void Main(string[] args)
        {
            using (IDbConnection connection = ConnectionFactory.CreateConnection())
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("ERROR: an argument must be given.");
                    return;
                }
                int jobId = Convert.ToInt32(args[0]);
                ProcessingVO processingVO = processingDAO.Get(jobId);
                //ProcessingVO processingXVO = processingXmlDao.Get(jobId);

                processingBO = CreateProcessing(processingVO);
                processingBO?.Process();
            }
        }

        private static IProcessable CreateProcessing(ProcessingVO processingVO)
        {
            ProcessingTypeFactory.Initialize(processingVO);
            return ProcessingTypeFactory.GetProcessing(processingVO);
        }
    }
}
