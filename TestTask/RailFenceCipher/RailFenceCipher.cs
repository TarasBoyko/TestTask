using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.RailFenceCipher
{
    // Implements the rail fence cipher(also called a zigzag cipher).
    public class RailFenceCipher
    {
        // Endodes @str depending of @numberOfRails.
        // @str specifies string for encoding.
        // @numberOfRails specifies number of rails (rows).
        public static string EncodeString(string str, int numberOfRails)
        {
            if (numberOfRails < 2)
            {
                throw new ArgumentException("number of rails is less than 2");
            }

            if (str == string.Empty)
            {
                return string.Empty;
            }

            StringBuilder encodedString = new StringBuilder();
            int periodLength = numberOfRails + numberOfRails - 2; // zigzag period length

            for (int railIndex = 0; railIndex < numberOfRails; railIndex++)
            {
                // define the first and the second offset in index (they both always equal to zigzag period length)
                int firstStep = periodLength - 2 * railIndex; 
                int secondStep = periodLength - firstStep;

                int decodedStringIndex = railIndex; // running index in decoded string
                while (decodedStringIndex < str.Length)
                {
                    if (firstStep != 0)
                    {
                        encodedString.Append(str[decodedStringIndex]);
                        decodedStringIndex += firstStep;
                    }

                    if ( decodedStringIndex >= str.Length)
                    {
                        break;
                    }

                    if (secondStep != 0)
                    {
                        encodedString.Append(str[decodedStringIndex]);
                        decodedStringIndex += secondStep;
                    }
                } 
            }

            return encodedString.ToString();
        }

        // Decodes @encodedString depending of @numberOfRails.
        // @encodedString specifies string for decoding.
        // @numberOfRails specifies number of rails (rows).
        public static string DecodeString(string encodedString, int numberOfRails)
        {
            if (numberOfRails < 2)
            {
                throw new ArgumentException("number of rails is less than 2");
            }

            if (encodedString == string.Empty)
            {
                return string.Empty;
            }

            StringBuilder decodedString = new StringBuilder();
            decodedString.Length = encodedString.Length;
            int periodLength = numberOfRails + numberOfRails - 2; // zigzag period length
            int encodedStringIndex = 0; // running index in encoded string

            for (int railIndex = 0; railIndex < numberOfRails; railIndex++)
            {
                // define the first and the second offset in index (they both always equal to zigzag period length)
                int firstStep = periodLength - 2 * railIndex;
                int secondStep = periodLength - firstStep;

                int decodedStringIndex = railIndex;
                while (decodedStringIndex < encodedString.Length)
                {
                    if (firstStep != 0)
                    {
                        decodedString[decodedStringIndex]= encodedString[encodedStringIndex];
                        decodedStringIndex += firstStep;
                        encodedStringIndex++;
                    }

                    if (decodedStringIndex >= encodedString.Length)
                    {
                        break;
                    }

                    if (secondStep != 0)
                    {
                        decodedString[decodedStringIndex] = encodedString[encodedStringIndex];
                        decodedStringIndex += secondStep;
                        encodedStringIndex++;
                    }
                }
            }

            return decodedString.ToString();
        }
    }
}
