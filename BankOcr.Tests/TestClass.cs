using System.Collections.Generic;
using NUnit.Framework;

namespace BankOcr.NetFramework.Tests
{
    [TestFixture]
    public class UserStoryOneTests
    {
        private const string TestLine1 = "    _  _     _  _  _  _  _ ";
        private const string TestLine2 = "  | _| _||_||_ |_   ||_||_|";
        private const string TestLine3 = "  ||_  _|  | _||_|  ||_| _|";
        private const string TestLine4 = "                           ";

        public static readonly List<string> Entry = new List<string>();

        [SetUp]
        public void SetUp()
        {
            Entry.Clear();
            Entry.Add(TestLine1);
            Entry.Add(TestLine2);
            Entry.Add(TestLine3);
            Entry.Add(TestLine4);
        }

        [Test]
        public void TestSetupIsCorrect()
        {
            Assert.AreEqual(Entry.Count, 4);
        }

        [Test]
        public void TestParseSimple()
        {
            var parser = new Code.Parser();
            var result = parser.Parse(Entry);
            Assert.AreEqual("123456789", result);
        }

        [Test]
        public void TestCheckCountPasses()
        {
            var rulesChecker = new Code.RulesChecker();
            var result = rulesChecker.CheckCount(Entry);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestCheckCountFails()
        {
            var entry1 = Entry;
            var rulesChecker = new Code.RulesChecker();
            //remove 1 to check failure
            entry1.Remove(TestLine1);
            var result = rulesChecker.CheckCount(entry1);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestCheckLengthPasses()
        {
            var rulesChecker = new Code.RulesChecker();
            var result = rulesChecker.CheckCount(Entry);
            Assert.IsTrue(result);            
            result = rulesChecker.CheckCount(Entry);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestCheckLengthFails()
        {
            //remove 1 character from a line
            Entry.RemoveAt(0);

            var rulesChecker = new Code.RulesChecker();
            var result = rulesChecker.CheckCount(Entry);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestSplitIntoChars()
        {
            var parser = new Code.Parser();
            var characters = parser.SplitIntoChars(Entry);

            Assert.That(characters.Count == 9, "SplitIntoChars must return 9 items");

            Assert.AreEqual(characters[0], Code.Characters.NumberOne);
            Assert.AreEqual(characters[1], Code.Characters.NumberTwo);
            Assert.AreEqual(characters[2], Code.Characters.NumberThree);
            Assert.AreEqual(characters[3], Code.Characters.NumberFour);
            Assert.AreEqual(characters[4], Code.Characters.NumberFive);
            Assert.AreEqual(characters[5], Code.Characters.NumberSix);
            Assert.AreEqual(characters[6], Code.Characters.NumberSeven);
            Assert.AreEqual(characters[7], Code.Characters.NumberEight);
            Assert.AreEqual(characters[8], Code.Characters.NumberNine);
        }

        [Test]
        public void TestMatching()
        {
            var parser = new Code.Parser();
            var characters = parser.SplitIntoChars(Entry);

            var one = parser.NumberMatcher(characters[0]);
            Assert.AreEqual(1, one);

            var two = parser.NumberMatcher(characters[1]);
            Assert.AreEqual(2, two);

            var three = parser.NumberMatcher(characters[2]);
            Assert.AreEqual(3, three);

            var four = parser.NumberMatcher(characters[3]);
            Assert.AreEqual(4, four);

            var five = parser.NumberMatcher(characters[4]);
            Assert.AreEqual(5, five);

            var six = parser.NumberMatcher(characters[5]);
            Assert.AreEqual(6, six);

            var seven = parser.NumberMatcher(characters[6]);
            Assert.AreEqual(7, seven);

            var eight = parser.NumberMatcher(characters[7]);
            Assert.AreEqual(8, eight);

            var nine = parser.NumberMatcher(characters[8]);
            Assert.AreEqual(9, nine);

        }

        [Test]
        public void TestMatch()
        {
            var parser = new Code.Parser();
            var characters = parser.SplitIntoChars(Entry);
            var result = parser.MatchChars(characters);
            Assert.AreEqual("123456789", result);
        }
    }
}
