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
            int valueX = array[x];
            int valueY = array[y];
            array[x] = valueY;
            array[y] = valueX;
        }
    }
}
