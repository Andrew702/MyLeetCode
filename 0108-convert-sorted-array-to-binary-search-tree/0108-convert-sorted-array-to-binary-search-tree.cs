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
    public TreeNode SortedArrayToBST(int[] nums) {

        // get mid put at first index
        // get left, right
        // get left mid put at next index
        // get right mid put at next index
        // go on

        int left = 0;
        int right = nums.Length - 1;
        return RecursiveSortedArrayToBst(nums, left, right);

    }

    private TreeNode RecursiveSortedArrayToBst(int[] nums ,int left , int right)
    {
            //calculate mid
            int mid = (left + right)/ 2;

            if(mid  == left && mid != right) // we hit leftmost
                return new TreeNode(nums[mid] , null , new TreeNode(nums[mid+1] , null , null) );               
            else if(mid == left && mid == right)
                return new TreeNode(nums[mid] , null , null );


            // create new node of mid
            return new TreeNode( nums[mid] ,
              RecursiveSortedArrayToBst(nums , left , mid -1 ) ,
                RecursiveSortedArrayToBst(nums , mid+1 ,right ) );
            
    }
}