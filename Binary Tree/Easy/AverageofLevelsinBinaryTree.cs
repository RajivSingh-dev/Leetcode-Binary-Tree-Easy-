using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree.Easy
{
    internal class AverageofLevelsinBinaryTree
    {

        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> result = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int count = 0;
                double sum = 0;
                Queue<TreeNode> temp = new Queue<TreeNode>();

                while (queue.Count > 0) 
                { 
                    TreeNode node = queue.Dequeue();
                    count++;
                    sum += node.val;
                    if (node.left!=null)
                        temp.Enqueue(node.left);
                    if(node.right!=null)
                        temp.Enqueue(node.right);

                    
                }
                queue = temp;
                result.Add(sum*1.0/count);

            }
            return result;

        }

    }
}
