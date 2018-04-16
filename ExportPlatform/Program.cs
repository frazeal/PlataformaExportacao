using ExportPlatform.BLL;
using ExportPlatform.BLL.VO;
using ExportPlatform.DAL;
using ExportPlatform.DAL.Interfaces;
using ExportPlatform.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform
{
    class Program
    {
        private static IProcessable processingBO;
        private static ProcessingVO processingDefinitions;
        private static IDao<ProcessingVO> processingDAO;
        private static int jobId;
        private const ProgramLoadMode DEFAULT_LOAD_MODE = ProgramLoadMode.XmlFile;

        private enum ProgramLoadMode
        {
            Database,
            XmlFile
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: an argument must be given.");
                return;
            }

            Run(args);
        }

        private static void Run(string[] args)
        {
            jobId = Convert.ToInt32(args[0]);
            LoadProcessingDefinitions(jobId, DEFAULT_LOAD_MODE);
            processingBO?.Process();
        }

        private static void LoadProcessingDefinitions(int jobId, ProgramLoadMode loadMode)
        {
            switch (loadMode)
            {
                case ProgramLoadMode.Database:
                    processingBO = LoadFromDatabase(jobId);
                    break;
                case ProgramLoadMode.XmlFile:
                    processingBO = LoadFromXmlFile(jobId);
                    break;
                default:
                    break;
            }
        }

        private static IProcessable LoadFromDatabase(int jobId)
        {
            using (IDbConnection connection = ConnectionFactory.CreateConnection())
            {
                processingDAO = new ProcessingDao();
                processingDefinitions = processingDAO.Get(jobId);
            }
            return ProcessingTypeFactory.CreateProcessing(processingDefinitions);
        }

        private static IProcessable LoadFromXmlFile(int jobId)
        {
            processingDAO = new ProcessingXmlDao();
            processingDefinitions = processingDAO.Get(jobId);
            return ProcessingTypeFactory.CreateProcessing(processingDefinitions);
        }
    }
}
