using SortingAlgorithms;
using System;
using System.Collections.Generic;

namespace Algo.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeExample();
        }

        static void BinaryTreeExample()
        {
            var bTree = new BinaryTree();

            var inorderNodes = new List<int>();
            bTree.Insert(20);
            bTree.Insert(25);
            bTree.Insert(45);
            bTree.Insert(15);
            bTree.Insert(67);
            bTree.Insert(43);
            bTree.Insert(80);
            bTree.Insert(33);
            bTree.Insert(67);
            bTree.Insert(99);
            bTree.Insert(91);
            Console.WriteLine("Inorder Traversal : ");
            bTree.Inorder(bTree.Root, ref inorderNodes);
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            bTree.Preorder(bTree.Root);
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            bTree.Postorder(bTree.Root);

            Console.WriteLine($"Is Binary Tree Balanced? {bTree.IsBalanced(bTree.Root, new Height())}");
            Console.WriteLine($"Is Binary Sub-Tree Balanced? {bTree.IsBalanced(bTree.Root.Rightc.Rightc.Rightc.Rightc, new Height())}");

            //How to Balance the BST Tree?
            //Inorder traversal and creation of a New BST Tree that will hopefully be Balanced!!
            var balancedBTree = BinaryTree.GenerateBalancedTreeFromSortedArray(inorderNodes.ToArray());
            balancedBTree.BFSTraversal();
            Console.ReadLine();
        }

        static void GraphExample()
        {
            // Create a graph given in the above diagram
            var g = new Graph();

            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(1, 4);

            g.AddEdge(2, 5);
            g.AddEdge(2, 6);
            g.AddEdge(4, 7);
            g.AddEdge(4, 8);

            g.AddEdge(5, 9);
            g.AddEdge(5, 10);
            g.AddEdge(7, 11);
            g.AddEdge(7, 12);


            Console.WriteLine("Following is Breadth First Traversal (starting from vertex 1)");
            g.BFSWalkWithStartNode(1);

            Console.WriteLine("Following is Depth First Traversal (starting from vertex 1)");
            g.DFSWalkWithStartNode(1);

            Console.WriteLine("Following is Depth First Traversal USING RECURSION (starting from vertex 1)");
            g.DFSWithRecursion(1);
        }
    }
}
