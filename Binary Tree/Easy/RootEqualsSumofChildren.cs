using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class RootEqualsSumofChildren
    {



        public static void Main(string[] args)
        {
            RootEqualsSumofChildren obj = new RootEqualsSumofChildren();
            TreeNode original = new TreeNode(5);
            original.left = new TreeNode(4);
            original.right = new TreeNode(9);
            original.right.left = new TreeNode(7);
            original.right.right = new TreeNode(10);



        }

    }
}
