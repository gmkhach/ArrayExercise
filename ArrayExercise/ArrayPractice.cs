using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class ArrayPractice
    {
        public void print(int[] array, string printString)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    printString += "\n{ " + array[0];
                }
                else
                {
                    printString += ", " + array[i];
                }
            }
            printString += " }\n";
            Console.WriteLine(printString);
        }

        public int[] BuildArray()
        {
            Console.Write("\nEnter numbers separated by commas to build your array\n\n>>> ");
            string[] stringArray = Console.ReadLine().Split(',');
            int[] array = new int[stringArray.Length];
            for (int i = 0; i< stringArray.Length; i++)
            {
                array[i] = int.Parse(stringArray[i].Trim());
            }
            return array;
        }

        public void Swap(int[] array, int x, int y)
        {
            var len = array.Length;
            if (x >= 0 && x < len && y >= 0 && y < len)
            {
                var temp = array[x];
                array[x] = array[y];
                array[y] = temp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            print(array, $"This is the altered array, where element {x + 1} and element {y + 1} are swapped with places:");
        }

        public void ReverseInPlace(int[] array)
        {
            var len = array.Length;
            for (int i=0; i<array.Length/2; i++)
            {
                var temp = array[i];
                array[i] = array[len - 1 - i];
                array[len - 1 - i] = temp;
            }
            print(array, "This is the same array but with it's elements order reversed: ");
        }

        public int[] ReverseNew(int[] array)
        {
            var len = array.Length;
            for (int i = 0; i < len / 2; i++)
            {
                var temp = array[i];
                array[i] = array[len - 1 - i];
                array[len - 1 - i] = temp;
            }
            print(array, "This is a new array with a reverse order of the previous array: ");
            int[] newArray = new int[len];
            for (int i = 0; i < len; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        public int[] BruteForceSort(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            int[] newArray = new int[len];
            for (int i = 0; i < len; i++)
            {
                newArray[i] = array[i];
            }
            print(newArray, "This is the brute-force-sorted array: ");
            return newArray;
        }
    }
}
