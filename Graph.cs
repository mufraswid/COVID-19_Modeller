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

        public Node getNodeFromIdx(int i){
            return nodes[i];
        }

        public Edge getEdgeFromIdx(int i){
            return edges[i];
        }

        public Node getNodeFromName(string name){
            for(int i = 0; i < nodes.Count; i++){
                if(nodes[i].getName() == name){
                    return nodes[i];
                }
            }

            Node err = new Node("Error", 404); //return error obj
            return err;
        }

        public void addToBFSQueue(Node n, ref Queue<Edge> q){
            for(int i = 0; i < edges.Count; i++){
                if(edges[i].getSourceNode() == n.getName()){
                    q.Enqueue(edges[i]);
                }
            }
        }

        public void BFS(string startingCity){
            Node start = getNodeFromName(startingCity);
            Queue<Edge> q = new Queue<Edge>();
            //BFS
        }

    }
}