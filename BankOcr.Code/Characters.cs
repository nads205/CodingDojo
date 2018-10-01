using System.Collections.Generic;

namespace BankOcr.Code
{

    public static class Characters
    {
        public static readonly List<string> NumberOne = new List<string>();
        public static readonly List<string> NumberTwo = new List<string>();
        public static readonly List<string> NumberThree = new List<string>();
        public static readonly List<string> NumberFour = new List<string>();
        public static readonly List<string> NumberFive = new List<string>();
        public static readonly List<string> NumberSix = new List<string>();
        public static readonly List<string> NumberSeven = new List<string>();
        public static readonly List<string> NumberEight = new List<string>();
        public static readonly List<string> NumberNine = new List<string>();
        
        static Characters()
        {
  

            var char1 = "   ";
            var char2 = "  |";
            var char3 = "  |";
            var char4 = "   ";

            NumberOne.Add(char1);
            NumberOne.Add(char2);
            NumberOne.Add(char3);
            NumberOne.Add(char4);

            char1 = " _ ";
            char2 = " _|";
            char3 = "|_ ";
            char4 = "   ";

            NumberTwo.Add(char1);
            NumberTwo.Add(char2);
            NumberTwo.Add(char3);
            NumberTwo.Add(char4);

            char1 = " _ ";
            char2 = " _|";
            char3 = " _|";
            char4 = "   ";

            NumberThree.Add(char1);
            NumberThree.Add(char2);
            NumberThree.Add(char3);
            NumberThree.Add(char4);

            char1 = "   ";
            char2 = "|_|";
            char3 = "  |";
            char4 = "   ";

            NumberFour.Add(char1);
            NumberFour.Add(char2);
            NumberFour.Add(char3);
            NumberFour.Add(char4);

            char1 = " _ ";
            char2 = "|_ ";
            char3 = " _|";
            char4 = "   ";

            NumberFive.Add(char1);
            NumberFive.Add(char2);
            NumberFive.Add(char3);
            NumberFive.Add(char4);

            char1 = " _ ";
            char2 = "|_ ";
            char3 = "|_|";
            char4 = "   ";

            NumberSix.Add(char1);
            NumberSix.Add(char2);
            NumberSix.Add(char3);
            NumberSix.Add(char4);

            char1 = " _ ";
            char2 = "  |";
            char3 = "  |";
            char4 = "   ";

            NumberSeven.Add(char1);
            NumberSeven.Add(char2);
            NumberSeven.Add(char3);
            NumberSeven.Add(char4);

            char1 = " _ ";
            char2 = "|_|";
            char3 = "|_|";
            char4 = "   ";

            NumberEight.Add(char1);
            NumberEight.Add(char2);
            NumberEight.Add(char3);
            NumberEight.Add(char4);

            char1 = " _ ";
            char2 = "|_|";
            char3 = " _|";
            char4 = "   ";

            NumberNine.Add(char1);
            NumberNine.Add(char2);
            NumberNine.Add(char3);
            NumberNine.Add(char4);
        }
    }
}
