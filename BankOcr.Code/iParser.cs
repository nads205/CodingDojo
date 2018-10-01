using System.Collections.Generic;

namespace BankOcr.Code
{
    public interface IParser
    {       
        string Parse(List<string> lines);
    }
}