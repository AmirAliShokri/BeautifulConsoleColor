using System;
using SHA.BeautifulConsoleColor.Core.Class;
using SHA.BeautifulConsoleColor.Core.Extension;
using SHA.BeautifulConsoleColor.Core.Model;

namespace SHA.BeautifulConsoleColor.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Masir");
            BCCConsole.Write(BCCConsoleColor.DarkBlue,true,"Amir","Asir");
            "Masir".Yellow();
        }
    }
}
