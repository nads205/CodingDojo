using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BankOcr.Code
{
    public class Parser : IParser
    {

        public string Parse(List<string> lines)
        {
            //output all the lines to trace
            foreach (var line in lines)
            {
                Trace.TraceInformation(line);
            }

            //pass all the rules? 
            var rulesChecker = new RulesEngine();
            var rulesPassed = rulesChecker.CheckAllRules(lines);
            if (!rulesPassed) return "Couldn't parse";

            var parser = new Parser();
            var characters = parser.SplitIntoChars(lines);
            var value = parser.MatchChars(characters);
            return value;
        }

        /// <summary>
        /// This method takes all the lines and splits them every three characters to returns a list nine items
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public List<List<string>> SplitIntoChars(List<string> lines)
        {
            var line0 = lines[0].SplitInParts(3).ToList();
            var line1 = lines[1].SplitInParts(3).ToList();
            var line2 = lines[2].SplitInParts(3).ToList();
            var line3 = lines[3].SplitInParts(3).ToList();
            var allChars = new List<List<string>>();            
            for (var i = 0; i < 9; i++)
            {
                var chars = new List<string>
                {
                    line0[i],
                    line1[i],
                    line2[i],
                    line3[i]
                };
                allChars.Add(chars);
            }
            return allChars;
        }

        public string MatchChars(List<List<string>> chars)
        {
            var numbers = new List<int>();
            foreach (var c in chars)
            {
                var number = NumberMatcher(c);
                numbers.Add(number);
            }

            return string.Join("", numbers);
        }

        /// <summary>
        /// given a char of numbers (matrix of 3,4) returns a integer
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public int NumberMatcher(List<string> chars)
        {
            if (chars[0] == Characters.NumberOne[0] &&
                chars[1] == Characters.NumberOne[1] &&
                chars[2] == Characters.NumberOne[2] &&
                chars[3] == Characters.NumberOne[3]
                ) return 1;

            if (chars[0] == Characters.NumberTwo[0] &&
                chars[1] == Characters.NumberTwo[1] &&
                chars[2] == Characters.NumberTwo[2] &&
                chars[3] == Characters.NumberTwo[3]
                ) return 2;

            if (chars[0] == Characters.NumberThree[0] &&
                chars[1] == Characters.NumberThree[1] &&
                chars[2] == Characters.NumberThree[2] &&
                chars[3] == Characters.NumberThree[3]
                ) return 3;

            if (chars[0] == Characters.NumberFour[0] &&
                chars[1] == Characters.NumberFour[1] &&
                chars[2] == Characters.NumberFour[2] &&
                chars[3] == Characters.NumberFour[3]
                ) return 4;

            if (chars[0] == Characters.NumberFive[0] &&
                chars[1] == Characters.NumberFive[1] &&
                chars[2] == Characters.NumberFive[2] &&
                chars[3] == Characters.NumberFive[3]
                ) return 5;

            if (chars[0] == Characters.NumberSix[0] &&
                chars[1] == Characters.NumberSix[1] &&
                chars[2] == Characters.NumberSix[2] &&
                chars[3] == Characters.NumberSix[3]
                ) return 6;

            if (chars[0] == Characters.NumberSeven[0] &&
                chars[1] == Characters.NumberSeven[1] &&
                chars[2] == Characters.NumberSeven[2] &&
                chars[3] == Characters.NumberSeven[3]
                ) return 7;

            if (chars[0] == Characters.NumberEight[0] &&
                chars[1] == Characters.NumberEight[1] &&
                chars[2] == Characters.NumberEight[2] &&
                chars[3] == Characters.NumberEight[3]
                ) return 8;

            if (chars[0] == Characters.NumberNine[0] &&
                chars[1] == Characters.NumberNine[1] &&
                chars[2] == Characters.NumberNine[2] &&
                chars[3] == Characters.NumberNine[3]
                ) return 9;     

            return 0;
        }

    }

    internal static class StringExtensions
    {

        public static IEnumerable<string> SplitInParts(this string s, int partLength)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }

    }

}
