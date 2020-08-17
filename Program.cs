using DataStructures.Sort_Algorithms;
using DataStructures.Trees;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("1: linked list");
            Console.WriteLine("2: search algos");
            Console.WriteLine("3: Binary Trees");
            Console.WriteLine("4: Bubble Sort");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
                p.runLinkedList();
            else if (input == 2)
                p.searchAlgos();
            else if (input == 3)
                p.binarytrees();
            else if (input == 4)
                p.bubblesort();
            else
                Console.WriteLine("The input povided is not valid");

        }

        public void bubblesort()
        {
            sortAlgorithms sort = new sortAlgorithms();
            int[] unsortedArray = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            unsortedArray = sort.bubbleSort(unsortedArray);
        }

        public void runLinkedList()
        {
            Node<string> node = new Node<string>();
            node.add("Kakinada");
            node.add("Vijayanagaram");
            node.add("Banglore");
            node.remove("Vijayanagaram");
            node.display("Banglore");
        }

        public void searchAlgos()
        {

        }

        public void binarytrees()
        {
            BinaryTrees bintrees = new BinaryTrees();
            bintrees.addleaf(1);
            bintrees.addleaf(4);
            bintrees.addleaf(2);
            bintrees.addleaf(7);
            bintrees.addleaf(9);
            bintrees.addleaf(8);
            bintrees.addleaf(5);
            bintrees.addleaf(6);
            int size = bintrees.size();
            List<int?> leaflist = bintrees.getAllLeaves();
            bool output = bintrees.searchRecursion(9);
            bintrees.printSortedOrder();
        }
    }
}
