using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree;

public class BinarySearchTree
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
                        parent.right = new Node() { Data = i };
                        break;
                    }
                }
            }
        }
    }

    public void InOrderTraversal(Node theRoot)
    {
        if(theRoot != null)
        {
            InOrderTraversal(theRoot.left);
            theRoot.DisplayNode();
            InOrderTraversal(theRoot.right);
        }
    }

    public void PreOrder(Node theRoot)
    {
        if (!(theRoot == null))
        {
            theRoot.DisplayNode();
            PreOrder(theRoot.left);
            PreOrder(theRoot.right);
        }
    }

    public void PostOrder(Node theRoot)
    {
        if (!(theRoot == null))
        {
            PostOrder(theRoot.left);
            PostOrder(theRoot.right);
            theRoot.DisplayNode();
        }
    }

    public int FindMin()
    {
        Node current = root;
        while (!(current.left == null))
            current = current.left;
        return current.Data;
    }

    public int FindMax()
    {
        Node current = root;
        while (!(current.right == null))
            current = current.right;
        return current.Data;
    }

    public Node Find(int key)
    {
        Node current = root;
        while(current != null)
        {
            if(current.Data == key)
            {
                return current;
            }
            else
            {
                if(key < current.Data)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
        }

        return null;
    }
}
