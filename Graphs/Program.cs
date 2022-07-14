// See https://aka.ms/new-console-template for more information
using Graphs;

Console.WriteLine("Graph represented with adjacency matrix!");

Graph aGraph = new Graph();
aGraph.AddVertex("A");
aGraph.AddVertex("B");
aGraph.AddVertex("C");
aGraph.AddVertex("D");
aGraph.AddVertex("E");
aGraph.AddVertex("F");
aGraph.AddVertex("G");
aGraph.AddVertex("H");
aGraph.AddVertex("I");
aGraph.AddVertex("J");
aGraph.AddVertex("K");
aGraph.AddVertex("L");
aGraph.AddVertex("M");
aGraph.AddEdge(0, 1);
aGraph.AddEdge(1, 2);
aGraph.AddEdge(2, 3);
aGraph.AddEdge(0, 4);
aGraph.AddEdge(4, 5);
aGraph.AddEdge(5, 6);
aGraph.AddEdge(0, 7);
aGraph.AddEdge(7, 8);
aGraph.AddEdge(8, 9);
aGraph.AddEdge(0, 10);
aGraph.AddEdge(10, 11);
aGraph.AddEdge(11, 12);
aGraph.DepthFirstSearch();
Console.WriteLine();
