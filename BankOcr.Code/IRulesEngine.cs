using System.Collections.Generic;

namespace BankOcr.Code
{
    public interface IRulesChecker
    {
        bool CheckAllRules(List<string> lines);
    }
}