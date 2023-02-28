using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{

    internal class RangeSumofBST
    {

        int sum = 0;

        int RangeSumBST(TreeNode root, int low, int high)
        {

            if (root == null )
                return 0;

            RangeSumBST(root.left, low, high);
            if(root.val >= low && root.val <= high)
               sum += root.val;
            RangeSumBST(root.right, low, high);


            return sum;

        }

        static void Main(string[] args)
        {
            RangeSumofBST obj = new RangeSumofBST();
            TreeNode original = new TreeNode(5);
            original.left = new TreeNode(4);
            original.right = new TreeNode(9);
            original.right.left = new TreeNode(7);
            original.right.right = new TreeNode(10);

            int res = obj.RangeSumBST(original, 4, 7);
            Console.WriteLine(res);

        }
    }
}
