using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class SortedArraytoBST
    {
        // 4: 17 pm : 4: 50 pm 
    public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;

            TreeNode treeNode = ArrayToBST(0,nums.Length,nums);
            
            return treeNode;
        }
        public TreeNode ArrayToBST(int low,int high,int[] nums)
        {
            if(low>high)
            {
                return null;
            }

            int mid = (low + high) / 2;

            TreeNode treeNode = new TreeNode(mid);


            treeNode.left = ArrayToBST(low,mid-1,nums);
            treeNode.right = ArrayToBST(mid+1,high,nums);



            return treeNode;

        }

        

    }
}
