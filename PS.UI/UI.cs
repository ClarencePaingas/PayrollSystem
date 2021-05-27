using BL;
using System;

namespace PS.UI
{
    public class UI
    {
        
        static void Main(string[] args)
        {
            


            string Username = "admin1234";
            string Password = "password";
            string username = "admin1234";
            string password = "password";
            int loginAttempts = 0;

            Console.Write("Username: ");
            Username = Console.ReadLine();
            Console.Write("Password: ");
            Password = Console.ReadLine();
            Console.Clear();


            if (Username == "admin1234" && Password == "password")
            {
                DisplaySuccessfulLogIn();
            }

            else
            {
                do
                {

                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    Console.Clear();

                    loginAttempts++;

                }
                while (username != "admin1234" && password != "password" && loginAttempts != 4);

                if (username == "admin1234" && password == "password")
                {
                    DisplaySuccessfulLogIn();
                }

                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("                   P R O G R A M   E X I T I N G");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("YOU HAVE REACHED THE MAXIMUM RETRIES POSSIBLE.");
                    Console.WriteLine("PLEASE TRY AGAIN LATER.");
                }


            }

            static void DisplaySuccessfulLogIn()
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("         W E L C O M E   T O   P A Y R O L L   S Y S T E M");
                Console.WriteLine("-------------------------------------------------------------------");

                MainOptions Options = new MainOptions();
                MainOptions.GetUserInput();
            }

            




        }
    }
}
