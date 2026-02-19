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
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {

        //1- Go To leaves
        //2- Remove target
        //3- check if parent become leaf
        //4- if it does remove parent also
        return TraverseRemove(root , target);
    
    }

    private TreeNode TraverseRemove(TreeNode Current , int target)
    {
        //navigate down Test condition first time
        if(Current.left == null && Current.right == null)
        {
            if( Current.val == target)
                return null;    //remove the node if it equals the target
            else
                return Current;
        }
        else
        {   // keep navigating down
            if(Current.left != null)
                Current.left = TraverseRemove(Current.left, target);
            if(Current.right != null)
                Current.right = TraverseRemove(Current.right, target);
    
            if (Current.left == null && Current.right == null && Current.val == target)
                return null;
        }
        return Current;

    }

}