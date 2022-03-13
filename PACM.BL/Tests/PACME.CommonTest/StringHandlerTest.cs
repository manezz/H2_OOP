using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACME.Common;

namespace PACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            var acutal = handler.InsertSpaces(source);

            Assert.AreEqual(expected, acutal);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            var actual = handler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }

    }
}
