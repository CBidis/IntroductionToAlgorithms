using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public BinaryTree() => Root = null;

        public BinaryTree(Node root) => Root = root;

        public void Insert(int id)
        {
            var newNode = new Node
            {
                Item = id
            };

            if (Root == null)
                Root = newNode;

            else
            {
                Node current = Root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (id < current.Item)
                    {
                        current = current.Leftc;
                        if (current == null)
                        {
                            parent.Leftc = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Rightc;
                        if (current == null)
                        {
                            parent.Rightc = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void BFSTraversal()
        {
            var queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count != 0)
            {
                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.Item + " ");

                /*Enqueue left child */
                if (tempNode.Leftc != null)
                    queue.Enqueue(tempNode.Leftc);

                /*Enqueue right child */
                if (tempNode.Rightc != null)
                    queue.Enqueue(tempNode.Rightc);
            }
        }

        /* Returns true if binary tree with root as root is height-balanced */
        public virtual bool IsBalanced(Node root, Height height)
        {
            /* If tree is empty then return true */
            if (root == null)
            {
                height.height = 0;
                return true;
            }

            /* Get heights of left and right sub trees */
            Height lheight = new Height(), rheight = new Height();
            var l = IsBalanced(root.Leftc, lheight);
            var r = IsBalanced(root.Rightc, rheight);
            int lh = lheight.height, rh = rheight.height;

            /* Height of current node is max of heights of  
               left and right subtrees plus 1*/
            height.height = (lh > rh ? lh : rh) + 1;

            /* If difference between heights of left and right  
               subtrees is more than 2 then this node is not balanced  
               so return 0 */
            if ((lh - rh >= 2) || (rh - lh >= 2))
            {
                return false;
            }

            /* If this node is balanced and left and right subtrees  
               are balanced then return true */
            else
            {
                return l && r;
            }
        }

        public virtual int Height(Node node)
        {
            /* base case tree is empty */
            if (node == null)
            {
                return 0;
            }

            /* If tree is not empty then height = 1 + max of left  
             height and right heights */
            return 1 + Math.Max(Height(node.Leftc), Height(node.Rightc));
        }

        public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Item + " ");
                Preorder(root.Leftc);
                Preorder(root.Rightc);
            }
        }

        public void Inorder(Node root, ref List<int> visitedNodes)
        {
            if (root != null)
            {
                Inorder(root.Leftc, ref visitedNodes);
                //adding item to visited nodes
                visitedNodes.Add(root.Item);
                Console.Write(root.Item + " ");

                Inorder(root.Rightc, ref visitedNodes);
            }
        }

        public void Postorder(Node root)
        {
            if (root != null)
            {
                Postorder(root.Leftc);
                Postorder(root.Rightc);
                Console.Write(root.Item + " ");
            }
        }

        public static BinaryTree GenerateBalancedTreeFromSortedArray(int[] sortedNodes)
        {
            return new BinaryTree(SortedArrayToBST(sortedNodes, 0, sortedNodes.Length - 1));
        }

        /* A function that constructs Balanced Binary Search Tree   
        from a sorted array */
        public static Node SortedArrayToBST(int[] arr, int start, int end)
        {
            /* Base Case */
            if (start > end)
            {
                return null;
            }

            /* Get the middle element and make it root */
            var mid = (start + end) / 2;

            var node = new Node(arr[mid])
            {
                /* Recursively construct the left subtree and make it  
                 left child of root */
                Leftc = SortedArrayToBST(arr, start, mid - 1),

                /* Recursively construct the right subtree and make it  
                 right child of root */
                Rightc = SortedArrayToBST(arr, mid + 1, end)
            };
            return node;
        }
    }

    public class Node
    {
        public int Item { get; set; }

        public Node Leftc { get; set; }

        public Node Rightc { get; set; }

        public Node() { }

        public Node(int d)
        {
            Item = d;
            Leftc = Rightc = null;
        }

        public void Display() => Console.Write($"[{Item}]");
    }

    // A wrapper class used to modify height across 
    // recursive calls. 
    public class Height
    {
        public int height = 0;
    }
}
