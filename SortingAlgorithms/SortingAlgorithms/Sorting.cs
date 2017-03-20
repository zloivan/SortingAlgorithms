using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public abstract class Sorting
    {
        protected int[] array ;
        protected int arrayLength;
        public Sorting(int length)
        {
            this.arrayLength = length;
        }
        public enum FillType
        {
            Increment,
            Decrement,
            Random
        }
        public int Comparisions { get; protected set; } = 0;
        public int Transactions { get; protected set; } = 0;

        public abstract void Sort();

        public int GetChecksum()
        {
            int sum = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public int GetSerisCount()
        {
            int series = 1;
            for (int i = 1; i < arrayLength; i++)
                if (array[i - 1] > array[i])
                {
                    series++;
                }
            return series;
        }

        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < arrayLength; i++)
                if (i != arrayLength - 1)
                temp += $"{array[i]} ";
            else
                    temp += $"{array[i]}";
            return temp;
        }
        public void Fill(FillType fillType)
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
            array = new int[arrayLength];
            int temp = arrayLength - 1;
            for (int i = 0; i < arrayLength; i++, temp--)
            {
                array[i] = temp;
            }
        }

        void FillIncrement()
        {
            array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = i;
            }
        }
        void FillRandom()
        {
            array = new int[arrayLength];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
        }
    }

    public class BubleSorting : Sorting
    {
        public BubleSorting(int length) : base(length)
        {

        }

        
        public override void Sort()
        {
            for (int j = 0; j < arrayLength-1 ; j++)
            {
                for (int i = 0; i < (arrayLength-1) - j; i++)
                {
                    Comparisions++;
                    if (array[i] > array[i + 1])
                    {
                        Transactions++;
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                if (Transactions == 0) break;
            }
        }
    }
}