using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExample
{
    public class Graph
    {
        public List<WeightedEdge> AllEdges { get; set; }//flight from one city to another
        public List<Node> Nodes { get; set; }//cities in the graph

        public Graph()
        {
            AllEdges = new List<WeightedEdge>();
            Nodes = new List<Node>();
        }

        public void CreateWeightedEdge(Node origin, Node destination, int mileage)
        {
            WeightedEdge edge = new WeightedEdge(origin, destination, mileage);
            AllEdges.Add(edge);

            //try to add nodes incase user inputs a node that does not exist yet
            AddNode(origin);
            AddNode(destination);
        }

        public void AddNode(Node node)
        {
            if (!Nodes.Contains(node))
            {
                Nodes.Add(node);
            }
        }

        //public List<Node> BreadthFirstSearch(Node searchNode)
        //{
        //    /* geeks for geeks notes
             
        //    searching all nodes at the current depth/level
        //    graph may contain cycles (may visit the same node again)
        //    mark the nodes as visited and not visited
        //        bool visited array/list to mark visited nodes
        //    use a queue data structure for traversal             
        //     */



        //    /* geeks for geek pseudo code
        //     Breadth_First_Search( Graph, X ) // Here, Graph is the graph that we already have and X is the source node

        //        Let Q be the queue
        //        Q.enqueue( X ) // Inserting source node X into the queue
        //        Mark X node as visited.

        //        While ( Q is not empty )
        //        Y = Q.dequeue( ) // Removing the front node from the queue

        //        Process all the neighbors of Y, For all the neighbors Z of Y
        //        If Z is not visited, Q. enqueue( Z ) // Stores Z in Q
        //        Mark Z as visited
             
        //     */

        //    List<Node> allRelatedNodes = new List<Node>();


        //    List<bool> visitedBool = new List<bool>();

        //    for (int i = 0; i < Nodes.Count; i++)
        //    {
        //        //create the visited list to track which node has been visited
        //        //the index of the visited list will correspond to the index of the nodes list
        //        visitedBool.Add(false);
        //    }

        //    Queue<Node> queue = new Queue<Node>();
        //    //create the queue

        //    queue.Enqueue(searchNode);
        //    //add the source node to the queue

        //    visitedBool[Nodes.IndexOf(searchNode)] = true;
        //    //mark the source node as visited

        //    while(queue.Count > 0)
        //    {
        //        Node tempNode = queue.Dequeue();
        //        allRelatedNodes.Add(tempNode);

        //        List<WeightedEdge> allNodeEdges = tempNode.Edges;

        //        foreach (WeightedEdge eachEdge in allNodeEdges)
        //        {
        //            int index = Nodes.IndexOf(eachEdge.Destination);
        //            if (!visitedBool[index])//index should be the destination of eachEdge, if it hasnt been visited (is false)
        //            {
        //                visitedBool[index] = true;//index of destination eachEdge, change visited to true
        //                queue.Enqueue(eachEdge.Destination);//this destination is added to queue?
        //            }

        //        }
        //    }



        //    return allRelatedNodes;
        //}//end of bfs

        public List<Node> BreadthFirstSearch(Node searchNode)
        {
            List<Node> allRelatedNodes = new List<Node>();


            List<bool> visitedBool = new List<bool>();

            for (int i = 0; i < Nodes.Count; i++)
            {
                //create the visited list to track which node has been visited
                //the index of the visited list will correspond to the index of the nodes list
                visitedBool.Add(false);
            }

            Queue<Node> queue = new Queue<Node>();
            //create the queue

            queue.Enqueue(searchNode);
            //add the source node to the queue

            visitedBool[Nodes.IndexOf(searchNode)] = true;
            //mark the source node as visited

            while (queue.Count > 0)
            {
                Node tempNode = queue.Dequeue();
                allRelatedNodes.Add(tempNode);

                List<Node> allNeighboringNodes = tempNode.Neighbors;

                foreach (Node eachNeighbor in allNeighboringNodes)
                {
                    int index = Nodes.IndexOf(eachNeighbor);
                    if (!visitedBool[index])//index should be the destination of eachEdge, if it hasnt been visited (is false)
                    {
                        visitedBool[index] = true;//index of destination eachEdge, change visited to true
                        queue.Enqueue(eachNeighbor);//this destination is added to queue?
                    }

                }
            }



            return allRelatedNodes;
        }//end of bfs

    }
}
