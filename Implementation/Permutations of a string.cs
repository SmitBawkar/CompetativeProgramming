using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            string s = "123";
            char[] strArr = s.ToCharArray();
            List<char[]> permutations = new List<char[]>();
            permutation(permutations, 0, strArr);
        foreach (var str in permutations)
        {
            Console.WriteLine(String.Join("", str));
        }

            Console.ReadLine();            
        }
        
        private static void permutation(List<char[]> permutations,int startIndex,char[] strArr)
        {
            if (startIndex >= strArr.Length)
            {
                permutations.Add((Char[])strArr.Clone());
            }
            else
            {
                for (int i = startIndex; i < strArr.Length; i++)
                {
                    swap(i, startIndex, strArr);
                    permutation(permutations, startIndex + 1, strArr);
                    swap(startIndex, i, strArr);
                }
            }            
        }

        private static void swap(int i,int j,char[] strArr)
        {
            char temp = strArr[i];
            strArr[i] = strArr[j];
            strArr[j] = temp;
        }
    }


