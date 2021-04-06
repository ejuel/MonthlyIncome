using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MonthlyIncome;

namespace MonthlyIncome.Utilities
{
    class FolderManager
    {
        public static List<string> GetAllFileNames(string dir, string fileExtension = ".csv")
        {
            List<string> foundFiles = new List<string>();
            DirectoryInfo d = new DirectoryInfo(dir);
            FileInfo[] Files = d.GetFiles($"*{fileExtension}"); // fileExtension ex: ".csv"
            foreach (FileInfo file in Files)
            {
                foundFiles.Add(file.Name);
            }
            return foundFiles;
        }
        public static int MakeDir(string dir)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            if (di.Exists) return AppSettings.status_AlreadyExists;

            di.Create();
            return AppSettings.status_Success;
        }
        public static int DeleteDir(string dir)
        {
            DirectoryInfo di = new DirectoryInfo(dir);
            if (di.Exists)
            {
                di.Delete();
                return AppSettings.status_Success;
            }
            return AppSettings.status_DoesNotExist;
        }
    }
}
