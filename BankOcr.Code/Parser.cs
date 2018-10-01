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
            var rulesChecker = new RulesChecker();
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
            List<List<string>> allChars = new List<List<string>>();            
            for (int i = 0; i < 9; i++)
            {
                List<string> chars = new List<string>
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
            List<int> numbers = new List<int>();
            foreach (var c in chars)
            {
                var number = NumberMatcher(c);
                numbers.Add(number);
            }

            return string.Join("", numbers);
        }

        /// <summary>
        /// given a char of numbers (matrix of 3,4) returns a intgeger
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public int NumberMatcher(List<string> chars)
        {
            if (chars[0] == Characters.numberOne[0] &&
                chars[1] == Characters.numberOne[1] &&
                chars[2] == Characters.numberOne[2] &&
                chars[3] == Characters.numberOne[3]
                ) return 1;

            if (chars[0] == Characters.numberTwo[0] &&
                chars[1] == Characters.numberTwo[1] &&
                chars[2] == Characters.numberTwo[2] &&
                chars[3] == Characters.numberTwo[3]
                ) return 2;

            if (chars[0] == Characters.numberThree[0] &&
                chars[1] == Characters.numberThree[1] &&
                chars[2] == Characters.numberThree[2] &&
                chars[3] == Characters.numberThree[3]
                ) return 3;

            if (chars[0] == Characters.numberFour[0] &&
                chars[1] == Characters.numberFour[1] &&
                chars[2] == Characters.numberFour[2] &&
                chars[3] == Characters.numberFour[3]
                ) return 4;

            if (chars[0] == Characters.numberFive[0] &&
                chars[1] == Characters.numberFive[1] &&
                chars[2] == Characters.numberFive[2] &&
                chars[3] == Characters.numberFive[3]
                ) return 5;

            if (chars[0] == Characters.numberSix[0] &&
                chars[1] == Characters.numberSix[1] &&
                chars[2] == Characters.numberSix[2] &&
                chars[3] == Characters.numberSix[3]
                ) return 6;

            if (chars[0] == Characters.numberSeven[0] &&
                chars[1] == Characters.numberSeven[1] &&
                chars[2] == Characters.numberSeven[2] &&
                chars[3] == Characters.numberSeven[3]
                ) return 7;

            if (chars[0] == Characters.numberEight[0] &&
                chars[1] == Characters.numberEight[1] &&
                chars[2] == Characters.numberEight[2] &&
                chars[3] == Characters.numberEight[3]
                ) return 8;

            if (chars[0] == Characters.numberNine[0] &&
                chars[1] == Characters.numberNine[1] &&
                chars[2] == Characters.numberNine[2] &&
                chars[3] == Characters.numberNine[3]
                ) return 9;     

            return 0;
        }

    }

    static class StringExtensions
    {

        public static IEnumerable<string> SplitInParts(this string s, int partLength)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", "partLength");

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }

    }

}
