using System;
using System.Collections.Generic;
using System.Linq;

namespace _380._Insert_Delete_GetRandom_O_1_
{
    public class RandomizedSet
    {
        List<int> l = new List<int>();

        public RandomizedSet()
        {

        }

        public bool Insert(int val)
        {
            if (l.Contains(val) == false)
            {
                l.Add(val);
                return true;
            }

            return false;
        }

        public bool Remove(int val)
        {
            if (l.Contains(val))
            {
                l.Remove(val);
                return true;
            }
            return false;
        }

        public int GetRandom()
        {
            Random rnd = new Random();
            return l[rnd.Next(0, l.Count)];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomizedSet obj = new RandomizedSet();
            Console.WriteLine(obj.Insert(1));
            Console.WriteLine(obj.Remove(2));
            Console.WriteLine(obj.Insert(2));
            Console.WriteLine(obj.GetRandom());
            Console.WriteLine(obj.Remove(1));
            Console.WriteLine(obj.Insert(2));
            Console.WriteLine(obj.GetRandom());
        }
    }
}
