using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class PAYROLLPROCESSINGHistory
    {
        //-nandito po yung method ko para po ma display lahat ng ininput
        //po ni user na details about sa payroll ng employee.

        //Pinag hiwalay ko po sila nung PAYROLLHISTORY.
        //Kasi po magkaiba po yung pinag gamitan ko sa kanila.
        //Yung PAYROLLHISTORY po right after po mag log in ni user,
        //pwede po sya ma access.Yung PAYROLLPROCESSINGHistory po, ma aaccess
        //lang po kapag po nakapag create na po si user ng payroll.

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
