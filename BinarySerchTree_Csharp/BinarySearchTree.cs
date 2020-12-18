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
                leftTree.Display();
            }
            Console.WriteLine(NodeData.ToString());
            if (rightTree != null)
            {
                rightTree.Display();
            }
        }
    }
}
