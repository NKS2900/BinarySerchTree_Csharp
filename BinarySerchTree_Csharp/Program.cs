using System;

namespace BinarySerchTree_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Binary_Search_Tree***");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);           
            binarySearchTree.Display();
            Console.ReadKey();
        }
    }
}
