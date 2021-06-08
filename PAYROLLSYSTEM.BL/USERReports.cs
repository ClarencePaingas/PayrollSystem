using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class USERReports
    {
        //-method po pang display ng lahat po ng ininput or ginawa ni user

        private static readonly List<string> Reports = new List<string>();

        public static void AddActionReport(string message)
        {
            AddReport($"USER ACTION:\t{message}");
        }

        public static void AddResultReport(string result)
        {
            AddReport($"RESULT:\t{result}");
        }

        public static void AddReport(string message)
        {
            Reports.Add($"[{DateTime.Now}]: {message}");
        }

        public static void ShowReports()
        {
            foreach (var report in Reports)
            {
                Console.WriteLine($"{report}");
            }

        }
    }
}
