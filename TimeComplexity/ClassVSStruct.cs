using BenchmarkDotNet.Attributes;
namespace TimeComplexity
{
    public class ClassVSStruct
    {
        public struct StructTesting
        {
            public int integer;
            public string nothing;
        }
        public class ClassTesting
        {
            public int integer;
            public string nothing;
        }
        [Benchmark]
        public void StructTest()
        {
            for (int integer = 0; integer < 1000; integer++)
            {
                var s = new StructTesting();
            }

        }
        [Benchmark]
        public void ClassTest()
        {
            for (int index = 0; index < 1000; index++)
            {
                var c = new ClassTesting();
            }
        }
    }
}


