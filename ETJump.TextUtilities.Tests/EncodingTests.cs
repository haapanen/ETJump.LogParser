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

        [TestMethod]
        public void Encode_ReturnsEmptyString_WhenInputIsEmpty()
        {
            var encoded = Encoding.Encode("");

            Assert.AreEqual(encoded, "");
        }

        [TestMethod]
        public void Encode_ReturnsSameString_WhenAllValuesAreRegularASCII()
        {
            var encoded = Encoding.Encode("just a regular string");

            Assert.AreEqual("just a regular string", encoded);
        }

        [TestMethod]
        public void Encode_EncodesValuesCorrectly()
        {
            var encoded = Encoding.Encode("Testing extended äöäö ASCII =ölö");

            Assert.AreEqual("Testing extended =E4=F6=E4=F6 ASCII =3D=F6l=F6", encoded);
        }
    }
}
