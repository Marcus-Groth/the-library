using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLibrary
{
    public class ConsolePrinter
    {
        public static void PrintMenu(string[] options)
        {
            if (options is null || options.Length == 0)
            {
                Console.WriteLine("No menu options was available");
                return;
            }

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {options[i]}");
            }
        }
    }
}