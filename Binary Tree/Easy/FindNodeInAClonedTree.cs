using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class FindNodeInAClonedTree
    {
        static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {

            if (original == null)
                return original;

            if (original == target) return cloned;

            TreeNode left = GetTargetCopy(original.left, cloned.left, target);

            if (left != null) return left;


            return GetTargetCopy(original.right, cloned.right, target);


        }
        static void Main(string[] args)
        {
            TreeNode original = new TreeNode(7);
            original.left = new TreeNode(4);
            original.right = new TreeNode(3);
            original.right.left = new TreeNode(6);
            original.right.right = new TreeNode(19);
            
            TreeNode cloned = new TreeNode(7);
            cloned.left = new TreeNode(4);
            cloned.right = new TreeNode(3);
            cloned.right.left = new TreeNode(6);
            cloned.right.right = new TreeNode(19);

            TreeNode result = GetTargetCopy(original,cloned,original.right);
            Console.WriteLine(result.val);

        }

    }
}
