using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class TreeToString
    {


        public string Tree2str(TreeNode root)
        {
            StringBuilder sb= new StringBuilder();

            helper(root,sb);
            return sb.ToString();
        }

        static void helper(TreeNode root, StringBuilder sb)
        { 
        if(root == null) return;

            sb.Append(root.val);
            if (root.left == null && root.right == null)
                return;
            sb.Append('(');
            helper(root.left,sb);
            sb.Append(')');
            if (root.right == null)
                return;
            sb.Append('(');
            helper(root.right,sb);
            sb.Append(')');

        }


    }
}
