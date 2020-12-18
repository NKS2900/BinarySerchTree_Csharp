using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySerchTree_Csharp
{
    class BinarySearchTree<T> where T : IComparable
    {
        T NodeData;
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }

        bool result = false;
        int leftCount = 0;
        int rightCount = 0;
        public BinarySearchTree(T NodeData)
        {
            this.NodeData = NodeData;
            leftTree = null;
            rightTree = null;
        }

        /// <summary>
        /// Inserting Elements in Tree.
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (leftTree == null)
                    leftTree = new BinarySearchTree<T>(item);
                else
                    leftTree.Insert(item);
            }
            else
            {
                if (rightTree == null)
                    rightTree = new BinarySearchTree<T>(item);
                else
                    rightTree.Insert(item);
            }
        }

        /// <summary>
        /// Displaying Tree
        /// </summary>
        public void Display()
        {
            if (leftTree != null)
            {
                leftCount++;
                leftTree.Display();
            }
            Console.WriteLine(NodeData.ToString());
            if (rightTree != null)
            {
                rightCount++;
                rightTree.Display();
            }
        }

        /// <summary>
        /// Size of Tree.
        /// </summary>
        public void Size()
        {
            Console.WriteLine("Size of BST is " + (1 + leftCount + rightCount));
        }

        /// <summary>
        /// Search Element in BST.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool ifExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element Found In BST :" + node.NodeData);
                return true;
            }
            else
                Console.WriteLine("Current element is {0} in BST ", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                ifExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                ifExists(element, node.rightTree);
            return result;
        }
    }
}