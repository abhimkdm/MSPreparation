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
        int[] arr1 = { 1, 2, 4, 5, 8 };
        int[] arr2 = { 8, 1, 4, 2, 5 };


        /// <summary>
        /// Compare 2 Arrays
        /// </summary>
        public void CompareTwoArrays()
        {
            if (arr1.Length != arr2.Length)
                Console.WriteLine("Both Array Elements Are Not Same");
            else
            {
                //Get it Sorted 
                bubbleSort(ref arr1, ref arr2);

                bool checkFlag = false;
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        checkFlag = true;
                        break;
                    }
                }

                if (checkFlag)
                    Console.WriteLine("Both Array Elements Are Not Same");
                else
                    Console.WriteLine("Both Array Elements Are Same");

            }
        }

        private void bubbleSort(ref int[] arr1, ref int[] arr2)
        {
            //Bubble Sort
            arr1 = BubbleSortArray(arr1);
            arr2 = BubbleSortArray(arr2);
        }
    }
}
