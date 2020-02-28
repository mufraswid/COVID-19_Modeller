using System;
using System.Collections.Generic;

namespace Testing
{
    public class Node {
        private string name;
        private int population;
        private Node parent;
        private bool visited;

        //def constructor
        public Node(){
            name = ""; population = 0; visited = false;
        }

        //mod constructor
        public Node(string cityName, int nPop){
            name = cityName; population = nPop; visited = false; 
        }

        public string getName(){
            return name;
        }

        public int getPopulation(){
            return population;
        }

        public bool isVisited(){
            return visited;
        }

        public Node getParent(){
            return parent;
        }

        public void setVisited(bool a){
            visited = a;
        }

        public void setParent(Node n){
            parent = n;
        }
    }
}
