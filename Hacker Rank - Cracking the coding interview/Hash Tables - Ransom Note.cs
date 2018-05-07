using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static void Main(String[] args) {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');
        string res = "No";
        Dictionary<string,int> mag_dict = new Dictionary<string,int>();
        
        for(int i=0; i< magazine.Length; i++)
        {
            if(mag_dict.ContainsKey(magazine[i]))
                mag_dict[magazine[i]]++;
            else
               mag_dict.Add(magazine[i],1);
        }
        
        for(int i=0; i< ransom.Length; i++)
        {
            if(mag_dict.ContainsKey(ransom[i]) && mag_dict[ransom[i]] > 0)
            {   res ="Yes";
                mag_dict[ransom[i]]--; 
            }
            else
            {
                res ="No";
                break;
            }
                
            
        }
			Console.Write(res);
               
    }
}
