using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        private static IComparable[] aux;

        public static void SortArray(IComparable[] arr, Int32 stopPoint)
        {
            aux = new IComparable[arr.Length];
            Sort(arr, 0, stopPoint);
        }

        private static void Sort(IComparable[] arr, Int32 lo, Int32 hi)
        {
            if (hi<=lo)
            {
                return;
            }

            Int32 mid = lo + ((hi - lo) / 2);
            Sort(arr, lo, mid);
            Sort(arr, mid + 1, hi);
            Merge(arr, lo, mid, hi);
        }

        private static void Merge(IComparable[] arr, Int32 lo, Int32 mid, Int32 hi)
        {
            Int32 i = lo;
            Int32 j = mid + 1;

            for(Int32 k = lo; k <= hi; k++)
            {
                aux[k] = arr[k];
            }
            for(Int32 k = lo; k <= hi; k++)
            {
                if(i>mid)
                {
                    arr[k] = aux[j++];
                }
                else if(j>hi)
                {
                    arr[k] = aux[i++];
                }
                else if (aux[j].CompareTo(aux[i]) < 0)
                {
                    arr[k] = aux[j++];
                }
                else
                {
                    arr[k] = aux[i++];
                }
            }
        }
    }
}
