/*
Given an array of  integers and a number, , perform  left rotations on the array. Then print the updated array as a single line of space-separated integers
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        /*My Code*/
        int rotationIndex = k % n;
        int arrElementCount = 0;
        
        while(++arrElementCount <= n)
        {
            Console.Write(a[rotationIndex % n]+" ");
            rotationIndex++;
        }        
    }
}