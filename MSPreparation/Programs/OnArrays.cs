using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSPreparation.Programs.SortAlgo;

namespace MSPreparation.Programs
{
    public class OnArrays : BubbleSort
    {
        public OnArrays()
        {

        }

        /// <summary>
        /// Comparison 2 array
        /// </summary>
        public void CompareTwoArrays()
        {
            int[] arr1 = { 1, 2, 4, 5, 8 };
            int[] arr2 = { 8, 1, 4, 2, 5 };

            //Bubble Sort
            //arr1 = BubbleSortArray(arr1);
            arr2 = BubbleSortArray(arr2);

        }
    }
}
