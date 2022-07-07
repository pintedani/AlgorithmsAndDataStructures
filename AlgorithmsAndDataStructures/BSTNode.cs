using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class BSTNode<T>
    {
        public BSTNode(T value)
        {
            Data = value;
        }

        public T Data;

        public BSTNode<T> Left;

        public BSTNode<T> Right;
    }
}
