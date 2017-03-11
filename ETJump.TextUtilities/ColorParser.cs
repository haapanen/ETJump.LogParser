using System;
using System.Collections.Generic;
using System.Text;

namespace ETJump.TextUtilities
{
    public static class ColorParser
    {
        /// <summary>
        /// Converts the input to colored ETString
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static ETString Parse(string input)
        {
            var etString = new ETString();

            var prevWasCaret = false;
            PartialString currentPart = null;
            for (int i = 0, len = input.Length; i < len; ++i)
            {
                if (input[i] == '^')
                {
                    if (prevWasCaret)
                    {
                        if (currentPart == null)
                        {
                            currentPart = new PartialString();
                        }

                        currentPart.Text += '^';
                    }
                    prevWasCaret = true;
                }
                else
                {
                    if (prevWasCaret)
                    {
                        if (currentPart != null)
                        {
                            etString.Parts.Add(currentPart);
                        }

                        currentPart = new PartialString
                        {
                            ColorCode = input[i]
                        };
                    }
                    else
                    {
                        if (currentPart == null)
                        {
                            currentPart = new PartialString();
                        }

                        currentPart.Text += input[i];
                    }
                    prevWasCaret = false;
                }
            }

            if (currentPart != null)
            {
                etString.Parts.Add(currentPart);
            }

            return etString;
        }
    }
}
