using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Sort_Algorithms
{
    public class sortAlgorithms
    {
        public int[] bubbleSort(int[] unsortedArray)
        {
            int len = unsortedArray.Length;
            for(int i=0;i<len;i++)
            {
                for(int j =i+1;j<len;j++)
                {
                    if(unsortedArray[i]>unsortedArray[j])
                    {
                        int temp = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[j];
                        unsortedArray[j] = temp;
                    }
                }
            }
            return unsortedArray;
        }

        public void test()
        {
            ICollection<int> sd = new List<int>();
            sd.Add(2);
            IEnumerable<int> ds = new List<int>();
            IList<int> ls = new List<int>();
            ls.Add(3);
            

        }

        private int[] swap(int[] unsortedarray,int swapposition1,int swapposition2)
        {
            unsortedarray[swapposition1] = unsortedarray[swapposition1] + unsortedarray[swapposition2];
            unsortedarray[swapposition2] = unsortedarray[swapposition1] - unsortedarray[swapposition2];
            unsortedarray[swapposition1] = unsortedarray[swapposition1] - unsortedarray[swapposition2];
            return unsortedarray;
        }

        public List<int> mergeSort(int[] unsortedArray)
        {
            return null;
        }

        public List<int> quickSort(int[] unsortedArray)
        {
            return null;
        }

        public List<int> heapSort(int[] unsortedArray)
        {
            return null;
        }


    }
}
