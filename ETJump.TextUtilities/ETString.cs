using System;
using System.Collections.Generic;
using System.Text;

namespace ETJump.TextUtilities
{
    public class PartialString
    {
        public char ColorCode { get; set; } = '7';
        public string Text { get; set; }
    }
    /// <summary>
    /// Color coded string
    /// </summary>
    public class ETString
    {
        public List<PartialString> Parts { get; set; } = new List<PartialString>();
    }
}
