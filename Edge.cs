using System;
using System.Collections.Generic;

namespace Testing
{
    public class Edge {
        private string fromNode;
        private string toNode;

        //def constructor
        public Edge(){
            fromNode = "";
            toNode = "";
        }

        //mod constructor
        public Edge(string from, string to){
            fromNode = from;
            toNode = to;
        }

        public string getFromNode(){
            return fromNode;
        }

        public string getToNode(){
            return toNode;
        }



    }
}