using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace AOC_Day8
{
    /* string json = JsonConvert.SerializeObject(inputList);
 File.WriteAllText(@"C:\Users\piotr\source\repos\AOC_Day8\AOC_Day8\Day8Serialized", json);*/
    partial class Program
    {
        struct SevenSegmentNumber
        {
            public string number;

            public SevenSegmentNumber(string number)
            {
                this.number = number;
            }
        }

        static void Main(string[] args)
        {
            string path = @"C:\Users\piotr\source\repos\AOC_Day8\AOC_Day8\inputFile.txt";
            List<string> inputList = File.ReadAllLines(path).ToList();
            List<SevenSegmentNumber> segmentNumbersList = new List<SevenSegmentNumber>();
            List<string> finalList = new List<string>();
            List<SevenSegmentDisplay> segmentList = new List<SevenSegmentDisplay>(); 

            int result = 0;

            foreach (var item in inputList)
            {
                finalList.Add(item.Substring(61));
                string x = item.Substring(61);
                string y = item.Substring(0, 59);
                segmentList.Add(new SevenSegmentDisplay(y, x));
            }

            for (int i = 0; i < finalList.Count; i++)
            {
                foreach (var item in finalList[i].Split(null))
                {
                    segmentNumbersList.Add(new SevenSegmentNumber(item));
                } 
            }

            foreach (var item in segmentNumbersList)
            {
                int itemSize = item.number.Length;
                if(itemSize == 2 || itemSize == 3 || itemSize == 4 || itemSize == 7) // 1 , 7 , 4 , 8
                {
                    result++;
                }
                
            }
            Console.WriteLine(result);
            SegmentLogic.DisplayList(segmentList);

            Console.WriteLine("-----");

            foreach (var item in segmentList[0].numbers)
            {
               if(item!=null) Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(SegmentLogic.FindFirstChar(segmentList[0].firstInstructionsList));

        }
    }
}
