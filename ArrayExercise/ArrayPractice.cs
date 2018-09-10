using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class ArrayPractice
    {
        public void Swap(int[] array, int x, int y)
        {
            var length = array.Length;
            if (x>=0 && x<length && y>=0 && y<length)
            {
                var temp = array[x];
                array[x] = array[y];
                array[y] = temp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            print(array, "This is the altered array: ");
        }

        public void ReverseInPlace(int[] array)
        {
            var length = array.Length;
            for (int i=0; i<array.Length/2; i++)
            {
                var temp = array[i];
                array[i] = array[length - 1 - i];
                array[length - 1 - i] = temp;
            }
            print(array, "This is the reversedInPlace array: ");
        }

        public int[] ReverseNew(int[] array)
        {
            var length = array.Length;
            int[] newArray = new int[length];
            for (int i = 0; i < length / 2; i++)
            {
                var temp = array[i];
                array[i] = array[length - 1 - i];
                array[length - 1 - i] = temp;
            }
            print(array, "This is the reversedNew array: ");
            return newArray;
        }

        public void print(int[] array, string printString)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(i == 0)
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
    }
}
