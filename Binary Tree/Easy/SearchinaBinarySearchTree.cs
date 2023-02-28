using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class SearchinaBinarySearchTree
    {
        static TreeNode SearchBST(TreeNode root, int val)
        {

            if (root == null)
                return null;

            if (root.val == val)
                return root;
            
            if (root.val < val)
               return SearchBST(root.right, val);  
            else
               return SearchBST(root.left, val);
          
        }
        static void Main(string[] args)
        {
            TreeNode original = new TreeNode(2);
            original.left = new TreeNode(1);
            original.right = new TreeNode(4);
            original.right.left = new TreeNode(3);
            original.right.right = new TreeNode(5);

            TreeNode res = SearchBST(original,3);

        }
    }
}
