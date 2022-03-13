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

            //var acutal = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }

    }
}
