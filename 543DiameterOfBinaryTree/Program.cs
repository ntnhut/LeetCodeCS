using System;
using System.Collections.Generic;

namespace _543DiameterOfBinaryTree
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
 
    public class Solution
    {
        private Dictionary<TreeNode, int> _height = new Dictionary<TreeNode, int>();
        public int Height(TreeNode root)
        {
            if (root == null) return 0;
            if (_height.ContainsKey(root))
            {
                return _height[root];
            }
            int h = root.left != null ? Height(root.left) + 1 : 0;
            if (root.right != null)
            {
                h = Math.Max(h, Height(root.right) + 1);
            }
            _height.Add(root, h);

            return h;
        }
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            int d = root.left != null ?  1 + Height(root.left) : 0;
            d += root.right != null ? 1 + Height(root.right) : 0;

            return Math.Max(Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right)), d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var so  = new Solution();
            var four = new TreeNode(4);
            var five = new TreeNode(5);
            var two = new TreeNode(2, four, five);
            var three = new TreeNode(3);
            var one = new TreeNode(1, two, three);

            Console.WriteLine(so.DiameterOfBinaryTree(one));
        }
    }
}
