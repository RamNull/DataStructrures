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

        public int[] insertionSortMethod1(int[] unsortedArray)
        {
            int length = unsortedArray.Length;
            bool setvalue = false;
            int[] sortedArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                int insertvalue = unsortedArray[i];
                if (i == 0)
                    sortedArray[i] = insertvalue;
                else
                    for (int j = 0; j < i; j++)
                    {
                        if (sortedArray[j] > insertvalue)
                        {
                            sortarray(sortedArray, j, insertvalue);
                            break;
                        }
                        setvalue = true;
                    }
                if (setvalue == true)
                    sortedArray[i + 1] = unsortedArray[i + 1];
            }
            return sortedArray;
        }

        public int[] insertionSort(int[] unsortedArray)
        {
            int length = unsortedArray.Length;
            for (int i = 1; i < length; i++)
            {
                int validator = i;
                int itemvalue = unsortedArray[validator];
                while (validator>0 && itemvalue < unsortedArray[validator - 1])
                    validator = validator - 1;
                if(validator>=0)
                    unsortedArray = sortarray(unsortedArray, i,validator, itemvalue);
            }

            return unsortedArray;
        }

        public int[] sortarray(int[] unsortedarray,int endposition,int replaceposition,int replacevalue)
        {
            if (replaceposition == endposition)
            {
                unsortedarray[replaceposition] = replacevalue;
                return unsortedarray;
            }
               
            else
            {
                int temp = unsortedarray[replaceposition];
                unsortedarray[replaceposition] = replacevalue;
                unsortedarray = sortarray(unsortedarray, endposition, replaceposition + 1, temp);
                return unsortedarray;
            }
        }

            public int[] sortarray(int[] sortedarray,int sortstartposition,int insertvalue)
        {

            int temp = sortedarray[sortstartposition];
            sortedarray[sortstartposition] = insertvalue;
            if (sortedarray[sortstartposition + 1] == 0)
            {
                sortedarray[sortstartposition + 1] = temp;
                return sortedarray;
            }
                
            sortedarray = sortarray(sortedarray, sortstartposition + 1, temp);
            return sortedarray;
        }


    }
}
