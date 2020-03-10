using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        static void Main(string[] args) {
        	Graph g = new Graph();

        	loadGraph(ref g);

            Console.Write("Masukkan Day: ");
            double day = Convert.ToDouble(Console.ReadLine());
        	//debug
            g.BFS(day);
            g.getTimes();
            g.printPath();
            g.resetGraph();
        }

        static void loadGraph(ref Graph g){
        	int numNodes = 0; int numEdges = 0;
        	string startingCity = "";

        	System.Console.Write("Masukkan nama file node: ");
            string nodeFile = System.Console.ReadLine();
            if(nodeFile == "") nodeFile = "node.txt"; //default

            System.Console.Write("Masukkan nama file edge: ");
            string edgeFile = System.Console.ReadLine();
            if(edgeFile == "") edgeFile = "edge.txt"; //default
            
 	        Parser.readNodes(nodeFile, ref numNodes, ref startingCity, ref g);
 	        Parser.readEdges(edgeFile, ref numEdges, ref g);

            g.setStartNode(startingCity);
        }
    }
}
