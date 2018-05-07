using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
class Solution
{
    class Trie
    {
        private class TrieNode
        {
            internal Dictionary<Char, TrieNode> children;
            internal int prefixCount;
            internal bool isEndOfWord;

            public TrieNode()
            {
                children = new Dictionary<char, TrieNode>();
                prefixCount = 0;
                isEndOfWord = false;
            }
        }
        
        private static TrieNode ROOT;
        public Trie()
        {
            ROOT = new TrieNode();
        }
        public void AddWord(String word)
        {
            AddWord(ROOT, word, 0);
        }
        private void AddWord(TrieNode Current, String Word, int index)
        {
            if (index == Word.Length)
            {
                Current.isEndOfWord = true;
                return;
            }
            if (Current.children.ContainsKey(Word[index]))
            {
                Current = Current.children[Word[index]];
               Current.prefixCount++;
            }
            else
            {
                Current.children.Add(Word[index], new TrieNode());
                Current = Current.children[Word[index]];
                Current.prefixCount++;
            }
            AddWord(Current, Word, index + 1);
        }
        public bool Search(String word)
        {
            return Search(ROOT, word, 0);
        }
        private bool Search(TrieNode Current, String Word, int index)
        {
            if (index == Word.Length)
            {
                return Current.isEndOfWord;
            }
            if (Current.children.ContainsKey(Word[index]))
            {
                return Search(Current.children[Word[index]], Word, index + 1);
            }
            else
            {
                return false;
            }

        }
        public int searchprefixwords(String prefix)
        {
            TrieNode curr = ROOT;
            foreach (char c in prefix.ToCharArray())
            {
                if (curr.children.ContainsKey(c))
                    curr = curr.children[c];
                else
                    return 0;
            }
            //int count = 0;
           // CountChildren(curr, ref count);
            return curr.prefixCount;
        }
        private void  CountChildren(TrieNode curr,ref int count)
        {
            foreach (char c in curr.children.Keys)
            {
                 CountChildren(curr.children[c],ref count);   
            }
            if (curr.isEndOfWord)
                count++;
        }
    }

    static void Main(String[] args)
    {
        Trie t = new Trie();
        int n = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < n; a0++)
        {
            string[] tokens_op = Console.ReadLine().Split(' ');
            string op = tokens_op[0];
            string contact = tokens_op[1];
            switch (op)
            {
                case "add":
                    t.AddWord(contact);
                    break;
                case "find":
                    Console.WriteLine(t.searchprefixwords(contact));
                    break;

            }
        }
        //Console.ReadKey();
    }
}

