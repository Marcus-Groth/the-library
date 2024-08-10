using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TheLibrary
{
    public class InputHandler
    {
        public static string GetStringInput(string propmt)
        {
            Console.Write(propmt);
            string input = Console.ReadLine();
            return input;
        }
    }
}