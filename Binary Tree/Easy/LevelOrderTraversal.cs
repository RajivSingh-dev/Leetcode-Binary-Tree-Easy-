
namespace Binary_Tree.Easy
{
    internal class LevelOrderTraversal
    {
       int count = 0;
     public void printLevelOrder(TreeNode root)
        {

           IList<Double> levels = new List<Double>();
            int h = height(root);

            for (int i = 0; i < h; i++)
            {
                levels.Add(printLevelOrder(root,i));
                count = 0;
            }


        }
        
        double printLevelOrder(TreeNode root, int level)
        {
            double sum = 0;
            if(root == null)
                return 0;

            if(level == 0) {
                count ++;  
                return root.val;
            }
            else 
                return (printLevelOrder(root.left, level-1) + printLevelOrder(root.right, level-1))/count;
            

        }

        int height(TreeNode root)
        {
            if(root == null)
                return 0;

            int leftHeight = height(root.left);
            int rightHeight = height(root.right);

            return Math.Max(rightHeight, leftHeight) + 1;
        }


    }
}
