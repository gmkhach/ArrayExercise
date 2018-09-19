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
            ArrayPractice practice = new ArrayPractice();
            int[] myArray = practice.BuildArray();
            practice.print(myArray, "\nThis is the original array: ");
            practice.Swap(myArray, 0, 3);
            practice.ReverseInPlace(myArray);
            int[] reversedArray = practice.ReverseNew(myArray);
            int[] bruteForceSortedArray = practice.BruteForceSort(myArray);
            int[] randomlySortedArray = practice.RandomSort(myArray);
        }
    }
}
