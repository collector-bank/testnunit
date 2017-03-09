using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testnunit
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyClass();
            int a = args.Length == 2 ? int.Parse(args[0]) : 1;
            int b = args.Length == 2 ? int.Parse(args[1]) : 2;
            int result = obj.Add(a, b);
            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }
    }
}
