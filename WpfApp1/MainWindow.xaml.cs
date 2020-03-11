using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Graph g = new Graph();
        string placedir = "";
        string routedir = "";
        public MainWindow()
        {
            InitializeComponent();
            //while (placedir == "" && routedir == "");
        }

        /*static void Main(string[] args)
        {
            Graph g = new Graph();

            loadGraph(ref g);

            Console.Write("Masukkan Day: ");
            double day = Convert.ToDouble(Console.ReadLine());
            //debug
            
        }*/

        private void btnOpenFile_Click(object sender, RoutedEventArgs e) // TextBox str
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                PlaceDir.Text = filename;
            }
        }

        private void btnOpenFile2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                RouteDir.Text = filename;
            }
        }

        private int strToInt(string s)
        {
            int res = 0;
            for(int i=0; i < s.Length; i++)
            {
                if (s[i] - '0' > 9 || s[i] - '0' < 0)
                    return -999;
                res *= 10;
                res += s[i] - '0';
            }
            return res;
        }

        private void simulateGraph_click(object sender, RoutedEventArgs e)
        {
            int day = strToInt(InfectTime.Text);
            if(day != -999)
            {
                loadGraph(ref g, placedir, routedir);
                g.BFS(day);
                g.getTimes();
                g.printPath();
                g.resetGraph();
            }  
        }/**/

        static void loadGraph(ref Graph g, string pdir, string rdir)
        {
            int numNodes = 0; int numEdges = 0;
            string startingCity = "";

            //System.Console.Write("Masukkan nama file node: ");
            //string nodeFile = System.Console.ReadLine();
            //if (nodeFile == "") 
            //string nodeFile = "node.txt"; //default
            //System.Console.Write("Masukkan nama file edge: ");
            //string edgeFile = System.Console.ReadLine();
            //if (edgeFile == "") 
            //string edgeFile = "edge.txt"; //default

            Parser.readNodes(pdir, ref numNodes, ref startingCity, ref g);
            Parser.readEdges(rdir, ref numEdges, ref g);
            g.setStartNode(startingCity);
        }
    }
}
