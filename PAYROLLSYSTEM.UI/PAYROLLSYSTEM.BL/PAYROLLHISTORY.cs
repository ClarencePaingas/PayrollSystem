using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class PAYROLLHISTORY
    {
        private static readonly List<string> PayrollHistory = new List<string>();


        public static void AddEmployeeName(string name)
        {
            AddPayrollHistory($"Name:\t  {name}");
        }

        public static void AddGrossIncome(string grossIncome)
        {
            AddPayrollHistory($"Gross Income:\t{grossIncome}");
        }

        public static void AddNetIncome(string netIncome)
        {
            AddPayrollHistory($"Net Income:\t{netIncome}");
        }

        public static void AddPayrollProcessing(string payrollProcessing)
        {
            AddPayrollHistory($"Payroll Processing\t{payrollProcessing}");
        }

        public static void AddPayrollHistory(string message)
        {
            PayrollHistory.Add($"[{DateTime.Now}]: {message}");
        }

        public static void ShowPayrollHistory()
        {
            Console.WriteLine("");
            foreach (var payrollHistory in PayrollHistory)
            {
                Console.WriteLine($"{payrollHistory}");
            }

        }

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
