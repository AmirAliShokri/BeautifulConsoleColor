using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHA.BeautifulConsoleColor.Core.Extension
{
    public static class BCCConsoleExtension
    {
        public static string Blue(this string str)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string DarkBlue(this string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string Green(this string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string DarkGreen(this string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string Gray(this string str)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string DarkGray(this string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string Red(this string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string DarkRed(this string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string White(this string str)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string Black(this string str)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string Yellow(this string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string DarkYellow(this string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string Magenta(this string str)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string DarkMagenta(this string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string Cyan(this string str)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
        public static string DarkCyan(this string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(str);
            Console.ResetColor();
            return str;
        }
    }
}
