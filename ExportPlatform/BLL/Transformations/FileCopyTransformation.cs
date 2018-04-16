using ExportPlatform.BLL.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPlatform.BLL
{
    public class FileCopyTransformation : TransformationBase
    {
        public FileCopyTransformation(ProcessingVO processing) : base(processing)
        {
        }

        public override void Transform()
        {
            string sourceFileName = this.processing.InputFileName + this.processing.InputFileExtension;
            string sourcePath = this.processing.InputFileFolderPath;
            string targetPath =  this.processing.OutputFileFolderPath;
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

            // COPY
            
            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        
            //// To copy all the files in one directory to another directory.
            //// Get the files in the source folder. (To recursively iterate through
            //// all subfolders under the current directory, see
            //// "How to: Iterate Through a Directory Tree.")
            //// Note: Check for target path was performed previously
            ////       in this code example.
            //if (System.IO.Directory.Exists(sourcePath))
            //{
            //    string[] files = System.IO.Directory.GetFiles(sourcePath);

            //    // Copy the files and overwrite destination files if they already exist.
            //    foreach (string s in files)
            //    {
            //        // Use static Path methods to extract only the file name from the path.
            //        fileName = System.IO.Path.GetFileName(s);
            //        destFile = System.IO.Path.Combine(targetPath, fileName);
            //        System.IO.File.Copy(s, destFile, true);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Source path does not exist!");
            //}

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
