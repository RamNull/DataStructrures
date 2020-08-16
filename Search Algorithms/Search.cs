using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Search_Algorithms
{
    class Search
    {
        /// <summary>
        /// Does a Linear Search Time Complexity O(n)
        /// </summary>
        /// <param name="a"> array to search</param>
        /// <param name="x">element to be found</param>
        /// <returns></returns>
        public int linearsearch(int[] a,int x)
        {

            if (a == null)
                return -1;
            else
            {
                for (int i= 0;i<a.Length;i++)
                {
                    if (a[i] == x)
                        return i;
                }
                return -1;
            }
        }

        /// <summary>
        /// Does a Binary search Time Complexity O(log(n)) Prereqistie: the array needs to be in sorted order
        /// </summary>
        /// <param name="a">array to search</param>
        /// <param name="x">element to be found</param>
        /// <returns></returns>
        public int binarysearch(int[] a, int x)
        {
            int left = 0;
            int right = a.Length - 1;
            while(left!=right)
            {
                int mid = (left + right) / 2;
                if (a[mid] == x)
                    return mid;
                else if (a[mid] > x)
                    right = mid-1;
                else
                    left = mid+1;
            }
            return -1;
        }
    }
}
