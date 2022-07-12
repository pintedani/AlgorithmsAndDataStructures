using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree;

public class Node
{
    public int Data;
    public Node left;
    public Node right;
    public void DisplayNode()
    {
        Console.Write(Data + " ");
    }
}
