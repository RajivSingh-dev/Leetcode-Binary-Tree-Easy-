using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class EvaluateBooleanBinaryTree
    {
        bool lvalue ;
        bool rvalue;
        public bool EvaluateTree(TreeNode root)
        {

            if (root.right == null)
                return root.val == 0 ? false : true;
        

         return   root.val == 2 ? (EvaluateTree(root.right) || EvaluateTree(root.left)) : (EvaluateTree(root.left) && EvaluateTree(root.right));


        }

        static void Main(string[] args)
        {
            EvaluateBooleanBinaryTree obj = new EvaluateBooleanBinaryTree();
            TreeNode original = new TreeNode(2);
            original.left = new TreeNode(1);
            original.right = new TreeNode(3);
            original.right.left = new TreeNode(0);
            original.right.right = new TreeNode(1);

            bool res = obj.EvaluateTree(original);
            Console.WriteLine(res);

        }
    }
}
