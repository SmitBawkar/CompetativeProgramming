using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
class Solution
{
    class Trie
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            bubbleSort(a);
        }
    }
    public static void bubbleSort(int[] a)
    {
        int n = a.Length;
        int noOfSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    noOfSwaps++;
                }
            }

        }
        Console.WriteLine("Array is sorted in " + noOfSwaps + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[n - 1]);
        // Console.ReadKey();
    }

}