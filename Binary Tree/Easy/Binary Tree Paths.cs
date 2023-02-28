using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class Binary_Tree_Paths
    {

        public IList<string> BinaryTreePaths(TreeNode root)
        {

            IList<string> paths = new List<string>();
            if (root != null) helper(root, "", paths);
            
            return paths;
        }


        void helper(TreeNode root,string s, IList<string> paths) 
        {
            if(root.left == null && root.right == null) paths.Add(s + root.val);

            if(root.left!=null) helper(root.left,s + root.val + "->", paths);
            if(root.right!=null) helper(root.right,s + root.val + "->", paths);        
        
        }




    }
}
