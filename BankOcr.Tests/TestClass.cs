using System.Collections.Generic;
using NUnit.Framework;

namespace BankOcr.NetFramework.Tests
{
    [TestFixture]
    public class UserStoryTests
    {
        readonly string testLine1 = "    _  _     _  _  _  _  _ ";
        readonly string testLine2 = "  | _| _||_||_ |_   ||_||_|";
        readonly string testLine3 = "  ||_  _|  | _||_|  ||_| _|";
        readonly string testLine4 = "                           ";       

        public static readonly List<string> entry = new List<string> { };

        [SetUp]
        public void SetUp()
        {
            entry.Clear();
            entry.Add(testLine1);
            entry.Add(testLine2);
            entry.Add(testLine3);
            entry.Add(testLine4);
        }

        [Test]
        public void TestSetupIsCorrect()
        {
            Assert.AreEqual(entry.Count, 4);
        }

        [Test]
        public void TestParseSimple()
        {
            var parser = new Code.Parser();
            var result = parser.Parse(entry);
            Assert.AreEqual("123456789", result);
        }

        [Test]
        public void TestCheckCountPasses()
        {
            var rulesChecker = new Code.RulesChecker();
            var result = rulesChecker.CheckCount(entry);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestCheckCountFails()
        {
            var entry1 = entry;
            var rulesChecker = new Code.RulesChecker();
            //remove 1 to check failure
            entry1.Remove(testLine1);
            var result = rulesChecker.CheckCount(entry1);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestCheckLengthPasses()
        {
            var rulesChecker = new Code.RulesChecker();
            var result = rulesChecker.CheckCount(entry);
            Assert.IsTrue(result);            
            result = rulesChecker.CheckCount(entry);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestCheckLengthFails()
        {
            //remove 1 character from a line
            entry.RemoveAt(0);

            var rulesChecker = new Code.RulesChecker();
            var result = rulesChecker.CheckCount(entry);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestSplitIntoChars()
        {
            var parser = new Code.Parser();
            var characters = parser.SplitIntoChars(entry);

            Assert.That(characters.Count == 9, "SplitIntoChars must return 9 items");

            Assert.AreEqual(characters[0], Code.Characters.numberOne);
            Assert.AreEqual(characters[1], Code.Characters.numberTwo);
            Assert.AreEqual(characters[2], Code.Characters.numberThree);
            Assert.AreEqual(characters[3], Code.Characters.numberFour);
            Assert.AreEqual(characters[4], Code.Characters.numberFive);
            Assert.AreEqual(characters[5], Code.Characters.numberSix);
            Assert.AreEqual(characters[6], Code.Characters.numberSeven);
            Assert.AreEqual(characters[7], Code.Characters.numberEight);
            Assert.AreEqual(characters[8], Code.Characters.numberNine);
        }

        [Test]
        public void TestMatching()
        {
            var parser = new Code.Parser();
            var characters = parser.SplitIntoChars(entry);

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
            var characters = parser.SplitIntoChars(entry);
            var result = parser.MatchChars(characters);
            Assert.AreEqual("123456789", result);
        }
    }
}
