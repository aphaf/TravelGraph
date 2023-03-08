using GraphExample;

Graph graph = new Graph();

Node node = new Node("Atlanta");
graph.AddNode(node);

graph.CreateWeightedEdge(node, new Node("Chicago"), 599);
graph.CreateWeightedEdge(node, new Node("Dallas"), 725);
graph.CreateWeightedEdge(node, new Node("New York"), 756);

node = new Node("Boston");
graph.AddNode(node);

graph.CreateWeightedEdge(node, graph.Nodes.First(n => n.Data == "New York"), 191);
graph.CreateWeightedEdge(node, new Node("Seattle"), 2489);

graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "Chicago"), new Node("Denver"), 907);

graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "Dallas"), graph.Nodes.First(n => n.Data == "Denver"), 650);
graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "Dallas"), new Node("Los Angeles"), 1240);
graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "Dallas"), new Node("San Francisco"), 1468);

graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "Denver"), graph.Nodes.First(n => n.Data == "San Francisco"), 954);

graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "New York"), graph.Nodes.First(n => n.Data == "Los Angeles"), 2800);


graph.CreateWeightedEdge(new Node("Portland"), graph.Nodes.First(n => n.Data == "San Francisco"), 550);
graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "Portland"), graph.Nodes.First(n => n.Data == "San Francisco"), 130);

Console.WriteLine("--All Cities--");
foreach (Node eachNode in graph.Nodes)
{
    Console.WriteLine(eachNode.Data);
}

Console.WriteLine("\n--All Mileages--");

foreach (WeightedEdge eachEdge in graph.Edges)
{
    Console.WriteLine(eachEdge.Mileage);
}

