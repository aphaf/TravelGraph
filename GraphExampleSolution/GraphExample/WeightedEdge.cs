using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExample
{
    public class WeightedEdge
    {
        public int Mileage { get; set; } //weight

        public Node Origin { get; set; }
        public Node Destination { get; set; }

        public WeightedEdge (Node origin, Node destination, int mileage)
        {
            Origin = origin;
            Destination = destination;
            Mileage = mileage;

            Origin.AddNeighbor(Destination);
            Destination.AddNeighbor(Origin);

            Origin.AddEdge(this);
            Destination.AddEdge(this);
        }
    }
}
