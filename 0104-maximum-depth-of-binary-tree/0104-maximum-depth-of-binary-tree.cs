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
    public int MaxDepth(TreeNode root) {
        //start at element, go down
        //if right or left go down recursively, record max jumps
        return RecursiveGetDepth(root,1);
    }

    private int RecursiveGetDepth(TreeNode current ,int floor)
    {
        if (current != null)
        {
        int maxC1 =floor ,maxC2 =floor;
        if(current.left != null)
            maxC1 = RecursiveGetDepth(current.left ,floor+1);
        if(current.right != null)
            maxC2 = RecursiveGetDepth(current.right ,floor+1);
        
        if(maxC1 > maxC2)
            return maxC1;
        else
            return maxC2;    
        }
        return 0;
        
    }
}