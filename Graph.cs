using System;
using System.Collections.Generic;

namespace Testing
{
    public class Graph {
        private List<Node> nodes = new List<Node>();
        private List<Edge> edges = new List<Edge>();

        //def constructor
        public Graph(){}

        public void addNode(Node n){
            nodes.Add(n);
        }

        public void addEdge(Edge e){
            edges.Add(e);
        }

        public Node getNode(int i){
            return nodes[i];
        }

        public Edge getEdge()

    }
}