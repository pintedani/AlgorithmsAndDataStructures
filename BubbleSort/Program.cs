// See https://aka.ms/new-console-template for more information
using ArrayHelpers;

Console.WriteLine("Bubble Sort!");

//The sort gets its name because values “float like a bubble” from one end of
//the list to another.

CArray nums = new CArray(10);
Random rnd = new Random(100);
for (int i = 0; i < 10; i++)
    nums.Insert((int)(rnd.NextDouble() * 100));
Console.WriteLine("Before sorting: ");
nums.DisplayElements();
Console.WriteLine("During sorting: ");
nums.BubbleSort();
Console.WriteLine("After sorting: ");
nums.DisplayElements();

Console.ReadLine();

