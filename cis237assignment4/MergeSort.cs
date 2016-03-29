using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        //Private IComparable variable to hold the collection of droids
        private IComparable[] aux;

        //Public method to initiate the merge sort process
        //Creates a new IComparable aux array to store a copy of the array being processed
        public void SortArray(IComparable[] arr, Int32 stopPoint)
        {
            aux = new IComparable[arr.Length];
            Sort(arr, 0, stopPoint);
        }

        //Private recursive method that sorts the array being processed, essentially splitting the array into pieces
        private void Sort(IComparable[] arr, Int32 lo, Int32 hi)
        {
            //Base case
            if (hi<=lo)
            {
                return;
            }
            //Logic for the recursive sort call
            Int32 mid = lo + ((hi - lo) / 2);
            Sort(arr, lo, mid);
            Sort(arr, mid + 1, hi);
            Merge(arr, lo, mid, hi);
        }

        //Private method that merges the array in the correct order using the CompareTo method
        private void Merge(IComparable[] arr, Int32 lo, Int32 mid, Int32 hi)
        {
            //Variables used within the process
            Int32 i = lo;
            Int32 j = mid + 1;

            //For each element in the arr array, copy it into the aux array
            for(Int32 k = lo; k <= hi; k++)
            {
                aux[k] = arr[k];
            }
            //Logic that compares TotalCost of each droid, and places them in the correct order.
            for(Int32 k = lo; k <= hi; k++)
            {
                //Is the TotalCost of the droid in "i" location greater than the TotalCost of the droid in the "mid" location
                if(i>mid)
                {
                    //If so overwrite what is in arr[k] with what is in aux[j] and then increment [j]
                    arr[k] = aux[j++];
                }
                //Is the TotalCost of the droid in "j" location greater than the TotalCost of the droid in the "hi" location
                else if (j>hi)
                {
                    //If so overwrite what is in arr[k] with what is in aux[i] and then increment [i]
                    arr[k] = aux[i++];
                }
                //Is the value of the TotalCost of the comparison of aux[j] and aux[i] less than zero
                else if (aux[j].CompareTo(aux[i]) < 0)
                {
                    //If so overwrite what is in arr[k] with what is in aux[j] and then increment [j]
                    arr[k] = aux[j++];
                }
                //If none of the above are true
                else
                {
                    //Overwrite what is in arr[k] with what is in aux[i] and then increment [i]
                    arr[k] = aux[i++];
                }
            }
        }
    }
}
