using System;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
namespace TimeComplexity
{
    public class TaskVSThread
    {
        [Benchmark]
        public void TaskTest()
        {
            Task.Run(async () =>
            {
                var task1 = SaveData();
                var task2 = PrintData();
                await Task.WhenAll(task1, task2);
            }
          ).GetAwaiter().GetResult();
        }
        [Benchmark]
        public void ThreadTest()
        {
            Thread saveDataThread = new Thread(ThreadSaveData);
            saveDataThread.Start();
            Thread PrintDataThread = new Thread(ThreadPrintData);
            PrintDataThread.Start();
        }
        public async  Task SaveData()
        {
            await Task.Delay(4000);
        }
        public async  Task PrintData()
        {
            await Task.Delay(3000);
            Console.WriteLine("In task");

        }
        public  void ThreadSaveData()
        {
            Thread.Sleep(4000);
        }
        public void ThreadPrintData()
        {
            Thread.Sleep(3000);
            Console.WriteLine("In thread");
        }
    }
}


