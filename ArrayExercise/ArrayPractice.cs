using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class ArrayPractice
    {
        public ArrayPractice(int[] array)
        {
            this.array = array;
        }

        private int[] array;

        public void Swap(int x, int y)
        {
            int length = array.Length;
            if (x>=0 && x<length && y>=0 && y< length)
            {
                int valueX = array[x];
                int valueY = array[y];
                array[x] = valueY;
                array[y] = valueX;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void ReverseInPlace()
        {
            for (int i=0; i<array.Length/2; i++)
            {
                int value1 = array[i];
                int value2 = array[array.Length - 1 - i];
                array[i] = value2;
                array[array.Length - 1 - i] = value1;
            }
        }

        public int[] ReverseNew()
        {
            int length = array.Length;
            int[] newArray = new int[length];

            for (int i = 0; i < array.Length / 2; i++)
            {
                int value1 = array[i];
                int value2 = array[array.Length - 1 - i];
                newArray[i] = value2;
                newArray[array.Length - 1 - i] = value1;
            }

            return newArray;
        }
    }
}
