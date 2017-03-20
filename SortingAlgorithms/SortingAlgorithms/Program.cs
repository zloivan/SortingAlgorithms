using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting sort = new BubleSorting(10);
            sort.Fill(Sorting.FillType.Random);
            Console.WriteLine($"{sort} {sort.Transactions}");
            sort.Sort();

            Console.WriteLine($"{sort} {sort.Transactions} {sort.Comparisions}");


        }
    }
}
