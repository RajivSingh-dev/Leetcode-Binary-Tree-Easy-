using Binary_Tree.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays.Easy
{
    public struct Car
    {
        public string Brand;
        public string Model;
        public string Color;
    }

    internal class DriverClass
    {

        static void Main(string[] args)
        {
            TreeNode original = new TreeNode(1);
            original.left = new TreeNode(2);
            original.right = new TreeNode(3);
            original.left.left = new TreeNode(4);

            TreeToString treeToString= new TreeToString();
            treeToString.Tree2str(original);


        }
    }
}
