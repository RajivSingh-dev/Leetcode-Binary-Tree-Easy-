using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Tree.Easy
{
    internal class IncreasingOrderSearchTree
    {
       static void inorder(TreeNode node,List<int> list)
        {
            if (node == null)
                return;

            inorder(node.left,list);

            list.Add(node.val);

            inorder(node.right,list);
        }


        static TreeNode IncreasingBST(TreeNode root)
        {

            List<int> vals = new List<int>();
            inorder(root,vals);

            TreeNode ans = new TreeNode(0), curr = ans;

            foreach (int val in vals) 
            { 
                curr.right = new TreeNode(val);
                curr = curr.right;
            }
            return ans.right;
        }

            static void Main(string[] args)
            {
                MergeTwoBinaryTrees obj = new MergeTwoBinaryTrees();
                TreeNode original = new TreeNode(2);
                original.left = new TreeNode(1);
                original.right = new TreeNode(4);
                original.right.left = new TreeNode(3);
                original.right.right = new TreeNode(5);

                TreeNode res = IncreasingBST(original);

            }

    }
}
