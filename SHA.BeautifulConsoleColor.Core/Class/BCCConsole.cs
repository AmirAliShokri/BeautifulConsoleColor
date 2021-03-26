using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SHA.BeautifulConsoleColor.Core.Model;

namespace SHA.BeautifulConsoleColor.Core.Class
{
    public class BCCConsole
    {
        /// <summary>
        /// Write In Console With Your Color And Reset It   
        /// </summary>
        public static void Write(BCCConsoleColor color,bool continuous, params string[] value)
        {
            Console.ForegroundColor = ColorFinder(color);
            foreach (string s in value)
            {
                if (continuous)
                {
                    Console.Write(s);
                    continue;
                }

                Console.WriteLine(s);
            }
            Console.ResetColor();
        }

        private static ConsoleColor ColorFinder(BCCConsoleColor color)
        {
            var _color = ConsoleColor.White;
            switch (color)
            {
                case BCCConsoleColor.Black:
                    _color = ConsoleColor.Black;
                    break;
                case BCCConsoleColor.Blue:
                    _color = ConsoleColor.Blue;
                    break;
                case BCCConsoleColor.Cyan:
                    _color = ConsoleColor.Cyan;
                    break;
                case BCCConsoleColor.DarkBlue:
                    _color = ConsoleColor.DarkBlue;
                    break;
                case BCCConsoleColor.DarkGray:
                    _color = ConsoleColor.DarkGray;
                    break;
                case BCCConsoleColor.DarkGreen:
                    _color = ConsoleColor.DarkGreen;
                    break;
                case BCCConsoleColor.Green:
                    _color = ConsoleColor.Green;
                    break;
                case BCCConsoleColor.DarkMagenta:
                    _color = ConsoleColor.DarkMagenta;
                    break;
                case BCCConsoleColor.Magenta:
                    _color = ConsoleColor.Magenta;
                    break;
                case BCCConsoleColor.Red:
                    _color = ConsoleColor.Red;
                    break;
                case BCCConsoleColor.DarkRed:
                    _color = ConsoleColor.DarkRed;
                    break;
                case BCCConsoleColor.Yellow:
                    _color = ConsoleColor.Yellow;
                    break;
                case BCCConsoleColor.DarkYellow:
                    _color = ConsoleColor.DarkYellow;
                    break;
                case BCCConsoleColor.Gray:
                    _color = ConsoleColor.Gray;
                    break;
                case BCCConsoleColor.DarkCyan:
                    _color = ConsoleColor.DarkCyan;
                    break;
            }

            return _color;
        }
    }
}
