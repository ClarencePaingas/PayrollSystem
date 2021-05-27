using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class MainOptions
    {

        public static List<string> mainOptions = new List<string>()
        {
             "\na - Create Payroll",
            "\nb - Employee Management",
            "\nc - Log Out"
        };

        public static List<char> Options = new List<char>() { 'a', 'b', 'c' };

        public static void ShowMainOptions()
        {
            Console.WriteLine("PLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");

            foreach (var options in mainOptions)
            {
                Console.WriteLine(options);
            }
        }

        public static void GetUserInput()
        {
            ShowMainOptions();
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.Write("INPUT: ");
            var option = Convert.ToChar(Console.ReadLine().ToLower());

            switch (option)
            {
                case 'a':
                    //Console.WriteLine("createpayroll");
                    CreatePayroll createPayroll = new CreatePayroll();
                    CreatePayroll.DisplayCreatePayroll();
                    break;

                case 'b':
                    //Console.WriteLine("Manageemployees");
                    break;

                case 'c':
                    Console.Clear();
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                         L O G G E D  O U T");
                    Console.WriteLine("-------------------------------------------------------------------");
                    break;

                default:
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                            E R R O R");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("INVALID INPUT. PLEASE TRY AGAIN LATER.");

                    break;
            }
        }

    }
}
