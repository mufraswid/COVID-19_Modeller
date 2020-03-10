using System;
using System.Collections.Generic;

namespace Testing
{
    public class Node {
        private string name;
        private int population;
        private double time;
        private bool infected;

        //def constructor
        public Node(){
            name = ""; population = 0; time = 0; infected = false;
        }

        //mod constructor
        public Node(string cityName, int nPop, int nTime, bool inf){
            name = cityName; population = nPop; time = nTime; infected = inf; 
        }

        public string getName(){
            return name;
        }

        public int getPopulation(){
            return population;
        }

        public double getTime(){
            return time;
        }

        public bool getInfected(){
            return infected;
        }

        public void setTime(double t){
            time = t;
        }

        public void setInfected(bool i){
            infected = i;
        }
    }
}
