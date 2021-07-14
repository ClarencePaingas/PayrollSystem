using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common
{
    public class SUMMARY
    {
        public static readonly List<string> Summary = new List<string>();
        
        public static void AddSummary(string summary)
        {
            Summary.Add($"\t {summary}");
        }

        public static void ShowSummary()
        {
            foreach (var summary in Summary)
            {
                Console.WriteLine(summary);
            }
        }
       
    }
}
