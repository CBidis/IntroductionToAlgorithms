using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    /// <summary>
    /// Graph C# Implementation
    /// </summary>
    public class Graph
    {
        public Graph() => Adj = new Dictionary<int, HashSet<int>>();

        public Dictionary<int, HashSet<int>> Adj { get; private set; }

        public void AddEdge(int source, int target)
        {
            if (Adj.ContainsKey(source))
            {
                try
                {
                    Adj[source].Add(target);
                }
                catch
                {
                    Console.WriteLine("This edge already exists: " + source + " to " + target);
                }
            }
            else
            {
                var hs = new HashSet<int>
                {
                    target
                };
                Adj.Add(source, hs);
            }
        }

        public void BFSWalkWithStartNode(int vertex)
        {
            var visited = new HashSet<int>
            {
                // Mark this node as visited
                vertex
            };
            // Queue for BFS
            var q = new Queue<int>();
            // Add this node to the queue
            q.Enqueue(vertex);

            while (q.Count > 0)
            {
                var current = q.Dequeue();
                Console.WriteLine(current);
                // Only if the node has a any adj notes
                if (Adj.ContainsKey(current))
                {
                    // Iterate through UNVISITED nodes
                    foreach (var neighbour in Adj[current].Where(a => !visited.Contains(a)))
                    {
                        visited.Add(neighbour);
                        q.Enqueue(neighbour);
                    }
                }
            }
        }

        public int BFSFindNodeWithStartNode(int vertex, int lookingFor)
        {
            if (vertex == lookingFor)
            {
                Console.WriteLine("Found it!");
                Console.WriteLine("Steps Took: 0");
                return 0;
            }
            var visited = new HashSet<int>
            {
                // Mark this node as visited
                vertex
            };
            // Queue for BFS
            var q = new Queue<int>();
            // Add this node to the queue
            q.Enqueue(vertex);

            var count = 0;

            while (q.Count > 0)
            {
                var current = q.Dequeue();
                Console.WriteLine(current);
                if (current == lookingFor)
                {
                    Console.WriteLine("Found it!");
                    Console.WriteLine("Steps Took: " + count);
                    return visited.Count();
                }

                // Only if the node has a any adj notes
                if (Adj.ContainsKey(current))
                {
                    // Iterate through UNVISITED nodes
                    foreach (var neighbour in Adj[current].Where(a => !visited.Contains(a)))
                    {
                        visited.Add(neighbour);
                        q.Enqueue(neighbour);
                    }
                }
                count++;
            }
            Console.WriteLine("Could not find node!");
            return count;
        }

        public void DFSWalkWithStartNode(int vertex)
        {
            var visited = new HashSet<int>
            {
                // Mark this node as visited
                vertex
            };
            // Stack for DFS
            var s = new Stack<int>();
            // Add this node to the stack
            s.Push(vertex);

            while (s.Count > 0)
            {
                var current = s.Pop();
                Console.WriteLine(current);
                // ADD TO VISITED HERE
                if (!visited.Contains(current))
                {
                    visited.Add(current);
                }
                // Only if the node has a any adj notes
                if (Adj.ContainsKey(current))
                {
                    // Iterate through UNVISITED nodes
                    foreach (var neighbour in Adj[current].Where(a => !visited.Contains(a)))
                    {
                        visited.Add(neighbour);
                        s.Push(neighbour);
                    }
                }
            }
        }

        public void DFSWithRecursion(int vertex)
        {
            var visited = new HashSet<int>();
            Traverse(vertex, visited);
        }

        private void Traverse(int v, HashSet<int> visited)
        {
            // Mark this node as visited
            visited.Add(v);
            Console.WriteLine(v);
            // Only if the node has a any adj notes
            if (Adj.ContainsKey(v))
            {
                // Iterate through UNVISITED nodes
                foreach (var neighbour in Adj[v].Where(a => !visited.Contains(a)))
                {
                    Traverse(neighbour, visited);
                }
            }
        }
    }
}
