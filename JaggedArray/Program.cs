// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

int[] Jan = new int[31];
int[] feb = new int[29];

int[][] sales = new int[][]{Jan,feb};

int month, day, total;

double average = 0.0;

sales[0][0] = 41;
sales[0][1] = 30;
sales[1][0] = 35;

for(month =0; month < sales.Length; month++)
{
    total = 0;
    for(day =0; day < sales[month].Length; day++)
    {
        total += sales[month][day];
        average = total / 7;
        Console.WriteLine("Average sales for month: " + month + ": " + average);
    }
}

