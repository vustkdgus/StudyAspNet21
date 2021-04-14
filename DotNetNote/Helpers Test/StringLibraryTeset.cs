using Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Helpers_Test
{
    class StringLibraryTeset
    {
        [TestMethod]
        public void CurStringTest()
        {
            string strCut = "Hello World, This is a test sentence";
            int intChar = 15;

            var expected = "Hello World,..."; //
            var actaul = StringLibrary.CutString(strCut, intChar);
            Assert.Equals(expected, actaul);
        }

        [TestMethod]
        public void CurStringUnicodeTest()
        {
            string strCut = "안녕하세요, 부경대학교입니다.";
            int intChar = 9;

            var expected = "안녕하세요....";
            var actaul = StringLibrary.CutString(strCut, intChar);
            Assert.Equals(expected, actaul);

        }
    }
}
