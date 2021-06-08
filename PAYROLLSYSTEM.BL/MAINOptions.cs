
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PAYROLLSYSTEM.BL
{
    public class MAINOptions
    {
        //-eto po yung pang display ko po nung main options po ng user.
        public static void DisplayMainOptions()
        {

            Console.Clear();
            Console.WriteLine(MAINOptionsDetails.MainOptionMessage);
            Console.WriteLine(MAINOptionsDetails.Options);

        }

    }
}
