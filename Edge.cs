using System;
using System.Collections.Generic;

namespace Testing
{
    public class Edge {
        private string sourceNode;
        private string destNode;
        private float weight;

        //def constructor
        public Edge(){
            sourceNode = "";
            destNode = "";
            weight = 0;
        }

        //mod constructor
        public Edge(string from, string to, float w){
            sourceNode = from;
            destNode = to;
            weight = w;
        }

        public string getSourceNode(){
            return sourceNode;
        }

        public string getDestNode(){
            return destNode;
        }

        public float getWeight(){
            return weight;
        }
    }
}