using ExportPlatform.BLL.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.BLL
{
    public class FileTransferTransformation : TransformationBase
    {
        public FileTransferTransformation(ProcessingVO processing) : base(processing)
        {
        }

        public override void Transform()
        {
            string sourceFileName = this.processing.InputFileName + this.processing.InputFileExtension;
            string sourcePath = this.processing.InputFileFolderPath;
            string targetPath = this.processing.OutputFileFolderPath;
            string targetFileName = this.processing.OutputFileName + this.processing.OutputFileExtension;
            string backupPath = this.processing.BackupFolderpath;
            string backupFileName = this.processing.InputFileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + this.processing.InputFileExtension;

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, sourceFileName);
            string destFile = System.IO.Path.Combine(targetPath, targetFileName);
            string backupFile = System.IO.Path.Combine(backupPath, backupFileName);

            // BACKUP
            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(backupPath))
            {
                System.IO.Directory.CreateDirectory(backupPath);
            }
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, backupFile, true);
            
            // To move a file or folder to a new location:
            System.IO.File.Move(sourceFile, destFile);

            // To move an entire directory. To programmatically modify or combine
            // path strings, use the System.IO.Path class.
            //System.IO.Directory.Move(@"C:\Users\Public\public\test\", @"C:\Users\Public\private");

            // Keep console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public override DataSet Transform(DataSet dataToTransform)
        {
            throw new NotImplementedException();
        }
    }
}
