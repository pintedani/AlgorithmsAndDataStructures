using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        private const int NUM_VERTICES = 13;
        private Vertex[] vertices;
        private int[,] adjMatrix;
        int numVerts;
        Stack gStack;
        public Graph()
        {
            gStack = new Stack();
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
                for (int k = 0; k <= NUM_VERTICES - 1; k++)
                    adjMatrix[j, k] = 0;
        }
        public void AddVertex(string label)
        {
            vertices[numVerts] = new Vertex(label);
            numVerts++;
        }
        public void AddEdge(int start, int eend)
        {
            adjMatrix[start, eend] = 1;
            adjMatrix[eend, start] = 1;
        }
        public void ShowVertex(int v)
        {
            Console.Write(vertices[v].label + " ");
        }

        public int NoSuccessors()
        {
            bool isEdge;
            for (int row = 0; row <= NUM_VERTICES - 1; row++)
            {
                isEdge = false;
                for (int col = 0; col <= NUM_VERTICES - 1; col++)
                    if (adjMatrix[row, col] > 0)
                    {
                        isEdge = true;
                        break;
                    }

                if (!isEdge)
                    return row;
            }

            return -1;
        }

        public void DelVertex(int vert)
        {
            if (vert != NUM_VERTICES - 1)
            {
                for (int j = vert; j <= NUM_VERTICES - 1; j++)
                    vertices[j] = vertices[j + 1];
                for (int row = vert; row <= NUM_VERTICES - 1; row++)
                    MoveRow(row, NUM_VERTICES);
                for (int col = vert; col <= NUM_VERTICES - 1; col++)
                    MoveCol(col, NUM_VERTICES - 1);
            }
        }

        private void MoveRow(int row, int length)
        {
            for (int col = 0; col <= length - 1; col++)
                adjMatrix[row, col] = adjMatrix[row + 1, col];
        }
        private void MoveCol(int col, int length)
        {
            for (int row = 0; row <= length - 1; row++)
                adjMatrix[row, col] = adjMatrix[row, col + 1];
        }

        //Depth First Search
        private int GetAdjUnvisitedVertex(int v)
        {
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
                if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited == false))
                    return j;
            return -1;
        }

        public void DepthFirstSearch()
        {
            vertices[0].wasVisited = true;
            ShowVertex(0);
            gStack.Push(0);
            int v;
            while (gStack.Count > 0)
            {
                v = GetAdjUnvisitedVertex((int)gStack.Peek());
                if (v == -1)
                    gStack.Pop();
                else
                {
                    vertices[v].wasVisited = true;
                    ShowVertex(v);
                    gStack.Push(v);
                }
            }
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
                vertices[j].wasVisited = false;
        }

        public void Mst()
        {
            vertices[0].wasVisited = true;
            gStack.Push(0);

            int currVertex, ver;
            while (gStack.Count > 0)
            {
                currVertex = (int)gStack.Peek();
                ver = GetAdjUnvisitedVertex(currVertex);
                if (ver == -1)
                    gStack.Pop();
                else
                {
                    vertices[ver].wasVisited = true;
                    gStack.Push(ver);
                    ShowVertex(currVertex);
                    ShowVertex(ver);
                    Console.Write(" ");
                }
            }
            for (int j = 0; j <= NUM_VERTICES - 1; j++)
                vertices[j].wasVisited = false;
        }


            //public void TopSort()
            //{
            //    int origVerts = NUM_VERTICES;
            //    while (NUM_VERTICES > 0)
            //    {
            //        int currVertex = NoSuccessors();
            //        if (currVertex == -1)
            //        {
            //            Console.WriteLine("Error: graph has cycles.");
            //            return;

            //        }
            //        gStack.Push(vertices[currVertex].label);
            //        DelVertex(currVertex);
            //    }
            //    Console.Write("Topological sorting order: ");
            //    while (gStack.Count > 0)
            //        Console.Write(gStack.Pop() + " ");
            //}
        }

}
