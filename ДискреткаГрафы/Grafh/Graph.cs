using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
////using System.Threading.Tasks;not support in 3.5 .Netnot support in 3.5 .Net
using System.Drawing;
namespace ClassLibraryGraph
{
    public class Lib
    {
        public static Node[] Nodes;
    }
    public class Edge
    {
        public int parent;
        public int child;
        public int dist;
    }
    public class Node
    {
        public double x;
        public double y;
        public List<Edge> Edges;
        public int name;
        public bool visit;
        public Color color;
        public Node(int x)
        {
            name = x;
            Edges = new List<Edge>();
            visit = false;
            this.x = 0;
            this.y = 0;
            color = Color.Black;
        }
    }
    public class Graph
    {

        private List<Node> Nodes;
        private int[,] a;
        private List<string> st;
        public void CreateGrafh(int[,] a)
        {
            this.a = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    this.a[i, j] = a[i, j];
                }
            Nodes = new List<Node>();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Nodes.Add(new Node(i));
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] != 0)
                    {
                        Nodes[i].Edges.Add(new Edge { parent = i, child = j, dist = a[i, j] });
                    }
                }
            }
            Lib.Nodes = new Node[Nodes.Count];
            Nodes.CopyTo(Lib.Nodes);
        }
        private void ClearVisit()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                Nodes[i].visit = false;
            }
        }
        private void ClearColor()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                Nodes[i].color = Color.Black;
            }
        }
        private string str = "";
        public string FindDeep(int index)
        {
            str = "";
            ClearVisit();
            FindDeep(Nodes[index]);
            return str;
        }
        private void FindDeep(Node node)
        {
            str = str + " " + node.name;
            node.visit = true;
            for (int i = 0; i < node.Edges.Count; i++)
            {
                int k = node.Edges[i].child;
                if (!Nodes[k].visit)
                {
                    FindDeep(Nodes[k]);
                }
            }
        }
        Queue<int> queue;
        public string WideDeep(int index)
        {
            str = "";
            ClearVisit();
            queue = new Queue<int>();
            queue.Enqueue(index);
            Nodes[index].visit = true;
            WideDeep();
            return str;
        }
        private void WideDeep()
        {
            if (queue.Count != 0)
            {
                Node node = Nodes[queue.Dequeue()];
                str = str + " " + node.name;
                for (int i = 0; i < node.Edges.Count; i++)
                {
                    int k = node.Edges[i].child;
                    if (!Nodes[k].visit)
                    {
                        queue.Enqueue(k);
                        Nodes[k].visit = true;
                    }
                }
                WideDeep();
            }

        }
    }
}
