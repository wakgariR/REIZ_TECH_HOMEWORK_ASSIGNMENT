using System;
using System.Collections.Generic;

namespace CalculateDepth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test sample
            Branch br1 = new Branch();
            Branch br2 = new Branch();
            Branch br3 = new Branch();
            Branch br4 = new Branch();
            Branch br5 = new Branch();

            br1.branches = new List<Branch> { br2 };
            br2.branches = new List<Branch> { br3 };
            br3.branches = new List<Branch> { br4 };
            br4.branches = new List<Branch> { br5 };

            int depth = calcDepth(br1);
            Console.WriteLine($"The depth of the provided structure is {depth}.");
        }

        static int calcDepth(Branch branch)
        {
            if (branch.branches == null || branch.branches.Count == 0)
            {
                return 1;
            }

            int branchDepth = 0;
            foreach (Branch b in branch.branches)
            {
                int depth = calcDepth(b);
                if (depth > branchDepth)
                {
                    branchDepth = depth;
                }
            }

            return branchDepth + 1;
        }
    }
    
}
