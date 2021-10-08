using System;
using System.Collections.Generic;

namespace _208ImplementTrie_PrefixTree
{
    public class Node
    {
        public Dictionary<char, Node> children;
        public bool leave { get; set; }
        public Node()
        {
            children = new Dictionary<char, Node>();
            leave = false;
        }
    }
    public class Trie
    {
        private Node _root;

        public Trie()
        {
            _root = new Node();
        }

        public void Insert(string word)
        {
            Node n = _root;
            foreach (char c in word)
            {
                if (n.children.ContainsKey(c) == false)
                {
                    n.children.Add(c, new Node());
                }
                n = n.children[c];
            }
            n.leave = true;
        }

        public bool Search(string word)
        {
            Node n = _root;
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
            return n.leave;
        }

        public bool StartsWith(string prefix)
        {
            Node n = _root;
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
