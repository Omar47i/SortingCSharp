﻿// Author: OMAR IBRAHIM
// Created on 28th November 2022
// Filename: SortingCSharp.cs
// LinkedIn: https://www.linkedin.com/in/omar-ibrahim-2510b7a6/
// Github: https://github.com/Omar47i

using System;
using SortingAlgorithms;

// Some test cases
int[] arr1 = new int[] { 5, 2, 4, 1, 9, 8 };
int[] arr2 = new int[] { 5, 2, 4, 1, 9, 8 };
int[] arr3 = new int[] { 5, 2, 4, 1, 9, 8 };

SelectionSort.Sort(arr1);
InsertionSort.Sort(arr2);
InsertionSort.Sort(arr3);

ConsoleUtils.DisplayArray(arr1);
ConsoleUtils.DisplayArray(arr2);
ConsoleUtils.DisplayArray(arr3);

namespace SortingAlgorithms
{
    // -- SELECTION SORT -- //
    public static class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (IsLess(arr[j], arr[i]))
                    {
                        Exchange(arr, i, j);
                    }
                }
            }
        }

        private static bool IsLess(IComparable n1, IComparable n2)
        {
            return n1.CompareTo(n2) < 0;
        }

        private static void Exchange(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    // -- INSERTION SORT -- //
    public static class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int currentIndex = i;

                while (currentIndex > 0 && IsLess(arr[currentIndex], arr[currentIndex - 1]))
                {
                    Exchange(arr, currentIndex, currentIndex - 1);
                    currentIndex--;
                }
            }
        }

        private static bool IsLess(IComparable n1, IComparable n2)
        {
            return n1.CompareTo(n2) < 0;
        }

        private static void Exchange(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    // -- BUBBLE SORT -- //
    public static class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            bool exchanged = false;
            int len = arr.Length;

            do
            {
                for (int i = 0; i < len - 1; i++)
                {
                    if (!IsLess(arr[i], arr[i + 1]))
                    {
                        Exchange(arr, i, i + 1);
                        exchanged = true;
                        len--;
                    }
                }
            }

            while (exchanged);
        }

        private static bool IsLess(IComparable n1, IComparable n2)
        {
            return n1.CompareTo(n2) < 0;
        }

        private static void Exchange(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    public static class ConsoleUtils
    {
        public static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}