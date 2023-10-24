using BenchmarkDotNet.Running;
using ListOfSorting;

namespace TestSortList
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ListOfSortingBenchmark>();
        }
    }
}
