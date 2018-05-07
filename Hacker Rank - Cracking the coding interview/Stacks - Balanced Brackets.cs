using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        string isBalanced;
        Stack st = new Stack();
        Dictionary<char,char> bracketMap = new Dictionary<char,char>()
        {
            {'}','{'},
            {']','['},
            {')','('}
        };
        for(int a0 = 0; a0 < t; a0++){
            isBalanced = "YES";
            st.Clear();
            string expression = Console.ReadLine();            
            for(int i=0; i < expression.Length; i++)
            {
                if(bracketMap.ContainsValue(expression[i]))
                    st.Push(expression[i]);
                else if(st.Count > 0)
                {
                    if(!st.Pop().Equals(bracketMap[expression[i]]))
                    {
                        isBalanced = "NO";                         
                        break;
                    }                                             
                }
                else
                {
                    isBalanced = "NO";
                    break;
                }
            }
            if(st.Count > 0)
               isBalanced = "NO";
            
            Console.WriteLine(isBalanced);            
        }
    }
}
