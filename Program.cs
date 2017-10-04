using System;
using Newtonsoft.Json;

namespace tel
{

    public class TestClass
    {
        public string StringValue { get; set; }
        public int NumericValue { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var o = new TestClass
            {
                StringValue = "This is a string value"
            };

            var json = JsonConvert.SerializeObject(o, Formatting.Indented);
            Console.WriteLine(json);

        }
    }
}
