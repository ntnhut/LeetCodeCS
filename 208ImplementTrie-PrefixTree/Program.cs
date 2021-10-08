using System;
using System.Collections.Generic;

namespace _208ImplementTrie_PrefixTree
{
    public class Trie
    {
        private Dictionary<char, Trie> children;
        public bool isWord { get; set; }

        public Trie()
        {
            children = new Dictionary<char, Trie>();
            isWord = false;
        }

        public void Insert(string word)
        {
            Trie n = this;
            foreach (char c in word)
            {
                if (n.children.ContainsKey(c) == false)
                {
                    n.children.Add(c, new Trie());
                }
                n = n.children[c];
            }
            n.isWord = true;
        }

        public bool Search(string word)
        {
            Trie n = this;
            foreach (char c in word)
            {
                if (n.children.ContainsKey(c))
                {
                    n = n.children[c];
                } else
                {
                    return false;
                }
            }
            return n.isWord;
        }

        public bool StartsWith(string prefix)
        {
            Trie n = this;
            foreach (char c in prefix)
            {
                if (n.children.ContainsKey(c))
                {
                    n = n.children[c];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            Console.WriteLine(trie.Search("apple"));   // return True
            Console.WriteLine(trie.Search("app"));     // return False
            Console.WriteLine(trie.StartsWith("app")); // return True
            trie.Insert("app");
            Console.WriteLine(trie.Search("app"));     // return True
            
        }
    }
}
