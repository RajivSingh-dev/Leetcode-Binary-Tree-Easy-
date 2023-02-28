using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class Two_SumInput_is_a_BSTcs
    {

        public bool FindTarget(TreeNode root, int k)
        {
            IList<int> list = new List<int>();

            Inorder(root,list);

            int low = 0, high = list.Count-1;

            while (low < high)
            {

                if (list[low] + list[high] == k)
                    return true;
                else if(list[low] + list[high] < k)
                    low++;
                else
                    high--;

            }

            return false;

        }

        void Inorder(TreeNode root, IList<int> list)
        {
            if (root == null)
                return;

            Inorder(root.left,list);
            list.Add(root.val);
            Inorder(root.right, list);


        }

    }
}
