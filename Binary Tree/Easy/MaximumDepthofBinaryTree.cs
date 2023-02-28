using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Tree.Easy
{
    internal class MaximumDepthofBinaryTree
    {
       /* static int MaxDepth(TreeNode root)
        {

            if (root == null)
                return 0;

            int leftHeight = MaxDepth(root.left);
            int rightHeight = MaxDepth(root.right);

            return Math.Max(rightHeight, leftHeight)+1;
         }*/
        public static int height(TreeNode root)
        {

            // the root is null then the height of the tree will be Zero  
            if (root == null)
                return 0;
            else
            {
                /* compute  height of each subtree */
                int lheight = height(root.left);
                int rheight = height(root.right);

                /* use the larger one */
                // height of both the sub trees is calcualted and which one is higher is used.   
                if (lheight > rheight)
                    return (lheight + 1);
                else
                    return (rheight + 1);
            }
        }
        public  static void Main(string[] args)
        {
            TreeNode original = new TreeNode(2);
            original.left = new TreeNode(1);
            original.right = new TreeNode(4);
            original.right.left = new TreeNode(3);
            original.right.right = new TreeNode(5);

            int  res = height(original);
            Console.WriteLine(res);
        }

    }
}
