using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ETJump.TextUtilities.Tests
{
    [TestClass]
    public class EncodingTests
    {
        [TestMethod]
        public void Decode_TestEmptyString()
        {
            var decoded = Encoding.Decode("");

            Assert.AreEqual("", decoded);
        }

        [TestMethod]
        public void Decode_TestStringWithoutEncodedValues()
        {
            var decoded = Encoding.Decode("aaAAbbEEddacasd");

            Assert.AreEqual("aaAAbbEEddacasd", decoded);
        }

        [TestMethod]
        public void Decode_TestStringWithEncodedValues()
        {
            var decoded = Encoding.Decode("Testing =E4 123 =F6");

            Assert.AreEqual(decoded, "Testing ä 123 ö");
        }
    }
}
