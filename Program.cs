using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        static void Main(string[] args) {
        	int numNode = 0; 
        	string startingCity = "";
            string filename = "";
        	Graph map = new Graph();


            System.Console.Write("Masukkan nama file: ");
            
            filename = System.Console.ReadLine();
            
 	        Parser.readNodes(filename, ref numNode, ref startingCity, ref map);

 	        Console.WriteLine(map.getNode(3).getName());

        }
    }
}
