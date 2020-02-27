namespace Testing
{
    public class Node {
        private string name;
        private int population;

        //def constructor
        public Node(){
            name = ""; population = 0;
        }

        //mod constructor
        public Node(string cityName, int nPop){
            name = cityName; population = nPop;
        }
    }
}
