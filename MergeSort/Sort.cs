using System;
public class Sort
{
    public void MergeSort(int[] array)
    {
        // Array to store sorted values
        int[] aux = new int[array.Length];
        Sort(0, array.Length -1);

        void Sort(int low,int high)
        {
            if(high <= low) return;
            int mid = (high + low ) / 2;
            //Take left side first
            Sort(low,mid);
            // Take right side 
            // +1 to make sure left side has more elements
            Sort(mid + 1, high);

            Merge(low,mid,high);

        }

        void Merge(int low,int mid,int high)
        {
            // Point to the first element of the left array
            int l = low;
            // Point to the first element in Right array;
            int r = mid + 1;
            // Copy original array starting frow low, to aux array starting from low
            Array.Copy(array,low,aux,low, high - low + 1);
            for(int k = low;k <= high;k++)
            {
                if(l > mid) array[k] = aux[r++];
                else if(r > high) array[k] = aux[l++];
                else if(aux[l] > aux[r]) array[k] = aux[r++];
                else array[k] = aux[l++];
                Console.WriteLine(array[k]);
            }
        }
    }
}