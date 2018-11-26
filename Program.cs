using System;

namespace ShortestPathAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create graph as per example */
            int[,] graph = new int[,]{{0, 3, 0, 7, 9, 0, 0, 0, 0,0},
                        {3, 0, 2, 0, 1, 0, 0, 0, 0,0},
                        {0, 2, 0, 0, 0, 2, 0, 0, 0,0},
                        {7, 0, 0, 0, 0, 0, 1, 0, 0,0},
                        {9, 1, 0, 0, 0, 0, 0, 3, 0,0},
                        {0, 0, 2, 0, 0, 0, 0, 0, 5,0},
                        {0, 0, 0, 1, 0, 0, 0, 0, 0,2},
                        {0, 0, 0, 0, 3, 0, 0, 0, 0,0},
                        {0, 0, 0, 0, 0, 5, 0, 0, 0,0},
                        {0, 0, 0, 0, 0, 0, 2, 0, 0,0}};
            ShortestPath t = new ShortestPath();
            t.FindShortestPath(graph, 0);
            Console.ReadKey();
        }
    }
}
