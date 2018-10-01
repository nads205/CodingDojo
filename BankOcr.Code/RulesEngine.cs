using System.Collections.Generic;
using System.Diagnostics;

namespace BankOcr.Code
{

    public class RulesEngine : IRulesChecker
    {
        public bool CheckAllRules(List<string> lines)
        {
            //must be 4 lines long
            var testCount = CheckCount(lines);
            if (!testCount) return false;

            //each line must be 27 characters 
            var testLength = CheckLength(lines);
            if (!testLength) return false;

            //todo: all characters must be a pipe or a underscore
            Trace.TraceInformation("Parsing");            
            return true;
        }

        public bool CheckCount(List<string> lines)
        {
            if (lines.Count == 4) return true;
            Trace.TraceError($"Entry doesn't contain 4 lines, contains {lines.Count} lines.");
            return false;

        }

        public bool CheckLength(List<string> lines)
        {
            foreach (var line in lines)
            {
                if (line.Length == 27) continue;
                Trace.TraceError("Each line must be 27 characters in length"); 
                return false;
            }
            return true;
        }
    }
}
