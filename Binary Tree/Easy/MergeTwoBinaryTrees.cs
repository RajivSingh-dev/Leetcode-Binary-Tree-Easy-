using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class MergeTwoBinaryTrees
    {

        static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
            {

            if (root1 == null)
                return null;

            if (root2 == null)
                return root1;

            TreeNode newNode = new TreeNode(root1.val + root2.val);

            newNode.left = MergeTrees(root1.left, root2.left);
            newNode.right = MergeTrees(root1.right, root2.right);

            return newNode;

        }

        static void main(string[] args)
        {
            MergeTwoBinaryTrees obj = new MergeTwoBinaryTrees();
            TreeNode original = new TreeNode(2);
            original.left = new TreeNode(1);
            original.right = new TreeNode(3);
            original.right.left = new TreeNode(0);
            original.right.right = new TreeNode(1);
            
            TreeNode original1 = new TreeNode(2);
            original.left = new TreeNode(1);
            original.right = new TreeNode(3);
            original.right.left = new TreeNode(0);
            original.right.right = new TreeNode(1);
            TreeNode res =  MergeTrees(original,original1);
        }

    }
}
