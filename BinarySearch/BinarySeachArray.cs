using ArrayHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySeachArray : CArray
    {
        public BinarySeachArray(int size) : base(size)
        {
        }

        public int BinSearch(int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = Arr.Length - 1;
            lowerBound = 0;

            while(lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound)/2;

                if (Arr[mid] == value)
                {
                    return mid;
                }
                else if (value < Arr[mid])
                {
                    upperBound = mid - 1;
                }
                else
                {
                    lowerBound = mid +1;
                }
            }

            return -1;
        }
    }
}
