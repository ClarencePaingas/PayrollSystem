using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEM.BL
{
    public class CREATEPAYROLL_NetIncome_
    {
        //CREATEPAYROLL_NetIncome_
        //-Dito po kina calculate yung net income.

        public static void CalculateNetIncome()
        {

            var AllDeductions = CREATEPAYROLLDetails.Tax + CREATEPAYROLLDetails.SSS +
                                CREATEPAYROLLDetails.PhilHealth + CREATEPAYROLLDetails.PagIbig +
                                CREATEPAYROLLDetails.CashAdvance + CREATEPAYROLLDetails.SalaryLoan +
                                CREATEPAYROLLDetails.PagIbigLoan + CREATEPAYROLLDetails.Bonus;
            CREATEPAYROLLDetails.NetIncome = CREATEPAYROLLDetails.GrossIncome - AllDeductions;

        }

    }
}
