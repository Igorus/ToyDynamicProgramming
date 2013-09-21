using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyDynamicProgramming
{
    static class Program
    {
        static void Main(string[] args)
        {
            ToyDynamicProgramming.examples.Fibonacci f = new examples.Fibonacci();
            Console.WriteLine(f.Run(10));
            Console.ReadLine();
        }
    }
}
