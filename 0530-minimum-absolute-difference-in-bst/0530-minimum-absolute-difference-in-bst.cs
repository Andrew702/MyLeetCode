/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int GetMinimumDifference(TreeNode root) {

        // look at every parent and every child
        // get the abs diff, compare with max
        return GetTreeMin(root, Int32.MaxValue);

    }

    public int GetTreeMin( TreeNode current ,int min)
    {
        if(current != null)
        {
            if(current.left != null)
            {
                TreeNode TempNode = current.left;
                while(true)
                {
                    int temp1 = (current.val - TempNode.val);
                    if (temp1 < min)
                        min = temp1;
                    if(TempNode.right != null)
                        TempNode = TempNode.right;
                    else break;
                }
                min = GetTreeMin(current.left, min);
            }

            if (current.right != null)
            {
                TreeNode TempNode = current.right;
                while (true)
                {
                    int temp2 = TempNode.val - current.val;
                    if (temp2 < min)
                        min = temp2;
                    if (TempNode.left != null)
                        TempNode = TempNode.left;
                    else break;
                }
                min = GetTreeMin(current.right, min);
            }

            return min;
        }
        return 0;
    } 
}
