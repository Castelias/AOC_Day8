using System;
using System.Collections.Generic;
using System.Text;
using static AOC_Day8.Program;

namespace AOC_Day8
{
    class SegmentLogic
    {

        public static char findExtraCharcter(char[] strA, char[] strB)
        {
            int[] m1 = new int[32];

            // store second string in map with frequency
            for (int i = 0; i < strB.Length; i++)
                m1[strB[i]]++;

            // store first string in map with frequency
            for (int i = 0; i < strA.Length; i++)
                m1[strA[i]]--;

            for (int i = 0; i < m1.Length; i++)
            {

                // if the frequency is 1 then this
                // character is which is added extra
                if (m1[i] == 1)
                    return (char)i;
            }
            return char.MinValue;
        }

        public static void DisplayList(List<SevenSegmentDisplay> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].firstInstructionsList.Count; j++)
                {
                    Console.WriteLine(list[i].firstInstructionsList[j]);
                }
            }
        }

        public static string SortString(string input)
        {
            char temp;
            char[] charstr = input.ToCharArray();

            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            return charstr.ToString();
        }

        public static char FindFirstChar(List<string>list)
        {
            string str1 =SortString(list[7]);
            string str2 =SortString(list[8]);
            string str3 =SortString(list[9]);
            char result = 'a';

            for (int i = 0; i < 5; i++)
            {

                if (str1[i] == str2[i] && str2[i] == str3[i] && (str1 == "c" || str1 == "g"))
                {
                    result = str1[i];
                }
            }
            return result;
        }
    }
}
