using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _463IslandPerimeter
{
    public class Solution
    {
        public int IslandPerimeter(int[,] grid)
        {
            int result = 0;
            for (int i=0; i < grid.GetLength(0); i++)
            {
                for (int j=0; j< grid.GetLength(1)-1; j++)
                {
                    if (grid[i,j]!=grid[i,j+1])
                    {
                        result++;
                    }
                }
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var so = new Solution();
            var grid = new int[,] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } };
            Console.WriteLine(so.IslandPerimeter(grid));
        }
    }
}
