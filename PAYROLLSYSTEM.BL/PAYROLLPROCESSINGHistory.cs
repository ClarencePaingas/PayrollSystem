using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class PAYROLLPROCESSINGHistory
    {

        private static readonly List<string> ViewPayrollDetails = new List<string>();

        public static void AddPayrollDetail(string message)
        {
            ViewPayrollDetails.Add($"{message}");
        }

        public static void ShowPayrollDetails()
        {
            Console.WriteLine("");
            foreach (var payrollDetails in ViewPayrollDetails)
            {
                Console.WriteLine($"{payrollDetails}");
            }

        }

    }
}
