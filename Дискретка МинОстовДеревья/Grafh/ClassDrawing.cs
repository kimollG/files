using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
////using System.Threading.Tasks;not support in 3.5 .Netnot support in 3.5 .Net
using System.Drawing;
namespace ClassLibraryGrafh
{
   public  class ClassDrawing
   {
        private static Node[] Nodes=Lib.Nodes;
        private static void ClearVisit()
        {
            for (int i = 0; i < Nodes.Length; i++)
            {
                Nodes[i].visit = false;
                for (int j = 0; j < Nodes[i].Edges.Count; j++)
                {
                    Nodes[i].Edges[j].IsVisited = false;
                }
            }
        }
        public static void ClearCoord()
        {
            for (int i = 1; i < Nodes.Length; i++)
            {
                Nodes[i].x = 0;
                Nodes[i].y = 0;
            }
        }
        public static bool CheckCoordinate(ref int index, double x, double y)
        {
            for (int i = 0; i < Nodes.Length; i++)
            {
                if (x < Nodes[i].x + 20 && x > Nodes[i].x - 20 && y < Nodes[i].y + 20 && y > Nodes[i].y - 20)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }
        public static void ChangeCoordinate(int index, double x, double y)
        {
            Nodes[index].x = x;
            Nodes[index].y = y;
        }
        public static void DrawGr(ref Graphics g, double x, double y)
        {
            Nodes = Lib.Nodes;
            Nodes[0].x = 100;
            Nodes[0].y = y / 2;
            ClearVisit();
            DrawGraw(ref g, 0, Nodes[0].x, Nodes[0].y);
            float d = 20;
            for (int i = 0; i < Nodes.Length; i++)
            {
                double max = 0;
                if (Nodes[i].visit == false)
                {
                    if (Nodes[i].x == 0)
                    {
                        for (int j = 0; j < Nodes.Length; j++)
                        {
                            if (max < Nodes[j].x)
                                max = Nodes[j].x;
                        }
                        if (max + 100 < 600)
                            max = max + 100;
                        Nodes[i].x = max;
                        Nodes[i].y = Nodes[0].y;
                        DrawGraw(ref g, i, max, Nodes[0].y);
                    }
                    else
                    {
                        DrawGraw(ref g, i, Nodes[i].x, Nodes[i].y);
                    }
                }
            }
            for (int i = 0; i <  Nodes.Length; i++)
            {
                g.FillEllipse(Brushes.White, (float)Nodes[i].x - d, (float)Nodes[i].y - d, 2 * d, 2 * d);
                g.DrawEllipse(new Pen(Nodes[i].color), (float)Nodes[i].x - d, (float)Nodes[i].y - d, 2 * d, 2 * d);
                g.DrawString(i.ToString(), new Font("Courier", 15), Brushes.Black, (float)Nodes[i].x - 10, (float)Nodes[i].y - 10);
            }
        }
        private static void DrawGraw(ref Graphics g, int index, double x, double y)
        {
            Nodes[index].visit = true;
            for (int i = 0; i < Nodes[index].Edges.Count; i++)
            {
                int k = Nodes[index].Edges[i].child;
                if (Nodes[k].x == 0)
                {
                    Nodes[k].x = x + Math.Abs((float)150 * Math.Cos(-Math.PI / 2 + (Math.PI * (i + 1)) / ((float)Nodes[index].Edges.Count + 1)));
                    Nodes[k].y = y + (float)150 * Math.Sin(-Math.PI / 2 + (Math.PI * (i + 1)) / ((float)Nodes[index].Edges.Count + 1));
                    if (Nodes[k].y < 0)
                    {
                        Nodes[k].y = 50;
                    }
                    if (Nodes[k].y > 500)
                    {
                        Nodes[k].y = 450;
                    }
                    if (Nodes[k].x > 600)
                    {
                        Nodes[k].x = 550;
                    }
                }
                Point[] point = new Point[3];
                if (Nodes[index].Edges[i].SecondEdge == false)
                {
                    g.DrawLine(new Pen(Nodes[index].Edges[i].color), (float)Nodes[k].x, (float)Nodes[k].y, (float)Nodes[index].x, (float)Nodes[index].y);
                    point[1].X = ((int)Nodes[index].x + (int)Nodes[k].x) / 2;
                    point[1].Y = ((int)Nodes[index].y + (int)Nodes[k].y) / 2;
                }
                else
                {
                    point[0].X = (int)Nodes[index].x;
                    point[0].Y = (int)Nodes[index].y;
                    point[2].X = (int)Nodes[k].x;
                    point[2].Y = (int)Nodes[k].y;
                    if (index < k)
                    {
                        point[1].X = ((int)Nodes[index].x + (int)Nodes[k].x) / 2 - 10;
                        point[1].Y = ((int)Nodes[index].y + (int)Nodes[k].y) / 2 - 10;
                        g.DrawCurve(new Pen(Nodes[index].Edges[i].color), point);
                    }
                    else
                    {
                        point[1].X = ((int)Nodes[index].x + (int)Nodes[k].x) / 2 + 10;
                        point[1].Y = ((int)Nodes[index].y + (int)Nodes[k].y) / 2 + 10;
                        g.DrawCurve(new Pen(Nodes[index].Edges[i].color), point);
                    }
                }
                double fl = 0;
                if ((Nodes[index].y - Nodes[k].y) != 0 && (Nodes[index].x - Nodes[k].x) != 0)
                    fl = Math.Atan((Nodes[index].y - Nodes[k].y) / (Nodes[index].x - Nodes[k].x));
                g.TranslateTransform(point[1].X, point[1].Y);
                g.RotateTransform((float)(fl * 180 / Math.PI));
                if (Nodes[index].x <= Nodes[k].x)
                    DrawRestangle(ref g, 1);
                else
                    DrawRestangle(ref g, -1);
                g.DrawString(Nodes[index].Edges[i].dist.ToString(), new Font("Courier", 10), Brushes.Black, -6, -5);
                g.RotateTransform(-(float)(fl * 180 / Math.PI));
                g.TranslateTransform(-point[1].X, -point[1].Y);
            }
            for (int i = 0; i < Nodes[index].Edges.Count; i++)
            {
                int k = Nodes[index].Edges[i].child;
                if (Nodes[k].visit == false)
                    DrawGraw(ref g, k, Nodes[k].x, Nodes[k].y);
            }
        }
        private static void DrawRestangle(ref Graphics g, int k)
        {
            PointF[] point = new PointF[4];
            point[0].X = -12;
            point[1].X = -12;
            point[2].X = 12;
            point[3].X = 12;
            point[0].Y = 6F;
            point[1].Y = -6F;
            point[2].Y = -6F;
            point[3].Y = 6F;
            //for (int i = 0; i < 4; i++)
            //{
            //    float f = point[i].X;
            //    float f1 = point[i].Y;
            //    point[i].X = (float)(f * Math.Cos(a) + f1 * Math.Sin(a));
            //    point[i].Y = (float)(f1 * Math.Cos(a) - f * Math.Sin(a));
            //}
            float d = 15 * k;
            g.FillPolygon(Brushes.White, point);
            g.DrawPolygon(new Pen(Color.Black), point);
            g.DrawLine(new Pen(Color.Black, 2), d, 5, 20 * k, 0);
            g.DrawLine(new Pen(Color.Black, 2), d, -5, 20 * k, 0);
        }
    }
}
