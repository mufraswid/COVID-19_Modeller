using System;
using System.Collections.Generic;

namespace Testing
{
    public class Graph {
        private List<Node> nodes = new List<Node>();
        private List<Edge> edges = new List<Edge>();
        private List<Edge> path = new List<Edge>();

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

        public void printPath(){
            Console.WriteLine(path.Count);
            for(int i = 0; i < path.Count; i++){
                Console.WriteLine(path[i].getSourceNode() + "->" + path[i].getDestNode());
            }
        }

        public void getTimes(){
            for(int i = 0; i < nodes.Count; i++){
                Console.WriteLine(nodes[i].getTime());
            }
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

            Node err = new Node("Error", -404, -404, false); //return error obj
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
            getNodeFromName(startingCity).setInfected(true);
            getNodeFromName(startingCity).setTime(0);
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
                nodes[i].setTime(0);
                path.Clear();
            }
        }

        public void BFS(double time){
            Queue<Edge> q = new Queue<Edge>();
            addAdjacents(getStartNode(), ref q);
            while(q.Count != 0){
                Edge temp = q.Dequeue();
                Node src = getNodeFromName(temp.getSourceNode());
                Node now = getNodeFromName(temp.getDestNode());
                
                if(S(src, now, T(src, time)) > 1 && src.getInfected()){
                    path.Add(temp);
                    if(!now.getInfected()){
                        getNodeFromName(temp.getDestNode()).setTime(Math.Ceiling(tInf(src, now)) + src.getTime());
                        getNodeFromName(temp.getDestNode()).setInfected(true);

                        for(int i = 0; i < edges.Count; i++){
                            if(edges[i].getSourceNode() == now.getName()){
                                q.Enqueue(getEdgeFromPoints(now, getNodeFromName(edges[i].getDestNode())));
                            }
                        }
                    }
                }
            }
        }

        public double I(Node A, double time){
            return Convert.ToDouble(A.getPopulation())/Convert.ToDouble(1+((A.getPopulation()-1)*Math.Exp(-0.25*time)));
        }

        public double S(Node A, Node B, double time){
            return I(A, time) * getEdgeFromPoints(A, B).getWeight();
        }

        public double T(Node A, double n){
            return n - A.getTime();
        }

        public double tInf(Node A, Node B){
            return 4 * Math.Log(Convert.ToDouble(A.getPopulation()-1)/Convert.ToDouble((A.getPopulation()*getEdgeFromPoints(A, B).getWeight())-1));
        }
    }
}