using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
namespace TimeComplexity
{
    public class ArrayVSList
    {
        
        
        [Benchmark]
        public void ArrayTest()
        {
            int[] array = new int[100];
            for (int index = 0; index < 100; index++)
            {
                array[index] = index;
            }
        }
        [Benchmark]
        public void ListTest()
        {
            List<int> list = new List<int>();
            for (int index = 0; index < 100; index++)
            {
                list.Add(index);
            }
        }
    }
}


