using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ETJump.TextUtilities
{
    public static class Encoding
    {
        /// <summary>
        /// Decodes ETJump encoded input string 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Decode(string input)
        {
            var sb = new StringBuilder();
            for (int i = 0, len = input.Length; i < len; ++i)
            {
                if (input[i] == '=' && input.Length > i + 2 && IsValidHexaByte(input[i + 1]) &&
                    IsValidHexaByte(input[i + 2]))
                {
                    var hexValue = int.Parse(input.Substring(i + 1, 2), NumberStyles.HexNumber);
                    sb.Append((char) hexValue);
                    i += 2;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            return sb.ToString();
        }

        private static bool IsValidHexaByte(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F');
        }

        /// <summary>
        /// Encodes extended ASCII to ETJump encoded string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Encode(string input)
        {
            var sb = new StringBuilder();

            for (int i = 0, len = input.Length; i < len; ++i)
            {
                if (input[i] <= 127 && input[i] != '=')
                {
                    sb.Append(input[i]);
                }
                else
                {
                    sb.Append(string.Format("={0:X2}", (int) input[i]));
                }
            }

            return sb.ToString();
        }
    }
}
