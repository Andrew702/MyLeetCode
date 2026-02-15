/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head)
    {
        int[] arr = new int[10];
        int i = 0 ,j = 0;
        ListNode current = head;
        while(current != null)
        {
            if(arr.Contains(current.val))
                j++;

            // snapshot
            arr[i++] = current.val;
            current = current.next;
            if (i == 9) i = 0;

            //test for j matches snapshots
            if(j == 10)
                return true;
            //1st case  2 3 4 -- 2 3 4 -- 2 3 4
            //2nd case 2 3 4 2 4 null
            //3rd case  1 -- 1 -- 1 -- 1 

        }
        return false;
    }
    
}