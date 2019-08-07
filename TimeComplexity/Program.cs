using System;
using System.Diagnostics;
using BenchmarkDotNet.Running;
namespace TimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {

            //var stringVSStringBuilderBench = BenchmarkRunner.Run<StringVSStringBuilder>();
            //var taskVsThreadBench = BenchmarkRunner.Run<TaskVSThread>();
            //var arrayVSList = BenchmarkRunner.Run<ArrayVSList>();
            //var forVsFoeach = BenchmarkRunner.Run<ForVSForeach>();
            var classVSStruct = BenchmarkRunner.Run<ClassVSStruct>();

            Console.Read();

        }

        
    }
}


