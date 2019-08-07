using System.Text;
using BenchmarkDotNet.Attributes;
namespace TimeComplexity
{
    public class StringVSStringBuilder
    { 
        [Benchmark]
        public void String()
        {
            
            string generalSting = "helloworld";
            

            
            for (int index = 0; index < 10000; index++)
            {
                generalSting += index;
            }                                  
        }
        [Benchmark]
        public void String_Buffer()
        {
            StringBuilder stringBuilder = new StringBuilder("helloworld");
            for (int index = 0; index < 10000; index++)
            {
                stringBuilder.Append(index);
            }
        }
    }
}


