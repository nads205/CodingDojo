using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BankOct.Tests
{

    [TestClass]
    public class UserStoryTests
    {
        readonly string testLine1 =      "    _  _     _  _  _  _  _";
        readonly string testLine2 =      "  | _| _||_||_ |_   ||_||_|";
        readonly string testLine3 =      "  ||_  _|  | _||_|  ||_| _|";
        readonly string testLine4 =      "                           ";
        List<string> entry = new List<string> { };        

        [TestInitialize]
        public void SetUp()
        {
            entry.Add(testLine1);
            entry.Add(testLine2);
            entry.Add(testLine3);
            entry.Add(testLine4);
        }

        [TestMethod]
        public void TestEntryHas4Lines()
        {
            Assert.AreEqual(2, 4);
            Assert.AreEqual(entry.Count, 4);
        }
    }
}
