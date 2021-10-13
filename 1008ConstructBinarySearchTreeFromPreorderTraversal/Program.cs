using System;

namespace _1008ConstructBinarySearchTreeFromPreorderTraversal
{
   public class TreeNode
   {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
   }

    public class Solution
    {
        public void Print(TreeNode root)
        {
            if (root == null)
            {
                Console.Write("null ");
                return;
            }
            else
            {
                Console.Write(root.val);
            }
            Console.Write(" ");

            Print(root.left);
            Print(root.right);
        }
        public void Insert(ref TreeNode node, int num)
        {
            if (node == null)
            {
                node = new TreeNode(num);
            } 
            else if (num < node.val)
            {
                Insert(ref node.left, num);
            }
            else
            {
                Insert(ref node.right, num);
            }
        }

        public TreeNode BstFromPreorder(int[] preorder)
        {
            var root = new TreeNode(preorder[0]);
            foreach (var num in preorder)
            {   
                Insert(ref root, num);
            }
            return root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var preorder = new int[] { 8, 5, 1, 7, 10, 12 };
            var so = new Solution();
            var root = so.BstFromPreorder(preorder);
            so.Print(root);
        }
    }
}
