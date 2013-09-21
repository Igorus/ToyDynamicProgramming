using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyDynamicProgramming.DynamicProgramming
{
    abstract class Dynamic<Arguments, Result> where Arguments : IComparable
    {
        protected abstract Result ExecutableMethod(Arguments args);

        Dictionary<Arguments, Result> DynamicSet;

        public Dynamic()
        {
            DynamicSet = new Dictionary<Arguments, Result>();
        }

        public Dynamic(IEqualityComparer<Arguments> IEC)
        {
            DynamicSet = new Dictionary<Arguments, Result>(IEC);
        }

        protected Result Execute(Arguments args)
        {
            if (DynamicSet.ContainsKey(args))
            {
                return DynamicSet[args];
            }
            else
            {
                Result r = ExecutableMethod(args);
                DynamicSet.Add(args, r);
                return r;
            }
        }
    }
}
