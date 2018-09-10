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
            int[] myArray = { 1, 2, 3, 4, 5 };
            string printString = "This is the original array: ";
            for (int i=0; i< myArray.Length; i++)
            {
                printString += " " + myArray[i];
            }
            Console.WriteLine(printString);

            ArrayPractice practice = new ArrayPractice(myArray);
            practice.Swap(0, 3);
            string printString2 = "This is the altered array: ";
            for (int i = 0; i < myArray.Length; i++)
            {
                printString2 += " " + myArray[i];
            }
            Console.WriteLine(printString2);

            //practice.ReverseInPlace();
            //string printString3 = "This is the reversedInPlace array: ";
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    printString3 += " " + myArray[i];
            //}
            //Console.WriteLine(printString3);

            int[] newArray = practice.ReverseNew();
            string printString4 = "This is the reversedNew array: ";
            for (int i = 0; i < myArray.Length; i++)
            {
                printString4 += " " + myArray[i];
            }
            Console.WriteLine(printString4);
        }
    }
}
