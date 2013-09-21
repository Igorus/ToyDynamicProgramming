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
            /*Dictionary<int[], int> h = new Dictionary<int[], int>();
            
            int[] i1 = new int[] { 0, 1, 2 };
            int[] i2 = new int[] { 2, 3, 4 };
            int[] i3 = new int[] { 2, 3, 4 };
            int[] i4 = new int[] { 3, 2, 4 };
            
            h.Add(i1, 1); Console.WriteLine(h.Count);
            h.Add(i2, 2); Console.WriteLine(h.Count);
            h.Add(i3, 3); Console.WriteLine(h.Count);
            h.Add(i4, 4); Console.WriteLine(h.Count);
            Console.WriteLine(i2[0].GetHashCode() + i2[1].GetHashCode() + i2[2].GetHashCode());
            Console.WriteLine(i3[0].GetHashCode() + i3[1].GetHashCode() + i3[2].GetHashCode());
            Console.WriteLine("a".GetHashCode());
            Console.WriteLine("abc".GetHashCode());*/
            ToyDynamicProgramming.examples.Fibonacci f = new examples.Fibonacci();
            Console.WriteLine(f.Run(10));
            Console.ReadLine();
        }
    }
    /*
    class A //: IEqualityComparer<int[]>
    {

    }*/
}
