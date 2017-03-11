using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ETJump.TextUtilities.Tests
{
    [TestClass]
    public class ColorParserTests
    {
        [TestMethod]
        public void Parse_ColorlessString_Returns_SinglePart()
        {
            const string input = "Hello, world!";

            Assert.AreEqual(ColorParser.Parse(input).Parts.First().Text, input);
        }

        [TestMethod]
        public void Parse_ColorfulString_Returns_CorrectAmountOfParts()
        {
            const string input = "^3Hello^7, ^9World^2!";

            var result = ColorParser.Parse(input);
            Assert.AreEqual(result.Parts.Count, 4);
            Assert.AreEqual(result.Parts[0].Text, "Hello");
            Assert.AreEqual(result.Parts[1].Text, ", ");
            Assert.AreEqual(result.Parts[2].Text, "World");
            Assert.AreEqual(result.Parts[3].Text, "!");
        }

        [TestMethod]
        public void Parse_ColorfulString_Returns_CorrectColors()
        {
            const string input = "^3Hello^7, ^9World^2!";

            var result = ColorParser.Parse(input);
            Assert.AreEqual(result.Parts[0].ColorCode, '3');
            Assert.AreEqual(result.Parts[1].ColorCode, '7');
            Assert.AreEqual(result.Parts[2].ColorCode, '9');
            Assert.AreEqual(result.Parts[3].ColorCode, '2');
        }

        [TestMethod]
        public void Parse_MultipleConsequentCarets_Returns_EscapedCaret()
        {
            const string input = "^^2Hello, ^^3World!";

            var result = ColorParser.Parse(input);
            Assert.AreEqual(result.Parts[0].Text, "^");
            Assert.AreEqual(result.Parts[1].Text, "Hello, ^");
            Assert.AreEqual(result.Parts[2].Text, "World!");
        }

        [TestMethod]
        public void Parse_MultipleConsequentCarets_Returns_CorrectColors()
        {
            const string input = "^^2Hello, ^^3World!";

            var result = ColorParser.Parse(input);
            Assert.AreEqual(result.Parts[0].ColorCode, '7');
            Assert.AreEqual(result.Parts[1].ColorCode, '2');
            Assert.AreEqual(result.Parts[2].ColorCode, '3');
        }
    }
}
