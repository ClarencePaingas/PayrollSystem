using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class PAYROLLHISTORY
    {

        //-nandito po yung method ko para po ma tingnan or ma monitor po yung mga
        //payroll po na ginawa/prinocess po ng user.
        //Parang reports po pero para lang po sa summary (or yung mga pinaka important
        //na information) po ng payroll na mga ginawa/prinocess ng user.
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

       

    }
}
