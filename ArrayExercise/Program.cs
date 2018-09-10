using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };
            string printString = "This is the original array: ";
            for (int i=0; i< originalArray.Length; i++)
            {
                printString += " " + originalArray[i];
            }
            Console.WriteLine(printString);
            ArrayPractice mySwapper = new ArrayPractice(originalArray);
            mySwapper.Swap(0, 3);
            string printString2 = "This is the altered array: ";
            for (int i = 0; i < originalArray.Length; i++)
            {
                printString2 += " " + originalArray[i];
            }
            Console.WriteLine(printString2);
        }
    }
}
