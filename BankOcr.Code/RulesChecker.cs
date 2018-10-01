using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BankOcr.Code
{

    public class RulesChecker : IRulesChecker
    {
        public bool CheckAllRules(List<string> lines)
        {
            //must be 4 lines long
            var testCount = CheckCount(lines);
            if (!testCount)
            {
                Trace.TraceError(string.Format("Entry doesn't contain 4 lines, contains {0} lines.", lines.Count()));
                return false;
            }
            //each line must be 27 characters 
            var testLength = CheckLength(lines);
            if (!testLength)
            {
                Trace.TraceError(string.Format("Each line must be 27 characters in length")); //todo:perhaps output which 
                return false;
            }

            //all characters must be a pipe or a underscore
            Trace.TraceInformation("Parsing");


            

            return true;
        }

        public bool CheckCount(List<string> lines)
        {
            return lines.Count() == 4;
        }

        public bool CheckLength(List<string> lines)
        {
            foreach (var line in lines)
            {
                if (line.Length != 27) return false;
            }
            return true;
        }
    }
}
