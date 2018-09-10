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
            Console.WriteLine($"this is the original array: {originalArray[0]}, {originalArray[1]}, {originalArray[2]}, {originalArray[3]}, {originalArray[4]}");
            ArrayItemSwapper mySwapper = new ArrayItemSwapper(originalArray);
            mySwapper.swapArrayItems(0, 4);
            Console.WriteLine($"this is the array after swap method is called: {originalArray[0]}, {originalArray[1]}, {originalArray[2]}, {originalArray[3]}, {originalArray[4]}");
        }

    }
}
