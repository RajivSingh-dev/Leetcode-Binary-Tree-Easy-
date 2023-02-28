using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class BinaryTreeDemo
    {

        TreeNode root;


        BinaryTreeDemo() { }
        BinaryTreeDemo(int key) { }


        static void Main(string[] args)
        {

            BinaryTreeDemo binaryTree = new BinaryTreeDemo();
            binaryTree.root = new TreeNode(1);

            binaryTree.root.left= new TreeNode(2);
            binaryTree.root.right= new TreeNode(3);
            binaryTree.root.left.left= new TreeNode(4);


        }


    }
}
