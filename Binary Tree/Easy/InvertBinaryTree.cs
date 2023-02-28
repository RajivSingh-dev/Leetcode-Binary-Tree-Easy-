using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class InvertBinaryTree
    {

        static void inorder(TreeNode node)
        {
            if (node == null)
                return;

            inorder(node.left);

            Console.WriteLine(node.val);
            inorder(node.right);
        }
        static TreeNode InvertTree(TreeNode root)
        {
             if (root == null)
                return null;


            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);
            
            root.left = right;
            root.right = left;

            return root;
        }
        static void Main(string[] args)
    {
        TreeNode original = new TreeNode(2);
        original.left = new TreeNode(1);
        original.right = new TreeNode(4);
        original.right.left = new TreeNode(3);
        original.right.right = new TreeNode(5);

        TreeNode res = InvertTree(original);
            inorder(res);
    }


    }


   

}
