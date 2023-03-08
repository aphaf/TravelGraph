using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExample
{
    public class Graph
    {
        public List<WeightedEdge> Edges { get; set; }//flight from one city to another
        public List<Node> Nodes { get; set; }//cities in the graph

        public Graph()
        {
            Edges = new List<WeightedEdge>();
            Nodes = new List<Node>();
        }

        public void CreateWeightedEdge(Node origin, Node destination, int mileage)
        {
            WeightedEdge edge = new WeightedEdge(origin, destination, mileage);
            Edges.Add(edge);

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
    }
}
