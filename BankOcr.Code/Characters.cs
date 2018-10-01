using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOcr.Code
{

    public static class Characters
    {
        public readonly static List<string> numberOne = new List<string> { };
        public readonly static List<string> numberTwo = new List<string> { };
        public readonly static List<string> numberThree = new List<string> { };
        public readonly static List<string> numberFour = new List<string> { };
        public readonly static List<string> numberFive = new List<string> { };
        public readonly static List<string> numberSix = new List<string> { };
        public readonly static List<string> numberSeven = new List<string> { };
        public readonly static List<string> numberEight = new List<string> { };
        public readonly static List<string> numberNine = new List<string> { };
        
        static Characters()
        {
  

            var char1 = "   ";
            var char2 = "  |";
            var char3 = "  |";
            var char4 = "   ";

            numberOne.Add(char1);
            numberOne.Add(char2);
            numberOne.Add(char3);
            numberOne.Add(char4);

            char1 = " _ ";
            char2 = " _|";
            char3 = "|_ ";
            char4 = "   ";

            numberTwo.Add(char1);
            numberTwo.Add(char2);
            numberTwo.Add(char3);
            numberTwo.Add(char4);

            char1 = " _ ";
            char2 = " _|";
            char3 = " _|";
            char4 = "   ";

            numberThree.Add(char1);
            numberThree.Add(char2);
            numberThree.Add(char3);
            numberThree.Add(char4);

            char1 = "   ";
            char2 = "|_|";
            char3 = "  |";
            char4 = "   ";

            numberFour.Add(char1);
            numberFour.Add(char2);
            numberFour.Add(char3);
            numberFour.Add(char4);

            char1 = " _ ";
            char2 = "|_ ";
            char3 = " _|";
            char4 = "   ";

            numberFive.Add(char1);
            numberFive.Add(char2);
            numberFive.Add(char3);
            numberFive.Add(char4);

            char1 = " _ ";
            char2 = "|_ ";
            char3 = "|_|";
            char4 = "   ";

            numberSix.Add(char1);
            numberSix.Add(char2);
            numberSix.Add(char3);
            numberSix.Add(char4);

            char1 = " _ ";
            char2 = "  |";
            char3 = "  |";
            char4 = "   ";

            numberSeven.Add(char1);
            numberSeven.Add(char2);
            numberSeven.Add(char3);
            numberSeven.Add(char4);

            char1 = " _ ";
            char2 = "|_|";
            char3 = "|_|";
            char4 = "   ";

            numberEight.Add(char1);
            numberEight.Add(char2);
            numberEight.Add(char3);
            numberEight.Add(char4);

            char1 = " _ ";
            char2 = "|_|";
            char3 = " _|";
            char4 = "   ";

            numberNine.Add(char1);
            numberNine.Add(char2);
            numberNine.Add(char3);
            numberNine.Add(char4);
        }
    }
}
