using BinarySearchTree;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


BinarySearchTree.BinarySearchTree bns = new BinarySearchTree.BinarySearchTree();
bns.Insert(23);
bns.Insert(45);
bns.Insert(16);
bns.Insert(3);

bns.InOrderTraversal(bns.root);

Console.WriteLine();
Console.WriteLine("-------Binary Search--------");


var node = bns.Find(33);
if(node != null)
{
    Console.WriteLine("Node exists in tree");
}
else
{
    Console.WriteLine("Node does not exist in tree");
}