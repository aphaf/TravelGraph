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

graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "New York"), graph.Nodes.First(n => n.Data == "Boston"), 2800);


graph.CreateWeightedEdge(new Node("Portland"), graph.Nodes.First(n => n.Data == "San Francisco"), 550);
graph.CreateWeightedEdge(graph.Nodes.First(n => n.Data == "Portland"), graph.Nodes.First(n => n.Data == "Seattle"), 130);

Console.WriteLine("Created graph");
Console.WriteLine("--All Cities--");
foreach (Node eachNode in graph.Nodes)
{
    Console.WriteLine(eachNode.Data);
}

Console.WriteLine("\n--All Edges and Mileages--");

foreach (WeightedEdge eachEdge in graph.AllEdges)
{
    Console.WriteLine($"{eachEdge.Origin.Data} > {eachEdge.Destination.Data} | {eachEdge.Mileage}");
}





/*
 need to figure out how to connect destination with correct edges, this search works up until the last city, bc of this connection issue
 
 */

Console.WriteLine("\n--BFS nodes--");
List<Node> bfsNodes = graph.BreadthFirstSearch(graph.Nodes.First());

foreach (Node eachNode in bfsNodes)
{
    Console.WriteLine(eachNode.Data);
}
