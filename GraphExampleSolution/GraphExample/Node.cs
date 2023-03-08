using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExample
{
    public class Node
    {
        public string Data { get; set; } //city

        public List<Node> Neighbors { get; set; } = new List<Node>();//neighboring cities

        //public List<WeightedEdge> Edges { get; set; } = new List<WeightedEdge>();//flight from this city to another

        public Node(string data)
        {
            Data = data;
        }

        public void AddNeighbor(Node neighbor)
        {
            Neighbors.Add(neighbor);
        }

        //public void AddEdge(Node neighbor, int mileage)
        //{
        //    Edges.Add(new WeightedEdge(this, neighbor, mileage));
        //}

        //public void AddEdge(WeightedEdge edge)
        //{
        //    Edges.Add(edge);
        //}
    }
}
