namespace Testing
{
    class Program
    {
        static void Main(string[] args) {
            System.Console.Write("Masukkan nama file: ");
            
            int numNode = 0; string startingCity = "";
            string filename = "";
            filename = System.Console.ReadLine();
            
 	        Parser.readNodes(filename, ref numNode, ref startingCity);
 	        
        }
    }
}
