using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverterTests
{
    static class RomanNumeralConverter
    {
        public static Int32 Convert(String numeral)
        {
            var valueOfNumeral = 0;

            for (var i = 0; i < numeral.Length; i++)
            {
                var currentCharacterValue = ValueOfBaseNumeral(numeral.ElementAt(i));

                if ( i < numeral.Length - 1)
                {
                    var nextCharacterValue = ValueOfBaseNumeral(numeral.ElementAt(i + 1));

                    if (currentCharacterValue < nextCharacterValue)
                    {
                        valueOfNumeral += nextCharacterValue - currentCharacterValue;
                        i++;
                    }
                    else
                    {
                        valueOfNumeral += ValueOfBaseNumeral((numeral.ElementAt(i)));
                    }

                }
                else
                {
                    valueOfNumeral += ValueOfBaseNumeral((numeral.ElementAt(i)));
                }    
                
            }
            return valueOfNumeral;
        }


        private static Int32 ValueOfBaseNumeral(char numeral)
        {
            if (numeral.Equals('I'))
                return 1;

            if (numeral.Equals('V'))
                return 5;

            if (numeral.Equals('X'))
                return 10;

            if (numeral.Equals('L'))
                return 50;

            if (numeral.Equals('C'))
                return 100;

            if (numeral.Equals('D'))
                return 500;

            if (numeral.Equals('M'))
                return 1000;

            return 0;
        }

    }
}
