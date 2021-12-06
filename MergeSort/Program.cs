using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort s = new Sort();
            s.MergeSort(new int[]{38,27,43,3,9,82,10});
        }
    }
}
