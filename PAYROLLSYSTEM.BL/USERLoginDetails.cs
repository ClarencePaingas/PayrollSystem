using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PAYROLLSYSTEM.BL
{
    public class USERLoginDetails
    {
        //-dito ko po nilagay yung mga properties na ginamit ko sa UserLogin
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string UsernameInput { get; set; }
        public static string PasswordInput { get; set; }
        public static int Attempts { get; set; }

    }
}
