using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPreparation.Programs.SortAlgo
{
   public class BubbleSort
    {
        /// <summary>
        /// Sort Array Using Bubble Sort
        /// out : [5 1 4 2 8]
        /// Best Case : O(n) when arrays are sorted.
        /// Worst Case : O(n2) when arrays are not sorted.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        protected int[] BubbleSortArray(int[] arr) {
            int n = arr.Length;
            // if we dont have any elements to swipe then isSwapped will be false for break the loop.
            bool isSwapped = false;
             
            for (int i = 0; i < n-1; i++)
            {
                isSwapped = false;
                // Here if condition is n-2, then simply elements will be looped from 0 to n-2
                // To Improve performance of below loop we can skip sorted elements by n-i-1
                for (int j = 0; j < n-i-1 ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swipe(arr, j);
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                    break;
            }
            
            return arr;
        }

        /// <summary>
        /// Swipe Elements
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private void swipe(int[] arr, int index) {
            int temp = arr[index];
            arr[index] = arr[index + 1];
            arr[index + 1] = temp;
        }
    }
}
