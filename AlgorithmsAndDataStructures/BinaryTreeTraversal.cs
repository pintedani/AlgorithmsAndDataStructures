using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class BinaryTreeTraversal<T>
    {
        public void PreOrderTraversal(Action<T> action)
        {
            PreOrderTraversal(action, Root);
        }

        private void PreOrderTraversal(Action<T> action, BSTNode<T> node)
        {
            if(node != null)
            {
                action(node.Value);

                PreOrderTraversal(action, node.Left);
                PreOrderTraversal(action, node.Right);
            }
        }
    }
}
