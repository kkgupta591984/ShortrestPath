using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathAlgo
{
    public class ShortestPath
    {

        static int V = 10;
        /// <summary>
        /// Find minimum distance
        /// </summary>
        /// <param name="dist"></param>
        /// <param name="sptSet"></param>
        /// <returns></returns>
        int minDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value 
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < V; v++)
                if (sptSet[v] == false &&
                    dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }
        /// <summary>
        /// Print Constructed path
        /// </summary>
        /// <param name="dist"></param>
        /// <param name="n"></param>
        void PrintDistanceArray(int[] dist, int n)
        {
            Console.Write("Vertex	 Distance " + "from Source\n");
            for (int i = 0; i < V; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }
        /// <summary>
        /// Find Shortest Path
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="src"></param>
        public void FindShortestPath(int[,] graph, int src)
        {
            int[] dist = new int[V];
            bool[] sptSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[src] = 0;

            // Find shortest path for all vertices 
            for (int count = 0; count < V - 1; count++)
            {
                int u = minDistance(dist, sptSet);

                sptSet[u] = true;

                for (int v = 0; v < V; v++)

                    if (!sptSet[v] && graph[u, v] != 0 &&
                            dist[u] != int.MaxValue &&
                        dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
            }
            PrintDistanceArray(dist, V);
        }
    }
}
