using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    static class Utilities
    {
        public static string ReqAddr()
        {
            Console.WriteLine("Please enter restaurant address:");
            return Console.ReadLine();
        }

        public static string ReqType()
        {
            Console.WriteLine("Please enter restaurant type:");
            return Console.ReadLine();
        }
    }
}
