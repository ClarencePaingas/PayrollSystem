using System;
using System.Collections.Generic;
using System.Text;

namespace PS.BL
{
    public class USER
    {

        private static string _username;
        private static string _password;

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public static string UsernameInput { get; set; }
        public static string PasswordInput { get; set; }
        

    }
}
