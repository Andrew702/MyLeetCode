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
 public class Solution
 {
     public IList<int>  RightSideView(TreeNode root)
     {

         //check first floor, if it has left and right add right,
         //check next floor, if right has right add it, right has left add it
         // if there's no more right grab left, if it has right add it
         // if it has left add it

         List<int> Mylist = new List<int>();

         RecursivePrintRight(root, 1, Mylist);

         return Mylist;
     }

     public void  RecursivePrintRight(TreeNode Current, int Currentfloor, List<int> Mylist)
     {
         // recursive fcn to navigate each floor and print the item at most right
         // append first the root of the tree
         if (Current != null)
         {
             if (Mylist.Count == 0)
                 Mylist.Add(Current.val);

             // when im in X floor i append the beneath element making count X+1 
                 if (Current.right != null)
                 {
                    if(Currentfloor == Mylist.Count)
                        Mylist.Add(Current.right.val);
                     RecursivePrintRight(Current.right, Currentfloor + 1, Mylist);
                 }
                 if (Current.left != null)
                 {
                     if(Currentfloor == Mylist.Count)
                         Mylist.Add(Current.left.val);
                     RecursivePrintRight(Current.left, Currentfloor + 1, Mylist);
                 }
                 else //if both are null just return
                 {
                     return;
                 }

             


         }


     }

 }