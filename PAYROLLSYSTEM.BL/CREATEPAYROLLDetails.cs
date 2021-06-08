using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class CREATEPAYROLLDetails
    {
        //CREATEPAYROLLDetails
        //-class po na pinaglalagyan po ng lahat po ng mga properties po na gamit ko po para po sa CreatePayroll(gross income at net income)
        public static string NameInput { get; set; }
        public static int DaysPresent { get; set; }
        public static int HoursWorked { get; set; }
        public static int HourlyRate { get; set; }
        public static int OTHoursWorked { get; set; }
        public static int OTRate { get; set; }
        public static int Bonus { get; set; }
        public static int Tax { get; set; }
        public static int SSS { get; set; }
        public static int PhilHealth { get; set; }
        public static int PagIbig { get; set; }
        public static int CashAdvance { get; set; }
        public static int SalaryLoan { get; set; }
        public static int PagIbigLoan { get; set; }
        public static int Others { get; set; }
        public static int GrossIncome { get; set; }
        public static int NetIncome { get; set; }
        public static char Input { get; set; }

    }
}
