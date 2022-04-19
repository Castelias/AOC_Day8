using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_Day8
{
    partial class Program
    {
        // 5 segments = 2,5,3 || 6 segments = 6,9,0 

        public class SevenSegmentDisplay
        {
            public List<string> firstInstructionsList = new List<string>();
            public List<string> secondInstructionsList = new List<string>();

            public string[] numbers = new string[10];
            /*
             * -0-
             * 5 1
             * -6-
             * 4 2
             * -3- 
            */
            public SevenSegmentDisplay(string firstInstructions, string secondInstructions)
            {
                foreach (var item in firstInstructions.Split(null))
                {
                    firstInstructionsList.Add(item);
                }
                foreach (var item in secondInstructions.Split(null))
                {
                    secondInstructionsList.Add(item);
                }
                firstInstructionsList.Sort((a, b) => a.Length.CompareTo(b.Length));
                SortDisplay();
            }

            public void SortDisplay()
            {
                this.numbers[4] = this.firstInstructionsList[3];
                this.numbers[1] = this.firstInstructionsList[1];
                this.numbers[7] = this.firstInstructionsList[2];
                this.numbers[8] = this.firstInstructionsList[firstInstructionsList.Count - 1];

              
            }

        }
    }
}
