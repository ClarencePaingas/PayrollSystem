using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common
{
    public class LOGS
    {
        private static readonly List<string> Logs = new List<string>();
        public static void AddLog(string log)
        {
            Logs.Add($"[{DateTime.Now}]: \t{log}");
        }

        public static void ShowLogs()
        {
            foreach (var log in Logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
