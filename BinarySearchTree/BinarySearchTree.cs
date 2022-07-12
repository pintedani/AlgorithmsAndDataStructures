using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree;

internal class BinarySearchTree
{
    public Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(int i)
    {
        if(root == null)
        {
            root = new Node() { Data = i};
        }
        else
        {
            Node current = root;
            Node parent;
            while (true)
            {
                parent = current;
                if( i < current.Data )
                {
                    current = parent.left;
                    if(current == null)
                    {
                        parent.left = new Node() { Data = i };
                        break;
                    }
                }
                else
                {
                    current = parent.right;
                    if( current == null)
                    {
                        current.right = new Node() { Data = i };
                        break;
                    }
                }
            }
        }
    }
}
