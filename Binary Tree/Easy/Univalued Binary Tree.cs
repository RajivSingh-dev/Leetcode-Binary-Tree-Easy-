using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class Univalued_Binary_Tree
    {

        public bool IsUnivalTree(TreeNode root)
        {

            if (root == null)
                return true;

            if(root.left != null && root.left.val != root.val)
                return false;
             else if(root.right != null && root.right.val != root.val)
                return false;

            

            bool left = IsUnivalTree(root.left);
            bool right = IsUnivalTree(root.right);


            return left && right;

        }



    }
}
