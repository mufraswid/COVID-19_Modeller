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

        public Edge getEdgeFromPoints(Node src, Node dst){
            for(int i = 0; i < edges.Count; i++){
                if(edges[i].getSourceNode() == src.getName() && edges[i].getDestNode() == dst.getName()){
                    return edges[i];
                }
            }

            Edge err = new Edge("Error", "Error", -404); //return error obj
            return err;
        }

        public Node getNodeFromName(string name){
            for(int i = 0; i < nodes.Count; i++){
                if(nodes[i].getName() == name){
                    return nodes[i];
                }
            }

            Node err = new Node("Error", -404); //return error obj
            return err;
        }

        public void addAdjacents(Node n, ref Queue<Edge> q){
            for(int i = 0; i < edges.Count; i++){
                if(edges[i].getSourceNode() == n.getName()){
                    q.Enqueue(edges[i]);
                }
            }
        }

        public void setStartNode(string startingCity){
            Node parent = new Node("", -1);
            getNodeFromName(startingCity).setVisited(true);
            getNodeFromName(startingCity).setParent(parent);
        }

        public Node getStartNode(){
            for(int i = 0; i < nodes.Count; i++){
                if(nodes[i].getPopulation() == -1){
                    return nodes[i];
                }
            }

            return nodes[0]; //def start point
        }

        public void resetGraph(){
            for(int i = 0; i < nodes.Count; i++){
                nodes[i].setVisited(false);
                nodes[i].setParent(new Node());
            }
        }

        public void BFS(){
            Queue<Edge> q = new Queue<Edge>();
            addAdjacents(getStartNode(), ref q);
            while(q.Count != 0){
                Edge temp = q.Dequeue();
                getNodeFromName(temp.getDestNode()).setVisited(true);
                Node now = getNodeFromName(temp.getDestNode());
                // Console.WriteLine("Being Evaluated: " + temp.getSourceNode() + " " + temp.getDestNode()); debug

                //if now is goal, break
                
                for(int i = 0; i < edges.Count; i++){
                    if(edges[i].getSourceNode() == now.getName() && !getNodeFromName(edges[i].getDestNode()).isVisited()){
                        getNodeFromName(edges[i].getDestNode()).setVisited(true);
                        getNodeFromName(edges[i].getDestNode()).setParent(now);
                        q.Enqueue(getEdgeFromPoints(now, getNodeFromName(edges[i].getDestNode())));
                    }
                }
                // if(q.Count != 0) Console.WriteLine("Next: " + q.Peek().getSourceNode() + " " + q.Peek().getDestNode()); debug
            }
        }
    }
}