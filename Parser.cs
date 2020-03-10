using System;
using System.Collections.Generic;

namespace Testing
{
    public class Parser {

        static public void readNodes(string filename, ref int numNodes, ref string startingCity, ref Graph g){
       		System.IO.StreamReader file = new System.IO.StreamReader(@filename);

    		string line = file.ReadLine();
            int iter = 0;
            numNodes = Int32.Parse(getToken(ref iter, line));
            startingCity = getToken(ref iter, line);

            for(int i = 1; i <= numNodes; i++){
                line = file.ReadLine();
                iter = 0;
                string nodeName = getToken(ref iter, line);
                int pop = Int32.Parse(getToken(ref iter, line));

                Node temp = new Node(nodeName, pop, 0, false);
                g.addNode(temp);
            }
        }

        static public void readEdges(string filename, ref int numEdges, ref Graph g){
            System.IO.StreamReader file = new System.IO.StreamReader(@filename);

            string line = file.ReadLine();
            int iter = 0;
            numEdges = Int32.Parse(getToken(ref iter, line));

            for(int i = 1; i <= numEdges; i++){
                line = file.ReadLine();
                iter = 0;
                string fromNode = getToken(ref iter, line);
                string toNode = getToken(ref iter, line);
                float weight = float.Parse(getToken(ref iter, line));

                Edge temp = new Edge(fromNode, toNode, weight);
                g.addEdge(temp);
            }
        }

    	static public string getToken(ref int iter, string line){
    		string temp = "";
    		while(line[iter] != '\n' && line[iter] != ' '){
    			temp += line[iter];
    			iter++;

    			if(iter > line.Length-1){
    				break;
    			}
    		}

            iter++;
    		return temp;
    	}	
    }
}