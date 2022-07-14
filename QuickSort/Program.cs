Console.WriteLine("Quick Sort Demo!");

int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
int n = 10, i;
Console.WriteLine("Quick Sort");
Console.Write("Initial array is: ");
for (i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
quickSort(arr, 0, arr.Length - 1);
Console.Write("\nSorted Array is: ");
for (i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}

void quickSort(int[] arr, int left, int right)
{
    int pivot;
    if (left < right)
    {
        pivot = Partition(arr, left, right);
        if (pivot > 1)
        {
            quickSort(arr, left, pivot - 1);
        }
        if (pivot + 1 < right)
        {
            quickSort(arr, pivot + 1, right);
        }
    }
}

int Partition(int[] arr, int left, int right)
{
    int pivot;
    pivot = arr[left];
    while (true)
    {
        while (arr[left] < pivot)
        {
            left++;
        }
        while (arr[right] > pivot)
        {
            right--;
        }
        if (left < right)
        {
            int temp = arr[right];
            arr[right] = arr[left];
            arr[left] = temp;
        }
        else
        {
            return right;
        }
    }
}