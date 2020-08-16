using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Recursive_Algorithms
{
    class RecrciveAlgos
    {
        public int fibnochiseries(int n)
        {
            return -1;
        }

        public int factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }
    }
}
