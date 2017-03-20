using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    abstract class Sorting
    {
        int[] array;
        int arrayLength;
        Sorting(int length)
        {
            this.arrayLength = length;
        }
        enum FillType
        {
            Increment,
            Decrement,
            Random
        }
        public int Comparisions { get; protected set; }
        public int Transactions { get; protected set; }

        public abstract void Sort();
        

        void Fill(FillType fillType)
        {
            switch (fillType)
            {
                case FillType.Increment:
                    FillIncrement();
                    break;
                case FillType.Decrement:
                    FillDecrement();
                    break;
                case FillType.Random:
                    FillRandom();
                    break;
            }
        }
        void FillDecrement()
        {
            int temp = arrayLength - 1;
            for (int i = 0; i < arrayLength; i++, temp--)
            {
                array[i] = temp;
            }
        }

        void FillIncrement()
        {
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = i;
            }
        }
        void FillRandom()
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
        }
    }
}