namespace ArrayHelpers
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;

        public int[] Arr => arr;

        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
                numElements = 0;
            }
        }
        public void BubbleSort()
        {
            int temp;
            for(int i = 0; i <= upper; i++)
            {
                for(int j = i; j <= upper; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;  

                    }
                }
                this.DisplayElements();
            }
        }
    }
}