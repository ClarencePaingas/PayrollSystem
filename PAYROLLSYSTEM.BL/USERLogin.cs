using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PAYROLLSYSTEM.BL
{
    public class USERLogin
    {
        //-class po para po pang authenticate po ng user.
        //Kapag po tama po yung ininput ni user na log in details,
        //dederetcho na po sya sa main Options.
        //Kapag hindi po tama, mag e exit po yung program.

        public static void LoginAuthentication()
        {

            if (USERLoginDetails.Username == USERLoginDetails.UsernameInput &&
                USERLoginDetails.Password == USERLoginDetails.PasswordInput)
            {

                SuccessfulLogin();
            }

            else
            {


                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("                   P R O G R A M   E X I T I N G");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("YOU HAVE EITHER REACHED THE MAXIMUM RETRIES POSSIBLE");
                Console.WriteLine("OR");
                Console.WriteLine("YOU HAVE ENTERED AN INVLAID USERNAME OR PASSWORD");
                Console.WriteLine("PLEASE TRY AGAIN LATER.");
                System.Environment.Exit(0);



            }

        }

        public static void SuccessfulLogin()
        {

            MAINOptions.DisplayMainOptions();

        }

    }
}
