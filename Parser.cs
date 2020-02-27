using System;

namespace Testing
{
    public class Parser {

        static public void readNodes(string filename, ref int numNodes, ref string startingCity){
       		System.IO.StreamReader file = new System.IO.StreamReader(@filename);

    		getInits(file, ref numNodes, ref startingCity);

            for(int i = 1; i <= numNodes; i++){
                string temp = file.ReadLine();
                
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

    		return temp;
    	}	

        static public void getInits(System.IO.StreamReader file, ref int numNodes, ref string startingCity){
        	string line = file.ReadLine();
        	
        	int i = 0;

        	numNodes = Int32.Parse(getToken(ref i, line));

        	i++;

        	startingCity = getToken(ref i, line);
        }

    }
}