using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyDynamicProgramming.DynamicProgramming;

namespace ToyDynamicProgramming.examples
{
    class Fibonacci : Dynamic<int, int>
    {
        override protected int ExecutableMethod(int i)
        {
            Console.WriteLine(i);
            if (i <= 0) return 0;
            if (i <= 1) return 1;
            return Execute(i - 1) + Execute(i - 2);
        }

        public int Run(int i) { return ExecutableMethod(i); }
    }
}
