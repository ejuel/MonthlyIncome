using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyIncome
{
    class AppSettings
    {
        public static string folder_FilePickup = @"C:\Users\Admin\source\repos\MonthlyIncome\FilePickup\";
        public static string folder_FileProcessed = @"C:\Users\Admin\source\repos\MonthlyIncome\FileProcessed\";


        public static int status_Success = 1;
        public static int status_Failed = 0;
        public static int status_AlreadyExists = -1;
        public static int status_DoesNotExist = -2;
    }
}
