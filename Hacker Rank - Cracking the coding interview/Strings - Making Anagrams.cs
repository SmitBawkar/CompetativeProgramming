using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int[] a_dict = new int[26];
        int[] b_dict = new int[26];
        int charToDel =0;
        
        for(int i=0; i < a.Length; i++)
            a_dict[(int)a[i]-97]++;
        
        for(int i=0; i < b.Length; i++)
            b_dict[(int)b[i]-97]++;
        
        for(int i=0; i < 26; i++)
         charToDel += Math.Abs(a_dict[i]-b_dict[i]);
            
        Console.Write(charToDel);    
    }
}