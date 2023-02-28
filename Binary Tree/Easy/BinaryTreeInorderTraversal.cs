using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class BinaryTreeInorderTraversal
    {

        static IList<int> InorderTraversal(TreeNode root)
        {

            IList<int> result = new List<int>();

            InorderTraversal(root,result);
            
            return result;
        }

        static void InorderTraversal(TreeNode root,IList<int> list)
        {
            if (root == null)
                return;

            InorderTraversal(root.left,list);
            list.Add(root.val);
            InorderTraversal(root.right, list);


        }

        public static void Main(string[] args)
        {
            TreeNode original = new TreeNode(2);
            original.left = new TreeNode(1);
            original.right = new TreeNode(4);
            original.right.left = new TreeNode(3);
            original.right.right = new TreeNode(5);

            IList<int> res = InorderTraversal(original);
            Console.WriteLine(res);
        }



    }

}

