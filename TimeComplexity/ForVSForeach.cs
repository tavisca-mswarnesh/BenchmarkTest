using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
namespace TimeComplexity
{
    public class ForVSForeach
    {
        [Benchmark]
        public void ForTest()
        {
            List<int> list = new List<int>();
            int[] array = new int[100];
            for (int index = 0; index < 100; index++)
            {
                list.Add(index);
            }
            for (int index = 0; index < 100; index++)
            {
                array[index] = list[index];
            }
        }
        [Benchmark]
        public void ForeachTest()
        {
            List<int> list = new List<int>();
            int[] array = new int[100];
            for (int index = 0; index < 100; index++)
            {
                list.Add(index);
            }
            foreach (var item in list)
            {
                array[item] = item;
            }
        }
    }
}


