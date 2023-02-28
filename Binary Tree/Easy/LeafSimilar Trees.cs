using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class LeafSimilar_Trees
    {

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {

            List<int> vals1 = new List<int>();
            List<int> vals2 = new List<int>();


            getLeafs(vals1,root1);
            getLeafs(vals2,root2);

            return vals1.SequenceEqual(vals2);

        }

        void getLeafs(IList<int> list,TreeNode root)
        {

            if(root == null) return;

            if (root.left == null && root.right == null)
                list.Add(root.val);

            getLeafs(list,root.left);
            getLeafs(list,root.right);



        }


    }
}
