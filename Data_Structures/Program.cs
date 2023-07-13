using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, -8, 0, 48, 98, 2, -4};
            Console.WriteLine("----- Array -----");
            PrintArr(arr);
            Console.WriteLine();

            Console.WriteLine("----- Sorted Array(Insertion) -----");
            int[] sortedArray = InsertionSort(arr);
            PrintArr(sortedArray);
            Console.WriteLine();

            //Console.WriteLine("----- Sorted Array(Bubble) -----");
            //int[] sortedArray = InsertionSort(arr);
            //PrintArr(sortedArray);
            //Console.WriteLine();

            Console.WriteLine("----- Binary Search -----");
            int ind = BinarySearch(sortedArray, 2);
            Console.WriteLine("Index: " + ind);
        }
        static int[] BubbleSort(int[] arr) 
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr; 
        }
        static int BinarySearch(int[] arr, int key)
        {
            int minInd = 0;
            int maxInd = arr.Length - 1;

            while (minInd <= maxInd)
            {
                int midInd = (maxInd + minInd) / 2;
                if (key == arr[midInd])
                {
                    return midInd;
                }
                else if (key > arr[midInd])
                {
                    minInd = midInd + 1;
                }
                else
                {
                    maxInd = midInd - 1;
                }
            }
            return -1;
        }
        static int[] InsertionSort(int[] arr) 
        {
            int j, key;
            for (int i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr; 
        }
        static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
