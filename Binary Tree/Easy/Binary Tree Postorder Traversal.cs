using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class Binary_Tree_Postorder_Traversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> vals = new List<int>();
            Postorder(root, vals);

            return vals;

        }
        
        void Postorder(TreeNode root , IList<int> list)
        {

            if(root == null)
                return;

            Postorder(root.left, list);
            Postorder(root.right, list);
            list.Add(root.val);

        }


    }
}
