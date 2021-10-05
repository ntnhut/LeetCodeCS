using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _463IslandPerimeter
{
    public class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            int result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (j == 0)
                        {
                            result += 2;
                        } else if (grid[i][j-1]==0)
                        {
                            result += 2;
                        }
                        if (i==0)
                        {
                            result += 2;
                        }
                        else if (grid[i-1][j]==0)
                        {
                            result += 2;
                        }
                    }
                }
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var so = new Solution();
            var grid1 = new int[][] 
            { 
                new int[] { 0, 1, 0, 0 }, 
                new int[] { 1, 1, 1, 0 }, 
                new int[] { 0, 1, 0, 0 }, 
                new int[] { 1, 1, 0, 0 } 
            };
            Console.WriteLine(so.IslandPerimeter(grid1)); // 16
            var grid2 = new int[][] 
            { 
                new int[] { 1 } 
            };
            Console.WriteLine(so.IslandPerimeter(grid2)); // 4
        }
    }
}
