using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common
{
    public class REPORT
    {
        public static readonly List<string> Reports = new List<string>();
        public static readonly List<string> HistoryE1 = new List<string>()
        {
            "07-2020\t\t\t52000\t\t\tApproved",
            "08-2020\t\t\t50000\t\t\tApproved",
            "09-2020\t\t\t56000\t\t\tApproved",
            "10-2020\t\t\t59000\t\t\tApproved",
            "11-2020\t\t\t57000\t\t\tApproved",
            "12-2020\t\t\t53000\t\t\tApproved",
            "01-2021\t\t\t54000\t\t\tApproved",
            "02-2021\t\t\t51000\t\t\tApproved",
            "03-2021\t\t\t59000\t\t\tApproved",
            "04-2021\t\t\t58000\t\t\tApproved",
            "05-2021\t\t\t61000\t\t\tApproved"
        };
        public static readonly List<string> HistoryE2 = new List<string>()
        {
            "11-2020\t\t\t32000\t\t\tApproved",
            "12-2020\t\t\t30000\t\t\tApproved",
            "01-2021\t\t\t36000\t\t\tApproved",
            "02-2021\t\t\t39000\t\t\tApproved",
            "03-2021\t\t\t37000\t\t\tApproved",
            "04-2021\t\t\t33000\t\t\tApproved",
            "05-2021\t\t\t34000\t\t\tApproved"

        };
        public static readonly List<string> HistoryE3 = new List<string>()
        {
            "09-2020\t\t\t22000\t\t\tApproved",
            "10-2020\t\t\t20000\t\t\tApproved",
            "11-2020\t\t\t26000\t\t\tApproved",
            "12-2020\t\t\t29000\t\t\tApproved",
            "01-2021\t\t\t27000\t\t\tApproved",
            "02-2021\t\t\t23000\t\t\tApproved",
            "03-2021\t\t\t24000\t\t\tApproved",
            "04-2021\t\t\t21000\t\t\tApproved",
            "05-2021\t\t\t29000\t\t\tApproved"
        };
        public static void AddReport(string report)
        {
            Reports.Add($"\t {report}");
        }

        public static void ShowReport()
        {
            foreach (var report in Reports)
            {
                Console.WriteLine(report);
            }
        }

        public static void AddHistoryE1(string history)
        {
            HistoryE1.Add($"{history}");
        }

        public static void ShowHistoryE1()
        {
            foreach (var history in HistoryE1)
            {
                Console.WriteLine(history);
            }
        }

        public static void AddHistoryE2(string history)
        {
            HistoryE2.Add($"{history}");
        }
       
        public static void ShowHistoryE2()
        {
            foreach (var history in HistoryE2)
            {
                Console.WriteLine(history);
            }
        }

        public static void AddHistoryE3(string history)
        {
            HistoryE3.Add($"{history}");
        }

        public static void ShowHistoryE3()
        {
            foreach (var history in HistoryE3)
            {
                Console.WriteLine(history);
            }
        }

    }
}
