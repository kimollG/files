using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
////using System.Threading.Tasks;not support in 3.5 .Netnot support in 3.5 .Net
using System.Drawing;
namespace ClassLibraryGrafh
{
    public  class Lib
    {
       public static Node [] Nodes;
    }
    public class Edge
    {
        public int parent;
        public int child;
        public int dist;
        public bool IsVisited;
        public bool twoside;
        public bool SecondEdge;
        public Color color;
    }
    public class Node
    {
        public double x;
        public double y;
        public List<Edge> Edges;
        public int name;
        public bool visit;
        public Color color;
        public int  degree;
        public Node(int x)
        {
            name = x;
            Edges = new List<Edge>();
            visit = false;
            this.x = 0;
            this.y = 0;
            degree = 0; 
            color = Color.Black;
        }
    }
    public class Grafh
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
                        Nodes[i].Edges.Add(new Edge { parent = i, child = j, dist = a[i, j], color = Color.Black });
                        if (a[i, j] == a[j, i])
                        {
                            Nodes[i].Edges[Nodes[i].Edges.Count - 1].twoside = true;
                        }
                        else
                        if (a[j, i] != 0)
                        {
                            Nodes[i].Edges[Nodes[i].Edges.Count - 1].SecondEdge = true;
                        }
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
                for (int j = 0; j < Nodes[i].Edges.Count; j++)
                {
                    Nodes[i].Edges[j].IsVisited = false;
                }
            }
        }
        private void ClearColor()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                Nodes[i].degree = 0;
                Nodes[i].color = Color.Black;
                for (int j = 0; j < Nodes[i].Edges.Count; j++)
                {
                    Nodes[i].Edges[j].color = Color.Black;
                }
            }
        }
        public void Prim()
        {
            ClearColor();
            Nodes[0].degree = 1;
            Nodes[0].color = Color.Red;
            for (int i=0;i<Nodes.Count-1;i++)
            {
                minEdge = new Edge();
                minEdge.dist = 100000;
                ClearVisit();
                Prim(0);
                minEdge.color = Color.Red;             
                Nodes[minEdge.parent].degree = 1;
                Nodes[minEdge.parent].color = Color.Red;
                Nodes[minEdge.child].degree = 1;
                Nodes[minEdge.child].color = Color.Red;
               // Nodes[minEdge.parent].Edges.Find(x => { return x.Equals(minEdge); }).color = Color.Red;
                Nodes[minEdge.child].Edges.Find(x => { return minEdge.parent==x.child; }).color = Color.Red;
            }
        }
        Edge minEdge;
        private void Prim(int index)
        {
            Nodes[index].visit = true;
            for (int i = 0; i < Nodes[index].Edges.Count; i++)
            {
                int ch = Nodes[index].Edges[i].child;
                if (Nodes[ch].visit == false)
                {
                    if(Nodes[ch].degree==1)
                    {
                        Prim(ch);
                    }
                    else
                    {
                        if(Nodes[index].Edges[i].dist<minEdge.dist)
                        {
                            minEdge = Nodes[index].Edges[i];
                        }
                    }
                }
            }
        }
        List<Edge> edges;
        public void Krascal()
        {
            ClearColor();
            ClearVisit();
            edges = new List<Edge>();
            for (int i = 0; i < Nodes.Count; i++)
                Nodes[i].color = Color.Red;
            for(int i = 0; i < Nodes.Count; i++)
            {
                for (int j = 0; j < Nodes[i].Edges.Count; j++)
                {
                    edges.Add(Nodes[i].Edges[j]);
                }
            }
            edges.Sort((x, y) => {
                if (x.dist > y.dist)
                {
                    return 1;
                }
                else if (x.dist < y.dist)
                {
                    return -1;
                }

                return 0;
            });
            int k = 1;
            for (int i = 0; i < edges.Count ; i++)
            {
                int ch = edges[i].child;
                int pr = edges[i].parent;
                if (Nodes[ch].degree * Nodes[pr].degree == 0)
                {
                    int c = Nodes[ch].degree + Nodes[pr].degree;
                    if (c==0)
                    {
                        Nodes[ch].degree = k;
                        Nodes[pr].degree = k;
                        k++;
                    }
                    else
                    {
                        Nodes[ch].degree = c;
                        Nodes[pr].degree = c;
                    }
                    Nodes[ch].Edges.Find(x => { return edges[i].parent == x.child; }).color = Color.Red;
                    edges[i].color = Color.Red;
                }
                else
                {
                    if(Nodes[ch].degree != Nodes[pr].degree)
                    {
                        Nodes[ch].Edges.Find(x => { return edges[i].parent == x.child; }).color = Color.Red;
                        edges[i].color = Color.Red;
                        ChangeDegree(ch, Nodes[pr].degree);
                    }
                }
            }
        }
        private void ChangeDegree(int index, int k)
        {
            Nodes[index].degree = k;
            for (int i = 0; i < Nodes[index].Edges.Count; i++)
            {
                int ch = Nodes[index].Edges[i].child;
                if (Nodes[ch].degree != k && Nodes[ch].degree!=0)
                {
                    ChangeDegree(ch, k);
                }
            }
        }
    }
}
