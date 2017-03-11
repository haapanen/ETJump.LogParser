using System;
using System.Collections.Generic;
using System.Text;

namespace ETJump.TextUtilities
{
    public static class ColorMap
    {
        /// <summary>
        /// Converts color code character to hex color
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        public static string GetHexColor(char colorCode)
        {
            switch (char.ToLower(colorCode))
            {
                case '0':
                    return "000000";
                case '1':
                    return "ff0000";
                case '2':
                    return "00ff00";
                case '3':
                    return "ffff00";
                case '4':
                    return "0000ff";
                case '5':
                    return "00ffff";
                case '6':
                    return "ff00ff";
                case '7':
                    return "ffffff";
                case '8':
                    return "ff7f00";
                case '9':
                    return "7f7f7f";
                case ':':
                    return "bfbfbf";
                case ';':
                    return "bfbfbf";
                case '<':
                    return "007f00";
                case '=':
                    return "7f7f00";
                case '>':
                    return "00007f";
                case '?':
                    return "7f0000";
                case '@':
                    return "7f3f00";
                case 'a':
                    return "ff9919";
                case 'b':
                    return "007f7f";
                case 'c':
                    return "7f007f";
                case 'd':
                    return "007fff";
                case 'e':
                    return "7f00ff";
                case 'f':
                    return "3399cc";
                case 'g':
                    return "ccffcc";
                case 'h':
                    return "006633";
                case 'i':
                    return "ff0033";
                case 'j':
                    return "b21919";
                case 'k':
                    return "993300";
                case 'l':
                    return "cc9933";
                case 'm':
                    return "999933";
                case 'n':
                    return "ffffbf";
                case 'o':
                    return "ffff7f";
                case 'p':
                    return "000000";
                case 'q':
                    return "ff0000";
                case 'r':
                    return "00ff00";
                case 's':
                    return "ffff00";
                case 't':
                    return "0000ff";
                case 'u':
                    return "00ffff";
                case 'v':
                    return "ff00ff";
                case 'w':
                    return "ffffff";
                case 'x':
                    return "ff7f00";
                case 'y':
                    return "7f7f7f";
                case 'z':
                    return "bfbfbf";
                default:
                    return "ffffff";
            }
        }

        public static ConsoleColor GetConsoleColor(char colorCode)
        {
            switch (char.ToLower(colorCode))
            {
                case '0':
                    return ConsoleColor.Black;
                case '1':
                    return ConsoleColor.Red;
                case '2':
                    return ConsoleColor.Green;
                case '3':
                    return ConsoleColor.Yellow;
                case '4':
                    return ConsoleColor.Blue;
                case '5':
                    return ConsoleColor.Cyan;
                case '6':
                    return ConsoleColor.Magenta;
                case '7':
                    return ConsoleColor.White;
                case '8':
                    return ConsoleColor.DarkYellow;
                case '9':
                    return ConsoleColor.Gray;
                case ':':
                    return ConsoleColor.Gray;
                case ';':
                    return ConsoleColor.Gray;
                case '<':
                    return ConsoleColor.DarkGreen;
                case '=':
                    return ConsoleColor.DarkYellow;
                case '>':
                    return ConsoleColor.DarkBlue;
                case '?':
                    return ConsoleColor.DarkRed;
                case '@':
                    return ConsoleColor.DarkYellow;
                case 'a':
                    return ConsoleColor.DarkYellow;
                case 'b':
                    return ConsoleColor.DarkGreen;
                case 'c':
                    return ConsoleColor.DarkMagenta;
                case 'd':
                    return ConsoleColor.Blue;
                case 'e':
                    return ConsoleColor.DarkMagenta;
                case 'f':
                    return ConsoleColor.Blue;
                case 'g':
                    return ConsoleColor.Green;
                case 'h':
                    return ConsoleColor.DarkGreen;
                case 'i':
                    return ConsoleColor.Red;
                case 'j':
                    return ConsoleColor.DarkRed;
                case 'k':
                    return ConsoleColor.DarkYellow;
                case 'l':
                    return ConsoleColor.Yellow;
                case 'm':
                    return ConsoleColor.Yellow;
                case 'n':
                    return ConsoleColor.White;
                case 'o':
                    return ConsoleColor.Yellow;
                case 'p':
                    return ConsoleColor.Black;
                case 'q':
                    return ConsoleColor.Red;
                case 'r':
                    return ConsoleColor.Green;
                case 's':
                    return ConsoleColor.Yellow;
                case 't':
                    return ConsoleColor.Blue;
                case 'u':
                    return ConsoleColor.Cyan;
                case 'v':
                    return ConsoleColor.Magenta;
                case 'w':
                    return ConsoleColor.White;
                case 'x':
                    return ConsoleColor.DarkYellow;
                case 'y':
                    return ConsoleColor.Gray;
                case 'z':
                    return ConsoleColor.DarkGray;
                default:
                    return ConsoleColor.White;
            }

        }
    }
}