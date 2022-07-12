// See https://aka.ms/new-console-template for more information
using BinarySearch;

Console.WriteLine("Hello, World!");

Random random = new Random();
BinarySeachArray mynums = new BinarySeachArray(9);
for (int i = 0; i < 9; i++)
    mynums.Insert(random.Next(100));
mynums.BubbleSort();
//mynums.showArray();
int position = mynums.BinSearch(4);
if (position != -1)
{
    Console.WriteLine("found item");
    // mynums.showArray();
}
else
{
    Console.WriteLine("Not in the array");
}
Console.Read();