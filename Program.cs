using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        static void Main(string[] args) {
        	Graph g = new Graph();

        	loadGraph(ref g);

        	//debug
 	        Console.WriteLine(g.getNodeFromIdx(4).getPopulation());
 	        Console.WriteLine(g.getEdgeFromIdx(1).getWeight());

        }

        static void loadGraph(ref Graph g){
        	int numNodes = 0; int numEdges = 0;
        	string startingCity = "";

        	System.Console.Write("Masukkan nama file node: ");
            string nodeFile = System.Console.ReadLine();

            System.Console.Write("Masukkan nama file edge: ");
            string edgeFile = System.Console.ReadLine();
            
 	        Parser.readNodes(nodeFile, ref numNodes, ref startingCity, ref g);
 	        Parser.readEdges(edgeFile, ref numEdges, ref g);
        }
    }
}
