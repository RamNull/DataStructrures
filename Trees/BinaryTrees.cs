using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinaryTrees
    {
        public int? value { get; set; }
        public BinaryTrees leftBinaryTree { get; set; }
        public BinaryTrees rightBinaryTree { get; set; }

        public BinaryTrees parentBinaryTree;

        /// <summary>
        /// Fetches the root 
        /// </summary>
        /// <returns></returns>
        public int? root()
        {
            return this.value;
        }

        /// <summary>
        /// Fetches the right binary tree 
        /// </summary>
        /// <returns></returns>
        public BinaryTrees getLeft()
        {
            return this.leftBinaryTree;
        }

        /// <summary>
        /// Fetches the right binarytree
        /// </summary>
        /// <returns></returns>
        public BinaryTrees getRight()
        {
            return this.rightBinaryTree;
        }

        public void MakeTree(int value, BinaryTrees left, BinaryTrees right)
        {

        }

        public void emptytree()
        {

        }

        /// <summary>
        /// Check if the binary tree is empty
        /// </summary>
        /// <param name="bt"></param>
        /// <returns></returns>
        public bool isEmpty(BinaryTrees bt)
        {
            if (bt == null)
                return true;
            return false;
        }

        /// <summary>
        /// Add leaf to binary tree according to the sort order
        /// </summary>
        /// <param name="value"> value to be added to the leaf</param>
        public void addleaf(int value)
        {
            BinaryTrees tree = this;
            BinaryTrees parentTree = null;

            while (tree.value != null)
            {
                parentTree = tree;
                if (tree.value > value)
                {
                    if (tree.leftBinaryTree == null)
                        tree.leftBinaryTree = new BinaryTrees();
                    tree = tree.leftBinaryTree;
                }
                    
                else
                {
                    if (tree.rightBinaryTree == null)
                        tree.rightBinaryTree = new BinaryTrees();
                    tree = tree.rightBinaryTree;
                }                    
            }
            tree.parentBinaryTree = parentTree;
            tree.value = value;
        }

        public void addleafRecursion(int value)
        {
            addleafRecursion(value, this, this);
        }

        //No Feasible solution found yet
        public void addleafRecursion(int value,BinaryTrees bt,BinaryTrees parentBt)
        {
            if(bt==null)
                bt = new BinaryTrees();

            if (bt.value == null)
            {
                bt.value = value;
                if (bt != parentBt)
                {
                    bt.parentBinaryTree = parentBt;
                }
            }
            else
            {
                if (bt.value > value)
                {
                    addleafRecursion(value, bt.leftBinaryTree, bt);
                }
                else
                {
                    addleafRecursion(value, bt.rightBinaryTree, bt);
                }
            }
        }

        /// <summary>
        /// Removes the Leaf form the tree
        /// </summary>
        /// <param name="item"></param>
        public void removeLeaf(int item)
        {

        }

        /// <summary>
        /// pop a Node in the middel of the tree and re-attach the tree if possible or recreate the Tree 
        /// </summary>
        /// <param name="item"></param>
        public void popnode(int item)
        {

        }


        /// <summary>
        /// Pops the Root for the tree 
        /// </summary>
        public void popRoot()
        {

        }

        public bool search(int value)
        {
            BinaryTrees binaryTrees = this;
            while(binaryTrees.value!=value)
            {
                if (binaryTrees.value > value)
                    binaryTrees = binaryTrees.leftBinaryTree;
                else
                    binaryTrees = binaryTrees.rightBinaryTree;
                if (binaryTrees.rightBinaryTree == null && binaryTrees.leftBinaryTree == null)
                    return false;
            }
            return true;
        }

        public bool searchRecursion(int value)
        {
           return searchRecursion(value, this);
        }

        public bool searchRecursion(int value,BinaryTrees bt)
        {
            if (bt.value == value)
                return true;
            else
            {

                if (bt.value > value)
                {
                    if (bt.leftBinaryTree == null)
                        return false;
                    return searchRecursion(value, bt.leftBinaryTree);
                }
                    
                else
                {
                    if (bt.rightBinaryTree == null)
                        return false;
                    return searchRecursion(value, bt.rightBinaryTree);
                }
                    
            }
           
        }

        public List<int?> printSortedOrder()
        {
            return printSortedOrder(this,new List<int?>());
        }

        public List<int?> printSortedOrder(BinaryTrees bt,List<int?> output)
        {
            if(!isEmpty(bt))
            {
                printSortedOrder(bt.leftBinaryTree,output);
                output.Add(bt.value);
                printSortedOrder(bt.rightBinaryTree, output);
            }
            return null;
        }

        
        /// <summary>
        /// Balances the Binary tree 
        /// </summary>
        public void balanceTree()
        {

        }

        public int findlevel(int value)
        {
            return -1;
        }

        public int height()
        {
            return -1;
        }


        /// <summary>
        /// Gives the size of the tree
        /// </summary>
        /// <returns></returns>
        public int size()
        {
           return size(this);
        }

        /// <summary>
        /// Runs a recursive function to get the size of the tree
        /// </summary>
        /// <param name="bt"></param>
        /// <returns></returns>
        private int size(BinaryTrees bt)
        {
            if (isEmpty(bt))
                return 0;
            else
                return (1 + size(bt.leftBinaryTree) + size(bt.rightBinaryTree));    
        }


        /// <summary>
        /// Get all the leaves of the Tree
        /// </summary>
        /// <returns></returns>
        public List<int?> getAllLeaves()
        {
            List<int?> leafList = new List<int?>();
            return getAllLeves(this, leafList);
        }

        public List<int?> getAllNodes()
        {
            return null;
        }

        //Need to change from List to Nodes 
        private List<int?> getAllLeves(BinaryTrees bt,List<int?> leafList)
        {
            if (bt == null)
                return leafList;
            else
            {
                if (bt.leftBinaryTree == null && bt.rightBinaryTree == null)
                    leafList.Add(bt.value);
                else
                {
                    getAllLeves(bt.leftBinaryTree,leafList);
                    getAllLeves(bt.rightBinaryTree, leafList);
                }
            }
            return leafList;
        }
        

    }
}
