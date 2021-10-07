using System;

namespace _79WordSearch
{
    public class Solution
    {
        // foreach char c in word
        //   foreach valid places to find a board cell that matches c
        //     if the cell at that place matches c, then break and go to next char c in word
        //     if no cell matches this current char c, comeback the previous char c to go the other direction.
        // if all were checked but not found return false;
        // 
        public bool backTrack(char[][] board, string word, int currentI, int currentJ, int k)
        {
            if (k >= word.Length)
            {
                return true;
            }
            for (int i = currentI>=1 ? currentI - 1: 0; i <= currentI + 1 && i < board.Length; i++)
            {
                for (int j = currentJ>=1 ? currentJ - 1 : 0; j <= currentJ + 1 && j < board[i].Length; j++)
                {
                    if ((i==currentI || j==currentJ) && board[i][j] == word[k])
                    {
                        board[i][j] = '.';
                        if (backTrack(board, word, i, j, k + 1))
                        {
                            return true;
                        }
                        board[i][j] = word[k];
                    }
                }
            }
            return false;

        }
        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        board[i][j] = '.';
                        if (backTrack(board, word, i, j, 1))
                        {
                            return true;
                        }
                        board[i][j] = word[0];
                    }
                }
            }
            return false;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var so = new Solution();
            var board = new char[2][]{
                new char[] {'A', 'B'},
                new char[] {'C', 'D'}
            };
            Console.WriteLine(so.Exist(board, "ABCD")); // false
            board = new char[3][]{
                new char[] {'A', 'B', 'C', 'E'},
                new char[] {'S', 'F', 'C', 'S'},
                new char[] {'A', 'D', 'E', 'E' }
            };
            Console.WriteLine(so.Exist(board, "ABCCED")); // true
            board = new char[3][]{
                new char[] {'A', 'B', 'C', 'E'},
                new char[] {'S', 'F', 'C', 'S'},
                new char[] {'A', 'D', 'E', 'E' }
            };

            Console.WriteLine(so.Exist(board, "SEE")); // true
            board = new char[3][]{
                new char[] {'A', 'B', 'C', 'E'},
                new char[] {'S', 'F', 'C', 'S'},
                new char[] {'A', 'D', 'E', 'E' }
            };

            Console.WriteLine(so.Exist(board, "ABCB")); // false

        }
    }
}
