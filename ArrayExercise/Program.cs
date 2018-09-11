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
            int[] myArray = { 1, 22, 31, 4, 42, 11, 17, 6, 27, 9, 16, 12, 47, 5, 35 };
            ArrayPractice practice = new ArrayPractice();
            practice.print(myArray, "This is the original array: ");
            practice.Swap(myArray, 0, 3);
            practice.ReverseInPlace(myArray);
            int[] reversedArray = practice.ReverseNew(myArray);
            int[] bruteForceSortedArray = practice.BruteForceSort(myArray);
        }
    }
}
